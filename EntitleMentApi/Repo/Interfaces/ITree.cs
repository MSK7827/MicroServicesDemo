using EntitleMentApi.Model;

namespace EntitleMentApi.Repo.Interfaces
{
    public interface ITree
    {
        public Task Create(TreeModel tree);
        public Task Update(int id,TreeModel tree);
        public Task Delete(int id);
        public Task<TreeModel> GetAll();
        public Task<TreeModel> Get(int id);
    }
}
