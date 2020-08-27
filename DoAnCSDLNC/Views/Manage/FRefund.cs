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

namespace DoAnCSDLNC.Views.Manage
{
    public partial class FRefund : Form
    {
        private RefundModel refundModel;
        private DataTable listRefund;
        private int selectedFunction, rowIndex;
        private Refund refund;
        public FRefund()
        {
            InitializeComponent();
            refundModel = new RefundModel();
            listRefund = new DataTable();
            selectedFunction = 0;
            refund = new Refund();
        }

        private void fomatDtgListRefund()
        {
            dtgListRefund.Columns[0].HeaderText = "Mã hoàn cọc";
            dtgListRefund.Columns[1].HeaderText = "Từ(Ngày)";
            dtgListRefund.Columns[2].HeaderText = "Đến(Ngày)";
            dtgListRefund.Columns[3].HeaderText = "Hoàn cọc(%)";

            dtgListRefund.Columns[0].Width = 330;
            dtgListRefund.Columns[1].Width = 330;
            dtgListRefund.Columns[2].Width = 330;
            dtgListRefund.Columns[3].Width = 330;

        }

        private void FRefund_Load(object sender, EventArgs e)
        {
            try
            {
                listRefund = refundModel.getAllRefund();
                dtgListRefund.DataSource = listRefund;
                fomatDtgListRefund();
            }
            catch (Exception)
            {
                Utils.showErrorLoadData(Constants.ettRefund);
            }
        }

        private void btnAddRefund_Click(object sender, EventArgs e)
        {
            selectedFunction = 0;
            tbxMinday.Clear();
            tbxMaxDay.Clear();
            tbxRefundRate.Clear();
        }

        private void btnDeleteRefund_Click(object sender, EventArgs e)
        {
            if(Utils.showConfirm(Constants.strConfirmDelete) == DialogResult.Yes)
            {
                try
                {
                    if (refundModel.deleteRefund(refund.RefundId))
                    {
                        listRefund.Rows.RemoveAt(rowIndex);
                        dtgListRefund.DataSource = listRefund;
                        //fomatDtgListRefund();
                        btnAddRefund_Click(sender, e);
                    }
                }
                catch (Exception)
                {
                    Utils.showError(Constants.strFailedDelete);
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            refund.MinDay = int.Parse(tbxMinday.Text);
            refund.MaxDay = int.Parse(tbxMaxDay.Text);
            refund.RefundRate = int.Parse(tbxRefundRate.Text);
            if(selectedFunction == 0)
            {
                try
                {
                    if (refundModel.insertRefund(refund))
                    {
                        DataRow insertedRow = listRefund.NewRow();
                        insertedRow[0] = refund.RefundId = refundModel.getInsertedId();
                        insertedRow[1] = refund.MinDay;
                        insertedRow[2] = refund.MaxDay;
                        insertedRow[3] = refund.RefundRate;
                        listRefund.Rows.InsertAt(insertedRow, listRefund.Rows.Count);
                        dtgListRefund.DataSource = listRefund;
                        fomatDtgListRefund();
                        selectedFunction = 1;
                        rowIndex = dtgListRefund.RowCount - 1;
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
                        try
                        {
                            if (refundModel.updateRefund(refund))
                            {
                                dtgListRefund.Rows[rowIndex].Cells[1].Value = refund.MinDay.ToString();
                                dtgListRefund.Rows[rowIndex].Cells[2].Value = refund.MaxDay.ToString();
                                dtgListRefund.Rows[rowIndex].Cells[3].Value = refund.RefundRate.ToString();
                            }
                        }
                        catch (Exception)
                        {
                            Utils.showError(Constants.strFailedUpdate);
                        }
                    }                    
                }
                catch (Exception)
                {
                    Utils.showError(Constants.strFailedUpdate);
                }
            }
        }

        private void dtgListRefund_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedFunction = 1;
            rowIndex = dtgListRefund.CurrentCell.RowIndex;
            refund.RefundId = int.Parse(dtgListRefund.Rows[rowIndex].Cells[0].Value.ToString());
            tbxMinday.Text = dtgListRefund.Rows[rowIndex].Cells[1].Value.ToString();
            tbxMaxDay.Text = dtgListRefund.Rows[rowIndex].Cells[2].Value.ToString();
            tbxRefundRate.Text = dtgListRefund.Rows[rowIndex].Cells[3].Value.ToString();
        }
    }
}
