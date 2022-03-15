namespace RTDMes.Forms
{
    partial class InstockMainFrm
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
            this.status1 = new System.Windows.Forms.StatusBar();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnPurcharseInstock = new System.Windows.Forms.Button();
            this.btnOutBox = new System.Windows.Forms.Button();
            this.btninstock = new System.Windows.Forms.Button();
            this.btninboxstock = new System.Windows.Forms.Button();
            this.BtnCodeInstork = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // status1
            // 
            this.status1.Location = new System.Drawing.Point(0, 324);
            this.status1.Name = "status1";
            this.status1.Size = new System.Drawing.Size(360, 24);
            this.status1.Text = "特变";
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackColor = System.Drawing.Color.Crimson;
            this.btnExit.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular);
            this.btnExit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnExit.Location = new System.Drawing.Point(247, 270);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(110, 48);
            this.btnExit.TabIndex = 42;
            this.btnExit.Text = "返回";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnPurcharseInstock
            // 
            this.btnPurcharseInstock.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPurcharseInstock.BackColor = System.Drawing.SystemColors.GrayText;
            this.btnPurcharseInstock.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular);
            this.btnPurcharseInstock.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnPurcharseInstock.Location = new System.Drawing.Point(247, 177);
            this.btnPurcharseInstock.Name = "btnPurcharseInstock";
            this.btnPurcharseInstock.Size = new System.Drawing.Size(110, 48);
            this.btnPurcharseInstock.TabIndex = 66;
            this.btnPurcharseInstock.Text = "越库收料";
            this.btnPurcharseInstock.Click += new System.EventHandler(this.btnPurcharseInstock_Click);
            // 
            // btnOutBox
            // 
            this.btnOutBox.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnOutBox.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular);
            this.btnOutBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnOutBox.Location = new System.Drawing.Point(3, 177);
            this.btnOutBox.Name = "btnOutBox";
            this.btnOutBox.Size = new System.Drawing.Size(127, 48);
            this.btnOutBox.TabIndex = 70;
            this.btnOutBox.Text = "来料接收";
            this.btnOutBox.Click += new System.EventHandler(this.btnOutBox_Click);
            // 
            // btninstock
            // 
            this.btninstock.BackColor = System.Drawing.Color.Olive;
            this.btninstock.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular);
            this.btninstock.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btninstock.Location = new System.Drawing.Point(3, 69);
            this.btninstock.Name = "btninstock";
            this.btninstock.Size = new System.Drawing.Size(127, 48);
            this.btninstock.TabIndex = 72;
            this.btninstock.Text = "入库拼托";
            this.btninstock.Click += new System.EventHandler(this.btninstock_Click);
            // 
            // btninboxstock
            // 
            this.btninboxstock.BackColor = System.Drawing.Color.Olive;
            this.btninboxstock.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular);
            this.btninboxstock.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btninboxstock.Location = new System.Drawing.Point(3, 15);
            this.btninboxstock.Name = "btninboxstock";
            this.btninboxstock.Size = new System.Drawing.Size(127, 48);
            this.btninboxstock.TabIndex = 74;
            this.btninboxstock.Text = "货位与料盒绑定";
            this.btninboxstock.Click += new System.EventHandler(this.btninboxstock_Click);
            // 
            // BtnCodeInstork
            // 
            this.BtnCodeInstork.BackColor = System.Drawing.Color.Olive;
            this.BtnCodeInstork.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular);
            this.BtnCodeInstork.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnCodeInstork.Location = new System.Drawing.Point(3, 123);
            this.BtnCodeInstork.Name = "BtnCodeInstork";
            this.BtnCodeInstork.Size = new System.Drawing.Size(127, 48);
            this.BtnCodeInstork.TabIndex = 76;
            this.BtnCodeInstork.Text = "入库上架";
            this.BtnCodeInstork.Click += new System.EventHandler(this.BtnCodeInstork_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(247, 15);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 48);
            this.button2.TabIndex = 79;
            this.button2.Text = "PCBA入库";
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(247, 69);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 48);
            this.button1.TabIndex = 81;
            this.button1.Text = "半成品入库";
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Location = new System.Drawing.Point(247, 123);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(110, 48);
            this.button3.TabIndex = 82;
            this.button3.Text = "成品入库";
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // InstockMainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(360, 348);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.BtnCodeInstork);
            this.Controls.Add(this.btninboxstock);
            this.Controls.Add(this.btninstock);
            this.Controls.Add(this.btnOutBox);
            this.Controls.Add(this.btnPurcharseInstock);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.status1);
            this.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular);
            this.Name = "InstockMainFrm";
            this.Text = "入库管理";
            this.Load += new System.EventHandler(this.MainFrm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.StatusBar status1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnPurcharseInstock;
        private System.Windows.Forms.Button btnOutBox;
        private System.Windows.Forms.Button btninstock;
        private System.Windows.Forms.Button btninboxstock;
        private System.Windows.Forms.Button BtnCodeInstork;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;

    }
}