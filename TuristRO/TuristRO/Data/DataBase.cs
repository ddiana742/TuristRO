using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TuristRO.Models;
namespace TuristRO.Data
{
   public class DataBase
    {
        readonly SQLiteAsyncConnection _database;
        public DataBase(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<FavoriteModels>().Wait();
        }
        public Task<List<FavoriteModels>> GetNotesAsync()
        {
            return _database.Table<FavoriteModels>().ToListAsync();
        }
        public Task<FavoriteModels> GetNoteAsync(int id)
        {
            return _database.Table<FavoriteModels>()
            .Where(i => i.ID == id)
            .FirstOrDefaultAsync();
        }
        public Task<int> SaveNoteAsync(FavoriteModels note)
        {
            if (note.ID != 0)
            {
                return _database.UpdateAsync(note);
            }
            else
            {
                return _database.InsertAsync(note);
            }
        }
        public Task<int> DeleteNoteAsync(FavoriteModels note)
        {
            return _database.DeleteAsync(note);
        }
    }
}
