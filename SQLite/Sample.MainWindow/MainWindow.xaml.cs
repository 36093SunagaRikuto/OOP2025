using Sample.Data;
using SQLite;
using System.Collections.ObjectModel;
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

namespace Sample.MainWindow;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    private ObservableCollection<Person> _persons = new ObservableCollection<Person>();
    public MainWindow()
    {
        InitializeComponent();
        
        ReadDB();
        PersonListView.ItemsSource = _persons;
    }

    private void SaveButton_Click(object sender, RoutedEventArgs e) {
        var person = new Person {
            Name = NameTextBox.Text,
            Phone = PhoneTextBox.Text,
        };

        
        using (var connection = new SQLiteConnection(App.databasePath)) {
            connection.CreateTable<Person>();
            connection.Insert(person);
        }
    }

    private void ReadButton_Click(object sender, RoutedEventArgs e) {
        ReadDB();
        PersonListView.ItemsSource = _persons;
    }
    

    private void ReadDB() {
        using (var connection = new SQLiteConnection(App.databasePath)) {
            connection.CreateTable<Person>();
            PersonListView.ItemsSource = connection.Table<Person>().ToList();

        }

        
    }
    
    private void DeleteButton_Click(object sender, RoutedEventArgs e) {
        var item = PersonListView.SelectedItem as Person;

        using (var connection = new SQLiteConnection(App.databasePath)) {
            connection.CreateTable<Person>();
            connection.Delete(item);
            ReadDB();
        }
    }
}