namespace LongDrive.Models
{
    public class Veoauto : LiikuvAuto
    {
        public int Id { get; set; }
        public SoiduPaevik SoiduPaevik { get; set; }
        public int SoiduPaevikId { get; set; }

        public Veoauto(int soiduPaevikId, double pikkus, int mass, string mark, int tee) : base(pikkus, mass, mark, tee) //SoiduPaevik soiduPaevik, 
        {
            SoiduPaevikId = soiduPaevikId;
        }
        public void OtsiTellimus(DateTime algus, DateTime lopp)
        {

        }
    }
}