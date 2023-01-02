using SorApi.Context;
using SorApi.Model;
using SorApi.Repo.Interface;

namespace SorApi.Repo.Implementations
{
    public class SorRepo : ISorRepo
    {
        private readonly SorDbContext _dbContext;
        public SorRepo(SorDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<SorModel> Create(SorModel _object)
        {
            var result = await _dbContext.Sors.AddAsync(_object);
            _dbContext.SaveChanges();
            return result.Entity;
        }

        public async Task<int> Delete(string id)
        {
            var result = await _dbContext.Sors.Remove(id);
            _dbContext.SaveChanges();
            return result.Entity;
        }

        public Task<List<SorModel>> GetAll()
        {
            var result = _dbContext.Sors.ToList();
            return Task.FromResult(result);
        }

        public Task<SorModel> GetById(string Id)
        {
            var result = _dbContext.Sors.Where(x => x.EnvironMentId == Id).FirstOrDefault();
            return Task.FromResult(result);
        }

        public async Task<bool> Update(string id, SorModel model)
        {
            bool updated = false;
            var result = await _dbContext.Sors.FindAsync(id);
            if (result != null)
            {
                result.SorDescription= model.SorDescription;
                result.SorName = model.SorName;
                result.EnvironMentId = model.EnvironMentId;
                result.InstitutionId = model.InstitutionId;
                updated = true;
                _dbContext.SaveChanges();
            }
            return updated;

        }
    }
}
