using RandGenerator.API.Models;
using RandGenerator.API.Repositories;

namespace RandGenerator.API.Services
{
    public class GenerateService : IGenerateService
    {
        private IBaseRepository<GeneratedSequence> Sequences { get; set; }

        public void Generate()
        {
            SequenceDisplay sd = new SequenceDisplay();
            int[] currentSequence = sd.Start();

            Sequences.Create(new GeneratedSequence
            {
                Sequence = currentSequence
            });
        }
    }
}
