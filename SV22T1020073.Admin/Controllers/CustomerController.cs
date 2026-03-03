using Microsoft.AspNetCore.Mvc;

namespace SV22T1020073.Admin.Controllers
{
    public class CustomerController : Controller
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
        public IActionResult Create(string customerName, string contactName, string phone, string email, string address, string province, string password, bool isLocked)
        {
            // Xử lý thêm mới khách hàng
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            return View();
        }

        [HttpPost]
        public IActionResult Edit(int id, string customerName, string contactName, string phone, string email, string address, string province, bool isLocked)
        {
            // Xử lý cập nhật khách hàng
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
            // Xử lý xóa khách hàng
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
    }
}
