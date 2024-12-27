using Microsoft.AspNetCore.Mvc;
using MyBlogNight.BusinessLayer.Abstract;

namespace MyBlogNight.PresentationLayer.ViewComponents
{
    public class _DefaultSidebarCategoryComponentPartial : ViewComponent
    {
        private readonly ICategoryService _categoryService;
        private readonly IArticleService _articleService;

        public _DefaultSidebarCategoryComponentPartial(ICategoryService categoryService, IArticleService articleService)
        {
            _categoryService = categoryService;
            _articleService = articleService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _articleService.TCategoryCountArticle();
            return View(values);
        }
    }
}
