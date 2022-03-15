namespace RTDMes.Forms
{
    partial class QueryMainFrm
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
            this.btnLocateQuery = new System.Windows.Forms.Button();
            this.btnCartonNoQuery = new System.Windows.Forms.Button();
            this.txt_part_no_query = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
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
            this.btnExit.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular);
            this.btnExit.Location = new System.Drawing.Point(269, 384);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(159, 48);
            this.btnExit.TabIndex = 42;
            this.btnExit.Text = "返回";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnLocateQuery
            // 
            this.btnLocateQuery.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular);
            this.btnLocateQuery.Location = new System.Drawing.Point(269, 24);
            this.btnLocateQuery.Name = "btnLocateQuery";
            this.btnLocateQuery.Size = new System.Drawing.Size(159, 48);
            this.btnLocateQuery.TabIndex = 66;
            this.btnLocateQuery.Text = "按货位查询";
            this.btnLocateQuery.Click += new System.EventHandler(this.btnLocateQuery_Click);
            // 
            // btnCartonNoQuery
            // 
            this.btnCartonNoQuery.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular);
            this.btnCartonNoQuery.Location = new System.Drawing.Point(17, 24);
            this.btnCartonNoQuery.Name = "btnCartonNoQuery";
            this.btnCartonNoQuery.Size = new System.Drawing.Size(175, 48);
            this.btnCartonNoQuery.TabIndex = 65;
            this.btnCartonNoQuery.Text = "按条码查询";
            this.btnCartonNoQuery.Click += new System.EventHandler(this.btnCartonNoQuery_Click);
            // 
            // txt_part_no_query
            // 
            this.txt_part_no_query.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular);
            this.txt_part_no_query.Location = new System.Drawing.Point(17, 176);
            this.txt_part_no_query.Name = "txt_part_no_query";
            this.txt_part_no_query.Size = new System.Drawing.Size(175, 48);
            this.txt_part_no_query.TabIndex = 68;
            this.txt_part_no_query.Text = "按料号查询";
            this.txt_part_no_query.Click += new System.EventHandler(this.txt_part_no_query_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular);
            this.button1.Location = new System.Drawing.Point(269, 176);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 48);
            this.button1.TabIndex = 70;
            this.button1.Text = "按容器查询";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // QueryMainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(478, 595);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_part_no_query);
            this.Controls.Add(this.btnLocateQuery);
            this.Controls.Add(this.btnCartonNoQuery);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.status1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular);
            this.Name = "QueryMainFrm";
            this.Text = "查询";
            this.Load += new System.EventHandler(this.MainFrm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.StatusBar status1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnLocateQuery;
        private System.Windows.Forms.Button btnCartonNoQuery;
        private System.Windows.Forms.Button txt_part_no_query;
        private System.Windows.Forms.Button button1;

    }
}