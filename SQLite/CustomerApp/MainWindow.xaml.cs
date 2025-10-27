using CustomerApp.Data;
using Microsoft.Win32;
using SQLite;
using System.Collections.ObjectModel;
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
    OpenFileDialog openfile = new OpenFileDialog();
    private ObservableCollection<Customer> _customer = new ObservableCollection<Customer>();
    public MainWindow()
    {
        InitializeComponent();
        ReadDB();
        
    }

    private void save_Click(object sender, RoutedEventArgs e) {
        MemoryStream ms = new MemoryStream();
        var customer = new Customer {
            Name = Name.Text,
            Phone = Phone.Text,
            Address = Address.Text,
            Picture = File.ReadAllBytes(openfile.FileName)
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

    private void TextBox_DragEnter(object sender, DragEventArgs e) {

    }

    private void SearchTextBox_TextChanged(object sender, TextChangedEventArgs e) {
        var search = _customer.Where(p => p.Name.Contains(Searchtb.Name));

        viewview.ItemsSource = search;
    }

    private void viewview_SelectionChanged_1(object sender, SelectionChangedEventArgs e) {
        if (viewview.SelectedItem is null) return; 
        var item = viewview.SelectedItem as Customer;
        Name.Text = item.Name;
        Phone.Text = item.Phone;
        Address.Text = item.Address;

    }

    private void update_Click(object sender, RoutedEventArgs e) {
        var unni = viewview.SelectedItem as Customer;
        if (unni is null) {
            return;
        }
        using (var connection = new SQLiteConnection(App.databasePath)) {

            var customer = new Customer() {
                Id = unni.Id,
                Name = Name.Text,
                Phone = Phone.Text,
                Picture = unni.Picture
                
            };
            connection.Update(customer);

            ReadDB();
        }
    }
}