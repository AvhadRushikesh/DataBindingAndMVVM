using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace DataBindingPractice.MVVM.ViewModels
{
    public class CommandsViewModel
    {
        public ICommand ClickCommand { get; }

        public ICommand SearchCommand { get; }

        public string SearchTerm { get; set; }


        public CommandsViewModel()
        {
            ClickCommand = new Command(() =>
            {
                App.Current.MainPage
                .DisplayAlert("Title", "Message", "Ok");
            });

            SearchCommand = new Command(() =>
            {
                var data = SearchTerm;
            });
        }
    }
}
