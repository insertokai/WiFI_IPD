using System.Collections.Generic;
using System.Linq;
using System.Text;
using SimpleWifi;

namespace Wifi
{
    internal class WiFi
    {
        public string Name { get; set; }
        public string Strength { get; set; }
        public List<string> MAC { get; set; }
        public string AuthType { get; set; }
        public bool IsSecured { get; set; }
        public bool IsConnected { get; set; }

        public WiFi(string name, string strength, List<string> mac, string authType, bool isSecured, bool isConnected)
        {
            Name = name;
            Strength = strength;
            MAC = mac;
            AuthType = authType;
            IsSecured = isSecured;
            IsConnected = isConnected;
        }

        public bool Connect(string password)
        {
            var wifi = new SimpleWifi.Wifi();
            var accessPoint = wifi.GetAccessPoints().FirstOrDefault(x => x.Name.Equals(Name));
            if (accessPoint != null)
            {
                var authRequest = new AuthRequest(accessPoint);
                authRequest.Password = password;
                return accessPoint.Connect(authRequest);
            }
            return false;
        }

        public string GetMAC()
        {
            var builder = new StringBuilder();
            foreach (var symbol in MAC)
                builder.Append(symbol + "\r\n");
            return builder.ToString();
        }
    }
}
//lvItem.SubItems.Add(Regex.Match(ap.GetProfileXML(), "(?<=<authentication>).*(?=<\\/authentication>)").Value);