using DataBindingPractice.MVVM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBindingPractice.MVVM.ViewModels
{
    public class ConverterViewModel
    {
        public Data data { get; set; }

        public ConverterViewModel()
        {
            data = new Data
            {
                Married = "YES"
            };
        }
    }
}
