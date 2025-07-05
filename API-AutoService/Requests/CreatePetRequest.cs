using System.ComponentModel.DataAnnotations;

namespace API_BlazorForSome.Requests
{
    public class CreatePetRequest
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
