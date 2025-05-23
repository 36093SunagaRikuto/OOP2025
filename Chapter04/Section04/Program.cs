
namespace Section04 {
    internal class Program {
        static void Main(string[] args) {

            #region nullの判定
            string? name = null;

            if (name is null)
                Console.WriteLine("nameはnullです");
            #endregion

            #region null合体演算子
            string code = "12345";
            var message = GetMessage(code) ?? DefaultMessage();
            Console.WriteLine(message);
            #endregion

            #region null条件演算子
            Sale? sale = null;

            int? amount = sale?.Amount;

            Console.WriteLine(amount);

            #endregion

            #region 値の入れ替え
            int a = 10;
            int b = 20;

            Console.WriteLine($"a = {a} b = {b}");

            //(b,a) = (a,b)
            //swapのアルゴリズム(古いやり方)

            //int c = a;
            //a = b;b = c;
            //Console.WriteLine($"a = {a} b = {b}");
            #endregion

            
            string? inputData = Console.ReadLine();

            if(int.TryParse(inputData, out var number)) {
                Console.WriteLine(number);
            } else {
                Console.Write("エラー");
            }

                Console.WriteLine(inputData);

        }

        private static object? DefaultMessage() {
            return "DefaultMessage";
        }

        private static object? GetMessage(string code) {
            return null;
        }
    }

    //売り上げクラス
    public class Sale {
        //店舗名
        public string ShopName { get; set; } = String.Empty;
        //商品カテゴリ
        public string ProductCategory { get; set; } = String.Empty;
        //売上高
        public int Amount { get; set; }


    }
}
