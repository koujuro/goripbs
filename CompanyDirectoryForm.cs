using GORIPBS.classes;
using GORIPBS.classes.entities;
using GORIPBS.database;
using Microsoft.SqlServer.Server;
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
        List<Company> reducedCompaniesDirectory;
        BindingSource bindingSource;
        int selectedDataGridViewCellRowIndex;
        int selectedDataGridViewCellColumnIndex;
        int selectedCompanyId;

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
            selectedCompanyId = -1;
        }

        private void companiesDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedDataGridViewCellRowIndex = e.RowIndex;
            selectedDataGridViewCellColumnIndex = e.ColumnIndex;
            if (validateSelectedRowAndColumn(e.RowIndex, e.ColumnIndex)) 
            {
                DataGridViewRow dataGridViewRow = companiesDataGridView.Rows[e.RowIndex];
                populateTextBoxesWithDataFromSelectedRow(dataGridViewRow);
                selectedCompanyId = Int32.Parse(companiesDataGridView.Rows[selectedDataGridViewCellRowIndex].Cells["CompanyId"].Value.ToString());
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

        private void saveCompanyButton_Click(object sender, EventArgs e)
        {
            if (validateSelectedRowAndColumn(selectedDataGridViewCellRowIndex, selectedDataGridViewCellColumnIndex))
            {
                try
                {
                    savingCompanyWithCompanyDirectory();
                    searchCompanyTextBox.Clear();
                }
                catch (FormatException)
                {
                    MessageBox.Show("Neki od unetih podataka nisu validni!");
                }
                catch (SQLiteException ex)
                {
                    if (ex.ErrorCode == 19)
                        MessageBox.Show("PIB koji ste uneli već postoji!", "Greška prilikom čuvanja podataka u bazi");
                }
            }
            else
                MessageBox.Show("Izaberite firmu koju želite da ažurirate!");
        }

        private void savingCompanyWithCompanyDirectory() 
        {
            Company editedCompany = createCompanyFromForm();
            if (companies.saveCompany(editedCompany))
            {
                MessageBox.Show("Izmene su uspešno sačuvane.");
                companies.updateCompanyInListOfCompanies(editedCompany);
                refreshElementsInForm();
            }
            else
                MessageBox.Show("Došlo je do greške prilikom čuvanja izmena!");
        }

        private Company createCompanyFromForm() 
        {

            return new Company(selectedCompanyId,
                companyNameTextBox.Text,
                pibTextBox.Text,
                addressTextBox.Text,
                cityTextBox.Text,
                Int32.Parse(postalCodeTextBox.Text),
                ownerTextBox.Text,
                bankAccountTextBox.Text,
                idNumberTextBox.Text,
                bankTextBox.Text,
                Int32.Parse(activityCodeTextBox.Text),
                telephoneTextBox.Text,
                mobileNumberTextBox.Text,
                emailTextBox.Text,
                faxTextBox.Text);
        }

        private void deleteCompanyButton_Click(object sender, EventArgs e)
        {
            if (validateSelectedRowAndColumn(selectedDataGridViewCellRowIndex, selectedDataGridViewCellColumnIndex))
            {
                DialogResult dialogResult = MessageBox.Show("Da li ste sigurni da želite da obrišete izabranu firmu?", "Brisanje firme", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    if (companies.deleteCompany(selectedCompanyId))
                    {
                        MessageBox.Show("Firma je uspešno obrisana.");
                        refreshElementsInForm();
                        searchCompanyTextBox.Clear();
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

        private void refreshElementsInForm() 
        {
            resetSavedSelectedValues();
            resetTextBoxes();
            bindingSource.ResetBindings(false);
        }

        private void resetSavedSelectedValues() 
        {
            selectedDataGridViewCellRowIndex = -1;
            selectedDataGridViewCellColumnIndex = -2;
            selectedCompanyId = -1;
        }

        private void resetTextBoxes() 
        {
            companyNameTextBox.Clear();
            pibTextBox.Clear();
            addressTextBox.Clear();
            cityTextBox.Clear();
            postalCodeTextBox.Clear();
            ownerTextBox.Clear();
            bankAccountTextBox.Clear();
            idNumberTextBox.Clear();
            bankTextBox.Clear();
            activityCodeTextBox.Clear();
            telephoneTextBox.Clear();
            mobileNumberTextBox.Clear();
            emailTextBox.Clear();
            faxTextBox.Clear();
        }

        private void searchCompanyTextBox_TextChanged(object sender, EventArgs e)
        {
            if (searchCompanyTextBox.Text != "")
            {
                reducedCompaniesDirectory = new List<Company>();
                foreach (Company company in companies.ListOfCompanies)
                {
                    if (company.Name.ToLower().Contains(searchCompanyTextBox.Text.ToLower()))
                        reducedCompaniesDirectory.Add(company);
                }
                bindingSource.DataSource = reducedCompaniesDirectory;
            }
            else 
            {
                reducedCompaniesDirectory = null;
                bindingSource.DataSource = companies.ListOfCompanies;
            }
            refreshElementsInForm();
        }

        private void exitFormButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CompanyDirectoryForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SqlHandler.closeConnectionToDataBase();
        }
    }
}
