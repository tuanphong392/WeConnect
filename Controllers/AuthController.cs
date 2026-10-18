using Microsoft.AspNetCore.Mvc;

namespace BTLltWNC.Controllers;

public class AuthController : Controller
{
    [HttpGet]
    public IActionResult Login() => View();

    // Giai đoạn 1: không kiểm tra gì, chỉ chuyển sang Công việc
    [HttpPost]
    public IActionResult Login(string email, string password)
        => RedirectToAction("Index", "Work");

    [HttpGet]
    public IActionResult Register() => View();

    // Giai đoạn 1: không tạo tài khoản thật, chỉ chuyển sang Công việc
    [HttpPost]
    public IActionResult Register(string fullName, string email, string password)
        => RedirectToAction("Index", "Work");

    [HttpGet]
    public IActionResult ForgotPassword() => View();

    // Giai đoạn 1: chỉ quay lại Đăng nhập sau khi nhấn gửi
    [HttpPost]
    public IActionResult ForgotPassword(string email)
        => RedirectToAction("Login");
}
