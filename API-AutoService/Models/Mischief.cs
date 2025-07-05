using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API_Coworking.Models
{
    public class Mischief
    {
        [Key]
        public int id { get; set; }
        public int pet_id { get; set; }
        public string type { get; set; } = string.Empty;
        public string description { get; set; } = string.Empty;
        public DateTime date_time { get; set; }
        public string severity { get; set; }

    }
}
