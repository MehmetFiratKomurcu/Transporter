using Transporter.CouchbaseAdapter.ConfigOptions.Target.Interfaces;
using Transporter.CouchbaseAdapter.Utils;

namespace Transporter.CouchbaseAdapter.ConfigOptions.Target.Implementations
{
    public class CouchbaseTargetOptions : ICouchbaseTargetOptions
    {
        public ConnectionData ConnectionData { get; set; }
        public string Bucket { get; set; }
        public long BatchQuantity { get; set; }
        public string Condition { get; set; }
    }
}