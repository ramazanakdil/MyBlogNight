using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MyBlogNight.BusinessLayer.Abstract;
using MyBlogNight.EntityLayer.Concrete;
using System.Runtime.InteropServices;
using X.PagedList.Mvc.Core;
using X.PagedList.Extensions;



namespace MyBlogNight.PresentationLayer.Controllers
{
    public class DefaultController : Controller
    {
        private readonly ISubscribeService _subscribeService;
        private readonly IArticleService _articleService;
        private readonly ICommentService _commentService;
        private readonly UserManager<AppUser> _userManager;

        public DefaultController(ISubscribeService subscribeService, IArticleService articleService, ICommentService commentService, UserManager<AppUser> userManager)
        {
            _subscribeService = subscribeService;
            _articleService = articleService;
            _commentService = commentService;
            _userManager = userManager;
        }

        public IActionResult Index(int page = 1)
        {
            const int pageSize = 5;
            var values = _articleService.TArticleListWithCategoryAndAppUser();
            var pagedArticles = values.ToPagedList(page, pageSize);
            return View(pagedArticles);
        }

        [HttpPost]
        public IActionResult AddNewsletter(Subscribe subscribe)
        {

            _subscribeService.TInsert(subscribe);
            TempData["NewsletterMessage"] = "Başarılı bir şekilde abone oldunuz!";
            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> AddComment(Comment comment)
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            comment.AppUserId = user.Id;
            comment.CreatedDate = DateTime.Now;
            comment.Status = true;
            _commentService.TInsert(comment);
            return RedirectToAction("Index", "Default");
        }

        public IActionResult ArticleDetail(int id)
        {
            _articleService.TArticleViewCountIncrease(id);
            var value = _articleService.TArticleListWithCategoryAndAppUserByArticleId(id);
            return View(value);
        }


    }
}
