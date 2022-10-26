using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class Teenus
    {
        [Key]
        public int TeenusID { get; set; }
        public string Nimetus { get; set; }
        public int Hind { get; set; }
        public int Kestvus { get; set; }
    }
}
