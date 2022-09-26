using Microsoft.AspNetCore.Mvc;
using RandGenerator;
using Generator.API.Services;

namespace Generator.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SequenceController : ControllerBase
    {
        private ISendingData SendingData { get; set; }



        [HttpPost]
        public JsonResult AddSequence()
        {
            SendingData.Work();
            return new JsonResult("Correct resault");
        }
    }
}