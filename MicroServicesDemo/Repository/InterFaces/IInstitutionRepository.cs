using InstitutionApi.Model;

namespace InstitutionApi.Repository.InterFaces
{
    public interface IInstitutionRepository
    {
        public Task<InstitutionModel> Create(InstitutionModel _object);

        public void Update(InstitutionModel _object);

        public IEnumerable<InstitutionModel> GetAll();

        public InstitutionModel GetById(string Id);

        public void Delete(InstitutionModel _object);

    }
}
