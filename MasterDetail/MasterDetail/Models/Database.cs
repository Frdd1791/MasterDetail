using System;
using System.Collections.Generic;
using System.Text;

namespace MasterDetail.Models
{
    using SQLite;
    using Models;
    using System.Threading.Tasks;

    public class Database
    {
        readonly SQLiteAsyncConnection _database;

        public Database(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<Item>().Wait();
        }

        public Task<List<Item>> GetIngresosAsync()
        {
            return _database.Table<Item>().ToListAsync();
        }

        public Task<int> SaveIngresosAsync(Item item)
        {
            return _database.InsertAsync(item);
        }
    }
}
