using LongDrive.Data;
using LongDrive.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LongDrive.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class SoiduPaevikController : ControllerBase //Прописать в js, что максимальная масса т.е. цифра в input number = 3500
    {
        private readonly ApplicationDbContext _context;

        public SoiduPaevikController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet] //SoiduPaevikute näitamine
        public List<SoiduPaevik> Get()
        {
            return _context.SoiduPaevikud.ToList();
        }

        [HttpGet("{id}")] //SoiduPaeviku näitamine
        public SoiduPaevik GetByID(int id)
        {
            foreach (SoiduPaevik soiduPaevik in _context.SoiduPaevikud)
            {
                if (soiduPaevik.Id == id)
                {
                    return soiduPaevik;
                }
            }
            return null;
        }

        [HttpPost("lisa/{algus}/{lopp}")] //SoiduPaeviku lisamine
        public List<SoiduPaevik> Add(DateTime algus, DateTime lopp)
        {
            bool olemus = true;
            foreach (SoiduPaevik soiduPaevik in _context.SoiduPaevikud)
            {
                if (soiduPaevik.Algus == algus && soiduPaevik.Lopp == lopp)
                {
                    olemus = false;
                }
            }

            if (olemus)
            {
                _context.Tellimused.Add(new Tellimus("", 0, ""));
                _context.SaveChanges();
                _context.SoiduPaevikud.Add(new SoiduPaevik(_context.Tellimused.Last().Id, algus, lopp));
                _context.SaveChanges();
            }

            return _context.SoiduPaevikud.ToList();
        }

        [HttpDelete("kustuta/{id}")] //SoiduPaeviku kustutamine
        public List<SoiduPaevik> Delete(int id)
        {
            var soiduPaevik = _context.SoiduPaevikud.Find(id);

            if (soiduPaevik == null)
                return _context.SoiduPaevikud.ToList();

            _context.SoiduPaevikud.Remove(soiduPaevik);
            _context.SaveChanges();
            return _context.SoiduPaevikud.ToList();
        }
    }
}
//Выбрать заказ или добавить новый
//