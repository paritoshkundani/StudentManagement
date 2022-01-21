using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace StudentManagement.Models
{

    /*
     * [BsonId] attribute specifies that this is the Id field or property. In this example, the property Id maps to _id field in Mongo document.
     * [BsonRepresentation] attribute automatically converts Mongo data type to a .Net data type and vice-versa. In this example, Mongo data type ObjectId is automatically converted to string datatype and vice-versa.
     * [BsonElement] handle any case or rename issues, for example C# has Name but Mongo has name and C# has IsGraduated while Mongo has graduated
     * [BsonIgnoreExtraElements] instructs the serializer to ignore the extra elements.
     */

    [BsonIgnoreExtraElements]
    public class Student
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; } = String.Empty;

        [BsonElement("name")]
        public string Name { get; set; } = String.Empty;

        [BsonElement("graduated")]
        public bool IsGraduated { get; set; }

        [BsonElement("courses")]
        public string[]? Courses { get; set; }

        [BsonElement("gender")]
        public string Gender { get; set; } = String.Empty;

        [BsonElement("age")]
        public int Age { get; set; }
    }
}
