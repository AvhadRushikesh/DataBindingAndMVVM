using DataBindingPractice.MVVM.ViewModels;

namespace DataBindingPractice.MVVM.Views;

public partial class SQLTest : ContentPage
{
	public SQLTest()
	{
		InitializeComponent();
		BindingContext = new SQLiteTestViewModel();
	}
}