using DataBindingPractice.MVVM.ViewModels;

namespace DataBindingPractice.MVVM.Views;

public partial class PeopleView : ContentPage
{
	public PeopleView()
	{
		InitializeComponent();

		BindingContext = new PeopleViewModel();
	}
}