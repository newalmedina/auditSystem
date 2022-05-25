using System;
using System.Linq;
using System.Threading.Tasks;
using auditSystem.Context;
using auditSystem.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace auditSystem.Controllers
{

    //[Authorize]
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext context;

        public CategoryController(ApplicationDbContext context)
        {
            this.context = context;
        }

        public async Task<IActionResult> Index()
        {
            ViewData["Title"] = "Categorías";
            ViewData["SubTitle"] = "Listado de Categorías";
            return View(await context.Categories.Where(x => x.Deleted_at == null).ToListAsync());
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id = 0)
        {
            if (id == 0)
            {
                ViewData["Title"] = "Nueva Categoría";
            }
            else
            {
                ViewData["Title"] = "Editar Categoría";

            }

              ViewData["SubTitle"] = "Información Básica";
            var category = await context.Categories.FindAsync(id);
            return View(category);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Category category)
        {
            if (ModelState.IsValid)
            {
                if (category.Id == 0)
                {
                    Category newCategory = new Category();
                    newCategory.Created_at = DateTime.Now;

                    var result = this.saveChanges(newCategory, category);
                    context.Add(result);
                }
                else
                {
                    Category editCategory = await context.Categories.FindAsync(category.Id);
                    editCategory.Updated_at = DateTime.Now;
                    var result = this.saveChanges(editCategory, category);
                    context.Update(result);
                }
                await context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(category);
        }

        public async Task<IActionResult> Delete(int id)
        {
            var category = await context.Categories.FindAsync(id);
            category.Deleted_at = DateTime.Now;
            await context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> HardDelete(int id)
        {
            var category = await context.Categories.FindAsync(id);
            context.Categories.Remove(category);
            await context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private Category saveChanges(Category newCategory, Category request)
        {
            newCategory.Active = request.Active;
            newCategory.Name = request.Name;
            newCategory.Description = request.Description;

            return newCategory;
        }


    }
}