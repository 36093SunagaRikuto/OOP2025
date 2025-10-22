using CustomerApp.Data;
using Microsoft.Win32;
using SQLite;
using System.IO;
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

namespace CustomerApp;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        ReadDB();
    }

    private void save_Click(object sender, RoutedEventArgs e) {
        var customer = new Customer {
            Name = Name.Text,
            Phone = Phone.Text,
            Address = Address.Text,
            //Picture = picture.Source
        };

        using (var conect = new SQLiteConnection(App.databasePath)) {
            conect.CreateTable<Customer>();
            conect.Insert(customer);
        }
        Name.Text = null;
        Phone.Text = null;
        Address.Text = null;

        
    }

    private void gbt_Click(object sender, RoutedEventArgs e) {
        OpenFileDialog openfile = new OpenFileDialog();

        openfile.Filter = "画像ファイル(*.png;*.jpg;*.jpeg;*bmp) | *.png;*.jpg;*bmp";
        if(openfile.ShowDialog() == true) {
            string filepath = openfile.FileName;

            BitmapImage bit = new BitmapImage();
            using (FileStream stream = File.OpenRead(filepath)) {
                bit.BeginInit();
                bit.CacheOption = BitmapCacheOption.OnLoad;
                bit.StreamSource = stream;
                bit.EndInit();
            }
            picture.Source = bit;

        } else {
            MessageBox.Show("なにいってんのかいしてんのこうかな");
        }
        
    }

    private void imagedelete_Click(object sender, RoutedEventArgs e) {
        picture.Source = null;
    }

    private void picture_MouseLeftButtonDown(object sender, MouseButtonEventArgs e) {
        
        if (stmax.ScaleX == 1.0) {
            stmax.ScaleX = 2.0;
            stmax.ScaleY = 2.0;
        } else {
            stmax.ScaleX = 1.0;
            stmax.ScaleY = 1.0;
        }
    }

    private void delete_Click(object sender, RoutedEventArgs e) {
        
        var item = viewview.SelectedItem as Customer;
        if (item is not null) {
            using (var connection = new SQLiteConnection(App.databasePath)) {
                connection.CreateTable<Customer>();
                connection.Delete(item);
               
            }
        }
    }

    private void viewview_SelectionChanged(object sender, SelectionChangedEventArgs e) {
        if (viewview.SelectedItem is null) return;
        var item = viewview.SelectedItem as Customer;
        Name.Text = item.Name ?? "こちらはnullです";
        Phone.Text = item.Phone;
        Address.Text = item.Address;

    }

    private void ReadDB() {
        using (var connection = new SQLiteConnection(App.databasePath)) {
            connection.CreateTable<Customer>();
            viewview.ItemsSource = connection.Table<Customer>().ToList();

        }


    }
}