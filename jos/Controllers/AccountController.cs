using jos.Models;
using Microsoft.AspNetCore.Mvc;

namespace jos.Controllers
{
    public class AccountController : Controller
    {
        // GET: /Account/Login
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(UserModel model)
        {
            if (model is null)
            {
                throw new ArgumentNullException(nameof(model));
            }

            if (IsValidUser(model.Username, model.Password))
            {
                // Authentication successful, redirect to dashboard or any other page
                return RedirectToAction("Index", "Home");
            }
            else
            {
                // Authentication failed, show error message
                ModelState.AddModelError("", "Invalid username or password");
                return View();
            }
        }

        // GET: /Account/Register
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(UserModel model)
        {
            // Save user to database or any other data store
            // Redirect to login page or any other page after successful registration
            return RedirectToAction("Login");
        }

        private bool IsValidUser(string username, string password)
        {
            // Check username and password against your database or any other data store
            // Return true if valid, false otherwise
            // This is a placeholder method, you should implement your own logic here
            // For simplicity, assume username and password validation here
            return username == "admin" && password == "admin";
        }
        public class UserController : Controller
{
    // GET: /User/Register
    public ActionResult Register()
    {
        return View();
    }

    // POST: /User/Register
    [HttpPost]
    [ValidateAntiForgeryToken]
    public ActionResult Register(UserReg model)
    {
                if (model is null)
                {
                    throw new ArgumentNullException(nameof(model));
                }

                if (ModelState.IsValid)
        {
            // Your registration logic here
            // For example, save the user details to the database
            return RedirectToAction("Index", "Home"); // Redirect to the homepage after successful registration
        }

        // If we got this far, something failed, redisplay form
        return View(model);
    }
    public class AdminController : Controller
{
    // GET: /Admin/RegisterAdmin
    public ActionResult RegisterAdmin()
    {
        return View();
    }

    // POST: /Admin/RegisterAdmin
    [HttpPost]
    [ValidateAntiForgeryToken]
    public ActionResult RegisterAdmin(AdminReg model)
    {
                    if (model is null)
                    {
                        throw new ArgumentNullException(nameof(model));
                    }

                    if (ModelState.IsValid)
        {
            // Your registration logic here
            // For example, save the admin details to the database
            return RedirectToAction("Index", "Home"); // Redirect to the homepage after successful registration
        }

        // If we got this far, something failed, redisplay form
        return View(model);
    }
}

}

    }
}