using System.ComponentModel.DataAnnotations;

namespace EnvironMentApi.Model
{
    public class EnviornmentModel
    {
        public string? InstitutionId { get; set; }
        [Key]
        public string? EnvironMentId { get; set; }

        public string? EnvironMentName { get;set; }

    }
}
