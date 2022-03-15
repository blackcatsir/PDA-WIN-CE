namespace RTDMes.Forms
{
    partial class ReturnMainFrm
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
            this.btnSQE_Recive = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // status1
            // 
            this.status1.Location = new System.Drawing.Point(0, 571);
            this.status1.Name = "status1";
            this.status1.Size = new System.Drawing.Size(478, 24);
            this.status1.Text = "苏州钰鑫";
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular);
            this.btnExit.Location = new System.Drawing.Point(319, 264);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(107, 48);
            this.btnExit.TabIndex = 42;
            this.btnExit.Text = "返回";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSQE_Recive
            // 
            this.btnSQE_Recive.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular);
            this.btnSQE_Recive.Location = new System.Drawing.Point(11, 15);
            this.btnSQE_Recive.Name = "btnSQE_Recive";
            this.btnSQE_Recive.Size = new System.Drawing.Size(107, 48);
            this.btnSQE_Recive.TabIndex = 65;
            this.btnSQE_Recive.Text = "生产退料";
            this.btnSQE_Recive.Click += new System.EventHandler(this.btnSQE_Recive_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular);
            this.button1.Location = new System.Drawing.Point(319, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 48);
            this.button1.TabIndex = 67;
            this.button1.Text = "销售退货";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular);
            this.button2.Location = new System.Drawing.Point(11, 69);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 48);
            this.button2.TabIndex = 69;
            this.button2.Text = "报废入库";
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular);
            this.button3.Location = new System.Drawing.Point(11, 123);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(107, 48);
            this.button3.TabIndex = 71;
            this.button3.Text = "采购退货";
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular);
            this.button4.Location = new System.Drawing.Point(319, 69);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(107, 48);
            this.button4.TabIndex = 73;
            this.button4.Text = "在库退货";
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular);
            this.button5.Location = new System.Drawing.Point(319, 123);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(107, 48);
            this.button5.TabIndex = 75;
            this.button5.Text = "供应商换货";
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // ReturnMainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(478, 595);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSQE_Recive);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.status1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular);
            this.Name = "ReturnMainFrm";
            this.Text = "退料管理";
            this.Load += new System.EventHandler(this.MainFrm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.StatusBar status1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSQE_Recive;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;

    }
}