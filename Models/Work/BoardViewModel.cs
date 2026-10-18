namespace BTLltWNC.Models.Work;

/// <summary>Dữ liệu hiển thị trang Kanban dự án.</summary>
public class BoardViewModel
{
    public string ProjectName { get; set; } = "";
    public List<BoardColumn> Columns { get; set; } = new();
}
