using Microsoft.AspNetCore.Mvc;
using SleepSystem.Data;
using SleepSystem.Models;
using SleepSystem.Pages;

namespace SleepSystem.Controllers
{
	public class LoginController : Controller
	{
        private readonly ApplicationDbContext dbContext;

        public LoginController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public IActionResult Index()
		{
			return View();
		}

        public IActionResult Login()
        {
            return View();
        }

        


        [HttpPost]
        public async Task<IActionResult> Login(AddUsercs add_user)
        {

            var user = new User_
            {
                Name = add_user.Name,
                LastName = add_user.LastName,
                Age = add_user.Age,
                Genre = add_user.Genre,
                Occupation = add_user.Occupation,
                Birth = add_user.Birth,
                Mail = add_user.Mail,
                Password = add_user.Password,

            };


            await dbContext.Users.AddAsync(user);
            await dbContext.SaveChangesAsync();

            return View();
        }
    }
}
