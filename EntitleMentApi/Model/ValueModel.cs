using System.ComponentModel.DataAnnotations;

namespace EntitleMentApi.Model
{
    public class ValueModel
    {
        [Key]
        public Guid id { get; set; }
        public string EntitlementName { get; set; }
        public List<string> path { get; set; }
        public  List<Elements> elements{ get; set; }
        public string value { get; set; }
    }
}
