using Transporter.CouchbaseAdapter.Utils;

namespace Transporter.CouchbaseAdapter.ConfigOptions.Source.Interfaces
{
    public interface ICouchbaseSourceOptions
    {
        public ConnectionData ConnectionData { get; set; }
        public string Bucket { get; set; }
        public long BatchQuantity { get; set; }
        public string Condition { get; set; }
    }
}