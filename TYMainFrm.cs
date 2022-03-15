using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace RTDMes.Forms
{
    public partial class TYMainFrm : Form
    {
        public TYMainFrm()
        {
            InitializeComponent();

            status1.Text = "操作人:" + Program.UserNo;
        }

        #region 退出系统
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        

        private void MainFrm_Load(object sender, EventArgs e)
        {
            //this.WindowState = FormWindowState.Maximized;
        }


        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            TB_UP frm = new TB_UP();
            frm.ShowDialog();
            frm.Dispose();
            this.Show();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            TB_DOW frm = new TB_DOW();
            frm.ShowDialog();
            frm.Dispose();
            this.Show();
        }

        private void btnSQE_Recive_Click(object sender, EventArgs e)
        {
            this.Hide();
            TB_PINTUO frm = new TB_PINTUO();
            frm.ShowDialog();
            frm.Dispose();
            this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            TB_CHAITUO frm = new TB_CHAITUO();
            frm.ShowDialog();
            frm.Dispose();
            this.Show();
        }




    }
}