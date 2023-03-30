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

        public void AddOrUpdate(Customer customer)
        {
            int result = 0;
            try
            {
                if (customer.ID != 0)
                {
                    result = conn.Update(customer);
                    StatusMsg = $"{result} row(s) Updated";
                }
                else
                {
                    result = conn.Insert(customer);
                    StatusMsg = $"{result} row(s) added";
                }               
            }
            catch (Exception ex)
            {
                StatusMsg = $"Error: {ex.Message}";
            }
        }

        //  Select * From Table
        public List<Customer> GetAll()
        {
            try
            {
                return conn.Table<Customer>().ToList();
            }
            catch (Exception ex)
            {
                StatusMsg = $"Error: {ex.Message}";
            }
            return null;
        }

        public Customer Get(int id)
        {
            try
            {
                return conn.Table<Customer>()
                    .FirstOrDefault(x => x.ID == id);
            }
            catch (Exception ex)
            {
                StatusMsg = $"Error: {ex.Message}";
            }
            return null;
        }

        //  Get Executing Query
        public List<Customer> GetAllQuery()
        {
            try
            {
                return conn.Query<Customer>("SELECT * FROM Customers").ToList();
            }
            catch (Exception ex)
            {
                StatusMsg = $"Error: {ex.Message}";
            }
            return null;
        }

        public void Delete(int customerID)
        {
            try
            {
                var customer = Get(customerID);
                conn.Delete(customer);
            }
            catch (Exception ex)
            {
                StatusMsg = $"Error: {ex.Message}";
            }
        }
    }
}
