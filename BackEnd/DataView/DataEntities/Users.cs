using System;
using MongoDB.Bson.Serialization.Attributes;
namespace DataView.DataEntities
{
    public class Users
    {
        [BsonId]
        public int userID { get; set; }
        public string Username { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int TeleNumber { get; set; }
    }
}
