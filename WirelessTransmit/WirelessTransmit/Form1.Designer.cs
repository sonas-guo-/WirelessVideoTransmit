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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.TcpPage = new System.Windows.Forms.TabPage();
            this.CloseConnection = new System.Windows.Forms.Button();
            this.OpenConnection = new System.Windows.Forms.Button();
            this.IPText = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.TcpPage.SuspendLayout();
            this.tabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // TcpPage
            // 
            this.TcpPage.BackColor = System.Drawing.Color.LightSteelBlue;
            this.TcpPage.Controls.Add(this.chart1);
            this.TcpPage.Controls.Add(this.CloseConnection);
            this.TcpPage.Controls.Add(this.OpenConnection);
            this.TcpPage.Controls.Add(this.IPText);
            this.TcpPage.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TcpPage.Location = new System.Drawing.Point(4, 29);
            this.TcpPage.Name = "TcpPage";
            this.TcpPage.Padding = new System.Windows.Forms.Padding(3);
            this.TcpPage.Size = new System.Drawing.Size(1062, 555);
            this.TcpPage.TabIndex = 0;
            this.TcpPage.Text = "Tcp";
            // 
            // CloseConnection
            // 
            this.CloseConnection.Location = new System.Drawing.Point(97, 127);
            this.CloseConnection.Name = "CloseConnection";
            this.CloseConnection.Size = new System.Drawing.Size(82, 38);
            this.CloseConnection.TabIndex = 4;
            this.CloseConnection.Text = "关闭";
            this.CloseConnection.UseVisualStyleBackColor = true;
            this.CloseConnection.Click += new System.EventHandler(this.CloseConnection_Click);
            // 
            // OpenConnection
            // 
            this.OpenConnection.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.OpenConnection.Location = new System.Drawing.Point(6, 127);
            this.OpenConnection.Name = "OpenConnection";
            this.OpenConnection.Size = new System.Drawing.Size(85, 38);
            this.OpenConnection.TabIndex = 1;
            this.OpenConnection.Text = "打开";
            this.OpenConnection.UseVisualStyleBackColor = true;
            this.OpenConnection.Click += new System.EventHandler(this.OpenConnection_Click);
            // 
            // IPText
            // 
            this.IPText.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.IPText.Location = new System.Drawing.Point(6, 75);
            this.IPText.Name = "IPText";
            this.IPText.Size = new System.Drawing.Size(173, 27);
            this.IPText.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.TcpPage);
            this.tabControl1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1070, 588);
            this.tabControl1.TabIndex = 0;
            // 
            // chart1
            // 
            chartArea4.AxisX.ArrowStyle = System.Windows.Forms.DataVisualization.Charting.AxisArrowStyle.Triangle;
            chartArea4.AxisX.Interval = 1D;
            chartArea4.AxisX.LineWidth = 2;
            chartArea4.AxisX.MajorGrid.LineColor = System.Drawing.Color.Gray;
            chartArea4.AxisX.Maximum = 12D;
            chartArea4.AxisX.Minimum = 0D;
            chartArea4.AxisX.Title = "time/s";
            chartArea4.AxisY.ArrowStyle = System.Windows.Forms.DataVisualization.Charting.AxisArrowStyle.Triangle;
            chartArea4.AxisY.Interval = 5D;
            chartArea4.AxisY.LineWidth = 2;
            chartArea4.AxisY.MajorGrid.LineColor = System.Drawing.Color.Gray;
            chartArea4.AxisY.Maximum = 45D;
            chartArea4.AxisY.Minimum = -45D;
            chartArea4.AxisY.Title = "temperature/℃";
            chartArea4.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea4);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Right;
            legend4.Name = "Legend1";
            this.chart1.Legends.Add(legend4);
            this.chart1.Location = new System.Drawing.Point(217, 3);
            this.chart1.Name = "chart1";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series4.Color = System.Drawing.Color.Red;
            series4.Legend = "Legend1";
            series4.Name = "Temperature";
            this.chart1.Series.Add(series4);
            this.chart1.Size = new System.Drawing.Size(842, 549);
            this.chart1.TabIndex = 5;
            this.chart1.Text = "chart1";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1109, 667);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.TcpPage.ResumeLayout(false);
            this.TcpPage.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage TcpPage;
        private System.Windows.Forms.Button CloseConnection;
        private System.Windows.Forms.Button OpenConnection;
        private System.Windows.Forms.TextBox IPText;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Timer timer1;

    }
}

