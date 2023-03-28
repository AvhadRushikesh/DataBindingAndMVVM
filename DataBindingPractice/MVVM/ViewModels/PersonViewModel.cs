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
                Age = 50,
                Married = true,
                BirthDate = new DateTime(2000, 08, 05),
                Weight = 100,
                Lunchtime = new TimeSpan(10, 0, 0)
            };
        }
    }
}
