using ChatApp.ViewModels;

namespace ChatApp
{
    public partial class ChatPage : ContentPage
    {
        public ChatPage()
        {
            InitializeComponent();
            BindingContext = new ChatPageViewModel();
        }
    }
}
