namespace LongDrive.Models
{
    public class Soiduauto : LiikuvAuto
    {
        public int Id { get; set; }
        public string Pilt { get; set; }
        public Soiduauto(double pikkus, int mass, string mark, int tee, string pilt) : base(pikkus, mass, mark, tee)
        {
            Pilt = pilt;
        }
    }
}