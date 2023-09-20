namespace LongDrive.Models
{
    public class Soiduauto : LiikuvAuto
    {
        public int Id { get; set; }
        public Soiduauto(double pikkus, int mass, string mark, int tee) : base(pikkus, mass, mark, tee)
        { 

        }
    }
}