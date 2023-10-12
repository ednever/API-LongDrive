using LongDrive.Data;
using LongDrive.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LongDrive.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class VeoautoController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public VeoautoController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet] //Veoautode näitamine
        public List<Veoauto> Get()
        {
            return _context.Veoautod.ToList();
        }

        [HttpGet("{id}")] //Veoauto näitamine
        public Veoauto GetByID(int id)
        {
            foreach (Veoauto veoauto in _context.Veoautod)
            {
                if (veoauto.Id == id)
                {
                    return veoauto;
                }
            }
            return null;
        }

        [HttpPost("lisa/{pikkus}/{mass}/{mark}/{tee}")] //Veoauto lisamine
        public List<Veoauto> Add(double pikkus, int mass, string mark, int tee)
        {
            bool olemus = true;
            foreach (Veoauto veoauto in _context.Veoautod)
            {
                if (veoauto.Pikkus == pikkus && veoauto.Mass == mass)
                {
                    olemus = false;
                }
            }

            if (olemus)
            {
                _context.Tellimused.Add(new Tellimus("", 0, ""));
                _context.SaveChanges();
                _context.SoiduPaevikud.Add(new SoiduPaevik(_context.Tellimused.ToList().Last().Id, DateTime.Now, DateTime.Now));
                _context.SaveChanges();
                _context.Veoautod.Add(new Veoauto(_context.SoiduPaevikud.ToList().Last().Id, pikkus, mass, mark, tee));
                _context.SaveChanges();
            }

            return _context.Veoautod.ToList();
        }

        [HttpDelete("kustuta/{id}")] //Veoauto kustutamine
        public List<Veoauto> Delete(int id)
        {
            var veoauto = _context.Veoautod.Find(id);

            if (veoauto == null)
                return _context.Veoautod.ToList();

            _context.Veoautod.Remove(veoauto);
            _context.SaveChanges();
            return _context.Veoautod.ToList();
        }
    }
}
