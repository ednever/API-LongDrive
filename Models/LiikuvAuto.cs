namespace LongDrive.Models
{
    public class LiikuvAuto : Auto
    {
        public int Tee { get; set; }
        //public LiikuvAuto() { }
        public LiikuvAuto(double pikkus, int mass, string mark, int tee) : base (pikkus, mass, mark)
        { 
            Tee = tee;
        }
        public int Edasi(int tee) 
        {
            return tee += 1;
        }
        public int Tagasi(int tee) 
        {
            return tee -= 1;
        }
    }
}
