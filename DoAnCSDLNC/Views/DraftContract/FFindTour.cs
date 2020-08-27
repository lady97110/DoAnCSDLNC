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
using DoAnCSDLNC.Classes;
using DoAnCSDLNC.Shared;
using DoAnCSDLNC.Models;

namespace DoAnCSDLNC.Views.DraftContract
{
    public partial class FFindTour : Form
    {
        private TourModel tourModel;
        private DataTable listTour;
        private Tour tour;
        private int rowIndex;
        public FFindTour()
        {
            InitializeComponent();
            tourModel = new TourModel();
            listTour = new DataTable();
            tour = new Tour();
            rowIndex = 0;
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
        }

        private void FFindingTour_Load(object sender, EventArgs e)
        {
            try
            {
                //dtgListTour.DataSource = tourModel.getValidTour();
               // formatDtgListTour();

                listTour = tourModel.getValidTour();
                dtgListTour.DataSource = listTour;
                formatDtgListTour();
            }
            catch
            {
                Utils.showErrorLoadData(Constants.ettTour);
            }            
        }

        private void tbxPriceChanged(object sender, EventArgs e)
        {
            Utils.tbx_TextBox_TextChanged(sender, e);           
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if(!chbxLocation.Checked && !chbxDate.Checked && !chbxPrice.Checked)
            {
                FFindingTour_Load(sender, e);
            }
            else
            {
                List<string> whereArgs = new List<string>();
                whereArgs.Add(chbxLocation.Checked.ToString());
                whereArgs.Add(tbxStartLocation.Text);
                whereArgs.Add(tbxDestination.Text);
                whereArgs.Add(chbxDate.Checked.ToString());
                whereArgs.Add(dtpFromDate.Text);
                whereArgs.Add(dtpEndDate.Text);
                whereArgs.Add(chbxPrice.Checked.ToString());
                whereArgs.Add(Utils.eraiseComma(tbxMinPrice.Text));
                whereArgs.Add(Utils.eraiseComma(tbxMaxPrice.Text));
                try
                {
                    dtgListTour.DataSource = tourModel.getValidTourWhere(whereArgs);
                    formatDtgListTour();
                }
                catch
                {
                    Utils.showErrorLoadData(Constants.ettTour);
                }
            }            
        }

        private void btnNext_Click(object sender, EventArgs e)
        {

            int tourId = int.Parse(dtgListTour.Rows[rowIndex].Cells[0].Value.ToString());
            string startLocation = dtgListTour.Rows[rowIndex].Cells[1].Value.ToString();
            string destination = dtgListTour.Rows[rowIndex].Cells[2].Value.ToString();
            string startDate = dtgListTour.Rows[rowIndex].Cells[3].Value.ToString();
            string endDate = dtgListTour.Rows[rowIndex].Cells[4].Value.ToString();
            int totalSeat = int.Parse(dtgListTour.Rows[rowIndex].Cells[5].Value.ToString());
            int emptySeat = int.Parse(dtgListTour.Rows[rowIndex].Cells[6].Value.ToString());
            int price = int.Parse(dtgListTour.Rows[rowIndex].Cells[7].Value.ToString());
            GlobalVarialbe.selectedTour = new Tour(tourId, startLocation, destination, startDate, endDate, totalSeat, emptySeat, price);
            Utils.ShowForm(FMain.pnlMain, new FCustomer());
        }

        private void dtgListTour_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            rowIndex = dtgListTour.CurrentCell.RowIndex;
        }

        private void dtgListTour_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            dtgListTour_CellClick(sender, e);
            btnNext_Click(sender, e);
        }
    }
}
