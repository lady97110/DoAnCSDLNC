using DoAnCSDLNC.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections;
using DoAnCSDLNC.Shared;
using DoAnCSDLNC.Views.DraftContract;
using DoAnCSDLNC.Views.Manage;
using DoAnCSDLNC.Views.EditContract;
using DoAnCSDLNC.Views;
using DoAnCSDLNC.Views.UserManagment;

namespace DoAnCSDLNC
{
    public partial class FMain : Form
    {
        public FMain()
        {
            InitializeComponent();
        }

        private void FMain_Load(object sender, EventArgs e)
        {
            if (GlobalVarialbe.isLogin)
            {
                menuItemFindTour.Enabled = true;
                menuItemEditContract.Enabled = true;
                menuItemAccdent.Enabled = true;
                if (GlobalVarialbe.selectedUser.UserType == 0)
                {
                    menuItemManagment.Enabled = true;
                }
                menuItemLogin.Enabled = false;
                menuItemFindTour_Click(sender, e);
            }
            else
            {
                menuItemLogin.Enabled = true;
            }
        }

        private void menuItemFindTour_Click(object sender, EventArgs e)
        {
            Utils.ShowForm(pnlMain, new FFindTour());
        }

        private void menuItemTour_Click(object sender, EventArgs e)
        {
            Utils.ShowForm(pnlMain, new FTour());
        }

        private void menuItemRefund_Click(object sender, EventArgs e)
        {
            Utils.ShowForm(pnlMain, new FRefund());
        }

        private void menuItemQuantityDiscount_Click(object sender, EventArgs e)
        {
            Utils.ShowForm(pnlMain, new FQuantityDiscount());
        }

        private void menuItemAgeDiscount_Click(object sender, EventArgs e)
        {
            Utils.ShowForm(pnlMain, new FAgeDiscount());
        }

        private void menuItemEditContract_Click(object sender, EventArgs e)
        {
            Utils.ShowForm(pnlMain, new FEditContract());
        }

        private void menuItemAccdent_Click(object sender, EventArgs e)
        {
            Utils.ShowForm(pnlMain, new FAccident());
        }

        private void FMain_Shown(object sender, EventArgs e)
        {
            new FLogin().Show();
            menuItemLogin.Enabled = false;
            //FMain_Activated(sender, e);
        }


        private void FMain_Activated(object sender, EventArgs e)
        {
            if (menuItemFindTour.Enabled)
            {
                return;
            }
            FMain_Load(sender, e);
        }

        private void menuItemLogin_Click(object sender, EventArgs e)
        {
            new FLogin().Show();
            menuItemLogin.Enabled = false;
        }

        private void tạoTàiKhoánQuảnTrịToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FRegister().Show();
        }
    }
}
