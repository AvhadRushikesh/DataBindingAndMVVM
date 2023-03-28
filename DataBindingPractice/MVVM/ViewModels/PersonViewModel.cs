using DataBindingPractice.MVVM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBindingPractice.MVVM.ViewModels
{
    public class PersonViewModel
    {
        public PersonViewModel()
        {
            var person = new Person
            {
                Name = "Hector",
                Age = 100
            };
        }
        
    }
}
