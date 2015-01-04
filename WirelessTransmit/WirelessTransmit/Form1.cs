using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace WirelessTransmit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void OpenConnection_Click(object sender, EventArgs e)
        {
            TcpListener server = null;
            Int32 port ;
            string[] source=new string[2];
            try
            {
                source = IPText.Text.Split(':');
                port = Convert.ToInt32(source[1]);
                IPAddress localAddr = IPAddress.Parse(source[0]);
                server = new TcpListener(localAddr, port);




                IPText.Enabled = false;
            }
            catch (Exception)
            {
                MessageBox.Show("请输入IP地址");
            }

        }

        private void CloseConnection_Click(object sender, EventArgs e)
        {
            IPText.Enabled = true;
        }


    }
}
