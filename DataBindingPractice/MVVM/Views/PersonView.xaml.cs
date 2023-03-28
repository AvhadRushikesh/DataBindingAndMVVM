using DataBindingPractice.MVVM.Models;

namespace DataBindingPractice.MVVM.Views;

public partial class PersonView : ContentPage
{
	public PersonView()
	{
		InitializeComponent();
		var person = new Person();
	}
}