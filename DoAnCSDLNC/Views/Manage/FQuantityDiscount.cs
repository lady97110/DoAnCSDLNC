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
    public partial class FQuantityDiscount : Form
    {
        private QuantityDiscountModel quantityDiscountModel;
        private DataTable listDiscount;
        private int rowIndex, seletedFunction;
        private QuantityDiscount quantityDiscount;
        public FQuantityDiscount()
        {
            InitializeComponent();
            quantityDiscountModel = new QuantityDiscountModel();
            listDiscount = new DataTable();
            rowIndex = 0;
            seletedFunction = 0;
            quantityDiscount = new QuantityDiscount();
        }

        private void fomatDtgListDiscount()
        {
            dtgListDiscount.Columns[0].HeaderText = "Mã chiết khấu";
            dtgListDiscount.Columns[1].HeaderText = "Từ";
            dtgListDiscount.Columns[2].HeaderText = "Đến";
            dtgListDiscount.Columns[3].HeaderText = "Chiết khấu(%)";

            dtgListDiscount.Columns[0].Width = 330;
            dtgListDiscount.Columns[1].Width = 330;
            dtgListDiscount.Columns[2].Width = 330;
            dtgListDiscount.Columns[3].Width = 330;
        }

        private void btnAddDiscount_Click(object sender, EventArgs e)
        {
            seletedFunction = 0;
            tbxMinQuantity.Clear();
            tbxMaxQuantity.Clear();
            tbxDiscountRate.Clear();
        }

        private void btnDeleteDiscount_Click(object sender, EventArgs e)
        {
            if (Utils.showConfirm(Constants.strConfirmDelete) == DialogResult.Yes)
            {
                try
                {
                    if (quantityDiscountModel.deleteQuantityDiscount(quantityDiscount.DiscountId))
                    {
                        listDiscount.Rows.RemoveAt(rowIndex);
                        dtgListDiscount.DataSource = listDiscount;
                        //fomatDtgListDiscount();
                        btnAddDiscount_Click(sender, e);
                    }
                }
                catch (Exception)
                {
                    Utils.showError(Constants.strFailedDelete);
                }
            }
        }

        private void btnSaveDiscount_Click(object sender, EventArgs e)
        {
            quantityDiscount.MinQuantity = int.Parse(tbxMinQuantity.Text);
            quantityDiscount.MaxQuantity = int.Parse(tbxMaxQuantity.Text);
            quantityDiscount.DiscountRate = int.Parse(tbxDiscountRate.Text);
            if (seletedFunction == 0)
            {
                try
                {
                    if (quantityDiscountModel.insertQuantityDiscount(quantityDiscount))
                    {
                        DataRow insertedRow = listDiscount.NewRow();
                        insertedRow[0] = quantityDiscount.DiscountId = quantityDiscountModel.getInsertefdId();
                        insertedRow[1] = quantityDiscount.MinQuantity;
                        insertedRow[2] = quantityDiscount.MaxQuantity;
                        insertedRow[3] = quantityDiscount.DiscountRate;
                        listDiscount.Rows.InsertAt(insertedRow, listDiscount.Rows.Count);
                        dtgListDiscount.DataSource = listDiscount;
                        seletedFunction = 1;
                        rowIndex = dtgListDiscount.RowCount - 1;
                    }
                }
                catch (Exception)
                {
                    Utils.showError(Constants.strFailedInsert);
                }
            }
            else
            {
                if (Utils.showConfirm(Constants.strConfirmUpdate) == DialogResult.Yes)
                {
                    try
                    {
                        if (quantityDiscountModel.updateQuantityDiscount(quantityDiscount))
                        {
                            dtgListDiscount.Rows[rowIndex].Cells[1].Value = quantityDiscount.MinQuantity.ToString();
                            dtgListDiscount.Rows[rowIndex].Cells[2].Value = quantityDiscount.MaxQuantity.ToString();
                            dtgListDiscount.Rows[rowIndex].Cells[3].Value = quantityDiscount.DiscountRate.ToString();
                        }
                    }
                    catch (Exception)
                    {
                        Utils.showError(Constants.strFailedUpdate);
                    }
                }
            }
        }

        private void dtgListDiscount_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            seletedFunction = 1;
            rowIndex = dtgListDiscount.CurrentCell.RowIndex;
            quantityDiscount.DiscountId = int.Parse(dtgListDiscount.Rows[rowIndex].Cells[0].Value.ToString());
            tbxMinQuantity.Text = dtgListDiscount.Rows[rowIndex].Cells[1].Value.ToString();
            tbxMaxQuantity.Text = dtgListDiscount.Rows[rowIndex].Cells[2].Value.ToString();
            tbxDiscountRate.Text = dtgListDiscount.Rows[rowIndex].Cells[3].Value.ToString();
        }

        private void FQuantityDiscount_Load(object sender, EventArgs e)
        {
            try
            {
                listDiscount = quantityDiscountModel.getAllQuantityDiscount();
                dtgListDiscount.DataSource = listDiscount;
                fomatDtgListDiscount();
            }
            catch (Exception)
            {

                Utils.showErrorLoadData(Constants.ettQuantityDiscount);
            }
        }
    }
}
