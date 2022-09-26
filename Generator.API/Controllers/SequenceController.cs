using Microsoft.AspNetCore.Mvc;
using Generator.API.Services;

namespace Generator.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SequenceController : Controller
    {
        private SendingData SendingData { get; set; }

        public SequenceController(SendingData sendingData)
        {
            SendingData = sendingData;
        }

        [HttpPost]
        public int AddSequence()
        {
            
            SendingData.Work();
            return 42;
        }
    }
}