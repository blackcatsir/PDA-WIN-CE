using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RTDMes.Forms
{
    public partial class OutstockMainFrm : Form
    {
        public OutstockMainFrm()
        {
            InitializeComponent();

            status1.Text = "操作人:" + Program.UserNo;
        }

        Authority auth = new Authority();

        #region 退出系统
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region  入库上架
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmInstock_New frm = new FrmInstock_New();
            frm.ShowDialog();
            frm.Dispose();
            this.Show();
        }
        #endregion

        private void MainFrm_Load(object sender, EventArgs e)
        {

            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }//this.WindowState = FormWindowState.Maximized;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            FrmPickMaterial frm = new FrmPickMaterial();
            frm.ShowDialog();
            frm.Dispose();
            this.Show();
        }

        private void cmdCheckStock_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmCheckStock frm = new FrmCheckStock();
            frm.ShowDialog();
            frm.Dispose();
            this.Show();
        }

        private void cmdMoveStock_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmMoveStock frm = new FrmMoveStock();
            frm.ShowDialog();
            frm.Dispose();
            this.Show();
        }

        private void cmdMaterialSplit_Click(object sender, EventArgs e)
        {
            this.Hide();
            DownShelves frm = new DownShelves();
            frm.ShowDialog();
            frm.Dispose();
            this.Show();

        }

        private void cmdCombine_Click(object sender, EventArgs e)
        {
            this.Hide();
            MaterialCombine frm = new MaterialCombine();
            frm.ShowDialog();
            frm.Dispose();
            this.Show();
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            PrintTest frm = new PrintTest();
            frm.ShowDialog();
            frm.Dispose();
            this.Show();
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmOutstock_New frm = new FrmOutstock_New();
            frm.ShowDialog();
            frm.Dispose();
            this.Show();
        }

        private void btnMovement_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmMoveStock_New frm = new FrmMoveStock_New();
            frm.ShowDialog();
            frm.Dispose();
            this.Show();
        }

        private void btnRepair_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmRepair_New frm = new FrmRepair_New();
            frm.ShowDialog();
            frm.Dispose();
            this.Show();
        }

        private void btnMaterSplit_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmMaterialSplit_New frm = new FrmMaterialSplit_New();
            frm.ShowDialog();
            frm.Dispose();
            this.Show();
        }

        private void btnSigleUp_Click(object sender, EventArgs e)
        {
           
            this.Hide();
            QITA_OUT_WH frm = new QITA_OUT_WH();
            frm.ShowDialog();
            frm.Dispose();
            this.Show();
        }

        private void btnBatchUp_Click(object sender, EventArgs e)
        {
            if (!auth.GetAuthorFinally(((Button)sender).Text))
            {
                return;
            }

            this.Hide();
            FrmCombineOutput frm = new FrmCombineOutput();
            frm.ShowDialog();
            frm.Dispose();
            this.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (!auth.GetAuthorFinally(((Button)sender).Text))
            {
                return;
            }

            this.Hide();
          // INJECTTION_OUT frm = new INJECTTION_OUT();
            INV_OUT_WH frm = new INV_OUT_WH();
            frm.ShowDialog();
            frm.Dispose();
            this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //if (!auth.GetAuthorFinally(((Button)sender).Text))
            //{
            //    return;
            //}

            this.Hide();
            TB_SalesOut frm = new TB_SalesOut();
            frm.ShowDialog();
            frm.Dispose();
            this.Show();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
       

            this.Hide();
            INV_OUT frm = new INV_OUT();
            frm.ShowDialog();
            frm.Dispose();
            this.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //if (!auth.GetAuthorFinally(((Button)sender).Text))
            //{
            //    return;
            //}

            this.Hide();
            MOVE_OUT frm = new MOVE_OUT();
            frm.ShowDialog();
            frm.Dispose();
            this.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (!auth.GetAuthorFinally(((Button)sender).Text))
            {
                return;
            }

            this.Hide();
            DZQOutS207 frm = new DZQOutS207();
            frm.ShowDialog();
            frm.Dispose();
            this.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //if (!auth.GetAuthorFinally(((Button)sender).Text))
            //{
            //    return;
            //}

            this.Hide();
            MOVE_IN frm = new MOVE_IN();
            frm.ShowDialog();
            frm.Dispose();
            this.Show();
        }



    }
}