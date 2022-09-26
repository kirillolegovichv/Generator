using Microsoft.AspNetCore.Mvc;

namespace RandGenerator.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GeneratedSequenceController : Controller
    {
        public int AddSequence(GeneratedSequence generatedSequence)
        {
            return 23;
        }
    }
}
