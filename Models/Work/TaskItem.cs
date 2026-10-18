namespace BTLltWNC.Models.Work;

/// <summary>Một card task trên bảng Kanban (dữ liệu mẫu).</summary>
public class TaskItem
{
    public string Code { get; set; } = "";
    public string Title { get; set; } = "";
    /// <summary>none / low / medium / high / urgent</summary>
    public string Priority { get; set; } = "none";
    /// <summary>Chữ trên avatar tròn nhỏ; rỗng -> hiển thị dấu "?".</summary>
    public string Avatar { get; set; } = "";
    /// <summary>true -> avatar nền vàng-cam (như "Q"); false -> nền xám.</summary>
    public bool AvatarWarn { get; set; }
}
