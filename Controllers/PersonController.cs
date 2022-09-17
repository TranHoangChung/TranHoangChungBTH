using Microsoft.AspNetCore.Mvc;
using TRANHOANGCHUNGBTH.Models;

namespace TRANHOANGCHUNGBTH.Controllers
{
        public class PersonController : Controller
    {
        //cac action
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(string PersonName, string PsAge, string PsAdd, string PsGender)
        {
            ViewBag.mess = "Họ tên: " + PersonName + " - Tuổi: " + PsAge + " - Địa chỉ: " + PsAdd + " - Giới tính: " + PsGender;
            return View();
        }
    }
}