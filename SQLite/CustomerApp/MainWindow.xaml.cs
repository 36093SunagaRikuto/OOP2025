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
        customerset();
    }

    private void customerset() {
        //using (var command = new SqliteCommand(query, connection)) {
        //    using (var reader = command.ExecuteReader()) {
        //        while (reader.Read()) {
        //            // DataReaderからデータを読み込み、Customerオブジェクトを作成
        //            var customer = new Customer {
        //                Id = reader.GetInt32(0),
        //                Name = reader.GetString(1),
        //                Address = reader.GetString(2)
        //                // nullを許容するカラムの場合は GetString(index) の前に DBNull.Value チェックが必要
        //            };

        //            // ObservableCollection に追加
        //            _customer.Add(customer);
        //        }
        //    }
        //}
    }

    private void save_Click(object sender, RoutedEventArgs e) {
        MemoryStream ms = new MemoryStream();
        var itsource = picture.Source as BitmapSource;
        if (itsource == null) return;
        var encoder = new PngBitmapEncoder();
        encoder.Frames.Add(BitmapFrame.Create(itsource));
        var stream = new MemoryStream();
        encoder.Save(stream);
        

        var customer = new Customer {
            Name = Name.Text,
            Phone = Phone.Text,
            Address = Address.Text,
            Picture = stream.ToArray()
        };
        
        using (var conect = new SQLiteConnection(App.databasePath)) {
            conect.CreateTable<Customer>();
            conect.Insert(customer);
        }
        _customer.Add(customer);

        Name.Text = null;
        Phone.Text = null;
        Address.Text = null;
        picture.Source = null;
        ReadDB();
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

        }
        ReadDB();
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
        ReadDB();
    }

    private void viewview_SelectionChanged(object sender, SelectionChangedEventArgs e) {
        if (viewview.SelectedItem is null) return;
        var item = viewview.SelectedItem as Customer;
        using (MemoryStream ms = new MemoryStream(item.Picture)) {
            BitmapImage bit = new BitmapImage();
            try {
                bit.BeginInit();
                bit.CacheOption = BitmapCacheOption.OnLoad;
                bit.StreamSource = ms;
                bit.EndInit();
            }
            catch {
                bit = null;
            }


            Name.Text = item.Name ?? "こちらはnullです";
            Phone.Text = item.Phone;
            Address.Text = item.Address;
            picture.Source = bit;
        }
    }

    private void ReadDB() {
        
        using (var connection = new SQLiteConnection(App.databasePath)) {
            connection.CreateTable<Customer>();
            var tablelist = connection.Table<Customer>().ToList();
            _customer.Clear();
            foreach (var cust in tablelist) {
                _customer.Add(cust);
            }

            viewview.ItemsSource = _customer;

        }

        

    }

    private void TextBox_DragEnter(object sender, DragEventArgs e) {

    }

    private void SearchTextBox_TextChanged(object sender, TextChangedEventArgs e){
        Name.Text = null;
        Phone.Text = null;
        Address.Text = null;
        picture.Source = null;

        var search = _customer.Where(p => p.Name.Contains(Searchtb.Text));

        viewview.ItemsSource = search;

    }

    private void viewview_SelectionChanged_1(object sender, SelectionChangedEventArgs e) {
        if (viewview.SelectedItem is null) return; 
        var item = viewview.SelectedItem as Customer;
        MemoryStream ms = new MemoryStream(item.Picture);
        BitmapImage? bit = new BitmapImage();
        try {
            bit.BeginInit();
            bit.CacheOption = BitmapCacheOption.OnLoad;
            bit.StreamSource = ms;
            bit.EndInit();
        }
        catch {
            bit = null;
        }

        Name.Text = item.Name;
        Phone.Text = item.Phone;
        Address.Text = item.Address;
        picture.Source = bit;
        
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

          
        }
        ReadDB();
    }
}