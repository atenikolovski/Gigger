using Gigger.Models;
using Gigger.ViewModels;
using System.Linq;
using System.Web.Mvc;

namespace Gigger.Controllers
{
    public class GigsController : Controller
    {
        private ApplicationDbContext _context;
        // GET: Gigs
        public GigsController()
        {
            _context = new ApplicationDbContext();
        }

        public ActionResult Create()
        {
            var ViewModel = new GigFormViewModel
            {
                Genres = _context.Genres.ToList()
            };
            
            return View(ViewModel);
        }
    }
}