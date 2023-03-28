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
        public ICommand ClickCommand =>
            new Command(Alert);


        private void Alert()
        {
            App.Current.MainPage.DisplayAlert("Title", "Message", "Ok");
        }
    }
}
