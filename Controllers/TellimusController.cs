using LongDrive.Data;
using LongDrive.Models;
using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;

namespace LongDrive.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class TellimusController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public TellimusController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet] //Tellimuste näitamine
        public List<Tellimus> Get()
        {
            return _context.Tellimused.ToList();
        }

        [HttpPost("lisa/{nimi}/{vahemaa}/{kirjeldus}")] //Tellimuse lisamine
        public List<Tellimus> Add(string nimi, int vahemaa, string kirjeldus)
        {
            bool olemus = true;
            foreach (Tellimus tellimus in _context.Tellimused)
            {
                if (tellimus.Nimi == nimi && tellimus.Vahemaa == vahemaa)
                {
                    olemus = false;
                }
            }

            if (olemus)
            {
                _context.Tellimused.Add(new Tellimus(nimi, vahemaa, kirjeldus));
                _context.SaveChanges();
            }

            return _context.Tellimused.ToList();
        }

        [HttpDelete("kustuta/{id}")] //Tellimuse kustutamine
        public List<Tellimus> Delete(int id)
        {
            var tellimus = _context.Tellimused.Find(id);

            if (tellimus == null)
                return _context.Tellimused.ToList();          

            _context.Tellimused.Remove(tellimus);
            _context.SaveChanges();
            return _context.Tellimused.ToList();
        }
    }
}
