using Microsoft.EntityFrameworkCore;
using MyBlogNight.DataAccessLayer.Abstract;
using MyBlogNight.DataAccessLayer.Context;
using MyBlogNight.DataAccessLayer.Repositories;
using MyBlogNight.EntityLayer.Concrete;
using MyBlogNight.EntityLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlogNight.DataAccessLayer.EntityFramework
{
    public class EfArticleDal : GenericRepository<Article>, IArticleDal
    {
        public EfArticleDal(BlogContext context) : base(context)
        {
        }

        public List<Article> ArticleListWithCategory()
        {
            var context = new BlogContext();
            var values = context.Articles.Include(x => x.Category).ToList();
            return values;
        }

        public List<Article> ArticleListWithCategoryAndAppUser()
        {
            var context = new BlogContext();
            var values = context.Articles.Include(x => x.Category).Include(y => y.AppUser).ToList();
            return values;
        }

        public Article ArticleListWithCategoryAndAppUserByArticleId(int id)
        {
            var context = new BlogContext();
            var values = context.Articles.Where(x => x.ArticleId == id).Include(y => y.Category).Include(z => z.AppUser).FirstOrDefault();
            return values;
        }

        public void ArticleViewCountIncrease(int id)
        {
            var context = new BlogContext();
            var updateValue = context.Articles.Find(id);
            updateValue.ArticleViewCount += 1;
            context.SaveChanges();
        }

        public List<CategoryArticleCountViewModel> CategoryCountArticle()
        {
            var context = new BlogContext();
            return context.Articles.GroupBy(x => new { x.CategoryId, x.Category.CategoryName }).Select(a => new CategoryArticleCountViewModel
            {
                CategoryId = a.Key.CategoryId,
                CategoryName = a.Key.CategoryName,
                ArticleCount = a.Count()
            }).OrderByDescending(x => x.ArticleCount).ToList();
        }

        public List<Article> GetArticlesByAppUserId(int id)
        {
            var context = new BlogContext();
            var values = context.Articles.Where(x => x.AppUserId == id).ToList();
            return values;
        }

        public List<Article> Last3ArticlesList()
        {
            var context = new BlogContext();
            var values = context.Articles.OrderByDescending(a => a.CreatedDate).Take(3).ToList();
            return values;
        }
    }
}
