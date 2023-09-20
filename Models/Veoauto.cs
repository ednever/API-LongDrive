namespace LongDrive.Models
{
    public class Veoauto : LiikuvAuto
    {
        public int Id { get; set; }
        public SoiduPaevik SoiduPaevik { get; set; }

        public Veoauto(double pikkus, int mass, string mark, int tee) : base(pikkus, mass, mark, tee)
        {
            
        }
        public void OtsiTellimus(DateTime algus, DateTime lopp)
        {

        }
    }
}
