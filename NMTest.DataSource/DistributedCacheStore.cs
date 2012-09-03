using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace NMTest.DataSource
{
    public class DistributedCacheStore
    {
        Dictionary<string, object> _Values = new Dictionary<string, object>();
        
        public object GetValue(string key)
        {
            //simulates 5 ms roundtrip to the distributed cache
            Thread.Sleep(5);
            object value;
            if (_Values.TryGetValue(key, out value))
            {
                return value;
            }
            return null;
        }

        public void StoreValue(string key, object value)
        {
            //simulates 5 ms roundtrip to the distributed cache
            Thread.Sleep(5);
            _Values[key] = value;
        }
    }
}
