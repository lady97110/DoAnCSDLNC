using DoAnCSDLNC.Models;
using DoAnCSDLNC.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnCSDLNC.Views.EditContract
{
    public partial class FCancleContract : Form
    {
        private ContractModel contractModel;
        public FCancleContract()
        {
            InitializeComponent();
            contractModel = new ContractModel();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSaveContract_Click(object sender, EventArgs e)
        {
            var msgbox = MessageBox.Show("Bạn chắc chắn muốn huỷ hợp đồng.", Constants.strConfirmTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(msgbox == DialogResult.Yes)
            {

                GlobalVarialbe.selectedContract.State = 2;
                try
                {
                    if (contractModel.updateContract(GlobalVarialbe.selectedContract))
                    {
                        MessageBox.Show("Hợp đồng đã huỷ.");
                        this.Close();
                    }
                }
                catch (Exception)
                {
                    Utils.showError("Huỷ không thành công");
                }
            }
        }

        private void FCancleContract_Load(object sender, EventArgs e)
        {
            try
            {
                int refundRate = contractModel.getRefundRate(GlobalVarialbe.selectedContract.ContracId);
                tbxContractId.Text = GlobalVarialbe.selectedContract.ContracId.ToString();
                tbxDeposit.Text = GlobalVarialbe.selectedContract.Deposit.ToString();
                tbxRefundRate.Text = refundRate.ToString();
                tbxPayBack.Text = (GlobalVarialbe.selectedContract.Deposit * refundRate / 100).ToString();
            }
            catch (Exception)
            {
                
            }
        }

        private void FCancleContract_FormClosed(object sender, FormClosedEventArgs e)
        {
            Utils.ShowForm(FMain.pnlMain, new FEditContract());
        }
    }
}
