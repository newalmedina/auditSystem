using System.Threading.Tasks;
using auditSystem.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace auditSystem.Controllers
{
    public class RoleController : Controller
    {
        private readonly RoleManager<IdentityRole> gestionRoles;

        public RoleController(RoleManager<IdentityRole> gestionRoles)
        {
            this.gestionRoles = gestionRoles;
        }

        [HttpGet]
        [Route("role")]
        public IActionResult Index()
        {
            ViewData["title"] = "Listado de Roles";
            var roles = gestionRoles.Roles;
            return View("index", roles);

        }

        [HttpGet]
        [Route("role/create")]
        public IActionResult CreateRole()
        {
            ViewData["title"] = "Crear Rol";
            return View("edit");
        }

        [HttpPost]
        [Route("role/create")]
        public async Task<IActionResult> CreateRole(RoleViewModel model)
        {
            if (ModelState.IsValid)
            {
                IdentityRole identityRole = new IdentityRole
                {
                    Name = model.Name
                };

                IdentityResult result = await gestionRoles.CreateAsync(identityRole);
                if (result.Succeeded)
                {
                    return RedirectToAction("index", "home");
                }
                foreach (IdentityError error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
            }
            return RedirectToAction(nameof(Index));
            // return View(model);

        }
    }
}