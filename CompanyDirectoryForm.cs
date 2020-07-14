﻿using GORIPBS.classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GORIPBS
{
    public partial class CompanyDirectoryForm : Form
    {
        CompanyDirectory companies;
        BindingSource bindingSource;
        int selectedDataGridViewCellRowIndex;
        int selectedDataGridViewCellColumnIndex;
        public CompanyDirectoryForm()
        {
            InitializeComponent();
            companies = new CompanyDirectory();
            bindingSource = new BindingSource();
        }

        private void CompanyDirectoryForm_Load(object sender, EventArgs e)
        {
            bindingSource.DataSource = companies.ListOfCompanies;
            companiesDataGridView.DataSource = bindingSource;
            companiesDataGridView.Columns["CompanyID"].Visible = false;
            selectedDataGridViewCellRowIndex = -1;
            selectedDataGridViewCellColumnIndex = -2;
        }

        private void companiesDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedDataGridViewCellRowIndex = e.RowIndex;
            selectedDataGridViewCellColumnIndex = e.ColumnIndex;
            if (validateSelectedRowAndColumn(e.RowIndex, e.ColumnIndex)) 
            {
                DataGridViewRow dataGridViewRow = companiesDataGridView.Rows[e.RowIndex];
                populateTextBoxesWithDataFromSelectedRow(dataGridViewRow);
            }
        }

        private bool validateSelectedRowAndColumn(int row, int column) 
        {
            return (row > -1 && column > -2);
        }

        private void populateTextBoxesWithDataFromSelectedRow(DataGridViewRow row) 
        {
            companyNameTextBox.Text = row.Cells[1].Value.ToString();
            pibTextBox.Text = row.Cells[2].Value.ToString();
            addressTextBox.Text = row.Cells[3].Value.ToString();
            cityTextBox.Text = row.Cells[4].Value.ToString();
            postalCodeTextBox.Text = row.Cells[5].Value.ToString();
            ownerTextBox.Text = row.Cells[6].Value.ToString();
            bankAccountTextBox.Text = row.Cells[7].Value.ToString();
            idNumberTextBox.Text = row.Cells[8].Value.ToString();
            bankTextBox.Text = row.Cells[9].Value.ToString();
            activityCodeTextBox.Text = row.Cells[10].Value.ToString();
            telephoneTextBox.Text = row.Cells[11].Value.ToString();
            mobileNumberTextBox.Text = row.Cells[12].Value.ToString();
            emailTextBox.Text = row.Cells[13].Value.ToString();
            faxTextBox.Text = row.Cells[14].Value.ToString();
        }

        private void addNewEmptyCompanyButton_Click(object sender, EventArgs e)
        {
            companies.insertEmptyCompanyIntoList();
            bindingSource.ResetBindings(false);
        }

        private void deleteCompanyButton_Click(object sender, EventArgs e)
        {
            if (validateSelectedRowAndColumn(selectedDataGridViewCellRowIndex, selectedDataGridViewCellColumnIndex))
            {
                DialogResult dialogResult = MessageBox.Show("Da li ste sigurni da želite da obrišete izabranu firmu?", "Brisanje firme", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    if (companies.deleteCompany(selectedDataGridViewCellRowIndex))
                    {
                        MessageBox.Show("Firma je uspešno obrisana.");
                        bindingSource.ResetBindings(false);
                    }
                    else
                        MessageBox.Show("Došlo je do greške prilikom brisanja firme!");
                }
            }
            else
            {
                MessageBox.Show("Izaberite firmu koju hoćete da obrišete.");
            }
        }
    }
}
