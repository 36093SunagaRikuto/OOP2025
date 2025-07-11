using System.ComponentModel;
using System.Drawing.Imaging;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml;
using System.Xml.Serialization;

namespace CarReportSystem {
    public partial class Form1 : Form {
        BindingList<CarReport> listCarReports = new BindingList<CarReport>();
        BindingList<String> listAuthor = new BindingList<string>();


        //設定クラスのインスタンスを
        Settings settings = Settings.getInstance();
        



        public Form1() {
            InitializeComponent();
            dgvRecord.DataSource = listCarReports;
        }

        private void bt1_Click(object sender, EventArgs e) {
            if (ofdPicFileOpen.ShowDialog() == DialogResult.OK) {
                pbPicture.Image = Image.FromFile(ofdPicFileOpen.FileName);
            }
        }

        private void bt2_Click(object sender, EventArgs e) {
            pbPicture.Image = null;
        }

        //記録者の履歴をコンボボックスへ登録（重複）
        private void SetCbAuthor(string author) {

            //既に登録済みか確認
            if (cbAuthor.Items.Contains(author)) {

                //未登録なら登録【登録済みなら何もしない】

            } else {
                cbAuthor.Items.Add(author);
            }
        }

        private void btRecordAdd_Click(object sender, EventArgs e) {


            tsslbMessage.Text = String.Empty;
            if (cbAuthor.Text == String.Empty || cbCarName.Text == String.Empty) return;
            var carReport = new CarReport {


                Date = dtDate.Value,
                Author = cbAuthor.Text,
                Maker = GetRadioButtonMaker(),
                CarName = cbCarName.Text,
                Report = tbReport.Text,
                Picture = pbPicture.Image

            };
            listCarReports.Add(carReport);
            SetCbAuthor(cbAuthor.Text);
            SetCbCarName(cbCarName.Text);
            InputItemsAllClear();
        }


        private void SetCbCarName(string carname) {

            //既に登録済みか確認
            if (cbCarName.Items.Contains(carname)) {

                //未登録なら登録【登録済みなら何もしない】

            } else {
                cbCarName.Items.Add(carname);
            }
        }

        private void InputItemsAllClear() {

            dtDate.Value = DateTime.Today;
            cbAuthor.Text = string.Empty;
            rbSonota.Checked = true;
            cbCarName.Text = string.Empty;
            tbReport.Text = string.Empty;
            pbPicture.Image = null;
        }

        private CarReport.MakerGroup GetRadioButtonMaker() {

            if (rbToyota.Checked) return CarReport.MakerGroup.トヨタ;
            if (rbNissan.Checked) return CarReport.MakerGroup.日産;
            if (rbSubaru.Checked) return CarReport.MakerGroup.スバル;
            if (rbSuzuki.Checked) return CarReport.MakerGroup.スズキ;
            if (rbYunyusya.Checked) return CarReport.MakerGroup.輸入車;
            if (rbSonota.Checked) return CarReport.MakerGroup.その他;


            return CarReport.MakerGroup.なし;
        }


        //指定したメーカーのラジオボタンをセット
        private void setRadioButtonMaker(CarReport.MakerGroup targetMaker) {
            switch (targetMaker) {
                case CarReport.MakerGroup.トヨタ:
                    rbToyota.Checked = true;
                    break;
                case CarReport.MakerGroup.日産:
                    rbNissan.Checked = true;
                    break;
                case CarReport.MakerGroup.スバル:
                    rbSubaru.Checked = true;
                    break;
                case CarReport.MakerGroup.スズキ:
                    rbSuzuki.Checked = true;
                    break;
                case CarReport.MakerGroup.輸入車:
                    rbYunyusya.Checked = true;
                    break;
                default:
                    rbSonota.Checked = true;
                    break;

            }
        }

        private void cbAuthor_SelectedIndexChanged(object sender, EventArgs e) {

        }

        private void cbCarName_SelectedIndexChanged(object sender, EventArgs e) {

        }

        private void dtPicker_ValueChanged(object sender, EventArgs e) {

        }
        private void pictureBox1_Click(object sender, EventArgs e) {

        }

        private void rbToyota_CheckedChanged(object sender, EventArgs e) {

        }

        private void dgvRecord_Click(object sender, EventArgs e) {
            if ((!dgvRecord.CurrentRow.Selected) || dgvRecord.CurrentRow is null) return;
            dtDate.Value = (DateTime)dgvRecord.CurrentRow.Cells["Date"].Value;

            cbAuthor.Text = (string)dgvRecord.CurrentRow.Cells["Author"].Value;
            setRadioButtonMaker((CarReport.MakerGroup)dgvRecord.CurrentRow.Cells["Maker"].Value);
            cbCarName.Text = (string)dgvRecord.CurrentRow.Cells["CarName"].Value;
            tbReport.Text = (string)dgvRecord.CurrentRow.Cells["Report"].Value;
            pbPicture.Image = (Image)dgvRecord.CurrentRow.Cells["Picture"].Value;


            //setRadioButtonMaker(GetRadioButtonMaker());
        }

        private void dgvRecord_CellContentClick(object sender, DataGridViewCellEventArgs e) {

        }

        //削除ボタン
        private void btRecordDelete_Click(object sender, EventArgs e) {
            //カーレポート管理用リストから、該当するデータを削除する
            if (dgvRecord.RowCount != 0) {

                int index = dgvRecord.CurrentRow.Index;
                listCarReports.RemoveAt(index);
            }
            //listCarReports.Remove();
        }

