using System.Globalization;

namespace Session01 {
    internal class Program {
        static void Main(string[] args) {

            var today = new DateTime(2005, 7, 12);
            var now = DateTime.Now;


            Console.WriteLine($"Today is {today}");
            Console.WriteLine($"Now is {now}");
            Console.WriteLine((now - today).Days);
            Console.WriteLine("\n");

            Console.WriteLine("西暦を入力してください");
            int seireki = int.Parse(Console.ReadLine());

            Console.WriteLine("月を入力してください");
            int month = int.Parse(Console.ReadLine());

            Console.WriteLine("日にちを入力してください");
            int day = int.Parse(Console.ReadLine());

            //mybirthday(seireki, month, day);//①自分の生年月日は何曜日かをプログラムで調べる
            usoyear(seireki); //②うるう年の判定プログラム
            //from();       //③生まれてから何日目か
            //yours();
            first();


        }

            //①自分の生年月日は何曜日かをプログラムで調べる
        private static void mybirthday(int seireki, int month, int day) {
            /*
                Console.WriteLine("西暦を入力してください");
                int seireki = int.Parse(Console.ReadLine());

                Console.WriteLine("月を入力してください");
                int month = int.Parse(Console.ReadLine());

                Console.WriteLine("日にちを入力してください");
                int day = int.Parse(Console.ReadLine());
            */

                var birthday = new DateTime(seireki, month, day);

                var youbi = new CultureInfo("ja-JP");
                Console.WriteLine($"{seireki}年{month}月{day}日は{youbi.DateTimeFormat.GetShortestDayName(birthday.DayOfWeek)}曜日です");
            }

        private static void usoyear(int seireki) {
            //②うるう年の判定プログラム

            

            if (DateTime.IsLeapYear(seireki))
                Console.WriteLine($"{seireki}年はうるう年です。");
            else
                Console.WriteLine($"{seireki}年はうるう年ではありません。");

        
        }

        //③生まれてから何日目か
        private static void from(int seireki, int month, int day) {
            

            var birthday = new DateTime(seireki, month, day);

            TimeSpan i = DateTime.Now - birthday;
            if (DateTime.Now > birthday)
                
                Console.WriteLine($"入力された日から{(DateTime.Now - birthday).Days}日経っています。");
            else
                Console.WriteLine($"入力された日から{(birthday - DateTime.Now).Days}日経っています。");


        }

        //④あなたは○○歳です。
        private static void yours() {

            Console.Write("西暦:");
            int seireki = int.Parse(Console.ReadLine());

            Console.Write("月:");
            int month = int.Parse(Console.ReadLine());

            Console.Write("日:");
            int day = int.Parse(Console.ReadLine());

            var birthday = new DateTime(seireki, month, day);

            var age = DateTime.Today.Year - birthday.Year;

            if (DateTime.Today < birthday.AddYears(age))
                age--;

            Console.WriteLine("あなたは" + age + "歳です。");
            
        }

        private static void first() {

            Console.WriteLine($"1月1日から{DateTime.Today.DayOfYear}日経っています。");
        }


    }
}
