using BTLltWNC.Models.Work;
using Microsoft.AspNetCore.Mvc;

namespace BTLltWNC.Controllers;

public class WorkController : Controller
{
    // Danh sách dự án (Công việc)
    public IActionResult Index()
    {
        var model = new List<ProjectItem>
        {
            new ProjectItem { Key = "vbot-mobile", Title = "vbot-mobile", Progress = 81, DueDate = "No due date", Status = "In progress" },
            new ProjectItem { Key = "vbot-console", Title = "vbot-console", Progress = 56, DueDate = "No due date", Status = "In progress" },
            new ProjectItem { Key = "cpaas", Title = "cpaas", Progress = 91, DueDate = "Jun 9, 2026", Status = "In progress" }
        };
        return View(model);
    }

    // Bảng Kanban của một dự án
    public IActionResult Board(string projectName)
    {
        if (string.IsNullOrWhiteSpace(projectName))
            projectName = "vbot-mobile";

        var model = new BoardViewModel
        {
            ProjectName = projectName,
            Columns = new List<BoardColumn>
            {
                new BoardColumn
                {
                    Name = "To Do", Icon = "○", TotalCount = 4,
                    Tasks = new List<TaskItem>
                    {
                        new TaskItem { Code = "Vbw-12", Title = "khi sap xep theo ngay den han thi ko kéo đc task nữa" },
                        new TaskItem { Code = "Vbw-22", Title = "Lưu trữ", Avatar = "Q", AvatarWarn = true },
                        new TaskItem { Code = "Vbw-39", Title = "Lỗi đo app cần xác minh" },
                        new TaskItem { Code = "Vbw-42", Title = "khi sửa lại tiêu đề nhiệm vụ update quá nhanh" }
                    }
                },
                new BoardColumn
                {
                    Name = "In Progress", Icon = "◔", TotalCount = 0,
                    Tasks = new List<TaskItem>()
                },
                new BoardColumn
                {
                    Name = "In Review", Icon = "🔍", TotalCount = 2,
                    Tasks = new List<TaskItem>
                    {
                        new TaskItem { Code = "Vbw-37", Title = "Admin cua project nhung khong co quyen add member", Avatar = "Q", AvatarWarn = true },
                        new TaskItem { Code = "Vbw-18", Title = "Xoa task nhung khong mat task", Avatar = "Q", AvatarWarn = true }
                    }
                },
                new BoardColumn
                {
                    Name = "Done", Icon = "✓", TotalCount = 11, Scrollable = true,
                    Tasks = new List<TaskItem>
                    {
                        new TaskItem { Code = "Vbw-4", Title = "Nhãn bị che khi text dài" },
                        new TaskItem { Code = "Vbw-24", Title = "Không xem đc ành ở bình luận", Avatar = "Q", AvatarWarn = true },
                        new TaskItem { Code = "Vbw-17", Title = "Lỗi giao diện", Avatar = "Q", AvatarWarn = true },
                        new TaskItem { Code = "Vbw-13", Title = "test" },
                        new TaskItem { Code = "Vbw-10", Title = "co nut phong to nhung ko co nut thu nhỏ" },
                        new TaskItem { Code = "Vbw-44", Title = "Lỗi không xoá được Task phụ", Priority = "high" }
                    }
                }
            }
        };
        return View(model);
    }

    // Chi tiết task (dữ liệu mẫu)
    public IActionResult TaskDetail(string id, string projectName)
    {
        var model = new TaskDetailViewModel
        {
            ProjectName = string.IsNullOrWhiteSpace(projectName) ? "vbot-mobile" : projectName,
            Code = string.IsNullOrWhiteSpace(id) ? "Vbw-12" : id,
            Title = "khi sap xep theo ngay den han thi ko kéo đc task nữa",
            Status = "To Do",
            Priority = "Không ưu tiên",
            Assignee = "Nguyễn Văn An",
            DueDate = "No due date",
            Labels = new List<string> { "API BCCS", "Công việc" },
            Description = "Khi sắp xếp cột theo ngày đến hạn, thao tác kéo thả task không còn hoạt động. Cần kiểm tra lại logic sắp xếp và sự kiện drag & drop.",
            Comments = new List<Comment>
            {
                new Comment { Author = "Nguyễn Văn An", Avatar = "NA", Time = "10:42", Text = "Mình đã tái hiện được lỗi trên môi trường staging, sẽ fix trong sprint này." },
                new Comment { Author = "Đặng Tuấn Phong", Avatar = "ĐV", Time = "11:05", Text = "Cần ưu tiên vì ảnh hưởng trực tiếp tới luồng làm việc của cả team." }
            },
            Attachments = new List<string> { "spec_weconnect_v2.pdf – 2.4 MB", "screenshot-loi-keo-tha.png" },
            Followers = new List<string> { "Nguyễn Văn An", "Đặng Tuấn Phong" }
        };
        return View(model);
    }
}
