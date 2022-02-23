﻿using Microsoft.AspNetCore.Mvc;
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
        public IActionResult Index(string bookCategory, int pageNum = 1)
        {
            int pageSize = 10;
            var thing = new BooksViewModel
            {
                //grab list of all books ordered by title
                //skip based on page youre currently on, take based amount desired on page
                Books = repo.Books
                .Where(b => b.Category == bookCategory || bookCategory == null)
                .OrderBy(x => x.Title)
                .Skip((pageNum -1) * pageSize)
                .Take(pageSize),
                //load page info
                PageInfo = new PageInfo
                {
                    //make it so that it works based on filters when a category is selected 
                    TotalNumBooks = (bookCategory == null ? repo.Books.Count() : repo.Books.Where(b => b.Category == bookCategory).Count()),
                    BooksPerPage = pageSize,
                    CurrentPage = pageNum
                }
            };
            return View(thing);
        }

    }
}
