using Microsoft.AspNetCore.Mvc;

namespace SV22T1020073.Admin.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(string fullName, string birthDate, string email, string phone, string address, string password, string roleNames, bool isWorking)
        {
            // Xử lý thêm mới nhân viên
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            return View();
        }

        [HttpPost]
        public IActionResult Edit(int id, string fullName, string birthDate, string email, string phone, string address, string roleNames, bool isWorking)
        {
            // Xử lý cập nhật nhân viên
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            return View();
        }

        [HttpPost]
        public IActionResult Delete(int id, string confirm)
        {
            // Xử lý xóa nhân viên
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult ChangePassword(int id)
        {
            return View();
        }

        [HttpPost]
        public IActionResult ChangePassword(int id, string newPassword, string confirmPassword)
        {
            // Xử lý đổi mật khẩu
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult ChangeRole(int id)
        {
            return View();
        }

        [HttpPost]
        public IActionResult ChangeRole(int id, string[] roles)
        {
            // Xử lý phân quyền
            return RedirectToAction("Index");
        }
    }
}
