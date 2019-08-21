using Gigger.Models;
using Gigger.ViewModels;
using System.Linq;
using System.Web.Mvc;
using System.Security.Principal;
using Microsoft.AspNet.Identity;
using System;

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

        [Authorize]
        public ActionResult Create()
        {
            var ViewModel = new GigFormViewModel
            {
                Genres = _context.Genres.ToList()
            };
            
            return View(ViewModel);
        }

        [Authorize]
        [HttpPost]       
        [ValidateAntiForgeryToken]
        public ActionResult Create(GigFormViewModel viewModel)
        {
            if (!ModelState.IsValid)
            {
                viewModel.Genres = _context.Genres.ToList();
                return View("Create", viewModel);
            }
                

            var gig = new Gig
            {
                ArtistId = User.Identity.GetUserId(),
                DateTime = viewModel.GetDateTime(),
                GenreId = viewModel.Genre,
                Venue = viewModel.Venue

            };

            _context.Gigs.Add(gig);
            _context.SaveChanges();

            return RedirectToAction("Index", "Home");
        }
    }
}