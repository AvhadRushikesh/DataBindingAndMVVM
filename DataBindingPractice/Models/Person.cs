using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DataBindingPractice.Models
{
    public class Person : INotifyPropertyChanged
    {
        private string _name;

        public string Name
        {
            get => _name; 
            set
            {
                _name = value;
                OnPropertyChanged();
            }
        }

        public string Phone { get; set; }

        public string Address { get; set; }


        public event PropertyChangedEventHandler PropertyChanged;


        protected void OnPropertyChanged([CallerMemberName] string propName = null)
        {
            PropertyChanged?.Invoke(this,
                new PropertyChangedEventArgs(propName));
        }
    }
}
