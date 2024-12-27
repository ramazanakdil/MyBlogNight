using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MyBlogNight.BusinessLayer.Abstract;
using MyBlogNight.EntityLayer.Concrete;

namespace MyBlogNight.PresentationLayer.Areas.Author.Controllers
{
    [Area("Author")]
    public class CommentController : Controller
    {
        private readonly ICommentService _commentService;
        private readonly UserManager<AppUser> _userManager;
        private readonly IArticleService _articleService;

        public CommentController(ICommentService commentService, UserManager<AppUser> userManager, IArticleService articleService)
        {
            _commentService = commentService;
            _userManager = userManager;
            _articleService = articleService;
        }

        public async Task<IActionResult> MyCommentList()
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            var values = _commentService.TGetCommtensByAppUserId(user.Id);
            return View(values);
        }
    }
}
