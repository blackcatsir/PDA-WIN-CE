using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RTDMes.Forms
{
    public partial class ZXMainFrm : Form
    {
        public ZXMainFrm()
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
            this.WindowState = FormWindowState.Maximized;
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

        private void btnPurcharseReceive_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //FrmPurcharseReceipt frm = new FrmPurcharseReceipt();
            //frm.ShowDialog();
            //frm.Dispose();
            //this.Show();
        }

        private void btnPurcharseInstock_Click(object sender, EventArgs e)
        {
            if (!auth.GetAuthorFinally(((Button)sender).Text))
            {
                return;
            }

            this.Hide();
            INJECTTION_LK_OUT frm = new INJECTTION_LK_OUT();
            frm.ShowDialog();
            frm.Dispose();
            this.Show();
        }

        private void btnProductInstock_Click(object sender, EventArgs e)
        {
            if (!auth.GetAuthorFinally(((Button)sender).Text))
            {
                return;
            }

            this.Hide();
            FG_WH_CODE_InStock frm = new FG_WH_CODE_InStock();
            frm.ShowDialog();
            frm.Dispose();
            this.Show();
        }

        private void btnOutBox_Click(object sender, EventArgs e)
        {
            //if (!auth.GetAuthorFinally(((Button)sender).Text))
            //{
            //    return;
            //}

            this.Hide();
            TB_FIELD_MATERIAL_RECEIVE frm = new TB_FIELD_MATERIAL_RECEIVE();
            frm.ShowDialog();
            frm.Dispose();
            this.Show();
        }

        private void btninstock_Click(object sender, EventArgs e)
        {
            this.Hide();
            ZX_InStock frm = new ZX_InStock();
            frm.ShowDialog();
            frm.Dispose();
            this.Show();
        }

        private void btninboxstock_Click(object sender, EventArgs e)
        {
           
            this.Hide();
            PAI_WH_BOX_CODE_InStock frm = new PAI_WH_BOX_CODE_InStock();
            frm.ShowDialog();
            frm.Dispose();
            this.Show();
        }

        private void BtnCodeInstork_Click(object sender, EventArgs e)
        {
            this.Hide();
            TB_LK_InConCode frm = new TB_LK_InConCode();
            frm.ShowDialog();
            frm.Dispose();
            this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!auth.GetAuthorFinally(((Button)sender).Text))
            {
                return;
            }

            this.Hide();
            FG_WH_CODE_InStock frm = new FG_WH_CODE_InStock();
            frm.ShowDialog();
            frm.Dispose();
            this.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            PCBA_WH_InStock frm = new PCBA_WH_InStock();
            frm.ShowDialog();
            frm.Dispose();
            this.Show();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            this.Hide();
            BFG_WH_CODE_InStock frm = new BFG_WH_CODE_InStock();
            frm.ShowDialog();
            frm.Dispose();
            this.Show();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            FG_WH_CODE_InStock frm = new FG_WH_CODE_InStock();
            frm.ShowDialog();
            frm.Dispose();
            this.Show();
        }

        private void button1_Click_3(object sender, EventArgs e)
        {
            this.Hide();
            ZX_OUT_WH frm = new ZX_OUT_WH();
            frm.ShowDialog();
            frm.Dispose();
            this.Show();
        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            this.Hide();
            MOVE_LK_OUT frm = new MOVE_LK_OUT();
            frm.ShowDialog();
            frm.Dispose();
            this.Show();
        }

        private void button2_Click_3(object sender, EventArgs e)
        {
            this.Hide();
            ZK_OUT_WH frm = new ZK_OUT_WH();
            frm.ShowDialog();
            frm.Dispose();
            this.Show();
        }

        private void button3_Click_2(object sender, EventArgs e)
        {
            this.Hide();
            ZK_InStock frm = new ZK_InStock();
            frm.ShowDialog();
            frm.Dispose();
            this.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            ZX_InWCSStock frm = new ZX_InWCSStock();
            frm.ShowDialog();
            frm.Dispose();
            this.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
             this.Hide();
             ZK_InWCSStock frm = new ZK_InWCSStock();
            frm.ShowDialog();
            frm.Dispose();
            this.Show();
          
        }
    }
}