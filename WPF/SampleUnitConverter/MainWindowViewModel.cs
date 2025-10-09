using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SampleUnitConverter
{
    internal class MainWindowViewModel : ViewModel
    {
        private double metricValue;
        private double imperialValue;

        //▲で呼ばれる
        public ICommand ImperialUnitToMetric { get; private set; }
        //▼で呼ばれる
        public ICommand MetricToImperialUnit { get; private set; }

        //上のcomboboxの選択されている値
        public MetricUnit CurrentMetricUnit { get; set; }
        //下のcomboboxの選択されている値
        public ImperialUnit CurrentImperialUnit { get; set; }

        public double MetricValue {
            get => metricValue;
            set {
                this.metricValue = value;
                this.OnPropertyChanged();
            }
        }

        public double Imperalvalue {
            get => imperialValue;
            set {
                this.imperialValue = value;
                this.OnPropertyChanged();
            }
        }

        public MainWindowViewModel() {

            CurrentMetricUnit = MetricUnit.Units.First();
            CurrentImperialUnit = ImperialUnit.Units.First();

            ImperialUnitToMetric = new DelegateCommand(
                () => MetricValue = 
                CurrentMetricUnit.FromImperialUnit(CurrentMetricUnit, imperialValue));

            MetricToImperialUnit = new DelegateCommand(
                () => Imperalvalue =
                CurrentImperialUnit.FromMetricUnit(CurrentMetricUnit, metricValue));

        }
    }
}