        //修正ボタン
        private void btRecordModify_Click(object sender, EventArgs e) {

            if (dgvRecord.RowCount != 0) {

                /*var carReport = new CarReport {

                    Date = dtDate.Value,
                    Author = cbAuthor.Text,
                    Maker = GetRadioButtonMaker(),
                    CarName = cbCarName.Text,
                    Report = tbReport.Text,
                    Picture = pbPicture.Image

                };*/
                int index = dgvRecord.CurrentRow.Index;
                listCarReports[index].Date = dtDate.Value;
                listCarReports[index].Author = cbAuthor.Text;
                listCarReports[index].Maker = GetRadioButtonMaker();
                listCarReports[index].CarName = cbCarName.Text;
                listCarReports[index].Report = tbReport.Text;
                listCarReports[index].Picture = pbPicture.Image;




                dgvRecord.Refresh();
            }
        }
        private void ファイルFToolStripMenuItem_Click(object sender, EventArgs e) {

        }
        private void tbReport_TextChanged(object sender, EventArgs e) {

        }

        private void tllsbMessage_ItemClicked(object sender, ToolStripItemClickedEventArgs e) {

        }

        private void tsmiExit_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void tsmi_Click(object sender, EventArgs e) {
            fmVersion help = new fmVersion();
            for (int i = 0; i < 100; i++)
                help.ShowDialog();
        }

        private void 色設定ToolStripMenuItem_Click(object sender, EventArgs e) {

            //ColorDialog cd = new ColorDialog();
            //Form1 f1 = new Form1();
            if (cdColor.ShowDialog() == DialogResult.OK) {


                BackColor = cdColor.Color;


                try {
                    //設定ファイルへ保存
                    
                    using (var setcolor = XmlWriter.Create("settings.xml")) {
                    var serializer = new XmlSerializer(settings.GetType());
                    serializer.Serialize(setcolor, settings);
                    
                    }
                }
                catch (Exception) {
                    tsslbMessage.Text = "ファイル書き出しに失敗しました。" ;
                    throw;
                }
                

                
            }

        }



        private void Form1_Load(object sender, EventArgs e) {
            //交互に色を設定
            InputItemsAllClear();
            dgvRecord.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke;
            dgvRecord.DefaultCellStyle.BackColor = Color.LightGray;


            if (File.Exists("settings.xml")) {
                //設定ファイルを読み込み背景色を設定する（逆シリアル化）
                //P286を参考にするファイル名

                try {
                    //設定ファイルが存在する場合、逆シリアル化で読み込む
                    using (var reader = XmlReader.Create("settings.xml")) {
                        var serializer = new XmlSerializer(typeof(Settings));
                        var novel = serializer.Deserialize(reader) as Settings;
                        if (novel != null) {
                            BackColor = Color.FromArgb(novel.MainFormBackColor);
                            //設定クラスのインスタンスにも現在の設定色を設定
                            settings.MainFormBackColor = BackColor.ToArgb();
                        }
                    }


                }
                catch (Exception ex) {
                    tsslbMessage.Text = "設定ファイルの読み込みに失敗しました。";
                    MessageBox.Show(ex.Message);
                    throw;
                }

            } else {
                tsslbMessage.Text = "設定ファイルが見つかりません";
            }

        }

        private void 開くToolStripMenuItem_Click(object sender, EventArgs e) {

            reportOpenFile();
        }

        private void reportOpenFile() {
            if (ofdPicFileOpen.ShowDialog() == DialogResult.OK)
                try {
                    //逆シリアル化でバイナリ形式を取り込む
#pragma warning disable SYSLIB0011
                    var bf = new BinaryFormatter();
#pragma warning restore SYSLIB0011
                    using (FileStream fs = File.Open(
                        ofdPicFileOpen.FileName, FileMode.Open, FileAccess.Read)) {

                       
                        listCarReports = (BindingList<CarReport>)bf.Deserialize(fs);
                        dgvRecord.DataSource = listCarReports;


                        cbAuthor.Items.Clear();
                        cbCarName.Items.Clear();

                        //コンボボックスに登録
                        foreach (var report in listCarReports) {
                            SetCbAuthor(report.Author);
                            SetCbCarName(report.CarName);
                        }



                    }
                }
                catch (Exception) {
                    //例外えらー処理
                    tsslbMessage.Text = "ファイルの形式が違います。";


                    throw;
                }
        }

        //ファイルセーブ処理
        private void reportSaveFile() {
            if (sfdReportFileSave.ShowDialog() == DialogResult.OK)
                try {
                    //バイナリ形式でシリアル化
#pragma warning disable SYSLIB0011
                    var bf = new BinaryFormatter();
#pragma warning restore SYSLIB0011
                    using (FileStream fs = File.Open(
                        sfdReportFileSave.FileName, FileMode.Create)) {

                        bf.Serialize(fs, listCarReports);
                    }
                }
                catch (Exception) {

                    tsslbMessage.Text = "ファイル書き出しに失敗しました。";

                    throw;
                }
        }

        private void sfdReportFSave_FileOk(object sender, CancelEventArgs e) {

        }

        private void 保存ToolStripMenuItem_Click(object sender, EventArgs e) {
            reportSaveFile();
        }

        //フォームが閉じたら呼ばれる
        private void Form1_FormClosed(object sender, FormClosedEventArgs e) {
            //設定ファイルへ色情報を保存する処理（シリアル化）
            //ファイル名settings.xml
            try {
                
                using (var setcolor = XmlWriter.Create("settings.xml")) {
                    var serializer = new XmlSerializer(settings.GetType());
                    serializer.Serialize(setcolor, settings);
                }

            }
            catch (Exception ex) {
                tsslbMessage.Text = "設定ファイルの書き出しに失敗しました。";
                MessageBox.Show(ex.Message);
                throw;
            }
            

        }
    }
}
