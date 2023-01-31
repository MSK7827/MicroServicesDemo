using System.ComponentModel.DataAnnotations;

namespace EntitleMentApi.Model
{
    public class DefinitionModel
    {
        [Key]
        public Guid Id { get; set; }
        public string Entitlement { get; set; }
        public List<string> Paths { get; set; }
        public string crawl { get; set; }
        public string Type { get; set; }
        public string calc { get; set; }
        public string Sorid { get; set; }
        public string treeId { get; set; }

    }
}
