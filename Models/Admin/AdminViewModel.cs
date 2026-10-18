namespace BTLltWNC.Models.Admin;

/// <summary>Thẻ thống kê đầu trang Quản trị.</summary>
public class StatCard
{
    public string Label { get; set; } = "";
    public string Value { get; set; } = "";
    public string Sub { get; set; } = "";
    public bool CyanSub { get; set; }
    public string Icon { get; set; } = "";
}

/// <summary>Một dòng trong ma trận đặc quyền.</summary>
public class MatrixRow
{
    public string Module { get; set; } = "";
    public string Description { get; set; } = "";
    public string Admin { get; set; } = "";
    public string Leader { get; set; } = "";
    public string Member { get; set; } = "";
    public bool AdminOn { get; set; } = true;
    public bool LeaderOn { get; set; } = true;
    public bool MemberOn { get; set; } = true;
}

/// <summary>Một dòng trong danh sách nhân sự.</summary>
public class MemberRow
{
    public string Name { get; set; } = "";
    public string Position { get; set; } = "";
    public string Email { get; set; } = "";
    public string Role { get; set; } = "";
    /// <summary>admin / leader / member — dùng để chọn màu badge.</summary>
    public string RoleType { get; set; } = "member";
    public string Status { get; set; } = "";
    public bool Locked { get; set; }
    public string Avatar { get; set; } = "";
    public string AvatarColor { get; set; } = "blue";
}

/// <summary>Dữ liệu trang Quản trị & Phân quyền.</summary>
public class AdminViewModel
{
    public List<StatCard> Stats { get; set; } = new();
    public List<MatrixRow> Matrix { get; set; } = new();
    public List<MemberRow> Members { get; set; } = new();
}
