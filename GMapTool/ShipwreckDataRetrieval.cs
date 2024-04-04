using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GMapTool
{
    internal class ShipwreckDataRetrieval
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("feature_type")]
        public string FeatureType { get; set; }

        [BsonElement("coordinates")]
        public List<double> Coordinates { get; set; }
    }
}
