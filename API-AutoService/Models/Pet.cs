using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API_Coworking.Models
{
    public class Pet
    {
        [Key]
        public int id { get; set; }
        public int userid { get; set; }
        public string name { get; set; } = string.Empty;
        public string type { get; set; } = string.Empty;
        public DateTime birth_date { get; set; }
        public int battle_rating { get; set; }

    }
}
