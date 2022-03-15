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
    public partial class MainFrm : Form
    {
        Authority auth = new Authority();

        public MainFrm()
        {
            InitializeComponent();

            status1.Text = "操作人:" + Program.UserNo;
        }

        #region ButtonClass


        private ButtonClass _button;
        public ButtonClass button
        {
            get { return _button; }
            set { _button = value; }
        }



        #endregion

        private bool GetAuthorFinally(string button_name)
        {
            Hashtable ht = new Hashtable();

            if (button_name.Length >= 8)
            {
                button_name = button_name.Substring(4, 4);
            }
            
            
            ht = Program.PDASocketProxy.LoginOperatingAuthority(Program.DeviceNo,Program.UserNo, button_name);

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



        #region 退出系统
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region  入库上架
        private void button2_Click(object sender, EventArgs e)
        {
            if (!auth.GetAuthorFinally(((Button)sender).Text))
            {
                return;
            }
            
            this.Hide();
            InstockMainFrm frm = new InstockMainFrm();

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
            if (!auth.GetAuthorFinally(((Button)sender).Text))
            {
                return;
            }
            this.Hide();
            FrmPickMaterial frm = new FrmPickMaterial();
            frm.ShowDialog();
            frm.Dispose();
            this.Show();
        }

        private void cmdCheckStock_Click(object sender, EventArgs e)
        {
            if (!auth.GetAuthorFinally(((Button)sender).Text))
            {
                return;
            }
            this.Hide();
            FrmCheckStock frm = new FrmCheckStock();
            frm.ShowDialog();
            frm.Dispose();
            this.Show();
        }

        private void cmdMoveStock_Click(object sender, EventArgs e)
        {
            if (!auth.GetAuthorFinally(((Button)sender).Text))
            {
                return;
            }
            this.Hide();
            FrmMoveStock frm = new FrmMoveStock();
            frm.ShowDialog();
            frm.Dispose();
            this.Show();
        }

        private void cmdMaterialSplit_Click(object sender, EventArgs e)
        {
            if (!auth.GetAuthorFinally(((Button)sender).Text))
            {
                return;
            }
            this.Hide();
            DownShelves frm = new DownShelves();
            frm.ShowDialog();
            frm.Dispose();
            this.Show();

        }

        private void cmdCombine_Click(object sender, EventArgs e)
        {
            if (!auth.GetAuthorFinally(((Button)sender).Text))
            {
                return;
            }
            this.Hide();
            MaterialCombine frm = new MaterialCombine();
            frm.ShowDialog();
            frm.Dispose();
            this.Show();
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!auth.GetAuthorFinally(((Button)sender).Text))
            {
                return;
            }
            this.Hide();
            PrintTest frm = new PrintTest();
            frm.ShowDialog();
            frm.Dispose();
            this.Show();
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            if (!auth.GetAuthorFinally(((Button)sender).Text))
            {
                return;
            }
            this.Hide();
            FrmOutstock_New frm = new FrmOutstock_New();
            frm.ShowDialog();
            frm.Dispose();
            this.Show();
        }

        private void btnMovement_Click(object sender, EventArgs e)
        {
            if (!auth.GetAuthorFinally(((Button)sender).Text))
            {
                return;
            }
            this.Hide();
            FrmSMTGI frm = new FrmSMTGI();
            frm.ShowDialog();
            frm.Dispose();
            this.Show();
        }

        private void btnRepair_Click(object sender, EventArgs e)
        {
            if (!auth.GetAuthorFinally(((Button)sender).Text))
            {
                return;
            }
            this.Hide();
            QualityMainFrm frm = new QualityMainFrm();
            frm.ShowDialog();
            frm.Dispose();
            this.Show();
        }

        private void btnMaterSplit_Click(object sender, EventArgs e)
        {

            TB_PD frm = new TB_PD();
            frm.ShowDialog();
            frm.Dispose();
            this.Show();
        }

        //private void btnSigleUp_Click(object sender, EventArgs e)
        //{
        //    this.Hide();
        //    FrmInstockSigle_New frm = new FrmInstockSigle_New();
        //    frm.ShowDialog();
        //    frm.Dispose();
        //    this.Show();
        //}

        private void btnBatchUp_Click(object sender, EventArgs e)
        {
            if (!auth.GetAuthorFinally(((Button)sender).Text))
            {
                return;
            }
            this.Hide();
            FrmInstockBatch_New frm = new FrmInstockBatch_New();
            frm.ShowDialog();
            frm.Dispose();
            this.Show();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (!auth.GetAuthorFinally(((Button)sender).Text))
            {
                return;
            }
            this.Hide();
            QueryMainFrm frm = new QueryMainFrm();
            frm.ShowDialog();
            frm.Dispose();
            this.Show();
        }

        private void btn_product_pull_Click(object sender, EventArgs e)
        {
            if (!auth.GetAuthorFinally(((Button)sender).Text))
            {
                return;
            }
            this.Hide();
            ChangePassWord frm = new ChangePassWord();
            frm.ShowDialog();
            frm.Dispose();
            this.Show();
        }

        private void btnOutStockManager_Click(object sender, EventArgs e)
        {
            if (!auth.GetAuthorFinally(((Button)sender).Text))
            {
                return;
            }

            this.Hide();
            OutstockMainFrm frm = new OutstockMainFrm();
            frm.ShowDialog();
            frm.Dispose();
            this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            TYMainFrm frm = new TYMainFrm();
            frm.ShowDialog();
            frm.Dispose();
            this.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            ReturnMainFrm frm = new ReturnMainFrm();
            frm.ShowDialog();
            frm.Dispose();
            this.Show();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            MoveMainFrm frm = new MoveMainFrm();
            frm.ShowDialog();
            frm.Dispose();
            this.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            AGVMainFrm frm = new AGVMainFrm();
            frm.ShowDialog();
            frm.Dispose();
            this.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            LKMainFrm frm = new LKMainFrm();
            frm.ShowDialog();
            frm.Dispose();
            this.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            ZXMainFrm frm = new ZXMainFrm();
            frm.ShowDialog();
            frm.Dispose();
            this.Show();
        }
    }
}