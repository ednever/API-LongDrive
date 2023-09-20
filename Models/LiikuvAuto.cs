namespace LongDrive.Models
{
    public class LiikuvAuto : Auto
    {
        public int Tee { get; set; }
        //public LiikuvAuto() { }
        public LiikuvAuto(double pikkus, int mass, string mark, int tee) 
        { 
            Tee = tee;
        }
        public void Edasi(int tee) { }
        public void Tagasi(int tee) { }
    }
}
