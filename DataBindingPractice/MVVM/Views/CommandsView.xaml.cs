using DataBindingPractice.MVVM.ViewModels;

namespace DataBindingPractice.MVVM.Views;

public partial class CommandsView : ContentPage
{
	public CommandsView()
	{
		InitializeComponent();

		BindingContext = new CommandsViewModel();
	}
}