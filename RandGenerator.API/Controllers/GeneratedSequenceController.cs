using Microsoft.AspNetCore.Mvc;
using RandGenerator.API.Models;
using RandGenerator.API.Services;

namespace RandGenerator.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GeneratedSequenceController : Controller
    {
        private IGenerateService GenerateService { get; set; }

        public GeneratedSequenceController(IGenerateService generateService)
        {
            GenerateService = generateService;
        }

        [HttpPost]
        public JsonResult AddSequence()
        {
            GenerateService.Generate();
            return new JsonResult("That`s work");
        }
    }
}
