using EntitleMentApi.Model;
using EntitleMentApi.Repo.Interfaces;

namespace EntitleMentApi.Repo.Implementations
{
    public class Value : IValue
    {
        public Task Create(ValueModel tree)
        {
            throw new NotImplementedException();
        }

        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ValueModel> Get(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ValueModel> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task Update(int id, ValueModel tree)
        {
            throw new NotImplementedException();
        }
    }
}
