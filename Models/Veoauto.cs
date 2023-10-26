namespace LongDrive.Models
{
    public class Veoauto : Auto
    {
        public int Id { get; set; }       
        public DateTime Algus { get; set; }
        public DateTime Lopp { get; set; }
        public ICollection<SoiduPaevik> SoiduPaevik { get; }
        public Veoauto(double pikkus, int mass, string mark, DateTime algus, DateTime lopp) : base(pikkus, mass, mark)
        {
            Algus = algus;
            Lopp = lopp;
        }
    }
}

//Грузовик(длина, масса, марка, начало, конец)
//ДневникЗаказов(время доставки, ГрузовикID, ЗаказID)
//Заказ(название, расстояние, описание)