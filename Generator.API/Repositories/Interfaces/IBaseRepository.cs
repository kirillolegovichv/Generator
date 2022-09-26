using Generator.API.Models;

namespace Generator.API.Repositories
{
    public interface IBaseRepository<TDbModel> where TDbModel : BaseModel
    {
        public TDbModel Create(TDbModel model);
    }
}
