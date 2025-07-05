using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API_Coworking.Models
{
    public class Training
    {
        [Key]
        public int id { get; set; }
        public int pet_id { get; set; }
        public string skill_name { get; set; } = string.Empty;
        public string status { get; set; } = string.Empty;
        public DateTime start_date { get; set; }
        public DateTime last_practice { get; set; }

    }
}
