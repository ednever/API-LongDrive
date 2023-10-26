namespace LongDrive.Models
{
    public class Soiduauto : Auto
    {
        public int Id { get; set; }
        public string Pilt { get; set; }
        public Soiduauto(double pikkus, int mass, string mark, string pilt) : base(pikkus, mass, mark)
        {
            Pilt = pilt;
        }
    }
}