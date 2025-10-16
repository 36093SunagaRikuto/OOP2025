using System.Configuration;
using System.Data;
using System.Windows;

namespace Sample.MainWindow;

/// <summary>
/// Interaction logic for App.xaml
/// </summary>
public partial class App : Application{
    static string databaseName = "Person.db";
    static string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
    public static string databasePath = System.IO.Path.Combine(folderPath, databaseName);
}

