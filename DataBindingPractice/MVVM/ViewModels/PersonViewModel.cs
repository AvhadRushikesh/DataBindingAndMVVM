using DataBindingPractice.MVVM.Models;

namespace DataBindingPractice.MVVM.ViewModels
{
    public class PersonViewModel
    {
        public Person person { get; set; }
        public Teacher teacher { get; set; }


        public PersonViewModel()
        {
            person = new Person
            {
                Name = "Hector",
                Age = 100,
                Phone = 9999,
                Address = "New Address",
                Technology = "MAUI"
            };

            teacher = new Teacher
            {
                ID = 1,
                Name = "Sanjay",
                Subject = "English",
                Phone = 783788
            };
        }
    }
}
