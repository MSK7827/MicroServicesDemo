using EnvironMentApi.context;
using EnvironMentApi.Model;
using EnvironMentApi.Repo.Interfaces;

namespace EnvironMentApi.Repo.Implimentations
{
    public class EnvironmtRepo : IEnvironment
    {
        private readonly EnvironMentDbContext _dbContext;
        public EnvironmtRepo(EnvironMentDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<EnviornmentModel> Create(EnviornmentModel _object)
        {
            var result = await _dbContext.Enviornments.AddAsync(_object);
            _dbContext.SaveChanges();
            return result.Entity;
        }

        public async Task<int> Delete(string id)
        {
            var result = await _dbContext.Enviornments.Remove(id);
            _dbContext.SaveChanges();
            return result.Entity;
        }

        public Task<List<EnviornmentModel>> GetAll()
        {
            var result = _dbContext.Enviornments.ToList();
            return Task.FromResult(result);
        }

        public Task<EnviornmentModel> GetById(string Id)
        {
            var result = _dbContext.Enviornments.Where(x => x.EnvironMentId == Id).FirstOrDefault();
            return Task.FromResult(result);
        }

        public async Task<bool> Update(string id, EnviornmentModel model)
        {
            bool updated = false;
            var result = await _dbContext.Enviornments.FindAsync(id);
            if (result != null)
            {
                result.EnvironMentName = model.EnvironMentName;
                result.EnvironMentId = model.EnvironMentId;
                result.InstitutionId = model.InstitutionId;
                updated = true;
                _dbContext.SaveChanges();
            }
            return updated;

        }
    }
}
