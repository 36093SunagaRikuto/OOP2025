using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrismObservesSample
{
    internal class MainWindowViewModel : BindableBase
    {
        public MainWindowViewModel() {
            SumCommand = new DelegateCommand(ExcuteSum);
            
        }
        public DelegateCommand SumCommand { get; }

        //足し算の処理
        private void ExcuteSum() {
            result = (int.Parse(input1) + int.Parse(input2)).ToString();
        }

        //足し算を実行できるか
        private bool canExcuteSum() {
            return int.TryParse(input1, out var a) && int.TryParse(input2, out var b);
        }


        private string _input1 = "";

        private string _input2 = "";

        private string _result = "";

        public string input1 {
            get => _input1;
            set => SetProperty(ref _input1, value);
        }
        public string input2 {
            get => _input2;
            set => SetProperty(ref _input2, value);
        }
        public string result {
            get => _result;
            set => SetProperty(ref _result, value);
        }

        
    }
}
