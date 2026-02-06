using Microsoft.AspNetCore.Mvc;

namespace SV22T1020073.Admin.Controllers
{
    public class AccountController : Controller
    {
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string email, string password)
        {
            // Kiểm tra thông tin đăng nhập (giả lập)s
            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
            {
                ModelState.AddModelError("", "Vui lòng nhập email và mật khẩu.");
                return View();
            }

            // Chuyển hướng về trang chủ mà không cần xử lý đăng nhập thật sự
            return RedirectToAction("Index", "Home");
        }

        public IActionResult Logout()
        {
            // Chuyển hướng về trang Login
            return RedirectToAction("Login");
        }

        public IActionResult ChangePassword()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ChangePassword(string oldPassword, string newPassword, string confirmPassword)
        {
            // Kiểm tra và đổi mật khẩu (giả lập)
            if (newPassword != confirmPassword)
            {
                ModelState.AddModelError("", "Mật khẩu xác nhận không trùng khớp.");
                return View();
            }
            
            // Xử lý đổi mật khẩu thành công...
            return RedirectToAction("Index", "Home");
        }
    }
}
