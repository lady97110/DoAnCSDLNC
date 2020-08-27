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
    public partial class FTour : Form
    {
        private TourModel tourModel;
        private int selectedFunction, rowIndex;
        private DataTable listTour;
        private Tour tour;
        public FTour()
        {
            InitializeComponent();
            tourModel = new TourModel();
            listTour = new DataTable();
            tour = new Tour();
            selectedFunction = 0;
            rowIndex = 0;
        }

        private void tbx_GiaTour_TextChanged(object sender, EventArgs e)
        {
            Utils.tbx_TextBox_TextChanged(sender, e);
        }

        private void formatDtgListTour()
        {
            dtgListTour.Columns[0].HeaderText = "Mã Tour";
            dtgListTour.Columns[1].HeaderText = "Điểm đi";
            dtgListTour.Columns[2].HeaderText = "Điểm đến";
            dtgListTour.Columns[3].HeaderText = "Ngày bắt đầu";
            dtgListTour.Columns[4].HeaderText = "Ngày kết thúc";
            dtgListTour.Columns[5].HeaderText = "Tổng số chỗ";
            dtgListTour.Columns[6].HeaderText = "Số chỗ trống";
            dtgListTour.Columns[7].HeaderText = "Giá Tour";

            dtgListTour.Columns[0].Width = 99;
            dtgListTour.Columns[1].Width = 250;
            dtgListTour.Columns[2].Width = 250;
            dtgListTour.Columns[3].Width = 150;
            dtgListTour.Columns[4].Width = 150;
            dtgListTour.Columns[5].Width = 135;
            dtgListTour.Columns[6].Width = 135;
            dtgListTour.Columns[7].Width = 150;
            dtgListTour.Columns[7].DefaultCellStyle.Format = "#,###";
            for (int i = 0; i < dtgListTour.RowCount; i++)
            {
                if (DateTime.Parse(dtgListTour.Rows[i].Cells[3].Value.ToString()) <= DateTime.Now)
                {
                    dtgListTour.Rows[i].DefaultCellStyle.BackColor = Color.Navy;
                    dtgListTour.Rows[i].DefaultCellStyle.ForeColor = Color.White;
                }
            }
        }

        private void FTour_Load(object sender, EventArgs e)
        {
            try
            {
                listTour = tourModel.getAllTour();
                dtgListTour.DataSource = listTour;
                formatDtgListTour();
            }
            catch (Exception)
            {
                Utils.showErrorLoadData(Constants.ettTour);
            }       
        }

        private void dtgListTour_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedFunction = 1;
            rowIndex = dtgListTour.CurrentCell.RowIndex;
            tour.TourId = int.Parse(dtgListTour.Rows[rowIndex].Cells[0].Value.ToString());
            tbxStartLocation.Text = dtgListTour.Rows[rowIndex].Cells[1].Value.ToString();
            tbxDestination.Text = dtgListTour.Rows[rowIndex].Cells[2].Value.ToString();
            dtpStartDate.Value = DateTime.Parse(dtgListTour.Rows[rowIndex].Cells[3].Value.ToString());
            dtpEndDate.Value = DateTime.Parse(dtgListTour.Rows[rowIndex].Cells[4].Value.ToString());
            tbxTotalSeat.Text = dtgListTour.Rows[rowIndex].Cells[5].Value.ToString();
            tbxEmptySeat.Text = dtgListTour.Rows[rowIndex].Cells[6].Value.ToString();
            tbxPrice.Text = dtgListTour.Rows[rowIndex].Cells[7].Value.ToString();
        }

        private void btnDeleteTour_Click(object sender, EventArgs e)
        {
            if(Utils.showConfirm(Constants.strConfirmDelete) == DialogResult.Yes)
            {
                try
                {
                    if (tourModel.deleteTour(tour.TourId))
                    {
                        listTour.Rows.RemoveAt(rowIndex);
                        dtgListTour.DataSource = listTour;
                        btnAddTour_Click(sender, e);
                    }
                }
                catch
                {
                    Utils.showError(Constants.strFailedDelete);
                }
            }
        }

        private void FTour_Shown(object sender, EventArgs e)
        {
            formatDtgListTour();
        }

        private void btnAddTour_Click(object sender, EventArgs e)
        {
            selectedFunction = 0;
            tbxStartLocation.Clear();
            tbxDestination.Clear();
            dtpStartDate.Value = DateTime.Now;
            dtpEndDate.Value = DateTime.Now;
            tbxTotalSeat.Clear();
            tbxEmptySeat.Clear();
            tbxPrice.Clear();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {            
            tour.StartLocation = tbxStartLocation.Text.ToUpper();
            tour.Destination = tbxDestination.Text.ToUpper();
            tour.StartDate = dtpStartDate.Text.ToString();
            tour.EndDate = dtpEndDate.Text.ToString();
            tour.TotalSeat = int.Parse(tbxTotalSeat.Text);
            tour.EmptySeat = int.Parse(tbxEmptySeat.Text);
            tour.Price = int.Parse(Utils.eraiseComma(tbxPrice.Text));
            if (selectedFunction == 0)
            {
                try
                {
                    if (tourModel.insertTour(tour))
                    {
                        DataRow insertedRow = listTour.NewRow();
                        insertedRow[0] = tour.TourId = tourModel.getInsertedId();
                        insertedRow[1] = tour.StartLocation;
                        insertedRow[2] = tour.Destination;
                        insertedRow[3] = tour.StartDate;
                        insertedRow[4] = tour.EndDate;
                        insertedRow[5] = tour.TotalSeat;
                        insertedRow[6] = tour.EmptySeat;
                        insertedRow[7] = tour.Price;
                        listTour.Rows.InsertAt(insertedRow, 0);
                        dtgListTour.DataSource = listTour;
                        selectedFunction = 1;
                    }
                }
                catch
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
                        if (tourModel.updateTour(tour))
                        {
                            dtgListTour.Rows[rowIndex].Cells[1].Value = tour.StartLocation;
                            dtgListTour.Rows[rowIndex].Cells[2].Value = tour.Destination;
                            dtgListTour.Rows[rowIndex].Cells[3].Value = tour.StartDate;
                            dtgListTour.Rows[rowIndex].Cells[4].Value = tour.EndDate;
                            dtgListTour.Rows[rowIndex].Cells[5].Value = tour.TotalSeat;
                            dtgListTour.Rows[rowIndex].Cells[6].Value = tour.EmptySeat;
                            dtgListTour.Rows[rowIndex].Cells[7].Value = tour.Price;
                        }
                    }
                    catch
                    {
                        Utils.showError(Constants.strFailedUpdate);
                    }
                }                
            }
        }
    }
}
