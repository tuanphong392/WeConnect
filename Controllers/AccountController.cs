using BTLltWNC.Models.Account;
using Microsoft.AspNetCore.Mvc;

namespace BTLltWNC.Controllers;

public class AccountController : Controller
{
    // Trang Hồ sơ cá nhân (route /Account/Profile)
    [HttpGet]
    public IActionResult Profile()
    {
        var model = new ProfileViewModel();
        return View(model);
    }

    // Giai đoạn 1: "Lưu thay đổi"/"Cập nhật mật khẩu" chưa làm gì, chỉ quay về Công việc
    [HttpPost]
    public IActionResult Profile(ProfileViewModel model)
        => RedirectToAction("Index", "Work");
}
