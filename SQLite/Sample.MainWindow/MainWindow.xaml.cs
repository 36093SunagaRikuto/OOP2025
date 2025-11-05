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
        NameTextBox.Text = null;
        PhoneTextBox.Text = null;

    }

    private void ReadButton_Click(object sender, RoutedEventArgs e) {
        ReadDB();
        
    }
    

    private void ReadDB() {
        using (var connection = new SQLiteConnection(App.databasePath)) {
            connection.CreateTable<Person>();
            var tablelist = connection.Table<Person>().ToList();
            _persons.Clear();
            foreach (var cust in tablelist) {
                _persons.Add(cust);
            }

            PersonListView.ItemsSource = _persons;

        }


    }
    
    private void DeleteButton_Click(object sender, RoutedEventArgs e) {
        var item = PersonListView.SelectedItem as Person;
        if (item is not null) {
            using (var connection = new SQLiteConnection(App.databasePath)) {
                connection.CreateTable<Person>();
                connection.Delete(item);
                ReadDB();
            }
        }
    }

    //リストビューのフィルタリング
    private void SearchTextBox_TextChanged(object sender, TextChangedEventArgs e) {
        var filterList = _persons.Where(p => p.Name.Contains(SearchTextBox.Text));
        

        PersonListView.ItemsSource = filterList;
        
    }

    private void PersonListView_SelectionChanged(object sender, SelectionChangedEventArgs e) {
        if (PersonListView.SelectedItem is null) return;
        var item = PersonListView.SelectedItem as Person;
        NameTextBox.Text = item.Name;
        PhoneTextBox.Text = item.Phone;
    }

    private void UpdateButton_Click(object sender, RoutedEventArgs e) {

        var unni = PersonListView.SelectedItem as Person;
        if (unni is null) {
            return;
        }
        using (var connection = new SQLiteConnection(App.databasePath)) {

            var person = new Person() {
                Id = unni.Id,
                Name = NameTextBox.Text,
                Phone = PhoneTextBox.Text
            };
            connection.Update(person);

            ReadDB();
        }
    }
}