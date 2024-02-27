using Entity.Concreate;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace E_Hosting.Controllers
{
    public class RegisterController : Controller
    {

        private UserManager<User> _userManager;
        public RegisterController(UserManager<User> userManager)
        {
            _userManager = userManager;
        }
        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> UserKayıt(RegisterViewKayıt registerViewKayıt)
        {
            User user = new User
            {
                UserName = registerViewKayıt.UserName,
                Surname = registerViewKayıt.Surname,
                PhoneNumber = registerViewKayıt.PhoneNumber,
                Email = registerViewKayıt.Mail,
                Name = registerViewKayıt.Name
            };
            var result = await _userManager.CreateAsync(user, registerViewKayıt.Password);
            await _userManager.AddToRoleAsync(user, "User");
            if (result.Succeeded)
            {

            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError("", errorMessage: item.Description);
                }
            }
            return RedirectToAction("Index", "Home");

        }
    }
}
