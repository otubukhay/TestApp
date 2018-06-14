using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TGate.Repository
{
    public class Repository
    {
        public static JObject GetData()
        {
            string data = "{id : 1, name : \"Otubu Kay\"}";
            JObject b = JObject.Parse(data);
            return b;
        }
    }
}
