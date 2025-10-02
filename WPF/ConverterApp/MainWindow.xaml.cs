using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ConverterApp
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window{

        Dictionary<string,double> tanni = new Dictionary<string, double> {
            {"m", 1},
            {"km", 1000},
            {"cm", 0.01},
            {"mm", 0.001},
            {"mile", 1609.34},
            {"yard", 0.9144},
            {"foot", 0.3048},
            {"inch", 0.0254}
        };

        public MainWindow(){
            InitializeComponent();
            MetricUnit.ItemsSource = tanni.Keys;
            ImperialUnit.ItemsSource = tanni.Keys;
        }

        private void ImperialUnitToMetoric_Click(object sender, RoutedEventArgs e) {


            
            if(int.TryParse(ImperialValue.Text, out int result)){
                MetricValue.Text = (result / 1).ToString();
            }
           
        }

        private void MetricToImperialUnit_Click(object sender, RoutedEventArgs e) {
            
            if(int.TryParse(MetricValue.Text, out int result)) {
                ImperialValue.Text = (result * 1).ToString();
            }
        }
    }
}
