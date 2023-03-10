using InstitutionApi.Context;
using InstitutionApi.Model;
using InstitutionApi.Repository.InterFaces;
using Microsoft.EntityFrameworkCore;

namespace InstitutionApi.Repository.Implementations
{
    public class InstitutionRepo : IRepository<InstitutionModel>
    {
        private readonly InstitutionDbContext _dbContext;
        public InstitutionRepo(InstitutionDbContext context)
        {
            _dbContext = context;
        }

        public async Task<InstitutionModel> Create(InstitutionModel _object)
        {
            var obj = await _dbContext.Institutions.AddAsync(_object);
            _dbContext.SaveChanges();
            return obj.Entity;
        }

        public void Delete(InstitutionModel _object)
        {
            _dbContext.Remove(_object);
            _dbContext.SaveChanges();
        }

        public IEnumerable<InstitutionModel> GetAll()
        {
            try
            {
                return _dbContext.Institutions.ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public InstitutionModel GetById(int Id)
        {
            return _dbContext.Institutions.Where(x => x.InstitutionId == Id).FirstOrDefault();
        }

        public void Update(InstitutionModel _object)
        {
            _dbContext.Institutions.Update(_object);
            _dbContext.SaveChanges();
        }
    }
}
