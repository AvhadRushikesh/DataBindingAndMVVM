using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace DataBindingPractice
{
    public class MainPageViewModel : INotifyPropertyChanged
    {
        private int _number1;
        private int _number2;
        private int _result;

        public int Number1
        {
            get => _number1;
            set
            {
                _number1 = value;
                OnPropertyChanged();
            }
        }
        public int Number2
        {
            get => _number2;
            set
            {
                _number2 = value;
                OnPropertyChanged();
            }
        }
        public int Result
        { 
            get => _result;
            set
            {
                _result = value;
                OnPropertyChanged();
            }
        }

        public ICommand AddCommand =>
            new Command(() => Result = Number1 + Number2);

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propName = null)
        {
            PropertyChanged?.Invoke(this,
                new PropertyChangedEventArgs(propName));
        }
    }
}
