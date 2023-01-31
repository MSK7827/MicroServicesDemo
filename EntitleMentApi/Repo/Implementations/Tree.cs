using EntitleMentApi.Model;
using EntitleMentApi.Repo.Interfaces;

namespace EntitleMentApi.Repo.Implementations
{
    public class Tree : ITree
    {
        public Task Create(TreeModel tree)
        {
            throw new NotImplementedException();
        }

        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<TreeModel> Get(int id)
        {
            throw new NotImplementedException();
        }

        public Task<TreeModel> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task Update(int id, TreeModel tree)
        {
            throw new NotImplementedException();
        }
    }
}
