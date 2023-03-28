using DataBindingPractice.MVVM.ViewModels;

namespace DataBindingPractice.MVVM.Views;

public partial class PersonView : ContentPage
{
	public PersonView()
	{
		InitializeComponent();

		BindingContext = new PersonViewModel();
	}
}