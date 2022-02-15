using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Mission7DeLange.Models;
using Mission7DeLange.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Mission7DeLange.Controllers
{
    public class HomeController : Controller
    {
        private IBookRepository repo;
        public HomeController(IBookRepository temp)
        {
            repo = temp;
        }
        public IActionResult Index(int pageNum = 1)
        {
            int pageSize = 10;
            var thing = new BooksViewModel
            {
                Books = repo.Books
                .OrderBy(x => x.Title)
                .Skip((pageNum -1) * pageSize)
                .Take(pageSize),
                PageInfo = new PageInfo
                {
                    TotalNumBooks = repo.Books.Count(),
                    BooksPerPage = pageSize,
                    CurrentPage = pageNum
                }
            };
            return View(thing);
        }

    }
}
