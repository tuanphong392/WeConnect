using Microsoft.AspNetCore.Mvc;

namespace BTLltWNC.Controllers;

public class HomeController : Controller
{
    // Trang lỗi chung
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View();
    }

    // Trang 404 (được gọi bởi MapFallbackToController)
    public IActionResult NotFoundPage()
    {
        Response.StatusCode = 404;
        return View("NotFound");
    }
}
