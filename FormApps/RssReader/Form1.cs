using System.Data;
using System.Net;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;
using static System.Net.WebRequestMethods;

namespace RssReader {
    public partial class Form1 : Form {

        private List<ItemData> items;
        Dictionary<string, string> dic = new Dictionary<string, string>() {
            {"��v", "https://news.yahoo.co.jp/rss/topics/top-picks.xml" },
            {"����", "https://news.yahoo.co.jp/rss/topics/domestic.xml" },
            {"����", "https://news.yahoo.co.jp/rss/topics/world.xml" },
            {"�X�|�[�c", "https://news.yahoo.co.jp/rss/topics/sports.xml" },
            {"�G���^��", "https://news.yahoo.co.jp/rss/topics/entertainment.xml" },
            {"IT", "https://news.yahoo.co.jp/rss/topics/it.xml" },
            {"�Ȋw", "https://news.yahoo.co.jp/rss/topics/science.xml" }

        };

        public Form1() {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e) {

            wvRssLink.GoBack();
        }

        private void go_Click(object sender, EventArgs e) {

            wvRssLink.GoForward();
        }

        private void tburl_TextChanged(object sender, EventArgs e) {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) {

            //tburl.Text = dic[cbBox.SelectedItem.ToString()];
            //wvRssLink.Source = new Uri(dic[cbBox.SelectedItem.ToString()]);
        }

        private void lbTitles_SelectedIndexChanged(object sender, EventArgs e) {

        }

        private void wvRssLink_SourceChanged(object sender, Microsoft.Web.WebView2.Core.CoreWebView2SourceChangedEventArgs e) {

        }










        private async void btRssGet_Click(object sender, EventArgs e) {
            //RSS����͂��ĕK�v�ȗv�f���擾����
            if (tburl.Text is null || cbBox.Text is null) return;

            using (var wc = new HttpClient()) {
                //var url = wc.OpenRead(tburl.Text);

                var xml = await wc.GetStringAsync(getRssUrl(cbBox.Text));
                XDocument xdoc = XDocument.Parse(xml);

                //RSS����͂��ĕK�v�ȗv�f���擾
                items = xdoc.Root.Descendants("item")
                    .Select(x =>
                        new ItemData {
                            Title = (string?)x.Element("title"),
                            Link = (string?)x.Element("link"),
                        }).ToList();

                lbTitles.Items.Clear();
                items.ForEach(item => lbTitles.Items.Add(item.Title ?? "�f�[�^�Ȃ�"));

            }

        }
        //�R���{�{�b�N�X�̕�������`�F�b�N���ăA�N�Z�X�\��URL��ԋp
        private string getRssUrl(string url) {

            if (dic.ContainsKey(url)) {
                return dic[url];
            }
            return "https://news.yahoo.co.jp/rss/media/keibalab/all.xml";

        }



        //�^�C�g����I�������Ƃ��ɌĂ΂��C�x���g�n���h��
        private void lbTitles_Click(object sender, EventArgs e) {
            if (lbTitles.SelectedIndex < 0) return;
            var ind = lbTitles.SelectedIndex;
            if (checkurl(items[ind].Link ?? "https://news.yahoo.co.jp/rss/media/keibalab/all.xml")) {
                wvRssLink.Source = new Uri(items[ind].Link ?? "https://news.yahoo.co.jp");

                back.Enabled = wvRssLink.CanGoBack;
                go.Enabled = wvRssLink.CanGoForward;
            }
        }



        private void Form1_Load(object sender, EventArgs e) {


            back.Enabled = wvRssLink.CanGoBack;
            go.Enabled = wvRssLink.CanGoForward;



            dicrss();

            //�ʐ^�ǉ�
            PictureBox pic = new PictureBox();
            pic.Size = new Size(600, 496);
            pic.Location = new Point(10, 300);
            pic.Image = Image.FromFile("C:/Users/infosys/source/repos/OOP2025/yay.jpg");
            this.Controls.Add(pic);

            

        }
        //�R���{�{�b�N�X����I��
        private void dicrss() {

            foreach (var sele in dic.Keys) {
                cbBox.Items.Add(sele);
            }

        }



        private void lbTitles_SelectedIndexChanged_1(object sender, EventArgs e) {

            back.Enabled = wvRssLink.CanGoBack;
            go.Enabled = wvRssLink.CanGoForward;
        }

        private void wvRssLink_NavigationStarting(object sender, Microsoft.Web.WebView2.Core.CoreWebView2NavigationStartingEventArgs e) {
            back.Enabled = wvRssLink.CanGoBack;
            go.Enabled = wvRssLink.CanGoForward;
        }

        //���C�ɓ���o�^
        private void byfavorite_Click(object sender, EventArgs e) {

            if (tburl.Text is null || cbBox.Text is null) return;
            //�g�s�b�N�������ɒǉ�����Ă���
            if (dic.ContainsKey(cbBox.Text)) return;
            //����URL�����ɒǉ�����Ă���
            if (dic.ContainsValue(tburl.Text)) return;

            dic.Add(cbBox.Text, tburl.Text);
            cbBox.Items.Clear();
            dicrss();
            cbBox.Text = null; tburl.Text = null;



        }
        //���C�ɓ���폜
        private void btRemove_Click(object sender, EventArgs e) {
            if (!dic.ContainsKey(cbBox.Text)) return;
            dic.Remove(cbBox.SelectedIndex.ToString());
            cbBox.Items.Clear();
            dicrss();
            cbBox.Text = null;
        }

        private void label2_Click(object sender, EventArgs e) {

        }

        private void lbTitles_DrawItem(object sender, DrawItemEventArgs e) {
            var idx = e.Index;                                                      //�`��Ώۂ̍s
            if (idx == -1) return;                                                  //�͈͊O�Ȃ牽�����Ȃ�
            var sts = e.State;                                                      //�Z���̏��
            var fnt = e.Font;                                                       //�t�H���g
            var _bnd = e.Bounds;                                                    //�`��͈�(�I���W�i��)
            var bnd = new RectangleF(_bnd.X, _bnd.Y, _bnd.Width, _bnd.Height);     //�`��͈�(�`��p)
            var txt = (string)lbTitles.Items[idx];                                  //���X�g�{�b�N�X���̕���
            var bsh = new SolidBrush(lbTitles.ForeColor);                           //�����F
            var sel = (DrawItemState.Selected == (sts & DrawItemState.Selected));   //�I���s��
            var odd = (idx % 2 == 1);                                               //��s��
            var fore = Brushes.WhiteSmoke;                                         //�����s�̔w�i�F
            var bak = Brushes.BurlyWood;                                           //��s�̔w�i�F

            e.DrawBackground();                                                     //�w�i�`��

            //����ڂ̔w�i�F��ς���i�I���s�͏����j
            if (odd && !sel) {
                e.Graphics.FillRectangle(bak, bnd);
            } else if (!odd && !sel) {
                e.Graphics.FillRectangle(fore, bnd);
            }

            //������`��
            e.Graphics.DrawString(txt, fnt, bsh, bnd);

        }

        private bool checkurl(string url) {

            if (Uri.IsWellFormedUriString(url, UriKind.Absolute)) return true;

            return false;
        }

        private void pictureBox1_Click(object sender, EventArgs e) {

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e) {
            try {
                using (var setrss = XmlWriter.Create("setrss.xml")) {
                    var serializer = new XmlSerializer(dic.GetType());
                    serializer.Serialize(setrss, dic);
                }
            }
            catch (Exception ex) {
                Console.WriteLine(ex.Message);
                throw;
            }
        }
    }
}

