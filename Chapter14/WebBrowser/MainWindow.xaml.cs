using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WebBrowser;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void BackButton_Click(object sender, RoutedEventArgs e) {
        if (WebView.CanGoBack) {
            WebView.GoBack();
        } else {
            back.IsEnabled = false;
        }   
    }

    private void FowardButton_Click(object sender, RoutedEventArgs e) {
        if (WebView.CanGoForward) {
            WebView.GoForward();
        } else {
            forward.IsEnabled = false;
        }
        
    }

    private void moveButton_Click(object sender, RoutedEventArgs e) {
        if (AddressBar.Text == "") return;
        try {
            var url = AddressBar.Text;
            WebView.Source = new Uri(url);
        }
        catch (Exception ex) {
            Console.WriteLine(ex.Message);
            throw;
        }
        
    }
}