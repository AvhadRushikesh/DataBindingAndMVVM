using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBindingPractice.Models
{
    public class Person : INotifyPropertyChanged
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
