using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RTDMes.Forms
{
    public partial class QueryMainFrm : Form
    {
        public QueryMainFrm()
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
            //if (this.WindowState == FormWindowState.Maximized)
            //{
            //    this.WindowState = FormWindowState.Normal;
            //}
            //else
            //{
            //    this.WindowState = FormWindowState.Maximized;
            //}
            //this.WindowState = FormWindowState.Maximized;
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
            FrmInstock_New frm = new FrmInstock_New();
            frm.ShowDialog();
            frm.Dispose();
            this.Show();
        }

        private void btnBatchUp_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmInstockBatch_New frm = new FrmInstockBatch_New();
            frm.ShowDialog();
            frm.Dispose();
            this.Show();
        }

        private void btnCartonNoQuery_Click(object sender, EventArgs e)
        {
                this.Hide();
            CartonNoQuery_New frm = new CartonNoQuery_New();
            frm.ShowDialog();
            frm.Dispose();
            this.Show();

        }

        private void btnLocateQuery_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            LocateQuery_New frm = new LocateQuery_New();
            frm.ShowDialog();
            frm.Dispose();
            this.Show();

        }

        private void txt_part_no_query_Click(object sender, EventArgs e)
        {
            this.Hide();
            MaterialQuery_New frm = new MaterialQuery_New();
            frm.ShowDialog();
            frm.Dispose();
            this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            PartNoQuery_New frm = new PartNoQuery_New();
            frm.ShowDialog();
            frm.Dispose();
            this.Show();
        }



    }
}