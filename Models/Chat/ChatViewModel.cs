namespace BTLltWNC.Models.Chat;

/// <summary>Một hội thoại trong danh sách bên trái trang Messages.</summary>
public class Conversation
{
    public string Id { get; set; } = "";
    public string Avatar { get; set; } = "";
    public string Name { get; set; } = "";
    public string LastMessage { get; set; } = "";
    public string Time { get; set; } = "";
    public int Unread { get; set; }
    public bool Online { get; set; }
    public bool Group { get; set; }
}

/// <summary>Dữ liệu trang Messages (danh sách hội thoại).</summary>
public class ChatViewModel
{
    public List<Conversation> Conversations { get; set; } = new();
}
