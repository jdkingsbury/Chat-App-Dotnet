namespace ChatApp.Models
{
    public class Message
    {
        public string ProfileImageUrl { get; set; }
        public string Name { get; set; }
        public string Text { get; set; }
        public DateTime MessageTime { get; set; }
        public bool IsIncoming { get; set; }

        public Message()
        {
            ProfileImageUrl = string.Empty;
            Name = string.Empty;
            Text = string.Empty;
            MessageTime = DateTime.Now;
            IsIncoming = false;
        }
    }
}
