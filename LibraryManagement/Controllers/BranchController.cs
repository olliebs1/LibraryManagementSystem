using System;
using Microsoft.AspNetCore.Mvc;

namespace LibraryManagement.Controllers
{
    public class BranchController : Controller
    {
        public ILibraryBranch _branch;
        public BranchController(ILibraryBranch branch)
        {
            _branch = branch;
        }


        public IActionResult Index()
        {
            return View();
        }
    }
}
