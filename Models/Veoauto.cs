namespace LongDrive.Models
{
    public class Veoauto : LiikuvAuto
    {
        List<Tellimus> Tellimus { get; set; }
        public Veoauto() { }
        public Veoauto(double pikkus, int mass, int mark) 
        {

        }
        public void OtsiTellimus(DateTime algus, DateTime lopp)
        {

        }
    }
}
