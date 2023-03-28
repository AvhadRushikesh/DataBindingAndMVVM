using DataBindingPractice.MVVM.ViewModels;

namespace DataBindingPractice.MVVM.Views;

public partial class ConverterView : ContentPage
{
	public ConverterView()
	{
		InitializeComponent();

		BindingContext = new ConverterViewModel();
    }
}