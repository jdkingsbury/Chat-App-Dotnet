using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;

using ChatApp.Models;

namespace ChatApp.ViewModels
{
    public partial class ChatPageViewModel : ObservableObject
    {
        [ObservableProperty]
        private ObservableCollection<Message> messages;

        public ChatPageViewModel()
        {
            Messages = new ObservableCollection<Message>
            {
                new Message { Text = "Hello, how are you?", IsIncoming = true },
                new Message { Text = "I'm fine, thanks! And you?", IsIncoming = false },
                new Message { Text = "I'm doing great, thanks for asking!", IsIncoming = true }
            };
        }
    }
}
