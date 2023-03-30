using DataBindingPractice.Repositories;

namespace DataBindingPractice;

public partial class App : Application
{
	public static CustomerRepository _customerRepo { get; private set; }

	public App(CustomerRepository repo)
	{
		InitializeComponent();

		_customerRepo = repo;

		MainPage = new MainPage();
	}
}