using Generator.API.Repositories;
using Generator.API.Models;
using Generator.API.Controllers;

namespace Generator.API.Services
{
    public class SendingData : ISendingData
    {
        private IBaseRepository<Sequence> Sequence { get; set; }
        string vs = "12";

        public void Work()
        {
            var sequenceId = Guid.NewGuid();            

            Sequence.Create(new Sequence
            {
                Id = sequenceId,
                GeneratedSequence = vs
            });
        }
    }
}
