namespace BTLltWNC.Models.Work;

/// <summary>Một cột trạng thái trên bảng Kanban.</summary>
public class BoardColumn
{
    public string Name { get; set; } = "";
    /// <summary>Biểu tượng trạng thái (dùng HTML entity/emoji).</summary>
    public string Icon { get; set; } = "";
    /// <summary>Tổng số task trong cột (có thể lớn hơn số card hiển thị).</summary>
    public int TotalCount { get; set; }
    public List<TaskItem> Tasks { get; set; } = new();
    /// <summary>true -> cột có thanh cuộn dọc riêng (cột Done).</summary>
    public bool Scrollable { get; set; }
}
