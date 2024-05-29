using System.ComponentModel.DataAnnotations;

namespace KisiselWebSitesi.Models.Classes
{
    public class AnaSayfa
    {
        [Key]
        public int id { get; set; }
        public string profileImg { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public string contact { get; set; }
    }
}
