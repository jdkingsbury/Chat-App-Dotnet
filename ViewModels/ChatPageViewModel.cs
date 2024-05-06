using System.ComponentModel;
using System.Collections.ObjectModel;
using ChatApp.Models;
using CommunityToolkit.Mvvm.ComponentModel;

namespace ChatApp.ViewModels
{
    public partial class ChatPageViewModel : ObservableObject
    {
        [ObservableProperty]
        private string messageText;
    }
}
