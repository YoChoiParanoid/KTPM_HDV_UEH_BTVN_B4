using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace SampleAPI.Models
{
	public class Book
	{
		[BsonId] // primary key
		[BsonRepresentation(BsonType.ObjectId)]
		public string? Id { get; set; }

		[BsonElement("Name")]
		public string BookName { get; set; } = null;
		public decimal Price { get; set; }
		public string Category { get; set; } = null;
		public string Author { get; set; } = null;
	}
}
