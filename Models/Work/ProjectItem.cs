namespace BTLltWNC.Models.Work;

/// <summary>Dòng dự án trong bảng danh sách Công việc.</summary>
public class ProjectItem
{
    public string Title { get; set; } = "";
    public int Progress { get; set; }
    public string DueDate { get; set; } = "";
    public string Status { get; set; } = "";
    public string Key { get; set; } = "";
}
