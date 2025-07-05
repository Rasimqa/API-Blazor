using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API_Coworking.Models
{
    public class MedCard
    {
        [Key]
        public int id { get; set; }
        public int pet_id { get; set; }
        public int vet_id { get; set; }
        public string prescription { get; set; } = string.Empty;
        public string diagnosis { get; set; } = string.Empty;
        public DateTime visit_date { get; set; }
        public DateTime next_visit { get; set; }

    }
}
