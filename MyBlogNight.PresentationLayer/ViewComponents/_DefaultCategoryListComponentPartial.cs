using Microsoft.AspNetCore.Mvc;
using MyBlogNight.BusinessLayer.Abstract;

namespace MyBlogNight.PresentationLayer.ViewComponents
{
    public class _DefaultCategoryListComponentPartial : ViewComponent
    {
        private readonly ICategoryService _categoryservice;

        public _DefaultCategoryListComponentPartial(ICategoryService categoryservice)
        {
            _categoryservice = categoryservice;
        }
        public IViewComponentResult Invoke()
        {
            var values = _categoryservice.TGetAll();
            return View(values);
        }
    }
}
