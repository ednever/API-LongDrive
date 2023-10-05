using LongDrive.Data;
using LongDrive.Models;
using Microsoft.AspNetCore.Mvc;

namespace LongDrive.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class SoiduautoController : ControllerBase //Прописать в js, что максимальная масса т.е. цифра в input number = 3500
    {
        private readonly ApplicationDbContext _context;

        public SoiduautoController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet] //Soiduautode näitamine
        public List<Soiduauto> Get()
        {
            return _context.Soiduautod.ToList();
        }

        [HttpGet("{id}")] //Soiduauto näitamine
        public List<Soiduauto> GetByID()
        {

            return _context.Soiduautod.ToList();
        }

        [HttpPost("lisa/{pikkus}/{mass}/{mark}/{tee}")] //Soiduauto lisamine
        public List<Soiduauto> Add(double pikkus, int mass, string mark, int tee)
        {
            bool olemus = true;
            foreach (Soiduauto soiduauto in _context.Soiduautod)
            {
                if (soiduauto.Pikkus == pikkus && soiduauto.Mass == mass)
                {
                    olemus = false;
                }
            }

            if (olemus)
            {
                _context.Soiduautod.Add(new Soiduauto(pikkus, mass, mark, tee));
                _context.SaveChanges();
            }

            return _context.Soiduautod.ToList();
        }

        [HttpDelete("kustuta/{id}")] //Soiduauto kustutamine
        public List<Soiduauto> Delete(int id)
        {
            var soiduauto = _context.Soiduautod.Find(id);

            if (soiduauto == null)
                return _context.Soiduautod.ToList();

            _context.Soiduautod.Remove(soiduauto);
            _context.SaveChanges();
            return _context.Soiduautod.ToList();
        }
    }
}
