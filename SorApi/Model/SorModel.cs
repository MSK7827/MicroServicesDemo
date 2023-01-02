using System.ComponentModel.DataAnnotations;

namespace SorApi.Model
{
    public class SorModel
    {
        public string? InstitutionId { get; set; }
        public string? EnvironMentId { get; set; }
        [Key]
        public string? SorId { get; set; }
        public string? SorName { get; set; }
        public string? SorDescription { get; set; }
    }
}
