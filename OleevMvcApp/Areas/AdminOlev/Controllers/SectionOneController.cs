using Microsoft.AspNetCore.Mvc;
using OleevMvcApp.Models;

namespace OleevMvcApp.Areas.AdminOlev.Controllers
{
    [Area("AdminOlev")]
    public class SectionOneController : Controller
    {
        private readonly OleevContext _context;

        public SectionOneController(OleevContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View(_context.SectionOnes.ToList());
        }

        [HttpGet]
        public async Task<IActionResult> Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(SectionOne sectionOne)
        {
            _context.SectionOnes.Add(sectionOne);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        
        public async Task<IActionResult> Detail(int id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sectionOne = _context.SectionOnes.FirstOrDefault(x => x.Id == id);
            if (sectionOne == null)
            {
                return NotFound();
            }

            return View(sectionOne);
        }


        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var section = _context.SectionOnes.FirstOrDefault(x=>x.Id == id);

            if (section == null)
            {
                return NotFound();
            }

            return View(section);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(SectionOne sectionOne)
        {
            _context.SectionOnes.Update(sectionOne);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }


        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            var section = _context.SectionOnes.FirstOrDefault(x => x.Id == id);

            if (section == null)
            {
                return NotFound();
            }

            return View(section);
        }

        [HttpPost]
        public async Task<IActionResult> Delete(SectionOne sectionOne)
        {
            _context.SectionOnes.Remove(sectionOne);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }


    }
}
