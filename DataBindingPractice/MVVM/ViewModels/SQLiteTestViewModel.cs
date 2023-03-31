using DataBindingPractice.MVVM.Models;
using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace DataBindingPractice.MVVM.ViewModels
{
    [AddINotifyPropertyChangedInterface]
    public class SQLiteTestViewModel
    {
        private static string _addressEntry;
        private static string _nameEntry;

        public List<Customer> customers { get; set; }

        public static Customer CurrentCustomer { get; set; }

        public string AddressEntry
        {
            get => _addressEntry;
            set
            {
                _addressEntry = value;
            }
        }
        public string NameEntry
        {
            get => _nameEntry;
            set
            {
                _nameEntry = value;
            }
        }

        public ICommand AddOrUpdateCommand =>
            new Command(async () =>
            {
                AddUpdateCustomer();
                App._customerRepo.AddOrUpdate(CurrentCustomer);
                Console.WriteLine(App._customerRepo.StatusMsg);
            });

        public static Customer AddUpdateCustomer()
        {
            CurrentCustomer = new Customer
            {
                ID = 1,
                Name = _nameEntry,
                Address = _addressEntry
            };
            return CurrentCustomer;
        }

        public SQLiteTestViewModel()
        
        {
            GetAll();
        }

        private void GetAll()
        {
            customers = App._customerRepo.GetAll();
        }
    }
}
