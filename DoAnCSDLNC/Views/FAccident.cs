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

namespace DoAnCSDLNC.Views
{
    public partial class FAccident : Form
    {
        private ContractModel contractModel;
        private DataTable listContract, listAccident;
        int selectedFunction, rowIndex;
        private AccidentModel accidentModel;
        private Accident accident;
        public FAccident()
        {
            InitializeComponent();
            contractModel = new ContractModel();
            listContract = new DataTable();
            listAccident = new DataTable();
            accidentModel = new AccidentModel();
            selectedFunction = rowIndex = 0;
            accident = new Accident();
        }

        private void FAccident_Load(object sender, EventArgs e)
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

        public void formatDtgListAccident()
        {
            dtgListAccident.Columns[1].Visible = false;
            dtgListAccident.Columns[0].HeaderText = "Mã SC";
            dtgListAccident.Columns[2].HeaderText = "Tên sự cố";
            dtgListAccident.Columns[3].HeaderText = "Ngày lập";
            dtgListAccident.Columns[4].HeaderText = "Bồi thường";
            dtgListAccident.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            dtgListAccident.Columns[0].Width = 100;
            dtgListAccident.Columns[2].Width = 819;
            dtgListAccident.Columns[3].Width = 200;
            dtgListAccident.Columns[4].Width = 200;

            for (int i = 0; i < dtgListAccident.RowCount; i++)
            {
                if (dtgListAccident.Rows[i].Cells[4].Value.ToString() != "0")
                {
                    dtgListAccident.Rows[i].Cells[4].Style.Format = "#,###";
                }
            }
        }

        private void tbxPayDamage_TextChanged(object sender, EventArgs e)
        {
            Utils.tbx_TextBox_TextChanged(sender, e);
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            
            accident.AccidentName = tbxAccidentName.Text;
            accident.DraftDate = dtpDraftDate.Text;
            if(tbxPayDamage.Text == "")
            {
                accident.PayDamage = 0;
            }
            else
            {
                accident.PayDamage = int.Parse(Utils.eraiseComma(tbxPayDamage.Text));
            }
            if(selectedFunction == 0)
            {
                try
                {
                    if (accidentModel.insertAccident(accident))
                    {
                        DataRow insertedRow = listAccident.NewRow();
                        insertedRow[0] = accident.AccidentId = accidentModel.getInsertefdId();
                        insertedRow[2] = accident.AccidentName;
                       // insertedRow[3] = accident.DraftDate;
                        insertedRow[4] = accident.PayDamage;
                        listAccident.Rows.InsertAt(insertedRow, 0);
                        dtgListAccident.DataSource = listAccident;
                        formatDtgListAccident();
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
                        if (accidentModel.updateAccident(accident))
                        {
                            dtgListAccident.Rows[rowIndex].Cells[2].Value = accident.AccidentName;
                            dtgListAccident.Rows[rowIndex].Cells[4].Value = accident.PayDamage.ToString();
                            formatDtgListAccident();
                        }
                    }
                    catch (Exception)
                    {
                        Utils.showError(Constants.strFailedUpdate);
                    }
                }
            }
        }

        private void btn_ThemSC_Click(object sender, EventArgs e)
        {
            cbxContractId.SelectedIndex = -1;
            tbxAccidentName.Clear();
            tbxPayDamage.Clear();
            selectedFunction = 0;
        }

        private void btn_XoaSC_Click(object sender, EventArgs e)
        {
            if(Utils.showConfirm(Constants.strConfirmDelete) == DialogResult.Yes)
            {
                try
                {
                    if (accidentModel.deleteAccident(accident))
                    {
                        listAccident.Rows.RemoveAt(rowIndex);
                        dtgListAccident.DataSource = listAccident;
                        formatDtgListAccident();
                    }
                }
                catch (Exception)
                {
                    Utils.showError(Constants.strFailedDelete);
                }
            }
        }

        private void dtgListAccident_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedFunction = 1;
            rowIndex = dtgListAccident.CurrentCell.RowIndex;
            accident.AccidentId = int.Parse(dtgListAccident.Rows[rowIndex].Cells[0].Value.ToString());
            tbxAccidentName.Text = dtgListAccident.Rows[rowIndex].Cells[2].Value.ToString();
            dtpDraftDate.Value = DateTime.Parse(dtgListAccident.Rows[rowIndex].Cells[3].Value.ToString());
            tbxPayDamage.Text = dtgListAccident.Rows[rowIndex].Cells[4].Value.ToString();
        }

        private void cbxContractId_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if(cbxContractId.SelectedIndex > -1)
            {
                accident.ContractId = int.Parse(cbxContractId.Text);
                try
                {
                    listAccident = accidentModel.getAccidentsByContract(accident.ContractId);
                    dtgListAccident.DataSource = listAccident;
                    formatDtgListAccident();
                }
                catch (Exception)
                {
                    Utils.showErrorLoadData("Sự cố");
                }
            }
        }
    }
}
