using System.ComponentModel.DataAnnotations;

namespace EntitleMentApi.Model
{
    public class TreeModel
    {
        [Key]
        public Guid TreeId { get; set; }
        public string TreeName { get; set; }
        public string sorId { get; set; }
        public List<string> Allpaths { get; set; }
    }
}
