using System.ComponentModel;
using System.Drawing.Imaging;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml;
using System.Xml.Serialization;

namespace CarReportSystem {
    public partial class Form1 : Form {
        BindingList<CarReport> listCarReports = new BindingList<CarReport>();
        BindingList<String> listAuthor = new BindingList<string>();


        //�ݒ�N���X�̃C���X�^���X��
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

        //�L�^�҂̗������R���{�{�b�N�X�֓o�^�i�d���j
        private void SetCbAuthor(string author) {

            //���ɓo�^�ς݂��m�F
            if (cbAuthor.Items.Contains(author)) {

                //���o�^�Ȃ�o�^�y�o�^�ς݂Ȃ牽�����Ȃ��z

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

            //���ɓo�^�ς݂��m�F
            if (cbCarName.Items.Contains(carname)) {

                //���o�^�Ȃ�o�^�y�o�^�ς݂Ȃ牽�����Ȃ��z

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

            if (rbToyota.Checked) return CarReport.MakerGroup.�g���^;
            if (rbNissan.Checked) return CarReport.MakerGroup.���Y;
            if (rbSubaru.Checked) return CarReport.MakerGroup.�X�o��;
            if (rbSuzuki.Checked) return CarReport.MakerGroup.�X�Y�L;
            if (rbYunyusya.Checked) return CarReport.MakerGroup.�A����;
            if (rbSonota.Checked) return CarReport.MakerGroup.���̑�;


            return CarReport.MakerGroup.�Ȃ�;
        }


        //�w�肵�����[�J�[�̃��W�I�{�^�����Z�b�g
        private void setRadioButtonMaker(CarReport.MakerGroup targetMaker) {
            switch (targetMaker) {
                case CarReport.MakerGroup.�g���^:
                    rbToyota.Checked = true;
                    break;
                case CarReport.MakerGroup.���Y:
                    rbNissan.Checked = true;
                    break;
                case CarReport.MakerGroup.�X�o��:
                    rbSubaru.Checked = true;
                    break;
                case CarReport.MakerGroup.�X�Y�L:
                    rbSuzuki.Checked = true;
                    break;
                case CarReport.MakerGroup.�A����:
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

        //�폜�{�^��
        private void btRecordDelete_Click(object sender, EventArgs e) {
            //�J�[���|�[�g�Ǘ��p���X�g����A�Y������f�[�^���폜����
            if (dgvRecord.RowCount != 0) {

                int index = dgvRecord.CurrentRow.Index;
                listCarReports.RemoveAt(index);
            }
            //listCarReports.Remove();
        }

        //�C���{�^��
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
        private void �t�@�C��FToolStripMenuItem_Click(object sender, EventArgs e) {

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

        private void �F�ݒ�ToolStripMenuItem_Click(object sender, EventArgs e) {

            //ColorDialog cd = new ColorDialog();
            //Form1 f1 = new Form1();
            if (cdColor.ShowDialog() == DialogResult.OK) {


                BackColor = cdColor.Color;


                try {
                    //�ݒ�t�@�C���֕ۑ�
                    
                    using (var setcolor = XmlWriter.Create("settings.xml")) {
                    var serializer = new XmlSerializer(settings.GetType());
                    serializer.Serialize(setcolor, settings);
                    
                    }
                }
                catch (Exception) {
                    tsslbMessage.Text = "�t�@�C�������o���Ɏ��s���܂����B" ;
                    throw;
                }
                

                
            }

        }



        private void Form1_Load(object sender, EventArgs e) {
            //���݂ɐF��ݒ�
            InputItemsAllClear();
            dgvRecord.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke;
            dgvRecord.DefaultCellStyle.BackColor = Color.LightGray;


            if (File.Exists("settings.xml")) {
                //�ݒ�t�@�C����ǂݍ��ݔw�i�F��ݒ肷��i�t�V���A�����j
                //P286���Q�l�ɂ���t�@�C����

                try {
                    //�ݒ�t�@�C�������݂���ꍇ�A�t�V���A�����œǂݍ���
                    using (var reader = XmlReader.Create("settings.xml")) {
                        var serializer = new XmlSerializer(typeof(Settings));
                        var novel = serializer.Deserialize(reader) as Settings;
                        if (novel != null) {
                            BackColor = Color.FromArgb(novel.MainFormBackColor);
                            //�ݒ�N���X�̃C���X�^���X�ɂ����݂̐ݒ�F��ݒ�
                            settings.MainFormBackColor = BackColor.ToArgb();
                        }
                    }


                }
                catch (Exception ex) {
                    tsslbMessage.Text = "�ݒ�t�@�C���̓ǂݍ��݂Ɏ��s���܂����B";
                    MessageBox.Show(ex.Message);
                    throw;
                }

            } else {
                tsslbMessage.Text = "�ݒ�t�@�C����������܂���";
            }

        }

        private void �J��ToolStripMenuItem_Click(object sender, EventArgs e) {

            reportOpenFile();
        }

        private void reportOpenFile() {
            if (ofdPicFileOpen.ShowDialog() == DialogResult.OK)
                try {
                    //�t�V���A�����Ńo�C�i���`������荞��
#pragma warning disable SYSLIB0011
                    var bf = new BinaryFormatter();
#pragma warning restore SYSLIB0011
                    using (FileStream fs = File.Open(
                        ofdPicFileOpen.FileName, FileMode.Open, FileAccess.Read)) {

                       
                        listCarReports = (BindingList<CarReport>)bf.Deserialize(fs);
                        dgvRecord.DataSource = listCarReports;


                        cbAuthor.Items.Clear();
                        cbCarName.Items.Clear();

                        //�R���{�{�b�N�X�ɓo�^
                        foreach (var report in listCarReports) {
                            SetCbAuthor(report.Author);
                            SetCbCarName(report.CarName);
                        }



                    }
                }
                catch (Exception) {
                    //��O����[����
                    tsslbMessage.Text = "�t�@�C���̌`�����Ⴂ�܂��B";


                    throw;
                }
        }

        //�t�@�C���Z�[�u����
        private void reportSaveFile() {
            if (sfdReportFileSave.ShowDialog() == DialogResult.OK)
                try {
                    //�o�C�i���`���ŃV���A����
#pragma warning disable SYSLIB0011
                    var bf = new BinaryFormatter();
#pragma warning restore SYSLIB0011
                    using (FileStream fs = File.Open(
                        sfdReportFileSave.FileName, FileMode.Create)) {

                        bf.Serialize(fs, listCarReports);
                    }
                }
                catch (Exception) {

                    tsslbMessage.Text = "�t�@�C�������o���Ɏ��s���܂����B";

                    throw;
                }
        }

        private void sfdReportFSave_FileOk(object sender, CancelEventArgs e) {

        }

        private void �ۑ�ToolStripMenuItem_Click(object sender, EventArgs e) {
            reportSaveFile();
        }

        //�t�H�[����������Ă΂��
        private void Form1_FormClosed(object sender, FormClosedEventArgs e) {
            //�ݒ�t�@�C���֐F����ۑ����鏈���i�V���A�����j
            //�t�@�C����settings.xml
            try {
                
                using (var setcolor = XmlWriter.Create("settings.xml")) {
                    var serializer = new XmlSerializer(settings.GetType());
                    serializer.Serialize(setcolor, settings);
                }

            }
            catch (Exception ex) {
                tsslbMessage.Text = "�ݒ�t�@�C���̏����o���Ɏ��s���܂����B";
                MessageBox.Show(ex.Message);
                throw;
            }
            

        }
    }
}
