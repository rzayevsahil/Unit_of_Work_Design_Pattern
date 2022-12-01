using Microsoft.AspNetCore.Mvc;
using UowDesignPattern.DataAccessLayer.Concrete;
using UowDesignPattern.EntityLayer.Concrete;

namespace UowDesignPattern.PresentationLayer.Controllers
{
    public class DefaultController : Controller
    {
        Context context = new Context();

        [HttpGet]
        public IActionResult Index()
        {
            context.Update(new Customer
            {
                CustomerID = 2,
                Name = "Mehmet Ali",
                Surname = "Kurtulmuş",
                Balance = 10500
            });
            context.SaveChanges();

            context.Update(new Customer
            {
                CustomerID = 3,
                Name = "Ayşenur",
                Surname = "Çuhacı",
                Balance = 11500
            });
            context.SaveChanges();
            return View();
        }
    }
}
