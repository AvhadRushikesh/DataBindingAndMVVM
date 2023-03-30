using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBindingPractice.Repositories
{
    public class CustomerRepository
    {
        SQLiteConnection conn;

        public CustomerRepository()
        {
            conn = new SQLiteConnection(Constants.DatabasePath, Constants.Flags);
        }
    }
}
