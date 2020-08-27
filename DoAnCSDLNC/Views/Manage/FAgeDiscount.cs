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
    public partial class FAgeDiscount : Form
    {
        private AgeDiscountModel ageDiscountModel;
        private DataTable listDiscount;
        private int rowIndex, seletedFunction;
        private AgeDiscount ageDiscount;
        public FAgeDiscount()
        {
            InitializeComponent();
            ageDiscountModel = new AgeDiscountModel();
            listDiscount = new DataTable();
            rowIndex = 0;
            seletedFunction = 0;
            ageDiscount = new AgeDiscount();
        }

        private void btnAddDiscount_Click(object sender, EventArgs e)
        {
            seletedFunction = 0;
            tbxMinAge.Clear();
            tbxMaxAge.Clear();
            tbxDiscountRate.Clear();
        }

        private void btnSaveDiscount_Click(object sender, EventArgs e)
        {
            ageDiscount.MinAge = int.Parse(tbxMinAge.Text);
            ageDiscount.MaxAge = int.Parse(tbxMaxAge.Text);
            ageDiscount.DiscountRate = int.Parse(tbxDiscountRate.Text);
            if (seletedFunction == 0)
            {
                try
                {
                    if (ageDiscountModel.insertAgeDiscount(ageDiscount))
                    {
                        DataRow insertedRow = listDiscount.NewRow();
                        insertedRow[0] = ageDiscount.DiscountId = ageDiscountModel.getInsertefdId();
                        insertedRow[1] = ageDiscount.MinAge;
                        insertedRow[2] = ageDiscount.MaxAge;
                        insertedRow[3] = ageDiscount.DiscountRate;
                        listDiscount.Rows.InsertAt(insertedRow, listDiscount.Rows.Count);
                        dtgListDiscount.DataSource = listDiscount;
                        fomatDtgListDiscount();
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
                        if (ageDiscountModel.updateAgeDiscount(ageDiscount))
                        {
                            dtgListDiscount.Rows[rowIndex].Cells[1].Value = ageDiscount.MinAge.ToString();
                            dtgListDiscount.Rows[rowIndex].Cells[2].Value = ageDiscount.MaxAge.ToString();
                            dtgListDiscount.Rows[rowIndex].Cells[3].Value = ageDiscount.DiscountRate.ToString();
                        }
                    }
                    catch (Exception)
                    {
                        Utils.showError(Constants.strFailedUpdate);
                    }
                }
            }
        }

        private void btnDeleteDiscount_Click(object sender, EventArgs e)
        {
            if (Utils.showConfirm(Constants.strConfirmDelete) == DialogResult.Yes)
            {
                try
                {
                    if (ageDiscountModel.deleteAgeDiscount(ageDiscount.DiscountId))
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

        private void dtgListDiscount_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            seletedFunction = 1;
            rowIndex = dtgListDiscount.CurrentCell.RowIndex;
            ageDiscount.DiscountId = int.Parse(dtgListDiscount.Rows[rowIndex].Cells[0].Value.ToString());
            tbxMinAge.Text = dtgListDiscount.Rows[rowIndex].Cells[1].Value.ToString();
            tbxMaxAge.Text = dtgListDiscount.Rows[rowIndex].Cells[2].Value.ToString();
            tbxDiscountRate.Text = dtgListDiscount.Rows[rowIndex].Cells[3].Value.ToString();
        }

        private void fomatDtgListDiscount()
        {
            dtgListDiscount.Columns[0].HeaderText = "Mã chiết khấu";
            dtgListDiscount.Columns[1].HeaderText = "Từ(Tuổi)";
            dtgListDiscount.Columns[2].HeaderText = "Đến(Tuổi)";
            dtgListDiscount.Columns[3].HeaderText = "Chiết khấu(%)";

            dtgListDiscount.Columns[0].Width = 330;
            dtgListDiscount.Columns[1].Width = 330;
            dtgListDiscount.Columns[2].Width = 330;
            dtgListDiscount.Columns[3].Width = 330;
        }

        private void FAgeDiscount_Load(object sender, EventArgs e)
        {
            try
            {
                listDiscount = ageDiscountModel.getAllAgeDiscount();
                dtgListDiscount.DataSource = listDiscount;
                fomatDtgListDiscount();
            }
            catch (Exception)
            {

                Utils.showErrorLoadData(Constants.ettAgeDiscount);
            }
        }
    }
}
