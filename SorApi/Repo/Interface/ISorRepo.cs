using SorApi.Model;

namespace SorApi.Repo.Interface
{
    public interface ISorRepo
    {
        public Task<SorModel> Create(SorModel _object);

        public Task<bool> Update(string id,SorModel _object);

        public Task<List<SorModel>> GetAll();

        public Task<SorModel> GetById(string Id);

        public Task<int> Delete(string id);
    }
}
