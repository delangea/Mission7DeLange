using Microsoft.AspNetCore.Mvc;
using Mission7DeLange.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission7DeLange.Components
{
    public class CategoryViewComponent : ViewComponent
    {
        private IBookRepository repo { get; set; }
        public CategoryViewComponent(IBookRepository temp)
        {
            repo = temp;
        }
        public IViewComponentResult Invoke()
        {
            ViewBag.SelectedType = RouteData?.Values["bookCategory"];
            var types = repo.Books.Select(x => x.Category).Distinct().OrderBy(x => x);
            return View(types);
        }
    }
}
