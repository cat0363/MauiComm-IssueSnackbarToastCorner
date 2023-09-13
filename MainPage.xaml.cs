using CommunityToolkit.Maui.Alerts;

namespace MauiComm_IssueSnackbarToastCorner
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        void btnShowSnackbar_Clicked(object sender, EventArgs e)
        {
            Snackbar snackbar = new Snackbar()
            {
                Text = "This is Snackbar corner test message. This is test message. This is test message. This is test message. This is test message.",                
                Action = null,
                Anchor = null,
                ActionButtonText = string.Empty,
                Duration = new TimeSpan(0, 0, 0, 0, 8500),
                VisualOptions = new CommunityToolkit.Maui.Core.SnackbarOptions()
                {
                    BackgroundColor = Colors.Red,
                    TextColor = Colors.White,
                    CornerRadius = new CornerRadius(5),           
                }
            };
            snackbar.Show();
        }

        private void btnShowToast_Clicked(object sender, EventArgs e)
        {
            Toast toast = new Toast()
            {
                Text = "This is toast corner test message. This is test message. This is test message. This is test message. This is test message.",
                TextSize = 15,
                Duration = CommunityToolkit.Maui.Core.ToastDuration.Long
            };
            toast.Show();
        }
    }
}