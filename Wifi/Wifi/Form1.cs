using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wifi
{
    public partial class Form1 : Form
    {
        private readonly WiFiSearcher _seacher = new WiFiSearcher();
        private List<WiFi> wiFis;
        private bool inProcess = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateWiFiList();
            buttonConnect.Enabled = false;
            Password.Enabled = false;
            timer1.Enabled = false;
        }

        private void UpdateWiFiList()
        {
            wiFis = _seacher.GetWiFis();
            listViewWifi.Items.Clear();
            foreach (var wiFi in wiFis)
            {
                var item = new ListViewItem(wiFi.Name);
                item.SubItems.Add(wiFi.GetMAC());
                item.SubItems.Add(wiFi.Strength);
                item.SubItems.Add(wiFi.AuthType);
                listViewWifi.Items.Add(item);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!inProcess)
                UpdateWiFiList();
        }

        private void listViewWifi_MouseClick(object sender, MouseEventArgs e)
        {
            if (wiFis[listViewWifi.SelectedItems[0].Index].IsConnected)
            {
                buttonConnect.Enabled = false;
                Password.Clear();
                timer1.Enabled = false;
                Status.Text = "Connected";
            }
            else
            {
                Status.Text = "Available";
                Password.Enabled = wiFis[listViewWifi.SelectedItems[0].Index].IsSecured;
                buttonConnect.Enabled = true;
            }
            
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            if (Password.Text.Length > 0)
                if (wiFis[listViewWifi.SelectedItems[0].Index].Connect(Password.Text))
                {
                    Status.Text = "Connected";
                    Password.Enabled = false;
                    buttonConnect.Enabled = false;
                    listViewWifi.SelectedItems[0].Selected = false;
                }
                else
                {
                    Status.Text = "Error";
                }
            inProcess = false;
        }

        private void Password_MouseClick(object sender, MouseEventArgs e)
        {
            inProcess = false;
        }
    }
}


  
                
              