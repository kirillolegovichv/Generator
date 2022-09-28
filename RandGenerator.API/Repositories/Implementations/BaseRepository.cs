using RandGenerator.API.Models;

namespace RandGenerator.API.Repositories
{
    public class BaseRepository<Model> : IBaseRepository<Model> where Model : GeneratedSequence
    {
        public Model Create(Model model)
        {
            return model;
        }
    }
}
