using API_Coworking.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace API_Coworking.Requests
{
    public class CreateWorkPlacesRequest
    {
        [Key]
        public int id { get; set; }
        public string Description { get; set; } = string.Empty;
        public int PriceForDay { get; set; }
        public DateTime StartRent { get; set; }
        public DateTime? EntRent { get; set; }
        public int User_id { get; set; }
        public int Space_id { get; set; }
    }
}
