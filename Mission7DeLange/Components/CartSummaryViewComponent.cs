using Microsoft.AspNetCore.Mvc;
using Mission7DeLange.Models;
namespace Mission7DeLange.Components
{
    public class CartSummaryViewComponent : ViewComponent
    {
        //used to create the cart qty and total in the navbar 
        private Cart cart;
        public CartSummaryViewComponent(Cart cartService)
        {
            cart = cartService;
        }
        public IViewComponentResult Invoke()
        {
            return View(cart);
        }
    }
}
