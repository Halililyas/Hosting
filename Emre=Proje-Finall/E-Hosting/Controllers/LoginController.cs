using Entity.Concreate;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace E_Hosting.Controllers
{
    public class LoginController : Controller
    {

        private UserManager<User> _userManager;
        private SignInManager<User> _signManager;

        public LoginController(UserManager<User> userManager, SignInManager<User> signInManager)
        {
            _userManager = userManager;
            _signManager = signInManager;

        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(UserKontrol p)
        {
            try
            {
                var user = await _userManager.FindByNameAsync(p.username);

                var sing = await _signManager.PasswordSignInAsync(user, p.password, false, false);
                return RedirectToAction("Index", "Home");
            }
            catch
            {

                return RedirectToAction("Index", "Login");
            }

        }
        public async Task<IActionResult> Logout()
        {
            await _signManager.SignOutAsync();
            //Çıkış yapıldığında kullanıcıya ait olan çerezler temizlenir.
            return RedirectToAction("Index", "Home");
        }
    }
}
