using DataBindingPractice.MVVM.Models;

namespace DataBindingPractice.MVVM.ViewModels
{
    public class PersonViewModel
    {
        public Person person { get; set; }

        public PersonViewModel()
        {
            person = new Person
            {
                Name = "Hector",
                Age = 100
            };
        }
        
    }
}
