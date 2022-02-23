using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Mission7DeLange.Infrastructure;
using Mission7DeLange.Models;

namespace Mission7DeLange.Pages
{
    public class CartModel : PageModel
    {
        private IBookRepository repo { get; set; }
        public CartModel(IBookRepository temp)
        {
            repo = temp;
        }
        public Cart Cart { get; set; }
        public string ReturnURL { get; set; }
        public void OnGet(string returnURL)
        {
            ReturnURL = returnURL ?? "/";
            //get cart info from the session
            Cart = HttpContext.Session.GetJson<Cart>("Cart") ?? new Cart();
        }
        public IActionResult OnPost(int bookId, string returnURL)
        {
            Book b = repo.Books.FirstOrDefault(x => x.BookId == bookId);
            //check session variable
            Cart = HttpContext.Session.GetJson<Cart>("Cart") ?? new Cart();
            //add cart
            Cart.AddItem(b, 1);
            //put cart info into session variable
            HttpContext.Session.SetJson("Cart", Cart);
            return RedirectToPage(new { ReturnURL = returnURL });
        }
    }
}
