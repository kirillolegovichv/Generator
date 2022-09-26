using Generator.API.Models;

namespace Generator.API.Repositories
{
    public class BaseRepository<TDbModel> : IBaseRepository<TDbModel> where TDbModel : BaseModel
    {
        public TDbModel Create(TDbModel model)
        {
            throw new NotImplementedException();
        }
    }
}
