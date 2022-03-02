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
        public Cart Cart { get; set; }
        public string ReturnURL { get; set; }
        public CartModel(IBookRepository temp, Cart c)
        {
            repo = temp;
            Cart = c;
        }
        public void OnGet(string returnURL)
        {
            //set url to return to
            ReturnURL = returnURL ?? "/";
        }
        public IActionResult OnPost(int bookId, string returnURL)
        {
            //grab book that matches bookid
            Book b = repo.Books.FirstOrDefault(x => x.BookId == bookId);
            //add cart
            Cart.AddItem(b, 1);

            return RedirectToPage(new { ReturnURL = returnURL });
        }
        public IActionResult OnPostRemove(int bookId, string returnUrl)
        {
            //remove item matching book id from cart and go to return url
            Cart.RemoveItem(Cart.Items.First(x => x.Book.BookId == bookId).Book);
            return RedirectToPage(new { ReturnURL = returnUrl });
        }
    }
}
