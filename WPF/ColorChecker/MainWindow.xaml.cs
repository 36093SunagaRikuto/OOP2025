using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Security.AccessControl;
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

namespace ColorChecker
{
    /// <summar>
    /// MainWindow.xml の相互作用口ジック
    /// </summar>
    public partial class MainWindow : Window{
        MyColor currentcolor;//現在の色
        public MainWindow(){
            InitializeComponent();
            DataContext = GetColorList();

        }

        private MyColor[] GetColorList() {
            return typeof(Colors).GetProperties(System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Static)
                .Select(i => new MyColor() { Color = (Color)i.GetValue(null), Name = i.Name }).ToArray();


        }

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e) {
            byte r = (byte)rSlider.Value;
            byte g = (byte)gSlider.Value;
            byte b = (byte)bSlider.Value;

            colorArea.Background = new SolidColorBrush(Color.FromRgb(r,g,b));
            if (itemname() == "") return;
            //combob.Text = itemname();

        }

        private void Stockbt_Click(object sender, RoutedEventArgs e) {
            //ストックボクンをケリック   

            Color col = Color.FromRgb((byte)rSlider.Value, (byte)gSlider.Value, (byte)bSlider.Value);


            //if (!Stocklb.Items.Contains(itemname())) {
            ////Stocklb.Items.Add($"{col}");
            //}

            

            string sss = itemname();
            if (sss != null) {
                foreach (var item in Stocklb.Items) {
                    if (((string)item).Contains(sss)) {
                        return;
                    }
                }
            }
            MyColor a = new MyColor() { Color = col, Name = itemname() };

            Stocklb.Items.Add(a.Name ?? $"{itemname()}\n  R:{(int)rSlider.Value}, G:{(int)gSlider.Value}, B:{(int)bSlider.Value}");
            //Stocklb.Items.Add(a.Name);
            

            
        }
        
        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            //コンポボックヌから色を選択


            var comboselectmycolor = (MyColor)((ComboBox)sender).SelectedItem;
            setslidervalued(comboselectmycolor.Color);//スライダ一を設定

        }

        //各スライダーの値を設定
        private void setslidervalued(Color color) {
            rSlider.Value = color.R;
            gSlider.Value = color.G;
            bSlider.Value = color.B;
        }

        private void Stocklb_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            //リストボックスから選沢
            var unko = Stocklb.Items[Stocklb.SelectedIndex];

            rSlider.Value = getcolor((string)unko).R;
            gSlider.Value = getcolor((string)unko).G;
            bSlider.Value = getcolor((string)unko).B;
            combob.Text = (string)unko;
            // setslidervalued(unko.Color);

        }

        private string itemname() {

            foreach (var it in GetColorList()) {
                if (it.Color.R == rSlider.Value && it.Color.G == gSlider.Value && it.Color.B == bSlider.Value)
                    return it.Name;
            }
            return  null;
        }

        private Color getcolor(string colorname) {
            foreach(var na in GetColorList()) {
                if (na.Name.Equals(colorname)) {
                    return na.Color;
                }
            }
            return colorArea.Background.GetValue(SolidColorBrush.ColorProperty) is Color c ? c : Colors.Black;
        }

        private void allclear_Click(object sender, RoutedEventArgs e) {
           //Stocklb.Items.Clear();
        }
    }
}
