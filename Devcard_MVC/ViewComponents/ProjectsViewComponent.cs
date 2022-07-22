using Devcard_MVC.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Devcard_MVC.ViewComponents
{
    public class ProjectsViewComponent:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var projects = new List<Project>
            {
                new Project(1,"تاکسی","درخواست تاکسی","project-1.jpg","Atriya"),
                new Project(2,"فست فود","درخواست غذای فوری","project-2.jpg","FastFood"),
                new Project(3,"مدارس"," سستم مدیریت مدارس","project-3.jpg","Monop"),
                new Project(4,"فضاپیما","  سیستم مدیریت فضاپیما","project-4.jpg","Nasa"),
            };
            return View("_Projects", projects);
        }
    }
}
