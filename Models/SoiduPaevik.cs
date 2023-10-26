namespace LongDrive.Models
{
    public class SoiduPaevik
    {
        public int Id { get; set; }
        public DateTime Aeg { get; set; }
        public Veoauto Veoauto { get; set; }
        public int VeoautoId { get; set; }
        public Tellimus Tellimus { get; set; }
        public int TellimusId { get; set; }           
        public SoiduPaevik(DateTime aeg, int veoautoId, int tellimusId)
        {
            Aeg = aeg;
            VeoautoId = veoautoId;
            TellimusId = tellimusId;
        }
    }
}
