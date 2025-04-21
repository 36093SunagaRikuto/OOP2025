namespace ProductSample{
    internal class Program{
        static void Main(string[] args) {

            Product karinto = new Product(123,"かりんとう", 180);
            Product daifuku = new Product(124,"大福", 100);




            //税抜きの価格を表示
            Console.WriteLine(daifuku.Name + "の税抜き価格は" + daifuku.Price + "円です");

            //消費税額の表示
            Console.WriteLine(daifuku.Name + "の消費税額は" + daifuku.ToString() + "円です");

            //税込みの価格の表示
            Console.WriteLine(karinto.Name + "の税込み価格は" + karinto.GetPriceIncludingTax() + "円です");

        }
    }
}
