namespace RTDMes.Forms
{
    partial class AGVMainFrm
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
            this.btninstock = new System.Windows.Forms.Button();
            this.BtnCodeInstork = new System.Windows.Forms.Button();
            this.btnPurcharseInstock = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // status1
            // 
            this.status1.Location = new System.Drawing.Point(0, 571);
            this.status1.Name = "status1";
            this.status1.Size = new System.Drawing.Size(478, 24);
            this.status1.Text = "特变";
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackColor = System.Drawing.Color.Crimson;
            this.btnExit.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular);
            this.btnExit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnExit.Location = new System.Drawing.Point(365, 270);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(110, 48);
            this.btnExit.TabIndex = 42;
            this.btnExit.Text = "返回";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btninstock
            // 
            this.btninstock.BackColor = System.Drawing.Color.Olive;
            this.btninstock.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular);
            this.btninstock.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btninstock.Location = new System.Drawing.Point(3, 3);
            this.btninstock.Name = "btninstock";
            this.btninstock.Size = new System.Drawing.Size(127, 48);
            this.btninstock.TabIndex = 72;
            this.btninstock.Text = "物料配送";
            this.btninstock.Click += new System.EventHandler(this.btninstock_Click);
            // 
            // BtnCodeInstork
            // 
            this.BtnCodeInstork.BackColor = System.Drawing.Color.Olive;
            this.BtnCodeInstork.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular);
            this.BtnCodeInstork.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnCodeInstork.Location = new System.Drawing.Point(3, 57);
            this.BtnCodeInstork.Name = "BtnCodeInstork";
            this.BtnCodeInstork.Size = new System.Drawing.Size(127, 48);
            this.BtnCodeInstork.TabIndex = 76;
            this.BtnCodeInstork.Text = "叫料配送";
            this.BtnCodeInstork.Click += new System.EventHandler(this.BtnCodeInstork_Click);
            // 
            // btnPurcharseInstock
            // 
            this.btnPurcharseInstock.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPurcharseInstock.BackColor = System.Drawing.SystemColors.GrayText;
            this.btnPurcharseInstock.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular);
            this.btnPurcharseInstock.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnPurcharseInstock.Location = new System.Drawing.Point(365, 57);
            this.btnPurcharseInstock.Name = "btnPurcharseInstock";
            this.btnPurcharseInstock.Size = new System.Drawing.Size(110, 48);
            this.btnPurcharseInstock.TabIndex = 66;
            this.btnPurcharseInstock.Text = "立库出库";
            this.btnPurcharseInstock.Visible = false;
            this.btnPurcharseInstock.Click += new System.EventHandler(this.btnPurcharseInstock_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Olive;
            this.button1.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular);
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(365, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 48);
            this.button1.TabIndex = 78;
            this.button1.Text = "入库拆托";
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_3);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.SystemColors.GrayText;
            this.button2.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular);
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Location = new System.Drawing.Point(3, 122);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(127, 48);
            this.button2.TabIndex = 80;
            this.button2.Text = "调拨出库";
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_2);
            // 
            // AGVMainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(478, 595);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BtnCodeInstork);
            this.Controls.Add(this.btninstock);
            this.Controls.Add(this.btnPurcharseInstock);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.status1);
            this.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular);
            this.Name = "AGVMainFrm";
            this.Text = "立库管理";
            this.Load += new System.EventHandler(this.MainFrm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.StatusBar status1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btninstock;
        private System.Windows.Forms.Button BtnCodeInstork;
        private System.Windows.Forms.Button btnPurcharseInstock;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;

    }
}