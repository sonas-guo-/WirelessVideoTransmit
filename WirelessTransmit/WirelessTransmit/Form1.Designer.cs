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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.TcpPage = new System.Windows.Forms.TabPage();
            this.SerialPortPage = new System.Windows.Forms.TabPage();
            this.IPText = new System.Windows.Forms.TextBox();
            this.OpenConnection = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CloseConnection = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.TcpPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.TcpPage);
            this.tabControl1.Controls.Add(this.SerialPortPage);
            this.tabControl1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(845, 588);
            this.tabControl1.TabIndex = 0;
            // 
            // TcpPage
            // 
            this.TcpPage.BackColor = System.Drawing.Color.LightSteelBlue;
            this.TcpPage.Controls.Add(this.CloseConnection);
            this.TcpPage.Controls.Add(this.pictureBox1);
            this.TcpPage.Controls.Add(this.OpenConnection);
            this.TcpPage.Controls.Add(this.IPText);
            this.TcpPage.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TcpPage.Location = new System.Drawing.Point(4, 29);
            this.TcpPage.Name = "TcpPage";
            this.TcpPage.Padding = new System.Windows.Forms.Padding(3);
            this.TcpPage.Size = new System.Drawing.Size(837, 555);
            this.TcpPage.TabIndex = 0;
            this.TcpPage.Text = "Tcp";
            // 
            // SerialPortPage
            // 
            this.SerialPortPage.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SerialPortPage.Location = new System.Drawing.Point(4, 29);
            this.SerialPortPage.Name = "SerialPortPage";
            this.SerialPortPage.Padding = new System.Windows.Forms.Padding(3);
            this.SerialPortPage.Size = new System.Drawing.Size(837, 555);
            this.SerialPortPage.TabIndex = 1;
            this.SerialPortPage.Text = "SerialPort";
            this.SerialPortPage.UseVisualStyleBackColor = true;
            // 
            // IPText
            // 
            this.IPText.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.IPText.Location = new System.Drawing.Point(6, 75);
            this.IPText.Name = "IPText";
            this.IPText.Size = new System.Drawing.Size(173, 27);
            this.IPText.TabIndex = 0;
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
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.AliceBlue;
            this.pictureBox1.Location = new System.Drawing.Point(212, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(619, 543);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 612);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.TcpPage.ResumeLayout(false);
            this.TcpPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage TcpPage;
        private System.Windows.Forms.TabPage SerialPortPage;
        private System.Windows.Forms.TextBox IPText;
        private System.Windows.Forms.Button OpenConnection;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button CloseConnection;
    }
}

