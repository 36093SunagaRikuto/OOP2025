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
              
        }


        private string _input1 = "";

        private string _input2 = "";

        private string _result = "";

        public string input1 {
            get => _input1;
            set;
        }
        public string input2 {
            get => _input2;
            set;
        }
        public string result {
            get => _result;
            set;
        }

        
    }
}
