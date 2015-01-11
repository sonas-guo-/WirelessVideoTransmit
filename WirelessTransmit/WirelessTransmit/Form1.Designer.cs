namespace WirelessTransmit
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.TcpPage = new System.Windows.Forms.TabPage();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.portText = new System.Windows.Forms.TextBox();
            this.portLabel = new System.Windows.Forms.Label();
            this.ipText = new System.Windows.Forms.TextBox();
            this.ipLabel = new System.Windows.Forms.Label();
            this.msgBox = new System.Windows.Forms.TextBox();
            this.CloseConnection = new System.Windows.Forms.Button();
            this.OpenConnection = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.chartUpdateTimer = new System.Windows.Forms.Timer(this.components);
            this.TcpPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TcpPage
            // 
            this.TcpPage.AllowDrop = true;
            this.TcpPage.BackColor = System.Drawing.Color.LightSteelBlue;
            this.TcpPage.Controls.Add(this.chart1);
            this.TcpPage.Controls.Add(this.portText);
            this.TcpPage.Controls.Add(this.portLabel);
            this.TcpPage.Controls.Add(this.ipText);
            this.TcpPage.Controls.Add(this.ipLabel);
            this.TcpPage.Controls.Add(this.msgBox);
            this.TcpPage.Controls.Add(this.CloseConnection);
            this.TcpPage.Controls.Add(this.OpenConnection);
            this.TcpPage.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TcpPage.Location = new System.Drawing.Point(4, 29);
            this.TcpPage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TcpPage.Name = "TcpPage";
            this.TcpPage.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TcpPage.Size = new System.Drawing.Size(1181, 631);
            this.TcpPage.TabIndex = 0;
            this.TcpPage.Text = "Tcp";
            // 
            // chart1
            // 
            this.chart1.AllowDrop = true;
            chartArea2.AxisX.ArrowStyle = System.Windows.Forms.DataVisualization.Charting.AxisArrowStyle.Lines;
            chartArea2.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
            chartArea2.AxisX.Interval = 1D;
            chartArea2.AxisX.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea2.AxisX.LineWidth = 2;
            chartArea2.AxisX.MajorGrid.LineColor = System.Drawing.Color.Gray;
            chartArea2.AxisX.Maximum = 12D;
            chartArea2.AxisX.Minimum = 0D;
            chartArea2.AxisX.ScaleBreakStyle.Enabled = true;
            chartArea2.AxisX.Title = "time/s";
            chartArea2.AxisY.ArrowStyle = System.Windows.Forms.DataVisualization.Charting.AxisArrowStyle.Lines;
            chartArea2.AxisY.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
            chartArea2.AxisY.Interval = 5D;
            chartArea2.AxisY.LineWidth = 2;
            chartArea2.AxisY.MajorGrid.LineColor = System.Drawing.Color.Gray;
            chartArea2.AxisY.Maximum = 45D;
            chartArea2.AxisY.Minimum = -45D;
            chartArea2.AxisY.Title = "temperature/℃";
            chartArea2.CursorY.IsUserEnabled = true;
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Right;
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(371, 4);
            this.chart1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chart1.Name = "chart1";
            this.chart1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.Color = System.Drawing.Color.Red;
            series3.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series3.Legend = "Legend1";
            series3.Name = "Temperature";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series4.Legend = "Legend1";
            series4.Name = "Humidity";
            this.chart1.Series.Add(series3);
            this.chart1.Series.Add(series4);
            this.chart1.Size = new System.Drawing.Size(807, 623);
            this.chart1.TabIndex = 12;
            this.chart1.Text = "chart1";
            this.chart1.TextAntiAliasingQuality = System.Windows.Forms.DataVisualization.Charting.TextAntiAliasingQuality.Normal;
            // 
            // portText
            // 
            this.portText.Location = new System.Drawing.Point(105, 160);
            this.portText.Name = "portText";
            this.portText.ReadOnly = true;
            this.portText.Size = new System.Drawing.Size(97, 27);
            this.portText.TabIndex = 11;
            // 
            // portLabel
            // 
            this.portLabel.Location = new System.Drawing.Point(11, 157);
            this.portLabel.Name = "portLabel";
            this.portLabel.Size = new System.Drawing.Size(92, 30);
            this.portLabel.TabIndex = 10;
            this.portLabel.Text = "端口:";
            this.portLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ipText
            // 
            this.ipText.Location = new System.Drawing.Point(106, 116);
            this.ipText.Name = "ipText";
            this.ipText.ReadOnly = true;
            this.ipText.Size = new System.Drawing.Size(96, 27);
            this.ipText.TabIndex = 9;
            // 
            // ipLabel
            // 
            this.ipLabel.Location = new System.Drawing.Point(7, 112);
            this.ipLabel.Name = "ipLabel";
            this.ipLabel.Size = new System.Drawing.Size(96, 34);
            this.ipLabel.TabIndex = 8;
            this.ipLabel.Text = "本地IP:";
            this.ipLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // msgBox
            // 
            this.msgBox.Location = new System.Drawing.Point(8, 209);
            this.msgBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.msgBox.Multiline = true;
            this.msgBox.Name = "msgBox";
            this.msgBox.Size = new System.Drawing.Size(194, 416);
            this.msgBox.TabIndex = 6;
            // 
            // CloseConnection
            // 
            this.CloseConnection.Location = new System.Drawing.Point(106, 33);
            this.CloseConnection.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CloseConnection.Name = "CloseConnection";
            this.CloseConnection.Size = new System.Drawing.Size(96, 51);
            this.CloseConnection.TabIndex = 4;
            this.CloseConnection.Text = "停止服务";
            this.CloseConnection.UseVisualStyleBackColor = true;
            this.CloseConnection.Click += new System.EventHandler(this.CloseConnection_Click);
            // 
            // OpenConnection
            // 
            this.OpenConnection.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.OpenConnection.Location = new System.Drawing.Point(7, 33);
            this.OpenConnection.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.OpenConnection.Name = "OpenConnection";
            this.OpenConnection.Size = new System.Drawing.Size(96, 51);
            this.OpenConnection.TabIndex = 1;
            this.OpenConnection.Text = "启动服务";
            this.OpenConnection.UseVisualStyleBackColor = true;
            this.OpenConnection.Click += new System.EventHandler(this.OpenConnection_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.TcpPage);
            this.tabControl1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabControl1.Location = new System.Drawing.Point(14, 16);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1189, 664);
            this.tabControl1.TabIndex = 0;
            // 
            // chartUpdateTimer
            // 
            this.chartUpdateTimer.Tick += new System.EventHandler(this.chartUpdateTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1237, 783);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.TcpPage.ResumeLayout(false);
            this.TcpPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage TcpPage;
        private System.Windows.Forms.Button CloseConnection;
        private System.Windows.Forms.Button OpenConnection;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TextBox msgBox;
        public System.Windows.Forms.Label ipLabel;
        private System.Windows.Forms.Label portLabel;
        private System.Windows.Forms.TextBox ipText;
        private System.Windows.Forms.TextBox portText;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Timer chartUpdateTimer;

    }
}

