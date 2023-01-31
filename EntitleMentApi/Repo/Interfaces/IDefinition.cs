using EntitleMentApi.Model;

namespace EntitleMentApi.Repo.Interfaces
{
    public interface IDefinition
    {
        public Task Create(DefinitionModel tree);
        public Task Update(int id, DefinitionModel tree);
        public Task Delete(int id);
        public Task<DefinitionModel> GetAll();
        public Task<DefinitionModel> Get(int id);
    }
}
