using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Gigger.Models;

namespace Gigger.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Gig> UpcomingGigs { get; set; }
        public bool ShowActions { get; set; }
        public IEnumerable<Gig> gigsLoggedUser { get; set; }
    }
}