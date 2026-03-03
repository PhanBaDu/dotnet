using Microsoft.AspNetCore.Mvc;

namespace SV22T1020073.Admin.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Detail(int id)
        {
            return View();
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(string productName, string productDescription, int? supplierID, int? categoryID, string unit, decimal price, bool isSelling)
        {
            // Xử lý thêm mới sản phẩm
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            return View();
        }

        [HttpPost]
        public IActionResult Edit(int id, string productName, string productDescription, int? supplierID, int? categoryID, string unit, decimal price, bool isSelling)
        {
            // Xử lý cập nhật sản phẩm
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
            // Xử lý xóa sản phẩm
            return RedirectToAction("Index");
        }

        // Attributes
        [HttpGet]
        public IActionResult ListAttributes(int id)
        {
            return View();
        }

        [HttpGet]
        public IActionResult CreateAttribute(int id)
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateAttribute(int id, string attributeName, string attributeValue, int displayOrder)
        {
            return RedirectToAction("ListAttributes", new { id });
        }

        [HttpGet]
        public IActionResult EditAttribute(int id, long attributeId)
        {
            return View();
        }

        [HttpPost]
        public IActionResult EditAttribute(int id, long attributeId, string attributeName, string attributeValue, int displayOrder)
        {
            return RedirectToAction("ListAttributes", new { id });
        }

        [HttpGet]
        public IActionResult DeleteAttribute(int id, long attributeId)
        {
            return View();
        }

        [HttpPost]
        public IActionResult DeleteAttribute(int id, long attributeId, string confirm)
        {
            return RedirectToAction("ListAttributes", new { id });
        }

        // Photos
        [HttpGet]
        public IActionResult ListPhoto(int id)
        {
            return View();
        }

        [HttpGet]
        public IActionResult CreatePhoto(int id)
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreatePhoto(int id, string photo, string description, int displayOrder, bool isHidden)
        {
            return RedirectToAction("ListPhoto", new { id });
        }

        [HttpGet]
        public IActionResult EditPhoto(int id, long photoId)
        {
            return View();
        }

        [HttpPost]
        public IActionResult EditPhoto(int id, long photoId, string photo, string description, int displayOrder, bool isHidden)
        {
            return RedirectToAction("ListPhoto", new { id });
        }

        [HttpGet]
        public IActionResult DeletePhoto(int id, long photoId)
        {
            return View();
        }

        [HttpPost]
        public IActionResult DeletePhoto(int id, long photoId, string confirm)
        {
            return RedirectToAction("ListPhoto", new { id });
        }
    }
}
