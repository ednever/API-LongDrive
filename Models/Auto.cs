namespace LongDrive.Models
{
    public class Auto
    {
        public double Pikkus { get; set; }
        public int Mass { get; set; }
        public string Mark { get; set; }
        //public Auto() { }
        public Auto(double pikkus, int mass, string mark)
        {
            Pikkus = pikkus;
            Mass = mass;
            Mark = mark;
        }
    }
}
