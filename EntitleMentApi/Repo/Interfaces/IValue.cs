using EntitleMentApi.Model;

namespace EntitleMentApi.Repo.Interfaces
{
    public interface IValue
    {
        public Task Create(ValueModel tree);
        public Task Update(int id, ValueModel tree);
        public Task Delete(int id);
        public Task<ValueModel> GetAll();
        public Task<ValueModel> Get(int id);
    }
}
