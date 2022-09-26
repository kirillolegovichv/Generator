using Generator.API.Repositories;
using Generator.API.Models;
using RandGenerator;


namespace Generator.API.Services
{
    public class SendingData : ISendingData
    {
        private IBaseRepository<Sequence> Sequence { get; set; }

        public void Work()
        {
            var sequenceId = Guid.NewGuid();
            SequenceDisplay sd = new SequenceDisplay();

            Sequence.Create(new Sequence
            {
                Id = sequenceId,
                GeneratedSequence = sd.Start()
            });
        }
    }
}
