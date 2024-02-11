using Castle.Core.Resource;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using NanoXLSX;
using Online_Food_Ordering_System.Models;
using Online_Food_Ordering_System.View_Models;

namespace Online_Food_Ordering_System.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<User> userManager;
        private readonly SignInManager<User> signInMAnager;
        private readonly RoleManager<IdentityRole> roleManager;

        public AccountController(UserManager<User> _UserManager, SignInManager<User> _SignInMAnager , RoleManager<IdentityRole> roleManager)
        {
            userManager = _UserManager;
            signInMAnager = _SignInMAnager;
            this.roleManager = roleManager;
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
                UserName = newUserVM.Email,
                DisplayName = newUserVM.Name,
                Email = newUserVM.Email,
                PasswordHash = newUserVM.Password,
                Address = newUserVM.Address,
                Image = "\\img\\Users\\Elghool3.jpg"
            };

            IdentityResult result = await userManager.CreateAsync(userModel, newUserVM.Password);
            IdentityResult AddToRoleResult = await userManager.AddToRoleAsync(userModel, RoleEnum.CustomerRole);

            if (result.Succeeded == true && AddToRoleResult.Succeeded)
            {
                // create cookie
                await signInMAnager.SignInAsync(userModel, false);
                return RedirectToAction("Index", "Home");
            }
            else
            {
                List<IdentityError> roles = result.Errors.ToList();
                roles.AddRange(AddToRoleResult.Errors);
                
                foreach (var item in roles)
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
        
       
        public async Task<IActionResult> Profile()
        {
            return PartialView();
        }






        //public async Task<IActionResult> AddUsersMockData()
        //{

        //    //IdentityRole role = new IdentityRole() { Name = "customer" }; 
        //    //await roleManager.CreateAsync(role);

        //    Workbook wb = Workbook.Load("C://Users//pc//Desktop//MyProject//archive (7)//Users.xlsx");
        //    Worksheet worksheet = wb.CurrentWorksheet;

        //    for (int i = 1; i <= worksheet.GetCurrentRowNumber(); i++)
        //    {

        //        string _DisplayName = worksheet.GetRow(i)[0].Value.ToString();
        //        string _Email = worksheet.GetRow(i)[1].Value.ToString();
        //        string _PasswordHash = worksheet.GetRow(i)[2].Value.ToString();
        //        string _PhoneNumber = worksheet.GetRow(i)[3].Value.ToString();
        //        string _Address = worksheet.GetRow(i)[4].Value.ToString();
        //        string _Image = worksheet.GetRow(i)[5].Value.ToString();

        //        User userModel = new User()
        //        {
        //            UserName = _Email,
        //            DisplayName = _DisplayName,
        //            Email = _Email,
        //            PasswordHash = _PasswordHash,
        //            Address = _Address,
        //            PhoneNumber = _PhoneNumber,
        //            Image = _Image
        //        };


        //        IdentityResult result = await userManager.CreateAsync(userModel, _PasswordHash);

        //        if (!result.Succeeded)
        //        {
        //            return Content("Faild1.");
        //        }

        //        IdentityResult AddToRoleResult = await userManager.AddToRoleAsync(userModel, RoleEnum.CustomerRole);
        //        if (!AddToRoleResult.Succeeded)
        //        {
        //            return Content("Faild2.");
        //        }

        //    }

        //    return Content("Done.");
        //}


    }

}
