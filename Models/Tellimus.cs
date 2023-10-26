namespace LongDrive.Models
{
    public class Tellimus
    {
        public int Id { get; set; }
        public string Nimi { get; set; }
        public int Vahemaa { get; set; }
        public string Kirjeldus { get; set; }   
        public bool IsActive { get; set; }
        public ICollection<SoiduPaevik> SoiduPaevik { get; }
        public Tellimus(string nimi, int vahemaa, string kirjeldus, bool isActive)
        {
            Nimi = nimi;
            Vahemaa = vahemaa;
            Kirjeldus = kirjeldus;
            IsActive = isActive;
        }
    }
}
