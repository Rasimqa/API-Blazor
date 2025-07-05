using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API_Coworking.Models
{
    public class Schedule
    {
        [Key]
        public int id { get; set; }
        public int pet_id { get; set; }
        public string food_typ { get; set; } = string.Empty;
        public string portion_size { get; set; } = string.Empty;
        public DateTime schedule_time { get; set; }
        public bool active { get; set; }

    }
}
