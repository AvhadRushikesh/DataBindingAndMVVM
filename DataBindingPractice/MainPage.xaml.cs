using DataBindingPractice.Models;

namespace DataBindingPractice;

public partial class MainPage : ContentPage
{
	

	public MainPage()
	{
		InitializeComponent();
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
		var person = new Person
		{
			Name = "John",
			Phone = "9999",
			Address = "X Address"
		};

		txtName.BindingContext = person;
		txtName.SetBinding(Label.TextProperty, "Name");


	}
}