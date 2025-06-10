using System.Security.Cryptography.X509Certificates;

namespace Secton02 {
    internal class Program {
        static void Main(string[] args) {


            var appVer1 = new AppVersion(5, 1);
            var appVer2 = new AppVersion(5, 1);

            Console.WriteLine(appVer1);
            if(appVer1 == appVer2) {
                Console.WriteLine("ひとし");
            } else {
                Console.WriteLine("ひとしくなさし");
            }

        }
    }

    //プライマリーコンストラクタを使ったクラス定義
    public record AppVersion(int Major, int Minor, int Build = 0, int Revision = 0) {
        







        public override string ToString() =>
            $"{Major}.{Minor}.{Build}.{Revision}";
    }

}
