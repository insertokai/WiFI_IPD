using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using NativeWifi;
using SimpleWifi;

namespace Wifi
{
    internal class WiFiSearcher
    {
        private readonly SimpleWifi.Wifi _wifi;
        private WlanClient _wlanClient;

        public WiFiSearcher()
        {
            _wifi = new SimpleWifi.Wifi();
            _wlanClient = new WlanClient();
        }

        public List<WiFi> GetWiFis()
        {
            var wiFis = new List<WiFi>();
            var accessPoints = _wifi.GetAccessPoints();
            foreach (var accessPoint in accessPoints)
                wiFis.Add(new WiFi(accessPoint.Name,
                    accessPoint.SignalStrength.ToString() + "%",
                    GetMAC(accessPoint),
                    accessPoint.ToString().Split()[6],
                    accessPoint.IsSecure,
                    accessPoint.IsConnected)
                );
            return wiFis;
        }

        private List<string> GetMAC(AccessPoint accessPoint)
        {
            var wlanInterface = _wlanClient.Interfaces.FirstOrDefault();
            return wlanInterface?.GetNetworkBssList()
                .Where(x => Encoding.ASCII.GetString(x.dot11Ssid.SSID, 0, (int) x.dot11Ssid.SSIDLength)
                    .Equals(accessPoint.Name))
                .Select(y => MACToString(y)).ToList();
        }

        private string MACToString(Wlan.WlanBssEntry entry)
        {
            var MACBuilder = new StringBuilder();
            foreach (var mByte in entry.dot11Bssid)
            {
                MACBuilder.Append(mByte.ToString("X"));
                MACBuilder.Append("-");
            }
            MACBuilder.Remove(MACBuilder.Length - 1, 1);
            return MACBuilder.ToString();
        }
       
        
    }
}
