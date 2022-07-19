using System.Threading.Tasks;
using eTickets.Data;
using eTickets.Data.Static;
using eTickets.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace eTickets.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly AppDbContext _context;
        public AccountController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, AppDbContext context)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _context = context;
        }
        public IActionResult Login()
        {
            return View(new LoginVM());
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginVM loginVm)
        {
            if (!(ModelState.IsValid))
                return View(loginVm);
            var user = await _userManager.FindByEmailAsync(loginVm.EmailAddress);
            if (user != null)
            {
                var passwordCheck = await _userManager.CheckPasswordAsync(user, loginVm.Password);
                if (passwordCheck)
                {
                    var result = await _signInManager.PasswordSignInAsync(user, loginVm.Password, false, false);
                    if (result.Succeeded)
                    {
                        return RedirectToAction("Index", "Movies");
                    }
                }
                TempData["Error"] = "Wrong credentials. Please, try again";
                return View(loginVm);
            }
            TempData["Error"] = "Wrong credentials. Please, try again";
            return View(loginVm);
        }
        
        public IActionResult Register()
        {
            return View(new RegisterVM());
        }
        [HttpPost]
        public async Task<IActionResult> Register(RegisterVM registerVm)
        {
            if (!(ModelState.IsValid))
                return View(registerVm);
            var user = await _userManager.FindByEmailAsync(registerVm.EmailAddress);
            if (user != null)
            {
                
                TempData["Error"] = "this email address is already in use";
                return View(registerVm);
            }

            var newUser = new ApplicationUser()
            {
                FullName = registerVm.FullName,
                Email = registerVm.EmailAddress,
                UserName = registerVm.EmailAddress,
            };
            var newUserResponse = await _userManager.CreateAsync(newUser, registerVm.Password);
            if (newUserResponse.Succeeded)
                await _userManager.AddToRoleAsync(newUser, UserRoles.User);
            return View("RegisterComplete");
        }
    }
}