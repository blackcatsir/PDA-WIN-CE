namespace RTDMes.Forms
{
    partial class MainFrm
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
            this.btnUp = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnOutStockManager = new System.Windows.Forms.Button();
            this.btnMaterSplit = new System.Windows.Forms.Button();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btn_product_pull = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // status1
            // 
            this.status1.Location = new System.Drawing.Point(0, 377);
            this.status1.Name = "status1";
            this.status1.Size = new System.Drawing.Size(318, 24);
            // 
            // btnUp
            // 
            this.btnUp.BackColor = System.Drawing.Color.Olive;
            this.btnUp.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular);
            this.btnUp.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnUp.Location = new System.Drawing.Point(34, 11);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(115, 48);
            this.btnUp.TabIndex = 28;
            this.btnUp.Text = "入库管理";
            this.btnUp.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.btnExit.Location = new System.Drawing.Point(172, 282);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(114, 48);
            this.btnExit.TabIndex = 42;
            this.btnExit.Text = "退出";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnOutStockManager
            // 
            this.btnOutStockManager.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOutStockManager.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnOutStockManager.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular);
            this.btnOutStockManager.Location = new System.Drawing.Point(172, 11);
            this.btnOutStockManager.Name = "btnOutStockManager";
            this.btnOutStockManager.Size = new System.Drawing.Size(112, 48);
            this.btnOutStockManager.TabIndex = 60;
            this.btnOutStockManager.Text = "出库管理";
            this.btnOutStockManager.Click += new System.EventHandler(this.btnOutStockManager_Click);
            // 
            // btnMaterSplit
            // 
            this.btnMaterSplit.BackColor = System.Drawing.Color.LightGray;
            this.btnMaterSplit.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular);
            this.btnMaterSplit.Location = new System.Drawing.Point(35, 65);
            this.btnMaterSplit.Name = "btnMaterSplit";
            this.btnMaterSplit.Size = new System.Drawing.Size(114, 48);
            this.btnMaterSplit.TabIndex = 63;
            this.btnMaterSplit.Text = "盘点管理";
            this.btnMaterSplit.Click += new System.EventHandler(this.btnMaterSplit_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelect.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnSelect.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular);
            this.btnSelect.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSelect.Location = new System.Drawing.Point(172, 174);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(111, 47);
            this.btnSelect.TabIndex = 65;
            this.btnSelect.Text = "查询";
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btn_product_pull
            // 
            this.btn_product_pull.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_product_pull.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular);
            this.btn_product_pull.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_product_pull.Location = new System.Drawing.Point(34, 282);
            this.btn_product_pull.Name = "btn_product_pull";
            this.btn_product_pull.Size = new System.Drawing.Size(114, 48);
            this.btn_product_pull.TabIndex = 67;
            this.btn_product_pull.Text = "更改密码";
            this.btn_product_pull.Click += new System.EventHandler(this.btn_product_pull_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Crimson;
            this.button1.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular);
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(34, 174);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 48);
            this.button1.TabIndex = 69;
            this.button1.Text = "通用功能";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.Color.Yellow;
            this.button2.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular);
            this.button2.Location = new System.Drawing.Point(171, 65);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 48);
            this.button2.TabIndex = 71;
            this.button2.Text = "退料管理";
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.LightGray;
            this.button3.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular);
            this.button3.Location = new System.Drawing.Point(35, 119);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(114, 48);
            this.button3.TabIndex = 73;
            this.button3.Text = "移库调拨";
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.LightGray;
            this.button5.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular);
            this.button5.Location = new System.Drawing.Point(35, 228);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(114, 48);
            this.button5.TabIndex = 77;
            this.button5.Text = "立库管理";
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.LightGray;
            this.button6.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular);
            this.button6.Location = new System.Drawing.Point(172, 228);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(110, 48);
            this.button6.TabIndex = 79;
            this.button6.Text = "杂项出入";
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.BackColor = System.Drawing.Color.Crimson;
            this.button4.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular);
            this.button4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button4.Location = new System.Drawing.Point(172, 120);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(111, 48);
            this.button4.TabIndex = 75;
            this.button4.Text = "AGV管理";
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(318, 401);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_product_pull);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.btnMaterSplit);
            this.Controls.Add(this.btnOutStockManager);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.status1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular);
            this.Name = "MainFrm";
            this.Text = "菜 单";
            this.Load += new System.EventHandler(this.MainFrm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.StatusBar status1;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnOutStockManager;
        private System.Windows.Forms.Button btnMaterSplit;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btn_product_pull;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button4;

    }
}