using Microsoft.EntityFrameworkCore;
using RandGenerator.API.Models;

namespace RandGenerator.API.Repositories
{
    public class BaseRepository<Model> : IBaseRepository<Model> where Model : GeneratedSequence
    {
        private ApplicationContext Context { get; set; }

        public BaseRepository(ApplicationContext context)
        {
            Context = context;
        }
        public Model Create(Model model)
        {
            Context.Set<Model>().Add(model);
            Context.SaveChanges();
            return model;
        }
    }
}
