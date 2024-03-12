using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;

namespace ChatApp.ViewModels
{
    public partial class MessagesViewModel : ObservableObject
    {
        [ObservableProperty]
        private ObservableCollection<Message> messages;

        public MessagesViewModel()
        {
            Messages = new ObservableCollection<Message>()
            {
                new Message {ProfileImageUrl="venom3.jpg", Name = "Jane Doe", Text = "Hi there!", MessageTime = DateTime.Now.AddMinutes(-15) },
                new Message {ProfileImageUrl="venom3.jpg", Name = "John Smith", Text = "How are you?", MessageTime = DateTime.Now.AddMinutes(-10) }
            };
        }
    }
}

