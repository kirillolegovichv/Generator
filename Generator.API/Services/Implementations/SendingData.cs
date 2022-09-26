using Generator.API.Repositories;

namespace Generator.API.Services
{
    public class SendingData : ISendingData
    {
        private IBaseRepository<Sequence> Sequence { get; set; }

        public void Work()
        {
            var sequenceId = Guid.NewGuid();

            Sequence.Create(new Sequence
            {
                Id = sequenceId,

            });
        }
    }
}
