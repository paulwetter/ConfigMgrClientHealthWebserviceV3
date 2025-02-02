using System.ComponentModel.DataAnnotations;

namespace ClientHealthWebserviceV3.Models
{
    public class ClientConfiguration
    {
        [Key]
        public string Id { get; set; } = string.Empty;
        public string Configuration { get; set; } = "{}";
    }
}
