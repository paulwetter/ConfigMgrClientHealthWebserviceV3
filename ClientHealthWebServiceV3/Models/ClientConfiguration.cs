using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ClientHealthWebserviceV3.Models
{
    public class ClientConfiguration
    {
        [Key]
        public string Id { get; set; } = string.Empty;
        public string Configuration { get; set; } = "{}";
    }
}
