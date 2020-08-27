using DoAnCSDLNC.Classes;
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
    public partial class FEditContract : Form
    {
        private ContractModel contractModel;
        private DataTable listContract, listMember;
        private Contract contract, updatingContract;
        private MemberModel memberModel;
        private Member member;
        private TourModel tourModel;
        public FEditContract()
        {
            InitializeComponent();
            contractModel = new ContractModel();
            listContract = listMember = new DataTable();
            contract = new Contract();
            updatingContract = new Contract();
            memberModel = new MemberModel();
            member = new Member();
            tourModel = new TourModel();
        }

        private void FEditContract_Load(object sender, EventArgs e)
        {
            try
            {
                listContract = contractModel.getValidContract();
                cbxContractId.DataSource = listContract;
                cbxContractId.DisplayMember = "ContractId";
                cbxContractId.SelectedIndex = -1;
            }
            catch (Exception)
            {
                Utils.showErrorLoadData(Constants.ettContract);
            }
        }

        public void formatDtgListMember()
        {
            dtgListMember.Columns[0].Visible = false;
            dtgListMember.Columns[1].HeaderText = "STT";
            dtgListMember.Columns[2].HeaderText = "Tên";
            dtgListMember.Columns[3].HeaderText = "Ngày sinh";
            dtgListMember.Columns[4].HeaderText = "CMT";
            dtgListMember.Columns[5].HeaderText = "Chiết khấu";
            dtgListMember.Columns[6].HeaderText = "Giá TV";

            dtgListMember.Columns[1].ReadOnly = true;
            dtgListMember.Columns[5].ReadOnly = true;
            dtgListMember.Columns[6].ReadOnly = true;

            dtgListMember.Columns[1].Width = 119;
            dtgListMember.Columns[2].Width = 350;
            dtgListMember.Columns[3].Width = 250;
            dtgListMember.Columns[4].Width = 200;
            dtgListMember.Columns[5].Width = 200;
            dtgListMember.Columns[6].Width = 200;

            for(int i=0; i<dtgListMember.RowCount; i++)
            {
                if(dtgListMember.Rows[i].Cells[6].Value.ToString() != "0")
                {
                    dtgListMember.Rows[i].Cells[6].Style.Format = "#,###";
                }
            }
            
            if (dtgListMember.RowCount >= 11)
            {
                dtgListMember.Columns[5].Width = 183;
            }
            else
            {
                dtgListMember.Columns[5].Width = 200;
            }
        }

        private void btnCancelContract_Click(object sender, EventArgs e)
        {
            GlobalVarialbe.selectedContract.ContracId = int.Parse(cbxContractId.Text);
            GlobalVarialbe.selectedContract.Deposit = int.Parse(Utils.eraiseComma(tbxDeposit.Text));
            new FCancleContract().ShowDialog();
        }

        public void calculateMoney()
        {
            updatingContract.TotalMoney = 0;
            for (int i = 0; i < dtgListMember.RowCount; i++)
            {
                if (dtgListMember.Rows[i].Cells[6].Value.ToString() != "")
                {
                    updatingContract.TotalMoney += int.Parse(dtgListMember.Rows[i].Cells[6].Value.ToString());
                }
            }
            int payedMoney = updatingContract.TotalMoney * (100 - updatingContract.QuantityDiscount) / 100;
            updatingContract.Deposit = payedMoney / 2;
            tbxTotalMoney.Text = updatingContract.TotalMoney.ToString();
            tbxPayedMoney.Text = payedMoney.ToString();
            if(contract.Deposit < updatingContract.Deposit)
            {
                tbxAddedDeposit.Text = (updatingContract.Deposit - contract.Deposit).ToString();
                tbxDeposit.Text = updatingContract.Deposit.ToString();
            }
            else
            {
                updatingContract.Deposit = contract.Deposit;
            }
        }

        private void tbxQuantity_Leave(object sender, EventArgs e)
        {
            int a;
            if (!int.TryParse(tbxQuantity.Text, out a))
            {
                return;
            }

            int oldQuantity = dtgListMember.RowCount;
            int newQuantity = int.Parse(tbxQuantity.Text);
            if(newQuantity > dtgListMember.RowCount)
            {
                for(int i = 0; i < (newQuantity - oldQuantity) ; i++)
                {
                    DataRow newRow = listMember.NewRow();
                    newRow[1] = listMember.Rows.Count + 1;
                    listMember.Rows.InsertAt(newRow, listMember.Rows.Count);
                }
            }
            else
            {
                for (int i = 0; i < (oldQuantity - newQuantity); i++)
                {
                    listMember.Rows.RemoveAt(listMember.Rows.Count - 1);
                }
            }
            dtgListMember.DataSource = listMember;
            formatDtgListMember();
            updatingContract.QuantityDiscount = contractModel.getQuantityDiscout(newQuantity);
            tbxQuantityDiscount.Text = updatingContract.QuantityDiscount.ToString();
            dtgListMember.CurrentCell = dtgListMember.Rows[0].Cells[1];
            calculateMoney();
        }

        private void dtgListMember_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                dtgListMember.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = dtgListMember.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString().ToUpper();
            }
            if (e.ColumnIndex == 3)
            {
                string DOB = dtgListMember.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                member.AgeDiscount = memberModel.getAgeDiscout(DateTime.Parse(DOB));
                dtgListMember.Rows[e.RowIndex].Cells[e.ColumnIndex + 2].Value = member.AgeDiscount;
                int memberPrice = GlobalVarialbe.selectedTour.Price * (100 - member.AgeDiscount) / 100;
                if (memberPrice == 0)
                {
                    dtgListMember.Rows[e.RowIndex].Cells[e.ColumnIndex + 3].Value = memberPrice.ToString();
                }
                else
                {
                    dtgListMember.Rows[e.RowIndex].Cells[e.ColumnIndex + 3].Value = memberPrice;
                }
                calculateMoney();
            }
        }

        private void cbxContractId_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int contractIndex = cbxContractId.SelectedIndex;
            if (contractIndex > -1)
            {
                dtpTerminalDate.Value = DateTime.Parse(listContract.Rows[contractIndex]["TerminationDate"].ToString());
                dtpStartTime.Value = DateTime.Parse(listContract.Rows[contractIndex]["StartTime"].ToString());
                tbxQuantity.Text = listContract.Rows[contractIndex]["Quantity"].ToString();
                tbxQuantityDiscount.Text = listContract.Rows[contractIndex]["QuantityDiscount"].ToString();
                tbxTotalMoney.Text = listContract.Rows[contractIndex]["TotalMoney"].ToString();
                updatingContract.Note = tbxNote.Text = listContract.Rows[contractIndex]["Note"].ToString();
                tbxPayedMoney.Text = (int.Parse(Utils.eraiseComma(tbxTotalMoney.Text)) * (100 - int.Parse(Utils.eraiseComma(tbxQuantityDiscount.Text))) / 100).ToString();
                tbxDeposit.Text = listContract.Rows[contractIndex]["Deposit"].ToString();

                contract.ContracId = int.Parse(listContract.Rows[contractIndex]["ContractId"].ToString());
                contract.Deposit = int.Parse(listContract.Rows[contractIndex]["Deposit"].ToString());
                try
                {
                    GlobalVarialbe.selectedTour = new Tour();
                    GlobalVarialbe.selectedTour.Price = tourModel.getPriceTourByContractId(contract.ContracId);
                    listMember = memberModel.getMemberByContractId(contract.ContracId);
                    dtgListMember.DataSource = listMember;
                    formatDtgListMember();
                }
                catch (Exception)
                {
                    Utils.showErrorLoadData(Constants.ettMember);
                }
            }
            else
            {
                dtpTerminalDate.Value = DateTime.Now;
                dtpStartTime.Value = DateTime.Now;
                tbxQuantity.Text = "0";
                tbxQuantityDiscount.Text = "0";
                tbxTotalMoney.Text = "0";
                tbxNote.Text = "";
                tbxPayedMoney.Text = "0";
                tbxDeposit.Text = "0";
                tbxAddedDeposit.Text = "0";
                dtgListMember.DataSource = null;
            }
        }

        public void insertMember()
        {
            for (int i = 0; i < dtgListMember.RowCount; i++)
            {
                member.ContracId = updatingContract.ContracId;
                member.MemberId = int.Parse(dtgListMember.Rows[i].Cells[1].Value.ToString());
                member.Name = dtgListMember.Rows[i].Cells[2].Value.ToString().ToUpper();
                member.Dob = dtgListMember.Rows[i].Cells[3].Value.ToString();
                if (dtgListMember.Rows[i].Cells[4].Value == null)
                {
                    member.Identification = "";
                }
                else
                {
                    member.Identification = dtgListMember.Rows[i].Cells[4].Value.ToString();
                }
                try
                {
                   
                    memberModel.UpdateMemberByContractId(member);
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        //private void btnTerminateContract_Click(object sender, EventArgs e)
        //{
        //    GlobalVarialbe.selectedContract.ContracId = int.Parse(cbxContractId.Text);
        //    GlobalVarialbe.selectedContract.QuantityDiscount = int.Parse(tbxQuantityDiscount.Text);
        //    GlobalVarialbe.selectedContract.TotalMoney = int.Parse(Utils.eraiseComma(tbxTotalMoney.Text));
        //    GlobalVarialbe.selectedContract.Deposit = int.Parse(Utils.eraiseComma(tbxDeposit.Text));
        //    new FTerminateContract().ShowDialog();
        //}

        private void btnSaveContract_Click(object sender, EventArgs e)
        {
            updatingContract.ContracId = contract.ContracId;
            updatingContract.Quantity = int.Parse(tbxQuantity.Text);
            updatingContract.Note = tbxNote.Text;
            updatingContract.Deposit = int.Parse(Utils.eraiseComma(tbxDeposit.Text));
            if (Utils.showConfirm(Constants.strConfirmUpdate) == DialogResult.Yes)
            {
                try
                {
                    if (contractModel.updateContract(updatingContract))
                    {
                        insertMember();
                        MessageBox.Show("Hợp đồng đã được lưu lại");
                    }
                }
                catch (Exception)
                {
                    Utils.showError(Constants.strFailedUpdate);
                }
            }
        }

        private void tbxMoneyChanged(object sender, EventArgs e)
        {
            Utils.tbx_TextBox_TextChanged(sender, e);
        }
    }
}
