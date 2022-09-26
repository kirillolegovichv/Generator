using Microsoft.AspNetCore.Mvc;
using RandGenerator;

namespace RandGenerator.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GeneratedSequenceController : Controller
    {
        [HttpPost]
        public int[] AddSequence(GeneratedSequence generatedSequence)
        {
            SequenceDisplay sd = new SequenceDisplay();
            int[] seq = sd.Start();
            generatedSequence.Sequence = seq;
            return generatedSequence.Sequence;
        }
    }
}
