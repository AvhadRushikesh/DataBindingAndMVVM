using DataBindingPractice.MVVM.Views;

namespace DataBindingPractice;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new PeopleView();
	}
}