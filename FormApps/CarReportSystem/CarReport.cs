﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarReportSystem
{
    public class CarReport    {

        public enum MakerGroup {
            なし,
            トヨタ,
            日産,
            本田,
            スバル,
            輸入車,
            その他,

        }

        public DateTime Date { get; set; }//日付
        public string Author { get; set; }//記録者
        public MakerGroup maker { get; set; }//メーカー
        public string CarName { get; set; }//車名
        public string Report { get; set; }//レポート
        public Image Picture { get; set; }//画像

    }
}
