using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace MultiShop.Catalog.Entities
{
	public class Product
	{
        //MongoDB de ilişkisel veritabanı yok o yüzden id olduğunu altaki şekilde yazmalıyız.

        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]

        public string ProductID { get; set; }
        public string ProductName { get; set; }
        public decimal ProductPrice { get; set; }

        public string ProductImageUrl { get; set; }
        public string ProductDescription { get; set; }

        public string CategoryId { get; set; }

        [BsonIgnore] //NEDİR NEDEN KULLANDIK AÇIKLA= niteliği, belirli veri alanlarını yönetmenizi sağlarken, MongoDB de esneklik ve performans sunarak modern uygulamalarda tercih edilir.
        public Category Category { get; set; }
    }
}

