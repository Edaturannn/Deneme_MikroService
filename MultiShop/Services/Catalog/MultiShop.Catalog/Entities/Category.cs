using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace MultiShop.Catalog.Entities
{
	public class Category
	{
        //MongoDB de ilişkisel veritabanı yok o yüzden id olduğunu altaki şekilde yazmalıyız.

        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]

        public string CategoryID { get; set; }
        public string CategoryName { get; set; }
    }
}

