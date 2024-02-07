using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Online_Food_Ordering_System.Models;
using Online_Food_Ordering_System.View_Models;

namespace Online_Food_Ordering_System.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<User> userManager;
        private readonly SignInManager<User> signInMAnager;

        public AccountController(UserManager<User> _UserManager, SignInManager<User> _SignInMAnager)
        {
            userManager = _UserManager;
            signInMAnager = _SignInMAnager;
        }


        [HttpGet]
        public IActionResult Login()
        {
            return PartialView();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginViewModel UserVm)
        {
            if (ModelState.IsValid)
            {
                //check
                User userModel = await userManager.FindByEmailAsync(UserVm.Email);
                if (userModel != null)
                {
                    bool found = await userManager.CheckPasswordAsync(userModel, UserVm.Password);
                    if (found)
                    {
                        await signInMAnager.SignInAsync(userModel, true);
                        return RedirectToAction("index", "Home");
                    }
                }
                ModelState.AddModelError("", "Username and password invalid");
            }
            return PartialView(UserVm);
        }


        [HttpGet]
        public IActionResult Register()
        {
            return PartialView();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterUserViewModel newUserVM)
        {
            if (!ModelState.IsValid)
            {
                return PartialView(newUserVM);
            }


            //create account
            User userModel = new User()
            {
                DisplayName = newUserVM.Name,
                Email = newUserVM.Email,
                PasswordHash = newUserVM.Password,
                Address = newUserVM.Address
            };

            IdentityResult result = await userManager.CreateAsync(userModel, newUserVM.Password);


            if (result.Succeeded == true)
            {
                // create cookie
                await signInMAnager.SignInAsync(userModel, false);
                return RedirectToAction("Index", "Home");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError("", item.Description);
                }
                return PartialView(newUserVM);
            }
        }

        [HttpGet]
        public async Task<IActionResult> Logout()
        {
            await signInMAnager.SignOutAsync();
            return RedirectToAction("Login", "Account");
        }
    }

}
