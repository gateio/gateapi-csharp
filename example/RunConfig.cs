using System;
using CommandLine;

namespace GateApiDemo
{
    public class RunConfig
    {
        public RunConfig()
        {
        }

        public RunConfig(string key, string secret, string url)
        {
            this.ApiKey = key;
            this.ApiSecret = secret;
            this.HostUsed = url;
        }

        [Option('k', "key", Required = true, HelpText = "Gate APIv4 key")]
        public string ApiKey { get; set; }
        
        [Option('s', "secret", Required = true, HelpText = "Gate APIv4 secret")]
        public string ApiSecret { get; set; }

        private string _hostUsed;

        [Option('u', "url", Required = false, HelpText = "Optional API base url used")]
        public string HostUsed
        {
            get { return _hostUsed; }
            private set
            {
                _hostUsed = value;
                if (string.IsNullOrWhiteSpace(_hostUsed))
                {
                    _hostUsed = "https://api.gateio.ws/api/v4";
                }

                if (!_hostUsed.StartsWith("http"))
                {
                    _hostUsed = "https://" + _hostUsed;
                }

                if (!_hostUsed.EndsWith("/api/v4"))
                {
                    _hostUsed += "/api/v4";
                }
                UseTestNet = "fx-api-testnet.gateio.ws".Equals(new Uri(_hostUsed).Host);
            }
        }

        public bool UseTestNet { get; private set;  }

        [Value(0, Required = true, HelpText = "Demo to run. Available demos: spot, margin, or futures")]
        public string Demo { get; set; }
    }
}