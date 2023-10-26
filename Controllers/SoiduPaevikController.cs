using LongDrive.Data;
using LongDrive.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LongDrive.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class SoiduPaevikController : ControllerBase
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

        [HttpPost("lisa/{aeg}/{veoautoId}/{tellimusid}")] //SoiduPaeviku lisamine
        public List<SoiduPaevik> Add(DateTime aeg, int veoautoId, int tellimusId)
        {
            bool olemus = true;
            foreach (SoiduPaevik soiduPaevik in _context.SoiduPaevikud)
            {
                if (soiduPaevik.VeoautoId == veoautoId && soiduPaevik.TellimusId == tellimusId)
                {
                    olemus = false;
                }
            }

            if (olemus)
            {
                _context.SoiduPaevikud.Add(new SoiduPaevik(aeg, veoautoId, tellimusId));
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