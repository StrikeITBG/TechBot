using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace TechBot
{
   public struct ConfigJson
    {
        [JsonProperty("token")]
        public string Token { get; private set; }

        [JsonProperty("prefix")]
        public string prefix { get; private set; }


    }
}
