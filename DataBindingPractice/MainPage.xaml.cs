using DataBindingPractice.Models;

namespace DataBindingPractice;

public partial class MainPage : ContentPage
{
	int count = 0;

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
	}
}