using Daewoo_Web_Application.Models;
using Daewoo_Web_Application.Models.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Daewoo_Web_Application.Controllers
{
    public class LoginController : Controller
    {
        private readonly IUserRepo _repo;
        private readonly IWebHostEnvironment Environment;
        public LoginController(IUserRepo repo, IWebHostEnvironment environment)
        {
            _repo = repo;
            Environment = environment;
        }
        [HttpGet]
        public ViewResult SignIn()
        {
            return View();
        }
        [HttpPost]
        public ActionResult SignIn(User user)
        {
            if (user.Email == null || user.Password == null)
                return View();

            bool flag = _repo.Check_Credentials(user);
            if (flag)
            {
                return RedirectToAction("Home", "Home");
            }
            else
            {
                if (flag == false)
                    ModelState.AddModelError(string.Empty, "🛈 Unauthenticated User.");
                return View();
            }
        }


        [HttpGet]
        public ViewResult SignUp()
        {
            return View();
        }
        [HttpPost]
        public ViewResult SignUp(IFormFile PostImage, User user)
        {
            //Image Saving
            if (PostImage.FileName.Length > 0)
            {
                //get last user's ID
                List<User> users = new List<User>();
                users = _repo.GetUsers();
                int lastUserID = 0;
                if (users.Count > 0)
                    lastUserID = users[users.Count - 1].ID;

               //make Uploads directory
                string wwwPath = this.Environment.WebRootPath;
                string path = Path.Combine(wwwPath, "Uploads");
                if (!Directory.Exists(path))
                    Directory.CreateDirectory(path);


                var fileExtension = Path.GetExtension(PostImage.FileName);
                var fileName = ($"{lastUserID + 1 }" + fileExtension).ToString();
                var pathWithFileName = Path.Combine(path, fileName);
                using (FileStream stream = new FileStream(pathWithFileName, FileMode.Create))
                {
                    PostImage.CopyTo(stream);
                }
                user.ProfilePicture = $"\\Uploads\\{fileName}";
            }

            if (ModelState.IsValid)
            {
                int flag = _repo.AddUser(user);
                if (flag == 0)
                {
                    ModelState.AddModelError(string.Empty, "🛈 An account with same email already exits!");
                    return View();
                }
                else if (flag == -1)
                {
                    ModelState.AddModelError(string.Empty, "🛈 An account with same phone number already exits!");
                    return View();
                }
                else
                    return View("SignIn");
            }
            else
                return View();
        }
    }
}
