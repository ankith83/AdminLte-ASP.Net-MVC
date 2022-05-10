using DataLayer.Services;
using MyShopWeb.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyShopWeb.Controllers
{
    public class CategoriesController : Controller
    {
        CategoriesService service = new CategoriesService();
        // GET: Categories
        public ActionResult Index(int? parentCategoryId)
        {
            List<CategoryViewModel> categories = service.GetAllCategories().Select(s => new CategoryViewModel
            {
                Id= s.Id,
                Name = s.Name,
                Description = s.Description,
                ParentId = s.ParentId,
                ParentName = s.Category1?.Name
            }).ToList();
            return View(categories);
        }

        public ActionResult Create(int? parentCategoryId)
		{
            ViewBag.ParentId = parentCategoryId;
            return View();
		}

        [HttpPost]
        public ActionResult Create(CategoryViewModel catergory)
        {
			if (ModelState.IsValid)
			{
                service.AddCategory(new DataLayer.Category{ Name = catergory.Name, Description = catergory.Description, ParentId = catergory.ParentId, CreatedOn = DateTime.UtcNow, LastModifiedOn = DateTime.UtcNow });
                return RedirectToAction("Index", "Categories");
            }

            return View();
        }
    }
}