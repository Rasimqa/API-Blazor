using System.ComponentModel.DataAnnotations;

namespace API_BlazorForSome.Requests
{
    public class CreateTrainingRequest
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
