using DataBindingPractice.Models;

namespace DataBindingPractice;

public partial class MainPage : ContentPage
{

	Person person = new Person();

	public MainPage()
	{
		InitializeComponent();

        var person = new Person
        {
            Name = "John",
            Phone = "9999",
            Address = "X Address"
        };

        BindingContext = person;
    }

	private void OnCounterClicked(object sender, EventArgs e)
	{
        person.Name = "Peter";
        person.Phone = "0000";
        person.Address = "New Address";


	}
}