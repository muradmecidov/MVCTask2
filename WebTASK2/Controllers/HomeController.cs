using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebTASK2.DAL;
using WebTASK2.Models;

namespace WebTASK2.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContex _appDbContex ;

        public HomeController(AppDbContex appDbContex)
        {
            _appDbContex = appDbContex;
        }

        public async Task<IActionResult> Index()
        {
            List<Slider> sliders = await _appDbContex.Sliders.ToListAsync();
            return View(sliders);
        }
    }
}
