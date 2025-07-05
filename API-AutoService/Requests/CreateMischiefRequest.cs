using System.ComponentModel.DataAnnotations;

namespace API_BlazorForSome.Requests
{
    public class CreateMischiefRequest
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
