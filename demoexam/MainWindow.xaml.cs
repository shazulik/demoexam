using demoexam.Pages;
using System.Windows;
using System.Windows.Navigation;

namespace demoexam
{

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            frameMain.Content = new LoginPage();
            frameMain.LoadCompleted += FrameMain_LoadCompleated;
        }

        private void FrameMain_LoadCompleated(object sender, NavigationEventArgs e)
        {
            if (!frameMain.CanGoBack)
            {
                btnBack.Content = "Показать товары";
                userDataBlock.Text = "";
                userDataBlock.Visibility = Visibility.Collapsed;
            }
          
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            if (frameMain.CanGoBack)
                frameMain.GoBack();
            else if (!frameMain.CanGoBack && App.currentUser != null) ;

            else
                frameMain.Navigate(new ProductPage());
        }
    }
}
