using GORIPBS.classes;
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
        BindingSource bindingSource = new BindingSource();
        public CompanyDirectoryForm()
        {
            InitializeComponent();
        }

        private void CompanyDirectoryForm_Load(object sender, EventArgs e)
        {
            companies = new CompanyDirectory();
            bindingSource.DataSource = companies.ListOfCompanies;
            companiesDataGridView.DataSource = bindingSource;
        }
    }
}
