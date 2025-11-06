using Microsoft.Web.WebView2.Core;
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
        InitializeAsync();
        back.IsEnabled = false;
        forward.IsEnabled = false;
    }

    private async void InitializeAsync() {
        await WebView.EnsureCoreWebView2Async();

        WebView.CoreWebView2.NavigationStarting += CoreWebView2_NavigationStarting;
        WebView.CoreWebView2.NavigationCompleted += CoreWebView2_NavigationCompleted;

    }

    private void CoreWebView2_NavigationCompleted(object? sender, CoreWebView2NavigationCompletedEventArgs e) {
        
    }

    private void CoreWebView2_NavigationStarting(object? sender, CoreWebView2NavigationStartingEventArgs e) {
        LoadingBar.Visibility = Visibility.Visible;
        LoadingBar.IsIndeterminate = true;
    }

    private void BackButton_Click(object sender, RoutedEventArgs e) {
        WebView.GoBack();
        //if (WebView.CanGoBack) {
        //    back.IsEnabled = true;
        //} else {
        //    back.IsEnabled = false;
        //}   
        back.IsEnabled = WebView.CanGoBack;
    }

    private void FowardButton_Click(object sender, RoutedEventArgs e) {
        WebView.GoForward();
        if (WebView.CanGoBack) {
            forward.IsEnabled = true;
        } else {
            forward.IsEnabled = false;
        }

    }

    private void moveButton_Click(object sender, RoutedEventArgs e) {
        var url = AddressBar.Text;
        if (AddressBar.Text == "") return;
        if (string.IsNullOrWhiteSpace(url)) return;
        try {
            
            WebView.Source = new Uri(url);
        }
        catch (Exception ex) {
            Console.WriteLine(ex.Message);
            throw;
        }
        
    }

    private void WebView_SourceChanged(object sender, Microsoft.Web.WebView2.Core.CoreWebView2SourceChangedEventArgs e) {
        back.IsEnabled = WebView.CanGoBack;
        forward.IsEnabled = WebView.CanGoForward;

    }
}