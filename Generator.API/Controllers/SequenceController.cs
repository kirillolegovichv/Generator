using Microsoft.AspNetCore.Mvc;
using RandGenerator;

namespace Generator.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SequenceController : ControllerBase
    {
        [HttpPost]
        public int[] AddSequence(Sequence currentSequence)
        {
            SequenceDisplay sd = new SequenceDisplay();


            int[] vs = new int[1];
            return vs;
        }
    }
}