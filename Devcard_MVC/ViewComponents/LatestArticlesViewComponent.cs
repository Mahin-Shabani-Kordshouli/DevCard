using Devcard_MVC.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Devcard_MVC.ViewComponents
{
    public class LatestArticlesViewComponent: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var articles = new List<Article>
            {
                new Article(1,"مقاله1","این اولین مقاله است.","blog-post-thumb-1.jpg"),
                new Article(2,"مقاله2","این دومین مقاله است.","blog-post-thumb-2.jpg"),
                new Article(3,"مقاله3","این سومین مقاله است.","blog-post-thumb-3.jpg"),
                new Article(4,"مقاله4","این چهارمین مقاله است.","blog-post-thumb-4.jpg"),

            };
            return View("_LatestArticles", articles);

        }
    }
}
