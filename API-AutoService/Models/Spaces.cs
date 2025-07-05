using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API_Coworking.Models
{
    public class Spaces
    {
        [Key]
        public int id { get; set; }
        public string NameSpace { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public int Square { get; set; }

    }
}
