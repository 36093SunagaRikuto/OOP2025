using System.Text;
using System.Windows.Forms;

namespace Exercise01 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void bt1_Click(object sender, EventArgs e) {
            ss1.Text = "";
            var filepath = "走れメロス.txt";

            using (StreamReader sr = new StreamReader(filepath, Encoding.Default)) {

                var all = File.ReadAllText(filepath);

                ss1.Text = "読み込み完了";
                rtextbox.Text = all;

            }
        }

        private void button1_Click(object sender, EventArgs e) {
            ss1.Text = "";
            var tiku = new Thread(dowork);
            tiku.Start();
            //dowork();

        }

        private void dowork() {
            System.Threading.Thread.Sleep(15000);
            ss1.Invoke((Action)delegate () {
                ss1.Text = "終了";
                rtextbox.Text = "好きな出っ歯";
            });
        }
    }
}
