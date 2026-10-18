namespace BTLltWNC.Models.Work;

/// <summary>Bình luận trong trang chi tiết task.</summary>
public class Comment
{
    public string Author { get; set; } = "";
    public string Avatar { get; set; } = "";
    public string Time { get; set; } = "";
    public string Text { get; set; } = "";
}

/// <summary>Dữ liệu hiển thị trang Chi tiết task.</summary>
public class TaskDetailViewModel
{
    public string ProjectName { get; set; } = "";
    public string Code { get; set; } = "";
    public string Title { get; set; } = "";
    public string Status { get; set; } = "";
    public string Priority { get; set; } = "";
    public string Assignee { get; set; } = "";
    public string DueDate { get; set; } = "";
    public List<string> Labels { get; set; } = new();
    public string Description { get; set; } = "";
    public List<Comment> Comments { get; set; } = new();
    public List<string> Attachments { get; set; } = new();
    public List<string> Followers { get; set; } = new();
}
