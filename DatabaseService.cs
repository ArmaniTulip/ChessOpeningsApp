using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpeningsApp
{
    public class DatabaseService
    {
        private readonly SQLiteAsyncConnection _database;

        public DatabaseService(string dbPath)
        {
            if (File.Exists(dbPath))
            {
                _database = new SQLiteAsyncConnection(dbPath, SQLiteOpenFlags.ReadWrite);
            }
            else 
            {
                _database = new SQLiteAsyncConnection(dbPath);
            }

            
            _database.CreateTableAsync<UserClass>().Wait();
        }

        public Task<int> RegisterUserAsync(UserClass user)
        {
            return _database.InsertAsync(user);
        }

        public Task<UserClass> LoginUserAsync(string email, string password)
        {
            return _database.Table<UserClass>().FirstOrDefaultAsync(u => u.Email == email && u.Password == password);
        }

        public Task<UserClass> GetUserByEmailAsync(string email)
        {
            return _database.Table<UserClass>().FirstOrDefaultAsync(u => u.Email == email);
        }
    }
}
