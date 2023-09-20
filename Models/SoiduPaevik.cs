using Microsoft.Extensions.Hosting;

namespace LongDrive.Models
{
    public class SoiduPaevik
    {
        public int Id { get; set; }
        public Tellimus Tellimus { get; set; }
        public ICollection<Veoauto> Veoauto { get; }
        public DateTime Algus { get; set; }
        public DateTime Lopp { get; set; }
        public SoiduPaevik(DateTime algus, DateTime lopp) 
        {
            Algus = algus;
            Lopp = lopp;
        }
    }
}
