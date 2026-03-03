using Microsoft.AspNetCore.Mvc;

namespace SV22T1020073.Admin.Controllers
{
    public class SupplierController : Controller
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
        public IActionResult Create(string supplierName, string contactName, string province, string address, string phone, string email)
        {
            // Xử lý thêm mới nhà cung cấp
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            return View();
        }

        [HttpPost]
        public IActionResult Edit(int id, string supplierName, string contactName, string province, string address, string phone, string email)
        {
            // Xử lý cập nhật nhà cung cấp
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
            // Xử lý xóa nhà cung cấp
            return RedirectToAction("Index");
        }
    }
}
