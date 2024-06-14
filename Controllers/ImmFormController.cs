using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Hosting;
using XFA;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ImmFormController : ControllerBase
    {

        private readonly IWebHostEnvironment _hostingEnvironment;
        private readonly ILogger<WeatherForecastController> _logger;

        public ImmFormController(IWebHostEnvironment hostingEnvironment, ILogger<WeatherForecastController> logger)
        {
            _hostingEnvironment = hostingEnvironment;
            _logger = logger;
        }

        [HttpPost(Name = "Fill")]
        public IActionResult Fill(string immType)
        {
            // Get the content root path of the application
            string contentRootPath = _hostingEnvironment.ContentRootPath;

            string SOURCE_DOCUMENT = Path.Combine(contentRootPath, "Assets", immType + ".pdf");
            string FILLED_DOCUMENT = Path.Combine(contentRootPath, "Assets", immType + "_filled.pdf");


            var xfaForm = new Imm5709e(SOURCE_DOCUMENT, FILLED_DOCUMENT);
            xfaForm.Fill();

            return Ok();
        }
    }
}