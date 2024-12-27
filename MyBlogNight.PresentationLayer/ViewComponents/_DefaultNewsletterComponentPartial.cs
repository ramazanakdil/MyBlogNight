using Microsoft.AspNetCore.Mvc;
using MyBlogNight.BusinessLayer.Abstract;
using MyBlogNight.EntityLayer.Concrete;

namespace MyBlogNight.PresentationLayer.ViewComponents
{
    public class _DefaultNewsletterComponentPartial : ViewComponent
    {
        private readonly ISubscribeService _subscribeService;

        public _DefaultNewsletterComponentPartial(ISubscribeService subscribeService)
        {
            _subscribeService = subscribeService;
        }

        public IViewComponentResult Invoke()
        {
            var subscribe = new Subscribe();
            return View(subscribe);
        }

    }
}
