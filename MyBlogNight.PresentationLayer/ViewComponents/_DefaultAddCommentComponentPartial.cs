using Microsoft.AspNetCore.Mvc;
using MyBlogNight.EntityLayer.Concrete;

namespace MyBlogNight.PresentationLayer.ViewComponents
{
    public class _DefaultAddCommentComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke(int articleId)
        {
            ViewData["ArticleId"] = articleId;
            return View(new Comment() );
        }
    }
}
