namespace LongDrive.Models
{
    public class Tellimus
    {
        public string Nimi { get; set; }
        public int Vahemaa { get; set; }
        public string Kirjeldus { get; set; } 
        //public Tellimus() { }
        public Tellimus(string nimi, int vahemaa, string kirjeldus) 
        {
            Nimi = nimi;
            Vahemaa = vahemaa;
            Kirjeldus = kirjeldus;
        }
    }
}
