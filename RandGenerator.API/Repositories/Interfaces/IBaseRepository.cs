using RandGenerator.API.Models;

namespace RandGenerator.API.Repositories
{
    public interface IBaseRepository<Model> where Model : GeneratedSequence
    {
        public Model Create(Model model);
    }
}
