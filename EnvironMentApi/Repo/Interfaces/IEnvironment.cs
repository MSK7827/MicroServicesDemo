using EnvironMentApi.Model;

namespace EnvironMentApi.Repo.Interfaces
{
    public interface IEnvironment
    {
        public Task<EnviornmentModel> Create(EnviornmentModel _object);

        public Task<bool> Update(string id,EnviornmentModel _object);

        public Task<List<EnviornmentModel>> GetAll();

        public Task<EnviornmentModel> GetById(string Id);

        public Task<int> Delete(string id);
    }
}
