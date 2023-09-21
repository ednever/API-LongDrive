using Microsoft.Extensions.Hosting;

namespace LongDrive.Models
{
    public class SoiduPaevik
    {
        public int Id { get; set; }
        public Tellimus Tellimus { get; set; }
        public int TellimusId { get; set; }
        public ICollection<Veoauto> Veoauto { get; }
        public DateTime Algus { get; set; }
        public DateTime Lopp { get; set; }
        public SoiduPaevik(int tellimusId, DateTime algus, DateTime lopp) //Tellimus tellimus, 
        {
            //Tellimus = tellimus;
            TellimusId = tellimusId;
            Algus = algus;
            Lopp = lopp;
        }
    }
}
