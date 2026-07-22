using Microsoft.AspNetCore.Mvc;
using PPECheckoutSystem.Models;
using PPECheckoutSystem.Data;

namespace PPECheckoutSystem.Controllers
{
    public class RegistrationController : Controller
    {
        public readonly ApplicationDbContext _context;

        public RegistrationController (ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(User user)
        {
            if (ModelState.IsValid)
            {
                _context.Users.Add(user);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index", "Home");
            }
            return View(user);
        }
    }
}
