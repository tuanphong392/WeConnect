namespace BTLltWNC.Models.Account;

/// <summary>Dữ liệu mẫu cho trang Hồ sơ cá nhân (giai đoạn 1: viết cứng).</summary>
public class ProfileViewModel
{
    public string EmployeeCode { get; set; } = "NV-0012";
    public string Role { get; set; } = "Member";
    public string RoleLabel { get; set; } = "Member (Thành viên)";
    public string FullName { get; set; } = "Phạm Gia Huy";
    public string Email { get; set; } = "huy.pham@weconnect.vn";
    public string Phone { get; set; } = "0901 234 567";
    public string Department { get; set; } = "Product Design";
    public string JobTitle { get; set; } = "Frontend Software Engineer";
    public string Bio { get; set; } = "Frontend developer tập trung vào trải nghiệm người dùng và hệ thống thiết kế.";
    public string AvatarText { get; set; } = "PH";
    public string Status { get; set; } = "Đang hoạt động";
}
