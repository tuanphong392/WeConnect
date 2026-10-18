

using BTLltWNC.Models.Admin;
using Microsoft.AspNetCore.Mvc;

namespace BTLltWNC.Controllers;

public class AdminController : Controller
{
    public IActionResult Index()
    {
        var model = new AdminViewModel
        {
            Stats = new List<StatCard>
            {
                new StatCard { Label = "VAI TRÒ ĐANG KÍCH HOẠT", Value = "3 Cấp bậc", Sub = "Admin · Leader · Member", CyanSub = true, Icon = "◆" },
                new StatCard { Label = "TỔNG NHÂN SỰ PHÂN BỔ", Value = "148 tài khoản", Sub = "142 hoạt động / 6 khóa", Icon = "◈" },
                new StatCard { Label = "CHÍNH SÁCH HẠN CHẾ", Value = "Bật mặc định", Sub = "Zero-Trust Workspaces", CyanSub = true, Icon = "▲" },
                new StatCard { Label = "PHIÊN XÁC THỰC", Value = "Cluster EU-01", Sub = "Đồng bộ tức thời (0.4ms)", Icon = "◎" }
            },
            Matrix = new List<MatrixRow>
            {
                new MatrixRow { Module = "Công việc & Tác vụ", Description = "Tạo, phân bổ, chỉnh sửa deadline và workflow sprint", Admin = "Toàn quyền (CRUD)", Leader = "Phân công & Duyệt task", Member = "Tạo & Nhận việc cá nhân" },
                new MatrixRow { Module = "Không gian nhóm (Workspaces)", Description = "Tạo mới dự án, lưu trữ tài liệu kho, thiết lập kênh", Admin = "Tạo / Xóa / Lưu trữ", Leader = "Quản trị nhóm được gán", Member = "Chỉ xem & Đóng góp", MemberOn = false },
                new MatrixRow { Module = "Tin nhắn & Thảo luận", Description = "Kênh hội thoại trực tiếp, ghim thông báo, đính kèm file", Admin = "Toàn quyền kênh chung", Leader = "Kiểm duyệt & Ghim bài", Member = "Trao đổi nội bộ" },
                new MatrixRow { Module = "Quản trị người dùng & Phân vai", Description = "Mời nhân sự, cấp vai trò, khóa tài khoản tạm thời", Admin = "Phê duyệt & Cấp quyền", Leader = "Mời vào nhóm dự án", Member = "Không được phép", MemberOn = false },
                new MatrixRow { Module = "Báo cáo & Cấu hình hệ thống", Description = "Xem nhật ký audit, tích hợp webhook, backup dữ liệu", Admin = "Toàn quyền hệ thống", Leader = "Chỉ báo cáo sprint", Member = "Không được phép", LeaderOn = false, MemberOn = false }
            },
            Members = new List<MemberRow>
            {
                new MemberRow { Name = "Nguyễn Tuấn Anh", Position = "Ban Giám Đốc Kỹ Thuật", Email = "tuananh.nguyen@weconnect.vn", Role = "Admin", RoleType = "admin", Status = "Đang hoạt động", Avatar = "NA", AvatarColor = "blue" },
                new MemberRow { Name = "Trần Hoàng Long", Position = "Trưởng nhóm Core Backend", Email = "long.tran@weconnect.vn", Role = "Leader", RoleType = "leader", Status = "Đang hoạt động", Avatar = "TH", AvatarColor = "violet" },
                new MemberRow { Name = "Lê Thảo My", Position = "Trưởng nhóm Product Design", Email = "my.le@weconnect.vn", Role = "Leader", RoleType = "leader", Status = "Đang hoạt động", Avatar = "LM", AvatarColor = "pink" },
                new MemberRow { Name = "Phạm Gia Huy", Position = "Frontend Software Engineer", Email = "huy.pham@weconnect.vn", Role = "Member", RoleType = "member", Status = "Đang hoạt động", Avatar = "PH", AvatarColor = "green" },
                new MemberRow { Name = "Đỗ Văn Hải", Position = "Cộng tác viên QA / Tester", Email = "hai.do@weconnect.vn", Role = "Member", RoleType = "member", Status = "Đã tạm khóa", Locked = true, Avatar = "ĐV", AvatarColor = "cyan" }
            }
        };
        return View(model);
    }
}
