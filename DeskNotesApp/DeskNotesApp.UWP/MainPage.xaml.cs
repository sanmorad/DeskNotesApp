
namespace DeskNotesApp.UWP
{
    public sealed partial class MainPage
    {
        public MainPage()
        {
            this.InitializeComponent();

            LoadApplication(new DeskNotesApp.App());
        }
    }
}
