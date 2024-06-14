using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace XFA
{
    public class Imm5709e : XFAForm
    {
        public Imm5709e(string source_path, string filled_path) : base(source_path, filled_path)
        {

        }

        public override bool Fill()
        {
            bool success = false;
            try
            {
                SetFieldValue("form1[0].Page1[0].PersonalDetails[0].ServiceIn[0].ServiceIn[0]", "English");
                SetFieldValue("form1[0].Page1[0].PersonalDetails[0].ApplyingFor[0].Extend[0]", "1");

                SetFieldValue("form1[0].Page1[0].PersonalDetails[0].Name[0].FamilyName[0]", "John Vibar");
                SetFieldValue("form1[0].Page1[0].PersonalDetails[0].Name[0].GivenName[0]", "John Vibar");
                SetFieldValue("form1[0].Page1[0].PersonalDetails[0].AliasName[0].AliasNameIndicator[0].AliasNameIndicator[0].No[0]", "N");
                SetFieldValue("form1[0].Page1[0].PersonalDetails[0].q3-4-5[0].sex[0].Sex[0]", "F Female");
                SetFieldValue("form1[0].Page1[0].PersonalDetails[0].q3-4-5[0].dob[0].DOBYear[0]", "1991");
                SetFieldValue("form1[0].Page1[0].PersonalDetails[0].q3-4-5[0].dob[0].DOBMonth[0]", "05");
                SetFieldValue("form1[0].Page1[0].PersonalDetails[0].q3-4-5[0].dob[0].DOBDay[0]", "05");
                SetFieldValue("form1[0].Page1[0].PersonalDetails[0].q3-4-5[0].pob[0].PlaceBirthCity[0]", "Beijing");
                SetFieldValue("form1[0].Page1[0].PersonalDetails[0].q3-4-5[0].pob[0].PlaceBirthCountry[0]", "China");
                SetFieldValue("form1[0].Page1[0].PersonalDetails[0].Citizenship[0].Citizenship[0]", "China");

                SetFieldValue("form1[0].Page1[0].PersonalDetails[0].CurrentCOR[0].CurrentCOR[0].Row2[0].Status[0]", "Student");
                //SetFieldValue("form1[0].Page1[0].PersonalDetails[0].CurrentCOR[0].CurrentCOR[0].Row2[0].Other[0]", "Note");
                SetFieldValue("form1[0].Page1[0].PersonalDetails[0].CurrentCOR[0].CurrentCOR[0].Row2[0].FromDate[0]", "2019-03-04");
                SetFieldValue("form1[0].Page1[0].PersonalDetails[0].CurrentCOR[0].CurrentCOR[0].Row2[0].ToDate[0]", "2024-09-04");
                SetFieldValue("form1[0].Page1[0].PersonalDetails[0].PrevCOR[0].PCRIndicator[0].No[0]", "N");

                SetFieldValue("form1[0].Page1[0].MaritalStatus[0].Current[0].MaritalStatus[0]", "Married");
                SetFieldValue("form1[0].Page1[0].MaritalStatus[0].Current[0].b[0].DateOfMarriage[0]", "2024-03-04");
                SetFieldValue("form1[0].Page1[0].MaritalStatus[0].Current[0].c[0].FamilyName[0]", "KH");
                SetFieldValue("form1[0].Page1[0].MaritalStatus[0].d[0].SpouseStatus[0].No[0]", "N");

                SetFieldValue("form1[0].Page2[0].MaritalStatus[0].PrevMarriage[0].PrevMarriedIndicator[0].No[0]", "N");


                SetFieldValue("form1[0].Page2[0].Languages[0].nativeLang[0]", "Chinese");
                SetFieldValue("form1[0].Page2[0].Languages[0].communicateLang[0]", "English");
                SetFieldValue("form1[0].Page2[0].Languages[0].LangTestIndicator[0].No[0]", "N");

                // Passport
                SetFieldValue("form1[0].Page2[0].Passport[0].PassportNum[0]", "fdsfe232");
                SetFieldValue("form1[0].Page2[0].Passport[0].CountryofIssue[0]", "CAN (Canada)");
                SetFieldValue("form1[0].Page2[0].Passport[0].IssueDate[0]", "2024-03-04");
                SetFieldValue("form1[0].Page2[0].Passport[0].ExpiryDate[0]", "2024-09-04");
                SetFieldValue("form1[0].Page2[0].Passport[0].TaiwanPIN[0].No[0]", "N");
                SetFieldValue("form1[0].Page2[0].Passport[0].IsraelPassportIndicator[0].No[0]", "N");

                // National identity document
                SetFieldValue("form1[0].Page2[0].natID[0].q1[0].natIDIndicator[0].No[0]", "N");

                // US card
                SetFieldValue("form1[0].Page2[0].USCard[0].q1[0].usCardIndicator[0].No[0]", "N");

                // Contact information
                SetFieldValue("form1[0].Page2[0].ContactInformation[0].Mailing[0].AddrLine1[0].Streetname[0]", "Street");
                SetFieldValue("form1[0].Page2[0].ContactInformation[0].Mailing[0].AddrLine2[0].City[0]", "City");
                SetFieldValue("form1[0].Page2[0].ContactInformation[0].Mailing[0].AddrLine2[0].Prov[0]", "ON");
                SetFieldValue("form1[0].Page2[0].ContactInformation[0].Mailing[0].AddrLine2[0].PostalCode[0]", "K1A 0B1");

                SetFieldValue("form1[0].Page2[0].ContactInformation[0].Resi[0].SameAsAddr[0].SameAsMailingInd[0].Yes[0]", "Y");

                // Comming into Canada
                SetFieldValue("form1[0].Page3[0].ComingIntoCda[0].OrigEntry[0].DateLastEntry[0]", "2024-02-04");
                SetFieldValue("form1[0].Page3[0].ComingIntoCda[0].OrigEntry[0].Place[0]", "Place");
                SetFieldValue("form1[0].Page3[0].ComingIntoCda[0].PurposeOfVisit[0].PurposeOfVisit[0]", "Study");

                // Details of intended study in Canada
                SetFieldValue("form1[0].Page3[0].DetailsOfStudy[0].SchoolDetails[0].SchoolName[0]", "Sample School");
                SetFieldValue("form1[0].Page3[0].DetailsOfStudy[0].SchoolDetails[0].StudyMajor[0].Level[0]", "Primary School");
                SetFieldValue("form1[0].Page3[0].DetailsOfStudy[0].SchoolDetails[0].Prov[0]", "ON");
                SetFieldValue("form1[0].Page3[0].DetailsOfStudy[0].SchoolDetails[0].CityTown[0]", "Ajax");
                SetFieldValue("form1[0].Page3[0].DetailsOfStudy[0].SchoolDetails[0].Address[0]", "Address");
                SetFieldValue("form1[0].Page3[0].DetailsOfStudy[0].SchoolDetails[0].StudyTerm[0].FromDate[0]", "2024-09-04");
                SetFieldValue("form1[0].Page3[0].DetailsOfStudy[0].SchoolDetails[0].StudyTerm[0].ToDate[0]", "2024-11-04");
                SetFieldValue("form1[0].Page3[0].DetailsOfStudy[0].SchoolDetails[0].EduCosts[0].Tuition[0]", "32");
                SetFieldValue("form1[0].Page3[0].DetailsOfStudy[0].SchoolDetails[0].Funds[0].FundsAvail[0]", "32");
                SetFieldValue("form1[0].Page3[0].DetailsOfStudy[0].SchoolDetails[0].Funds[0].ExpPaidBy[0]", "Parents");

                SetFieldValue("form1[0].Page3[0].WorkPermit[0].a[0].WorkPermit[0].No[0]", "N");

                // Education
                SetFieldValue("form1[0].Page3[0].Education[0].EducationIndicator[0].No[0]", "N");

                // Employment
                SetFieldValue("form1[0].Page3[0].Employment[0].EmpRec1[0].Line1[0].From[0].YYYY[0]", "2019");
                SetFieldValue("form1[0].Page3[0].Employment[0].EmpRec1[0].Line1[0].From[0].MM[0]", "03");
                SetFieldValue("form1[0].Page3[0].Employment[0].EmpRec1[0].Line1[0].Occupation[0]", "fd");
                SetFieldValue("form1[0].Page3[0].Employment[0].EmpRec1[0].Line1[0].Employer[0]", "fee");
                SetFieldValue("form1[0].Page3[0].Employment[0].EmpRec1[0].Line2[0].To[0].YYYY[0]", "2024");
                SetFieldValue("form1[0].Page3[0].Employment[0].EmpRec1[0].Line2[0].To[0].MM[0]", "05");
                SetFieldValue("form1[0].Page3[0].Employment[0].EmpRec1[0].Line2[0].City[0]", "ddd");
                //SetFieldValue("form1[0].Page3[0].Employment[0].EmpRec1[0].Line2[0].ProvState[0]", "ON");
                SetFieldValue("form1[0].Page3[0].Employment[0].EmpRec1[0].Line2[0].Country[0]", "China");

                // Background Information
                //a) Within the past two years, have you or a family member ever had tuberculosis of the lungs or been in close contact with a person with tuberculosis?
                SetFieldValue("form1[0].Page4[0].BackgroundInfo[0].HealthQ[0].qANY[0].No[0]", "N");
                //b)Do you have any physical or mental disorder that would require social and/or health services, other than medication, during a stay in Canada?
                SetFieldValue("form1[0].Page4[0].BackgroundInfo[0].HealthQ[0].qBNY[0].No[0]", "N");
                //a)Have you ever remained beyond the validity of your status, attended school without authorization or worked without authorization in Canada? 
                SetFieldValue("form1[0].Page4[0].BackgroundInfo[0].PrevApplied[0].qANY[0].No[0]", "N");
                //b) Have you ever been refused a visa or permit, denied entry or ordered to leave Canada or any other country or territory?
                SetFieldValue("form1[0].Page4[0].BackgroundInfo[0].PrevApplied[0].qBNY[0].No[0]", "N");
                //c) Have you previously applied to enter or remain in Canada?
                SetFieldValue("form1[0].Page4[0].BackgroundInfo[0].PrevApplied[0].qCNY[0].No[0]", "N");
                //a)Have you ever committed, been arrested for or been charged with or convicted of any criminal offence in any country or territory?
                SetFieldValue("form1[0].Page4[0].BackgroundInfo[0].Criminal[0].qANY[0].No[0]", "N");
                //a) Did you serve in any military, militia, or civil defence unit or serve in a security organization or police force (including non obligatory national service, reserve or volunteer units)?
                SetFieldValue("form1[0].Page4[0].BackgroundInfo[0].Military[0].qANY[0].No[0]", "N");
                //Are you, or have you ever been a member or associated with any political party, or other group or organization which has engaged in or advocated violence as a means to achieving a political Or religious objective, Or which has been associated with criminal activity at any time?
                SetFieldValue("form1[0].Page4[0].BackgroundInfo[0].Occupation[0].Choice[0].No[0]", "N");
                SetFieldValue("form1[0].Page4[0].BackgroundInfo[0].GovPosition[0].qGovtNY[0].No[0]", "N");
                //Have you ever witnessed or participated in the ill treatment of prisoners or civilians, looting or desecration of religious buildings?
                SetFieldValue("form1[0].Page4[0].BackgroundInfo[0].Illtreatment[0].qWitnessNY[0].No[0]", "N");

                Validate();


                Save();

                success = true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Close();
            }

            return success;
        }

        public override bool Validate()
        {
            Object? validateButton = ResolveNode("form1[0].Page1[0].ButtonsHeader[0].ValidateButton[0]");
            Object? globValidatePressed = ResolveNode("form1[0].globValidatePressed");
            Object? validateForm = ResolveNode("form1[0].validateForm");
            Object? BC = ResolveNode("form1[0].BC");
            Object? messages = ResolveNode("form1[0].messages");

            SetProperty(globValidatePressed, "value", "true");
            InvokeMember(validateForm, "writeReaderInfo", null, BindingFlags.InvokeMethod);
            SetProperty(
                ResolveNode("form1[0].Page1[0].PersonalDetails[0].OfficeUse[0].ApplicationValidatedFlag[0]"),
                "editValue",
                "Yes"
            );
            InvokeMember(BC, "showBarcodes", null, BindingFlags.InvokeMethod);
            InvokeMember(validateForm, "setDateLastValidated", null, BindingFlags.InvokeMethod);

            return true;

        }
    }
}
