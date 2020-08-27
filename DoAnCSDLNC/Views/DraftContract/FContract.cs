using DoAnCSDLNC.Classes;
using DoAnCSDLNC.Models;
using DoAnCSDLNC.Shared;
using DoAnCSDLNC.Views.EditContract;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnCSDLNC.Views.DraftContract
{
    public partial class FContract : Form
    {
        private ContractModel contractModel;
        private int selectedFunction;
        private Contract contract;
        private Member member;
        private MemberModel memberModel;
        public FContract()
        {
            InitializeComponent();
            contractModel = new ContractModel();
            selectedFunction = 0;
            contract = new Contract();
            member = new Member();
            memberModel = new MemberModel();
        }

        private void FContract_Load(object sender, EventArgs e)
        {
            dtpTerminalDate.Value = DateTime.Parse(GlobalVarialbe.selectedTour.EndDate).AddDays(2);
            dtpStartTime.Value = DateTime.Parse(GlobalVarialbe.selectedTour.StartDate);
            tbxQuantity.Focus();
        }

        private void formatDtgListMember()
        {
            if (dtgListMember.RowCount >= 11)
            {
                dtgListMember.Columns[5].Width = 183;
            }
            else
            {
                dtgListMember.Columns[5].Width = 200;
            }
        }

        public void insertMember()
        {
            for(int i=0; i<dtgListMember.RowCount; i++)
            {
                member.ContracId = contract.ContracId;
                member.MemberId = int.Parse(dtgListMember.Rows[i].Cells[0].Value.ToString());
                member.Name = dtgListMember.Rows[i].Cells[1].Value.ToString().ToUpper();
                member.Dob = dtgListMember.Rows[i].Cells[2].Value.ToString();
                member.MemberPrice = int.Parse(dtgListMember.Rows[i].Cells[5].Value.ToString());
                if (dtgListMember.Rows[i].Cells[3].Value == null)
                {
                    member.Identification = "";
                }
                else
                {
                    member.Identification = dtgListMember.Rows[i].Cells[3].Value.ToString();
                }
                try
                {
                    memberModel.insertMember(member);
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        private void btnSaveContract_Click(object sender, EventArgs e)
        {
            contract.CustomerId = GlobalVarialbe.selectedCustomer.CustomerId;
            contract.TourId = GlobalVarialbe.selectedTour.TourId;
            contract.TemimationDate = dtpTerminalDate.Text; 
            contract.StartTime = dtpStartTime.Text;
            contract.Quantity = int.Parse(tbxQuantity.Text);
            contract.Note = tbxNote.Text;
            contract.Deposit = int.Parse(Utils.eraiseComma(tbxDeposit.Text));
            if (selectedFunction == 0)
            {
                try
                {
                    if (contractModel.insertContract(contract))
                    {
                        contract.ContracId = contractModel.getInsertedId();
                        insertMember();
                        selectedFunction = 1;
                        MessageBox.Show("Hợp đồng đã được lưu");
                    }
                }
                catch (Exception)
                {
                    Utils.showError(Constants.strFailedInsert);
                }
            }
            else
            {
                try
                {
                    if(Utils.showConfirm(Constants.strConfirmUpdate) == DialogResult.Yes)
                    {
                        if (contractModel.updateContract(contract))
                        {
                            insertMember();
                        }
                    }
                }
                catch (Exception)
                {
                    Utils.showError(Constants.strFailedUpdate);
                }
            }
        }

        private void tbxQuantity_Leave(object sender, EventArgs e)
        {
            int a;
            if (!int.TryParse(tbxQuantity.Text, out a))
            {
                return;
            }
            contract.Quantity = int.Parse(tbxQuantity.Text);
            contract.QuantityDiscount = contractModel.getQuantityDiscout(contract.Quantity);
            tbxQuantityDiscount.Text = contract.QuantityDiscount.ToString();
            dtgListMember.ColumnCount = 6;
            dtgListMember.RowCount = contract.Quantity;
            formatDtgListMember();
            for (int i = 0; i < contract.Quantity; i++)
            {
                dtgListMember.Rows[i].Cells[0].Value = i + 1;
            }
            dtgListMember.CurrentCell = dtgListMember.Rows[0].Cells[1];
            calculateMoney();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Utils.ShowForm(FMain.pnlMain, new FCustomer());
        }

        public void calculateMoney()
        {
            contract.TotalMoney = 0;
            for (int i = 0; i < dtgListMember.RowCount; i++)
            {
                if (dtgListMember.Rows[i].Cells[5].Value != null)
                {
                    contract.TotalMoney += int.Parse(dtgListMember.Rows[i].Cells[5].Value.ToString());
                }
            }
            int payedMoney = contract.TotalMoney * (100 - contract.QuantityDiscount) / 100;
            contract.Deposit = payedMoney / 2;
            tbxTotalMoney.Text = contract.TotalMoney.ToString();
            tbxPayedMoney.Text = payedMoney.ToString();
            tbxDeposit.Text = contract.Deposit.ToString();
        }

        private void dtgListMember_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2)
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

        private void tbxMoneyChanged(object sender, EventArgs e)
        {
            Utils.tbx_TextBox_TextChanged(sender, e);
        }
    }
}
