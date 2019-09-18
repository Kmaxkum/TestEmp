using Newtonsoft.Json;

namespace TestEml
{
    class Pack
    {
        [JsonProperty("Token")]
        public string Token { get; set; }

        [JsonProperty("LockStatus")]
        public bool LockStatus { get; set; }

        [JsonProperty("PowerStatus")]
        public bool PowerStatus { get; set; }

        [JsonProperty("NetStatus")]
        public bool NetStatus { get; set; }
    }
}
