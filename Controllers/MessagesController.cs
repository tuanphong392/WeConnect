using BTLltWNC.Models.Chat;
using Microsoft.AspNetCore.Mvc;

namespace BTLltWNC.Controllers;

public class MessagesController : Controller
{
    public IActionResult Index()
    {
        var model = new ChatViewModel
        {
            Conversations = new List<Conversation>
            {
                new Conversation { Id = "na", Avatar = "NA", Name = "Nguyễn Văn An", LastMessage = "Đã cập nhật xong API đăng nhập...", Time = "10:42", Unread = 0, Online = true },
                new Conversation { Id = "wcn", Avatar = "WC", Name = "WCN Console Core", LastMessage = "Cập nhật lịch họp sprint", Time = "09:15", Unread = 3, Online = false, Group = true },
                new Conversation { Id = "lp", Avatar = "LP", Name = "Linh Phương", LastMessage = "Em xem lại file thiết kế giúp chị nhé", Time = "Hôm qua", Unread = 0, Online = false },
                new Conversation { Id = "hn", Avatar = "HN", Name = "Phạm Hoàng Nam", LastMessage = "OK để mình kiểm tra lại", Time = "2 ngày trước", Unread = 0, Online = false },
                new Conversation { Id = "bgd", Avatar = "BG", Name = "Ban Giám Đốc", LastMessage = "Duyệt ngân sách quý 4", Time = "3 ngày trước", Unread = 0, Online = false, Group = true },
                new Conversation { Id = "dp", Avatar = "ĐV", Name = "Đặng Tuấn Phong", LastMessage = "Đã xong phần backend", Time = "4 ngày trước", Unread = 0, Online = false }
            }
        };
        return View(model);
    }
}
