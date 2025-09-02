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
            {"主要", "https://news.yahoo.co.jp/rss/topics/top-picks.xml" },
            {"国内", "https://news.yahoo.co.jp/rss/topics/domestic.xml" },
            {"国際", "https://news.yahoo.co.jp/rss/topics/world.xml" },
            {"スポーツ", "https://news.yahoo.co.jp/rss/topics/sports.xml" },
            {"エンタメ", "https://news.yahoo.co.jp/rss/topics/entertainment.xml" },
            {"IT", "https://news.yahoo.co.jp/rss/topics/it.xml" },
            {"科学", "https://news.yahoo.co.jp/rss/topics/science.xml" }

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
            //RSSを解析して必要な要素を取得する
            if (tburl.Text is null || cbBox.Text is null) return;

            using (var wc = new HttpClient()) {
                //var url = wc.OpenRead(tburl.Text);

                var xml = await wc.GetStringAsync(getRssUrl(cbBox.Text));
                XDocument xdoc = XDocument.Parse(xml);

                //RSSを解析して必要な要素を取得
                items = xdoc.Root.Descendants("item")
                    .Select(x =>
                        new ItemData {
                            Title = (string?)x.Element("title"),
                            Link = (string?)x.Element("link"),
                        }).ToList();

                lbTitles.Items.Clear();
                items.ForEach(item => lbTitles.Items.Add(item.Title ?? "データなし"));

            }

        }
        //コンボボックスの文字列をチェックしてアクセス可能なURLを返却
        private string getRssUrl(string url) {

            if (dic.ContainsKey(url)) {
                return dic[url];
            }
            return "https://news.yahoo.co.jp/rss/media/keibalab/all.xml";

        }



        //タイトルを選択したときに呼ばれるイベントハンドラ
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

            //写真追加
            PictureBox pic = new PictureBox();
            pic.Size = new Size(600, 496);
            pic.Location = new Point(10, 300);
            pic.Image = Image.FromFile("C:/Users/infosys/source/repos/OOP2025/yay.jpg");
            this.Controls.Add(pic);

            

        }
        //コンボボックスから選択
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

        //お気に入り登録
        private void byfavorite_Click(object sender, EventArgs e) {

            if (tburl.Text is null || cbBox.Text is null) return;
            //トピック名が既に追加されている
            if (dic.ContainsKey(cbBox.Text)) return;
            //同じURLが既に追加されている
            if (dic.ContainsValue(tburl.Text)) return;

            dic.Add(cbBox.Text, tburl.Text);
            cbBox.Items.Clear();
            dicrss();
            cbBox.Text = null; tburl.Text = null;



        }
        //お気に入り削除
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
            var idx = e.Index;                                                      //描画対象の行
            if (idx == -1) return;                                                  //範囲外なら何もしない
            var sts = e.State;                                                      //セルの状態
            var fnt = e.Font;                                                       //フォント
            var _bnd = e.Bounds;                                                    //描画範囲(オリジナル)
            var bnd = new RectangleF(_bnd.X, _bnd.Y, _bnd.Width, _bnd.Height);     //描画範囲(描画用)
            var txt = (string)lbTitles.Items[idx];                                  //リストボックス内の文字
            var bsh = new SolidBrush(lbTitles.ForeColor);                           //文字色
            var sel = (DrawItemState.Selected == (sts & DrawItemState.Selected));   //選択行か
            var odd = (idx % 2 == 1);                                               //奇数行か
            var fore = Brushes.WhiteSmoke;                                         //偶数行の背景色
            var bak = Brushes.BurlyWood;                                           //奇数行の背景色

            e.DrawBackground();                                                     //背景描画

            //奇数項目の背景色を変える（選択行は除く）
            if (odd && !sel) {
                e.Graphics.FillRectangle(bak, bnd);
            } else if (!odd && !sel) {
                e.Graphics.FillRectangle(fore, bnd);
            }

            //文字を描画
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

