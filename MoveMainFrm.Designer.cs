namespace RTDMes.Forms
{
    partial class MoveMainFrm
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
            this.btnProductInstock = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // status1
            // 
            this.status1.Location = new System.Drawing.Point(0, 244);
            this.status1.Name = "status1";
            this.status1.Size = new System.Drawing.Size(360, 24);
            this.status1.Text = "特变";
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackColor = System.Drawing.Color.Olive;
            this.btnExit.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular);
            this.btnExit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnExit.Location = new System.Drawing.Point(181, 177);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(139, 48);
            this.btnExit.TabIndex = 42;
            this.btnExit.Text = "返回";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnPurcharseInstock
            // 
            this.btnPurcharseInstock.BackColor = System.Drawing.Color.Olive;
            this.btnPurcharseInstock.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular);
            this.btnPurcharseInstock.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnPurcharseInstock.Location = new System.Drawing.Point(31, 15);
            this.btnPurcharseInstock.Name = "btnPurcharseInstock";
            this.btnPurcharseInstock.Size = new System.Drawing.Size(139, 48);
            this.btnPurcharseInstock.TabIndex = 66;
            this.btnPurcharseInstock.Text = "移库下架";
            this.btnPurcharseInstock.Click += new System.EventHandler(this.btnPurcharseInstock_Click);
            // 
            // btnProductInstock
            // 
            this.btnProductInstock.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnProductInstock.BackColor = System.Drawing.Color.Olive;
            this.btnProductInstock.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular);
            this.btnProductInstock.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnProductInstock.Location = new System.Drawing.Point(181, 15);
            this.btnProductInstock.Name = "btnProductInstock";
            this.btnProductInstock.Size = new System.Drawing.Size(139, 48);
            this.btnProductInstock.TabIndex = 68;
            this.btnProductInstock.Text = "移库上架";
            this.btnProductInstock.Click += new System.EventHandler(this.btnProductInstock_Click);
            // 
            // MoveMainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(360, 268);
            this.Controls.Add(this.btnProductInstock);
            this.Controls.Add(this.btnPurcharseInstock);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.status1);
            this.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular);
            this.Name = "MoveMainFrm";
            this.Text = "移库调拨";
            this.Load += new System.EventHandler(this.MainFrm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.StatusBar status1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnPurcharseInstock;
        private System.Windows.Forms.Button btnProductInstock;

    }
}