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
    public partial class ReturnMainFrm : Form
    {
        public ReturnMainFrm()
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
            this.Hide();
            TallyApart frm = new TallyApart();
            frm.ShowDialog();
            frm.Dispose();
            this.Show();
        }

        private void btnProductInstock_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmProductInStock frm = new FrmProductInStock();
            frm.ShowDialog();
            frm.Dispose();
            this.Show();
        }

        private void btnSQE_Recive_Click(object sender, EventArgs e)
        {
            //if (!GetAuthorFinally(((Button)sender).Text))
            //{
            //    return;
            //}

            this.Hide();

            RM_INV_RETURN frm = new RM_INV_RETURN();
            frm.ShowDialog();
            frm.Dispose();
            this.Show();
        }

        private bool GetAuthorFinally(string button_name)
        {
            Hashtable ht = new Hashtable();

            if (button_name.Length >= 8)
            {
                button_name = button_name.Substring(4, 4);
            }


            ht = Program.PDASocketProxy.LoginOperatingAuthority(Program.DeviceNo, Program.UserNo, button_name);

            if (ht["@retValue"].ToString() == "0")
            {

                return true;
            }
            else
            {
                //MessageBox.Show(ht["@MsgText"].ToString());

                System.Windows.Forms.MessageBox.Show
                       (ht["@MsgText"].ToString(), "系统提示",
                       System.Windows.Forms.MessageBoxButtons.OK,
                       System.Windows.Forms.MessageBoxIcon.None,
                       System.Windows.Forms.MessageBoxDefaultButton.Button1
                       );
                return false;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FG_RETURN frm = new FG_RETURN();
            frm.ShowDialog();
            frm.Dispose();
            this.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            BF_RETURN frm = new BF_RETURN();
            frm.ShowDialog();
            frm.Dispose();
            this.Show();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
             this.Hide();
             PO_RM_RETURN frm = new PO_RM_RETURN();
            frm.ShowDialog();
            frm.Dispose();
            this.Show();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            PO_INV_RETURN frm = new PO_INV_RETURN();
            frm.ShowDialog();
            frm.Dispose();
            this.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            HH_InOutStock frm = new HH_InOutStock();
            frm.ShowDialog();
            frm.Dispose();
            this.Show();
        }
    }
}