using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NRCan.Datahub.Shared.Data
{
    public class StorageMetadata
    {
        public string AccountName { get; set; }
        public string Url { get; set; }
        public string StorageAccountType { get; set; }
        public string GeoRedundancy { get; set; }
        public string Versioning { get; set; }
        public string Container { get; set; }
        
    }
}
