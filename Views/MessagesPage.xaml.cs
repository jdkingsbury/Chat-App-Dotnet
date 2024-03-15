using ChatApp.ViewModels;

namespace ChatApp
{
    public partial class MessagesPage : ContentPage
    {
        public MessagesPage()
        {
            InitializeComponent();
            BindingContext = new MessagesViewModel();
        }
    }
}
