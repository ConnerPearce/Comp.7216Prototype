using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comp._7216Prototype.Database_Files
{
    public class DataService
    {
        private IMongoDatabase db;

        public DataService()
        {
            var client = new MongoClient("mongodb+srv://admin:admin@prototype-iuehj.mongodb.net/");
            db = client.GetDatabase("prototypedatabase");
        }

        // GET METHODS //

        // Gets a record by id
        public async Task<T> GetRecordByIdAsync<T>(string collection, string id)
        {
            var itemId = new ObjectId(id);
            var item = db.GetCollection<T>(collection);
            var filter = Builders<T>.Filter.Eq("_id", itemId);

            return await item.Find(filter).FirstOrDefaultAsync();
        }

        // Gets multiple items by foreign key ID
        public async Task<IEnumerable<T>> GetMultipleByID<T>(string id, string collection, string foreignKey)
        {
            var items = db.GetCollection<T>(collection);
            var filter = Builders<T>.Filter.Eq(foreignKey, id);

            return await items.Find(filter).ToListAsync();
        }

        // UPDATE METHODS //

        // Updates a record by ID
        public async Task<bool> UpdateAsync<T>(string id, T item, string collection)
        {
            var itemId = new ObjectId(id);
            var temp = db.GetCollection<T>(collection);
            var filter = Builders<T>.Filter.Eq("_id", itemId);
            var result = await temp.ReplaceOneAsync(
                filter,
                item,
                new ReplaceOptions { IsUpsert = true }
                );

            return result.IsAcknowledged && result.ModifiedCount > 0;
        }

        // CREATE METHODS //

        // Inserts a new record
        public async Task InsertAsync<T>(T item, string collection)
        {
            var temp = db.GetCollection<T>(collection);
            await temp.InsertOneAsync(item);
        }

        // DELETE METHODS //

        // Deletes a record by id
        public async Task<bool> DeleteAsync<T>(string id, string collection)
        {
            var itemId = new ObjectId(id);
            var item = db.GetCollection<T>(collection);
            var filter = Builders<T>.Filter.Eq("_id", itemId);

            if (item == null)
                return false;

            var result = await item.DeleteOneAsync(filter);

            return result.IsAcknowledged && result.DeletedCount > 0;
        }

    }
}
