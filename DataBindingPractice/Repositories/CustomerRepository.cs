using DataBindingPractice.MVVM.Models;
using SQLite;

namespace DataBindingPractice.Repositories
{
    public class CustomerRepository
    {
        SQLiteConnection conn;
        public string StatusMsg { get; set; }
        
        public CustomerRepository()
        {
            conn = new SQLiteConnection(Constants.DatabasePath, Constants.Flags);
            conn.CreateTable<Customer>();
        }

        public void Add(Customer newCustomer)
        {
            int result = 0;
            try
            {
                result = conn.Insert(newCustomer);
                StatusMsg = $"{result} row(s) added";
            }
            catch (Exception ex)
            {
                StatusMsg = $"Error: {ex.Message}";
            }
        }
    }
}
