public class Message
{
    public string ProfileImageUrl { get; set; }
    public string Name { get; set; }
    public string Text { get; set; }
    public DateTime MessageTime { get; set; }

    public Message()
    {
        ProfileImageUrl = string.Empty;
        Name = string.Empty;
        Text = string.Empty;
        MessageTime = DateTime.Now;
    }
}
