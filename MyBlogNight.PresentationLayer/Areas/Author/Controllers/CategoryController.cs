using Microsoft.AspNetCore.Mvc;
using MyBlogNight.BusinessLayer.Abstract;
using MyBlogNight.BusinessLayer.ValidationRules.CategoryValidationRules;
using MyBlogNight.EntityLayer.Concrete;
using System.ComponentModel.DataAnnotations;
using FluentValidation.Results;


namespace MyBlogNight.PresentationLayer.Areas.Author.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public IActionResult CategoryList()
        {
            var values = _categoryService.TGetAll();
            return View(values);
        }
        [HttpGet]
        public IActionResult CreateCategory()
        {
            return View();
        }
       

        public IActionResult DeleteCategory(int id)
        {
            _categoryService.TDelete(id);
            return RedirectToAction("CategoryList");
        }
        [HttpGet]
        public IActionResult UpdateCategory(int id)
        {
            var value = _categoryService.TGetById(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult UpdateCategory(Category category)
        {
            _categoryService.TUpdate(category);
            return RedirectToAction("CategoryList");
        }
    }
}
