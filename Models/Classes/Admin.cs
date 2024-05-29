using System.ComponentModel.DataAnnotations;

namespace KisiselWebSitesi.Models.Classes
{
    public class Admin
    {
        [Key]
        public int id { get; set; }
        public string userName { get; set; }
        public string password { get; set; }
    }
}
