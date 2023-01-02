using System.ComponentModel.DataAnnotations;

namespace InstitutionApi.Model
{
    public class InstitutionModel
    {
        [Key]
        public string? InstitutionId { get; set; }
        public string? InstitutionName { get; set;}
    }
}
