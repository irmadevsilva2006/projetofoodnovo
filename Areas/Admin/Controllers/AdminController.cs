using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace projetofood.Areas.Admin.Controllers
{
    public class AdminController: Controller
    {
        [Area("Admin")]
         [Authorize(Roles = "Admin")]
        public IActionResult Index(){
            return View();
        }
    }
}