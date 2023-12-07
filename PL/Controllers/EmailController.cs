using Microsoft.AspNetCore.Mvc;

namespace PL.Controllers
{
    public class EmailController : Controller
    {
        public IActionResult SendEmail()
        {
            BL.Email email = new BL.Email();

            bool enviado = email.SendEmail();
            return View();
        }



    }
}
