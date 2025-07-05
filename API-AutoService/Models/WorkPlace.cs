using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API_BlazorForSome.Models
{
    public class WorkPlace
    {
        [Key]
        public int id { get; set; }
        public string Description { get; set; } = string.Empty;
        public int PriceForDay { get; set; }
        public DateTime StartRent { get; set; }
        public DateTime? EntRent { get; set; }
        
        public int userid { get; set; }
        public int spacesid { get; set; }
    }
}
