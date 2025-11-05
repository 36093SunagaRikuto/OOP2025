using System.Diagnostics;

namespace Section03 {
    public partial class Form1 : Form {
        private object listBox1;

        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            //toolStripStatusLablel1.Text = "";
            //DoLongTimeWorkAsync(4000);
            //toolStripStatusLablel1.Text = "終了";

            toolStripStatusLablel1.Text = "処理中";
            Cursor = Cursors.WaitCursor;
            System.Threading.Thread.Sleep(10000);
            toolStripStatusLablel1.Text = "終了";
            Cursor = Cursors.Arrow;

        }

        //戻り値のある同期メソッド
        private async Task<long> DoLongTimeWorkAsync(int milliseconds) {
            var sw = Stopwatch.StartNew();
            await Task.Run(() => {
                System.Threading.Thread.Sleep(5000);
            });
            sw.Stop();
            return sw.ElapsedMilliseconds;

        }

        private void listBox1_MeasureItem(object listBox1, MeasureItemEventArgs? args) {
            
        }

        
    }

    
}
