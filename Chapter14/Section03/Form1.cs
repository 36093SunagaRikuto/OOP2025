using System.Diagnostics;

namespace Section03 {
    public partial class Form1 : Form {
        private object listBox1;

        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            toolStripStatusLablel1.Text = "";
            DoLongTimeWorkAsync(4000);
            toolStripStatusLablel1.Text = "�I��";
        }

        //�߂�l�̂��铯�����\�b�h
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
