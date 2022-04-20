using System;
using System.Linq;
using LibraryData;
using Microsoft.AspNetCore.Mvc;

namespace LibraryManagement.Controllers
{
    public class PatronController : Controller
    {
        private IPatron _patron;

        public PatronController(IPatron patron)
        {
            _patron = patron;
        }

        public IActionResult Index()
        {
            var allPatrons = _patron.GetAll();

            var patronModels = allPatrons.Select(p => new PatronDetailModel
            {

            });
        }
    }
}
