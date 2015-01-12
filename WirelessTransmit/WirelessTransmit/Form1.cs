using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;//网络
using System.Net.Sockets;//套接字
using System.Windows.Forms.DataVisualization.Charting;//图表控件
using System.Threading;//线程
using System.Text.RegularExpressions;//正则表达式

namespace WirelessTransmit
{
    public partial class Form1 : Form
    {
        Thread threadWatch = null;
        Socket socketWatch = null;
        Socket socketConnection = null;

        IPAddress clientIP; //访问客户端的IP
        int clientPort; //访问客户端的端口号

        public const int SendBufferSize = 2 * 1024;
        public const int ReceiveBufferSize = 8 * 1024;

        public double temperature;
        public double humidity;
        Queue<double> temperatureQueue = new Queue<double>();
        Queue<double> humidityQueue = new Queue<double>();

        public Form1()
        {
            InitializeComponent();
            InitChart();
            chartDisplay();
            TextBox.CheckForIllegalCrossThreadCalls = false;
        }

        private void InitChart()
        {
            int i;
            for (i = 0; i <= chart1.ChartAreas[0].AxisX.Maximum;i++ )
            {
                temperatureQueue.Enqueue(0);
                humidityQueue.Enqueue(0);
            }
            chartUpdateTimer.Enabled = true;
            chartUpdateTimer.Start();

           //chart1.ChartAreas[0].AxisX.Enabled = AxisEnabled.True;
           //chart1.ChartAreas[0].AxisY.Enabled = AxisEnabled.True;
        }
        
        private void receiveData()
        {
            while (true)
            {
                try
                {
                    socketConnection = socketWatch.Accept();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message); //提示套接字监听异常
                    break;
                }
                clientIP = (socketConnection.RemoteEndPoint as IPEndPoint).Address;//获取访问客户端的IP
                clientPort = (socketConnection.RemoteEndPoint as IPEndPoint).Port;//获取访问客户端的Port
                ParameterizedThreadStart pts = new ParameterizedThreadStart(ServerRecMsg);//创建通信线程 
                Thread thread = new Thread(pts);
                thread.IsBackground = true;
                thread.Start(socketConnection);//启动线程
                msgBox.AppendText("IP: " + clientIP + " Port: " + clientPort + " 的客户端与您连接成功,现在你们可以开始通信了...\r\n");
            }
        }
        /// 获取本地IPv4地址
        private IPAddress GetLocalIPv4Address()
        {
            IPAddress localIPv4 = null;
            IPAddress[] ipAddressList = Dns.GetHostAddresses(Dns.GetHostName());//获取本机所有的IP地址列表
            foreach (IPAddress ipAddress in ipAddressList)
            {
                //判断是否是IPv4地址
                if (ipAddress.AddressFamily == AddressFamily.InterNetwork) //AddressFamily.InterNetwork表示IPv4 
                {
                    localIPv4 = ipAddress;
                }
                else
                    continue;
            }
            return localIPv4;
        }

        private void OpenConnection_Click(object sender, EventArgs e)
        {
            //定义一个套接字用于监听客户端发来的信息  包含3个参数(IP4寻址协议,流式连接,TCP协议)
            socketWatch = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            //发送信息 需要1个IP地址和端口号
            //获取服务端IPv4地址
            IPAddress ipAddress = GetLocalIPv4Address();
            ipText.Text=ipAddress.ToString(); 
            int port = 8000;//开启的本地端口号
            portText.Text = port.ToString();
            IPEndPoint endpoint = new IPEndPoint(ipAddress, port);//将IP地址和端口号绑定到网络节点endpoint上 
            socketWatch.Bind(endpoint);//将负责监听的套接字绑定网络端点
            socketWatch.Listen(20);//将套接字的监听队列长度设置为20
            threadWatch = new Thread(receiveData);//创建一个负责监听客户端的线程 
            threadWatch.IsBackground = true;//将窗体线程设置为与后台同步
            threadWatch.Start();//启动线程
            msgBox.AppendText("服务器已经启动,开始监听客户端传来的信息!" + "\r\n");
            OpenConnection.Enabled = false;
            CloseConnection.Enabled = true;
        }

        private void CloseConnection_Click(object sender, EventArgs e)
        {
            socketWatch.Close();
            //socketWatch = null;
            threadWatch.DisableComObjectEagerCleanup();
            OpenConnection.Enabled = true;
            CloseConnection.Enabled = false;
        }

        /// 接收客户端发来的信息
        private void ServerRecMsg(object socketClientPara)
        {
            Socket socketServer = socketClientPara as Socket;
            bool temperatureStart=false;
            
            while (true)
            {
                int dataCount = 0;
                byte[] buffer = new byte[ReceiveBufferSize];
                try
                {
                    //获取接收的数据,并存入内存缓冲区  返回一个字节数组的长度
                    if (socketServer != null) dataCount = socketServer.Receive(buffer);
                    if (dataCount > 0) 
                    {
                        string sourceStr;
                        sourceStr=System.Text.Encoding.Default.GetString(buffer);
                        dataSolution(sourceStr);
                        //msgBox.AppendText(System.Text.Encoding.Default.GetString(buffer));
                        //msgBox.AppendText("\n");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    break;
                }
                
                




            }
        }
        public void dataSolution(string source)
        {
            string patternHT=@"[HT]:[0-9]{1,2}.[0-9]{2,3}";
            string temp;
            Regex regHT = new Regex(patternHT, RegexOptions.IgnoreCase);
            Match m = regHT.Match(source);
            while(m.Success)
            {
                msgBox.AppendText(m.Groups[0].ToString());
                temp = m.Groups[0].ToString();
                if (temp[0]=='H'||temp[0]=='h')
                {
                    temp = temp.Substring(2, temp.Length - 2);
                    humidity = double.Parse(temp);
                }
                if (temp[0] == 'T' || temp[0] == 't')
                {
                    temp = temp.Substring(2, temp.Length - 2);
                    temperature = double.Parse(temp);
                }
                m = m.NextMatch();
            }


        }
        public void chartDisplay()
        {
            int i;
            for (i=0;i<temperatureQueue.Count;i++)
            {
                chart1.Series[0].Points.AddXY(i,temperatureQueue.ElementAt(i));
                chart1.Series[1].Points.AddXY(i,humidityQueue.ElementAt(i));

            }



        }

        private void chartUpdateTimer_Tick(object sender, EventArgs e)
        {
            temperatureQueue.Enqueue(temperature);
            humidityQueue.Enqueue(humidity);

            temperatureQueue.Dequeue();
            humidityQueue.Dequeue();

            chart1.Series[0].Points.Clear();
            chart1.Series[1].Points.Clear();

            chartDisplay();

        }





    }


}
