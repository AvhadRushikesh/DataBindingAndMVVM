using DataBindingPractice.Pages;

namespace DataBindingPractice;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new SliderPage();
	}
}
