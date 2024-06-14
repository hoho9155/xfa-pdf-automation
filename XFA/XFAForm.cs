using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Runtime.InteropServices;
using Acrobat;

namespace XFA
{
    public abstract class XFAForm
    {

        protected static dynamic? InvokeMember(Object? obj, string memberName, object[]? param, BindingFlags invokeFlags)
        {
            if (obj == null) return null;

            dynamic? value = null;
            try
            {
                // Attempt to access the xfa property
                value = obj.GetType().InvokeMember(
                    memberName,
                    invokeFlags |
                    BindingFlags.Public |
                    BindingFlags.Instance,
                    null, obj, param);
            }
            catch (Exception ex)
            {
                // Handle any errors accessing the xfa property
                Console.WriteLine("Error accessing xfa property: " + ex.Message);
            }
            return value;
        }


        protected AcroPDDoc? _pdDoc;
        protected Object? _jsObj;
        protected Object? _xfa;
        protected Object? _form;

        protected string _sourcePath;
        protected string _filledPath;

        public XFAForm(string sourcePath, string filledPath)
        {
            _sourcePath = sourcePath;
            _filledPath = filledPath;

            _pdDoc = new AcroPDDoc();

            bool ret = _pdDoc.Open(_sourcePath);
            if (!ret)
            {
                // Failed to open source document
                throw new Exception("Failed to open source document. Make sure that SOURCE_DOCUMENT has been configured."); ;
            }

            _jsObj = _pdDoc.GetJSObject();
            _xfa = InvokeMember(_jsObj, "xfa", null, BindingFlags.GetProperty);
            _form = InvokeMember(_xfa, "form", null, BindingFlags.GetProperty);
        }

        public dynamic? ResolveNode(string nodeName)
        {
            return InvokeMember(_form, "resolvenode", new object[] { nodeName }, BindingFlags.InvokeMethod);
        }

        public dynamic? ResolveNode(Object obj, string nodeName)
        {
            return InvokeMember(obj, "resolvenode", new object[] { nodeName }, BindingFlags.InvokeMethod);
        }

        public dynamic? GetProperty(Object obj, string[] properties)
        {
            Object? value = obj;
            foreach (string property in properties)
            {
                value = InvokeMember(value, property, null, BindingFlags.GetProperty);
            }
            return value;
        }

        public void SetProperty(Object? obj, string propertyName, string value)
        {
            InvokeMember(obj, propertyName, new object[] { value }, BindingFlags.SetProperty);
        }

        public void ExecEvent(Object field, string activity)
        {
            InvokeMember(field, "execEvent", new object[] { activity }, BindingFlags.InvokeMethod);
        }

        public string? GetDisplayItem(Object field, int index)
        {
            return InvokeMember(field, "getDisplayItem", new object[] { index }, BindingFlags.InvokeMethod);
        }

        public void SetItemState(Object field, int index, bool state)
        {
            InvokeMember(field, "setItemState", new object[] { index, state }, BindingFlags.InvokeMethod);
        }


        public bool SetFieldValue(string nodeName, string value)
        {
            Object? field = ResolveNode(nodeName);
            if (field == null) return false;

            string? className = GetProperty(field, new string[] { "ui", "oneOfChild", "className" });

            if (className == "checkButton")
            {
                SetProperty(field, "formattedValue", value);
                ExecEvent(field, "click");
            }
            else if (className == "choiceList")
            {
                int i = 0;
                string? item;

                while (string.Empty != (item = GetDisplayItem(field, ++i)))
                {
                    if (item == value)
                    {
                        SetItemState(field, i, true);
                    }
                }

                ExecEvent(field, "exit");
            }
            else
            {
                SetProperty(field, "formattedValue", value);
            }

            Console.WriteLine(nodeName + ":" + value);

            return true;
        }

        public virtual bool Fill()
        {
            return true;
        }

        public virtual bool Validate()
        {
            return true;
        }

        public bool Save()
        {
            if (_pdDoc != null)
            {
                _pdDoc.Save(1, _filledPath);
                return true;
            }
            return false;
        }

        public void Close()
        {
            // Release the COM object for jsObj
            if (_jsObj != null)
            {    
                _jsObj = null;
            }

            // Close and release the COM object for srcDoc
            if (_pdDoc != null)
            {
                _pdDoc.Close();
                _pdDoc = null;
            }
        }
    }
}
