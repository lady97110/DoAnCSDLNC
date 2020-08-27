using DoAnCSDLNC.Classes;
using DoAnCSDLNC.Models;
using DoAnCSDLNC.Shared;
using DoAnCSDLNC.Views.DraftContract;
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
    public partial class FCustomer : Form
    {
        private CustomerModel customerModel;
        private DataTable listCustomer;
        private int rowIndex, selectedFunction;
        private Customer customer;
        public FCustomer()
        {
            InitializeComponent();
            customerModel = new CustomerModel();
            listCustomer = new DataTable();
            rowIndex = 0;
            selectedFunction = 0;
            customer = new Customer();
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            selectedFunction = 0;
            tbxName.Clear();
            dtpDOB.Value = DateTime.Now;
            tbxPhoneNumber.Clear();
            tbxIdentification.Clear();
            tbxAccountNumber.Clear();
            tbxAddress.Clear();
        }

        private void btnSaveCustomer_Click(object sender, EventArgs e)
        {
            customer.Name = tbxName.Text.ToUpper();
            customer.Dob = dtpDOB.Text;
            customer.PhoneNumber = tbxPhoneNumber.Text;
            customer.Identification = tbxIdentification.Text;
            customer.AccountNumber = tbxAccountNumber.Text;
            customer.Address = tbxAddress.Text;
            if(selectedFunction == 0)
            {
                try
                {
                    if (customerModel.insertCustomer(customer))
                    {
                        DataRow insertedRow = listCustomer.NewRow();
                        insertedRow[0] = customer.CustomerId = customerModel.getInsertedId();
                        insertedRow[1] = customer.Name;
                        insertedRow[2] = customer.Dob;
                        insertedRow[3] = customer.PhoneNumber;
                        insertedRow[4] = customer.Identification;
                        insertedRow[5] = customer.AccountNumber;
                        insertedRow[6] = customer.Address;
                        listCustomer.Rows.InsertAt(insertedRow, 0);
                        dtgListCustomer.DataSource = listCustomer;
                        selectedFunction = 1;
                    }
                }
                catch (Exception)
                {
                    Utils.showError(Constants.strFailedInsert);
                }
            }
            else
            {
                if(Utils.showConfirm(Constants.strConfirmUpdate) == DialogResult.Yes)
                {
                    try
                    {
                        if (customerModel.updateCustomer(customer))
                        {
                            dtgListCustomer.Rows[rowIndex].Cells[1].Value = customer.Name;
                            dtgListCustomer.Rows[rowIndex].Cells[2].Value = customer.Dob;
                            dtgListCustomer.Rows[rowIndex].Cells[3].Value = customer.PhoneNumber;
                            dtgListCustomer.Rows[rowIndex].Cells[4].Value = customer.Identification;
                            dtgListCustomer.Rows[rowIndex].Cells[5].Value = customer.AccountNumber;
                            dtgListCustomer.Rows[rowIndex].Cells[6].Value = customer.Address;
                        }
                    }
                    catch (Exception)
                    {
                        Utils.showError(Constants.strFailedUpdate);
                    }
                }
            }
        }

        private void dtgListCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedFunction = 1;
            rowIndex = dtgListCustomer.CurrentCell.RowIndex;
            customer.CustomerId = int.Parse(dtgListCustomer.Rows[rowIndex].Cells[0].Value.ToString());
            tbxName.Text = dtgListCustomer.Rows[rowIndex].Cells[1].Value.ToString();
            dtpDOB.Value = DateTime.Parse(dtgListCustomer.Rows[rowIndex].Cells[2].Value.ToString());
            tbxPhoneNumber.Text = dtgListCustomer.Rows[rowIndex].Cells[3].Value.ToString();
            tbxIdentification.Text = dtgListCustomer.Rows[rowIndex].Cells[4].Value.ToString();
            tbxAccountNumber.Text = dtgListCustomer.Rows[rowIndex].Cells[5].Value.ToString();
            tbxAddress.Text = dtgListCustomer.Rows[rowIndex].Cells[6].Value.ToString();
        }

        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            if(Utils.showConfirm(Constants.strConfirmDelete) == DialogResult.Yes)
            {
                try
                {
                    if (customerModel.deleteCustomer(customer.CustomerId))
                    {
                        listCustomer.Rows.RemoveAt(rowIndex);
                        dtgListCustomer.DataSource = listCustomer;
                        btnAddCustomer_Click(sender, e);
                    }
                }
                catch (Exception)
                {
                    Utils.showError(Constants.strFailedDelete);
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            //this.Close();
            Utils.ShowForm(FMain.pnlMain, new FFindTour());
        }

        private void btnContract_Click(object sender, EventArgs e)
        {

            GlobalVarialbe.selectedCustomer = customer;
            Utils.ShowForm(FMain.pnlMain, new FContract());
        }

        private void dtgListCustomer_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            dtgListCustomer_CellClick(sender, e);
            btnContract_Click(sender, e);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if(tbxSearchedCustomer.Text == "")
            {
                FCustomer_Load(sender, e);
            }
            else
            {
                listCustomer = customerModel.getCustomerByPhoneNumber(tbxSearchedCustomer.Text);
                dtgListCustomer.DataSource = listCustomer;
            }
        }

        private void formatDtdListCustomer()
        {
            dtgListCustomer.Columns[0].HeaderText = "Mã KH";
            dtgListCustomer.Columns[1].HeaderText = "Tên";
            dtgListCustomer.Columns[2].HeaderText = "Ngày sinh";
            dtgListCustomer.Columns[3].HeaderText = "Số điện thoại";
            dtgListCustomer.Columns[4].HeaderText = "Số CMT";
            dtgListCustomer.Columns[5].HeaderText = "Số TK";
            dtgListCustomer.Columns[6].HeaderText = "Địa chỉ";
            dtgListCustomer.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dtgListCustomer.Columns[6].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;

            dtgListCustomer.Columns[0].Width = 80;
            dtgListCustomer.Columns[1].Width = 300;
            dtgListCustomer.Columns[2].Width = 140;
            dtgListCustomer.Columns[3].Width = 140;
            dtgListCustomer.Columns[4].Width = 210;
            dtgListCustomer.Columns[5].Width = 210;
            dtgListCustomer.Columns[6].Width = 500;
        }

        private void FCustomer_Load(object sender, EventArgs e)
        {
            try
            {
                listCustomer = customerModel.getAllCustomer();
                dtgListCustomer.DataSource = listCustomer;
                formatDtdListCustomer();
            }
            catch (Exception)
            {
                Utils.showErrorLoadData(Constants.ettCustomer);
            }
        }
    }
}
