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
using System.Windows.Forms.DataVisualization.Charting;



namespace WirelessTransmit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitChart();
        }

        private void InitChart()
        {
            //chart1.ChartAreas.
            //List<double>[] listX=new List<double>[1];
            //List<double>[] listY=new List<double>[1];
            //chart1.Series[0].Points.DataBindXY(listX, listY);
            //chart1.Series[0].Points.DataBindY(listY);


            //chart1.ChartAreas["mainChart"].Points;
            for (int i = 0; i < 10; i++)
            {
                chart1.Series["Temperature"].Points.AddXY(i, i*i);
            }
            //chart1.Show();
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

        private void timer1_Tick(object sender, EventArgs e)
        {

        }



    }


}
