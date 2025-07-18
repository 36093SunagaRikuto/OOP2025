using System.Net;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace RssReader {
    public partial class Form1 : Form {

        private List<ItemData> items;

        public Form1() {
            InitializeComponent();
        }

        private async void btRssGet_Click(object sender, EventArgs e) {
            //RSS‚ð‰ðÍ‚µ‚Ä•K—v‚È—v‘f‚ðŽæ“¾‚·‚é
            lbTitles.Items.Clear();
            using (var wc = new HttpClient()) {
                //var url = wc.OpenRead(tburl.Text);

                var xml = await wc.GetStringAsync(tburl.Text);
                XDocument xdoc = XDocument.Parse(xml);

                items = xdoc.Root.Descendants("item")
                    .Select(x =>
                        new ItemData {
                            Title = (string)x.Element("title"),
                            Link = (string)x.Element("link"),
                        }).ToList();

                items.ForEach(x => lbTitles.Items.Add($"{x.Title}    :    {x.Link}"));
                
            }

            

        }
    }
}

