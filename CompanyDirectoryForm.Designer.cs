namespace GORIPBS
{
    partial class CompanyDirectoryForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.searchCompanyGroupBox = new System.Windows.Forms.GroupBox();
            this.searchCompanyButton = new System.Windows.Forms.Button();
            this.searchCompanyTextBox = new System.Windows.Forms.TextBox();
            this.addNewEmptyCompanyButton = new System.Windows.Forms.Button();
            this.saveCompanyButton = new System.Windows.Forms.Button();
            this.deleteCompanyButton = new System.Windows.Forms.Button();
            this.exitFormButton = new System.Windows.Forms.Button();
            this.companiesDataGridView = new System.Windows.Forms.DataGridView();
            this.companyNameLabel = new System.Windows.Forms.Label();
            this.pibLabel = new System.Windows.Forms.Label();
            this.addressLabel = new System.Windows.Forms.Label();
            this.cityLabel = new System.Windows.Forms.Label();
            this.postalLabel = new System.Windows.Forms.Label();
            this.ownerLabel = new System.Windows.Forms.Label();
            this.bankAccountLabel = new System.Windows.Forms.Label();
            this.idNumberLabel = new System.Windows.Forms.Label();
            this.bankLabel = new System.Windows.Forms.Label();
            this.activityCodeLabel = new System.Windows.Forms.Label();
            this.telephoneLabel = new System.Windows.Forms.Label();
            this.mobilePhoneLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.faxLabel = new System.Windows.Forms.Label();
            this.companyNameTextBox = new System.Windows.Forms.TextBox();
            this.pibTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.postalCodeTextBox = new System.Windows.Forms.TextBox();
            this.ownerTextBox = new System.Windows.Forms.TextBox();
            this.bankAccountTextBox = new System.Windows.Forms.TextBox();
            this.idNumberTextBox = new System.Windows.Forms.TextBox();
            this.bankTextBox = new System.Windows.Forms.TextBox();
            this.activityCodeTextBox = new System.Windows.Forms.TextBox();
            this.telephoneTextBox = new System.Windows.Forms.TextBox();
            this.mobileNumberTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.faxTextBox = new System.Windows.Forms.TextBox();
            this.searchCompanyGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.companiesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // searchCompanyGroupBox
            // 
            this.searchCompanyGroupBox.Controls.Add(this.searchCompanyButton);
            this.searchCompanyGroupBox.Controls.Add(this.searchCompanyTextBox);
            this.searchCompanyGroupBox.Location = new System.Drawing.Point(12, 12);
            this.searchCompanyGroupBox.Name = "searchCompanyGroupBox";
            this.searchCompanyGroupBox.Size = new System.Drawing.Size(200, 77);
            this.searchCompanyGroupBox.TabIndex = 0;
            this.searchCompanyGroupBox.TabStop = false;
            this.searchCompanyGroupBox.Text = "Pretraga Po Nazivu Firme:";
            // 
            // searchCompanyButton
            // 
            this.searchCompanyButton.Location = new System.Drawing.Point(151, 29);
            this.searchCompanyButton.Name = "searchCompanyButton";
            this.searchCompanyButton.Size = new System.Drawing.Size(42, 23);
            this.searchCompanyButton.TabIndex = 2;
            this.searchCompanyButton.Text = "*Search*";
            this.searchCompanyButton.UseVisualStyleBackColor = true;
            // 
            // searchCompanyTextBox
            // 
            this.searchCompanyTextBox.Location = new System.Drawing.Point(6, 31);
            this.searchCompanyTextBox.Name = "searchCompanyTextBox";
            this.searchCompanyTextBox.Size = new System.Drawing.Size(139, 20);
            this.searchCompanyTextBox.TabIndex = 1;
            this.searchCompanyTextBox.TextChanged += new System.EventHandler(this.searchCompanyTextBox_TextChanged);
            // 
            // addNewEmptyCompanyButton
            // 
            this.addNewEmptyCompanyButton.Location = new System.Drawing.Point(218, 28);
            this.addNewEmptyCompanyButton.Name = "addNewEmptyCompanyButton";
            this.addNewEmptyCompanyButton.Size = new System.Drawing.Size(138, 49);
            this.addNewEmptyCompanyButton.TabIndex = 1;
            this.addNewEmptyCompanyButton.Text = "** Dodaj";
            this.addNewEmptyCompanyButton.UseVisualStyleBackColor = true;
            this.addNewEmptyCompanyButton.Click += new System.EventHandler(this.addNewEmptyCompanyButton_Click);
            // 
            // saveCompanyButton
            // 
            this.saveCompanyButton.Location = new System.Drawing.Point(362, 28);
            this.saveCompanyButton.Name = "saveCompanyButton";
            this.saveCompanyButton.Size = new System.Drawing.Size(138, 49);
            this.saveCompanyButton.TabIndex = 2;
            this.saveCompanyButton.Text = "** Sačuvaj";
            this.saveCompanyButton.UseVisualStyleBackColor = true;
            this.saveCompanyButton.Click += new System.EventHandler(this.saveCompanyButton_Click);
            // 
            // deleteCompanyButton
            // 
            this.deleteCompanyButton.Location = new System.Drawing.Point(506, 28);
            this.deleteCompanyButton.Name = "deleteCompanyButton";
            this.deleteCompanyButton.Size = new System.Drawing.Size(138, 49);
            this.deleteCompanyButton.TabIndex = 3;
            this.deleteCompanyButton.Text = "** Obriši";
            this.deleteCompanyButton.UseVisualStyleBackColor = true;
            this.deleteCompanyButton.Click += new System.EventHandler(this.deleteCompanyButton_Click);
            // 
            // exitFormButton
            // 
            this.exitFormButton.Location = new System.Drawing.Point(650, 28);
            this.exitFormButton.Name = "exitFormButton";
            this.exitFormButton.Size = new System.Drawing.Size(138, 49);
            this.exitFormButton.TabIndex = 4;
            this.exitFormButton.Text = "Izlaz";
            this.exitFormButton.UseVisualStyleBackColor = true;
            // 
            // companiesDataGridView
            // 
            this.companiesDataGridView.AllowUserToAddRows = false;
            this.companiesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.companiesDataGridView.Location = new System.Drawing.Point(12, 95);
            this.companiesDataGridView.Name = "companiesDataGridView";
            this.companiesDataGridView.ReadOnly = true;
            this.companiesDataGridView.Size = new System.Drawing.Size(488, 343);
            this.companiesDataGridView.TabIndex = 5;
            this.companiesDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.companiesDataGridView_CellClick);
            // 
            // companyNameLabel
            // 
            this.companyNameLabel.AutoSize = true;
            this.companyNameLabel.Location = new System.Drawing.Point(522, 95);
            this.companyNameLabel.Name = "companyNameLabel";
            this.companyNameLabel.Size = new System.Drawing.Size(37, 13);
            this.companyNameLabel.TabIndex = 6;
            this.companyNameLabel.Text = "Naziv:";
            // 
            // pibLabel
            // 
            this.pibLabel.AutoSize = true;
            this.pibLabel.Location = new System.Drawing.Point(522, 153);
            this.pibLabel.Name = "pibLabel";
            this.pibLabel.Size = new System.Drawing.Size(27, 13);
            this.pibLabel.TabIndex = 7;
            this.pibLabel.Text = "PIB:";
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Location = new System.Drawing.Point(522, 175);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(43, 13);
            this.addressLabel.TabIndex = 8;
            this.addressLabel.Text = "Adresa:";
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.Location = new System.Drawing.Point(522, 197);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(39, 13);
            this.cityLabel.TabIndex = 9;
            this.cityLabel.Text = "Mesto:";
            // 
            // postalLabel
            // 
            this.postalLabel.AutoSize = true;
            this.postalLabel.Location = new System.Drawing.Point(522, 219);
            this.postalLabel.Name = "postalLabel";
            this.postalLabel.Size = new System.Drawing.Size(54, 13);
            this.postalLabel.TabIndex = 10;
            this.postalLabel.Text = "Pošt. broj:";
            // 
            // ownerLabel
            // 
            this.ownerLabel.AutoSize = true;
            this.ownerLabel.Location = new System.Drawing.Point(522, 241);
            this.ownerLabel.Name = "ownerLabel";
            this.ownerLabel.Size = new System.Drawing.Size(44, 13);
            this.ownerLabel.TabIndex = 11;
            this.ownerLabel.Text = "Vlasnik:";
            // 
            // bankAccountLabel
            // 
            this.bankAccountLabel.AutoSize = true;
            this.bankAccountLabel.Location = new System.Drawing.Point(522, 264);
            this.bankAccountLabel.Name = "bankAccountLabel";
            this.bankAccountLabel.Size = new System.Drawing.Size(68, 13);
            this.bankAccountLabel.TabIndex = 12;
            this.bankAccountLabel.Text = "Bank. račun:";
            // 
            // idNumberLabel
            // 
            this.idNumberLabel.AutoSize = true;
            this.idNumberLabel.Location = new System.Drawing.Point(522, 286);
            this.idNumberLabel.Name = "idNumberLabel";
            this.idNumberLabel.Size = new System.Drawing.Size(64, 13);
            this.idNumberLabel.TabIndex = 13;
            this.idNumberLabel.Text = "Matični broj:";
            // 
            // bankLabel
            // 
            this.bankLabel.AutoSize = true;
            this.bankLabel.Location = new System.Drawing.Point(522, 308);
            this.bankLabel.Name = "bankLabel";
            this.bankLabel.Size = new System.Drawing.Size(41, 13);
            this.bankLabel.TabIndex = 14;
            this.bankLabel.Text = "Banka:";
            // 
            // activityCodeLabel
            // 
            this.activityCodeLabel.AutoSize = true;
            this.activityCodeLabel.Location = new System.Drawing.Point(522, 330);
            this.activityCodeLabel.Name = "activityCodeLabel";
            this.activityCodeLabel.Size = new System.Drawing.Size(79, 13);
            this.activityCodeLabel.TabIndex = 15;
            this.activityCodeLabel.Text = "Šifra delatnosti:";
            // 
            // telephoneLabel
            // 
            this.telephoneLabel.AutoSize = true;
            this.telephoneLabel.Location = new System.Drawing.Point(522, 353);
            this.telephoneLabel.Name = "telephoneLabel";
            this.telephoneLabel.Size = new System.Drawing.Size(46, 13);
            this.telephoneLabel.TabIndex = 16;
            this.telephoneLabel.Text = "Telefon:";
            // 
            // mobilePhoneLabel
            // 
            this.mobilePhoneLabel.AutoSize = true;
            this.mobilePhoneLabel.Location = new System.Drawing.Point(522, 375);
            this.mobilePhoneLabel.Name = "mobilePhoneLabel";
            this.mobilePhoneLabel.Size = new System.Drawing.Size(60, 13);
            this.mobilePhoneLabel.TabIndex = 17;
            this.mobilePhoneLabel.Text = "Mobilni tel.:";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(522, 398);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(35, 13);
            this.emailLabel.TabIndex = 18;
            this.emailLabel.Text = "Email:";
            // 
            // faxLabel
            // 
            this.faxLabel.AutoSize = true;
            this.faxLabel.Location = new System.Drawing.Point(522, 420);
            this.faxLabel.Name = "faxLabel";
            this.faxLabel.Size = new System.Drawing.Size(27, 13);
            this.faxLabel.TabIndex = 19;
            this.faxLabel.Text = "Fax:";
            // 
            // companyNameTextBox
            // 
            this.companyNameTextBox.Location = new System.Drawing.Point(612, 92);
            this.companyNameTextBox.Multiline = true;
            this.companyNameTextBox.Name = "companyNameTextBox";
            this.companyNameTextBox.Size = new System.Drawing.Size(175, 52);
            this.companyNameTextBox.TabIndex = 20;
            // 
            // pibTextBox
            // 
            this.pibTextBox.Location = new System.Drawing.Point(612, 150);
            this.pibTextBox.Name = "pibTextBox";
            this.pibTextBox.Size = new System.Drawing.Size(175, 20);
            this.pibTextBox.TabIndex = 21;
            // 
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(612, 172);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(175, 20);
            this.addressTextBox.TabIndex = 22;
            // 
            // cityTextBox
            // 
            this.cityTextBox.Location = new System.Drawing.Point(612, 194);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(175, 20);
            this.cityTextBox.TabIndex = 23;
            // 
            // postalCodeTextBox
            // 
            this.postalCodeTextBox.Location = new System.Drawing.Point(612, 216);
            this.postalCodeTextBox.Name = "postalCodeTextBox";
            this.postalCodeTextBox.Size = new System.Drawing.Size(175, 20);
            this.postalCodeTextBox.TabIndex = 24;
            // 
            // ownerTextBox
            // 
            this.ownerTextBox.Location = new System.Drawing.Point(612, 238);
            this.ownerTextBox.Name = "ownerTextBox";
            this.ownerTextBox.Size = new System.Drawing.Size(175, 20);
            this.ownerTextBox.TabIndex = 25;
            // 
            // bankAccountTextBox
            // 
            this.bankAccountTextBox.Location = new System.Drawing.Point(612, 261);
            this.bankAccountTextBox.Name = "bankAccountTextBox";
            this.bankAccountTextBox.Size = new System.Drawing.Size(175, 20);
            this.bankAccountTextBox.TabIndex = 26;
            // 
            // idNumberTextBox
            // 
            this.idNumberTextBox.Location = new System.Drawing.Point(612, 283);
            this.idNumberTextBox.Name = "idNumberTextBox";
            this.idNumberTextBox.Size = new System.Drawing.Size(175, 20);
            this.idNumberTextBox.TabIndex = 27;
            // 
            // bankTextBox
            // 
            this.bankTextBox.Location = new System.Drawing.Point(612, 305);
            this.bankTextBox.Name = "bankTextBox";
            this.bankTextBox.Size = new System.Drawing.Size(175, 20);
            this.bankTextBox.TabIndex = 28;
            // 
            // activityCodeTextBox
            // 
            this.activityCodeTextBox.Location = new System.Drawing.Point(612, 327);
            this.activityCodeTextBox.Name = "activityCodeTextBox";
            this.activityCodeTextBox.Size = new System.Drawing.Size(175, 20);
            this.activityCodeTextBox.TabIndex = 29;
            // 
            // telephoneTextBox
            // 
            this.telephoneTextBox.Location = new System.Drawing.Point(612, 350);
            this.telephoneTextBox.Name = "telephoneTextBox";
            this.telephoneTextBox.Size = new System.Drawing.Size(175, 20);
            this.telephoneTextBox.TabIndex = 30;
            // 
            // mobileNumberTextBox
            // 
            this.mobileNumberTextBox.Location = new System.Drawing.Point(612, 372);
            this.mobileNumberTextBox.Name = "mobileNumberTextBox";
            this.mobileNumberTextBox.Size = new System.Drawing.Size(175, 20);
            this.mobileNumberTextBox.TabIndex = 31;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(612, 395);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(175, 20);
            this.emailTextBox.TabIndex = 32;
            // 
            // faxTextBox
            // 
            this.faxTextBox.Location = new System.Drawing.Point(612, 417);
            this.faxTextBox.Name = "faxTextBox";
            this.faxTextBox.Size = new System.Drawing.Size(175, 20);
            this.faxTextBox.TabIndex = 33;
            // 
            // CompanyDirectoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.faxTextBox);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.mobileNumberTextBox);
            this.Controls.Add(this.telephoneTextBox);
            this.Controls.Add(this.activityCodeTextBox);
            this.Controls.Add(this.bankTextBox);
            this.Controls.Add(this.idNumberTextBox);
            this.Controls.Add(this.bankAccountTextBox);
            this.Controls.Add(this.ownerTextBox);
            this.Controls.Add(this.postalCodeTextBox);
            this.Controls.Add(this.cityTextBox);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(this.pibTextBox);
            this.Controls.Add(this.companyNameTextBox);
            this.Controls.Add(this.faxLabel);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.mobilePhoneLabel);
            this.Controls.Add(this.telephoneLabel);
            this.Controls.Add(this.activityCodeLabel);
            this.Controls.Add(this.bankLabel);
            this.Controls.Add(this.idNumberLabel);
            this.Controls.Add(this.bankAccountLabel);
            this.Controls.Add(this.ownerLabel);
            this.Controls.Add(this.postalLabel);
            this.Controls.Add(this.cityLabel);
            this.Controls.Add(this.addressLabel);
            this.Controls.Add(this.pibLabel);
            this.Controls.Add(this.companyNameLabel);
            this.Controls.Add(this.companiesDataGridView);
            this.Controls.Add(this.exitFormButton);
            this.Controls.Add(this.deleteCompanyButton);
            this.Controls.Add(this.saveCompanyButton);
            this.Controls.Add(this.addNewEmptyCompanyButton);
            this.Controls.Add(this.searchCompanyGroupBox);
            this.Name = "CompanyDirectoryForm";
            this.Text = "CompanyDirectoryForm";
            this.Load += new System.EventHandler(this.CompanyDirectoryForm_Load);
            this.searchCompanyGroupBox.ResumeLayout(false);
            this.searchCompanyGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.companiesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox searchCompanyGroupBox;
        private System.Windows.Forms.Button searchCompanyButton;
        private System.Windows.Forms.TextBox searchCompanyTextBox;
        private System.Windows.Forms.Button addNewEmptyCompanyButton;
        private System.Windows.Forms.Button saveCompanyButton;
        private System.Windows.Forms.Button deleteCompanyButton;
        private System.Windows.Forms.Button exitFormButton;
        private System.Windows.Forms.DataGridView companiesDataGridView;
        private System.Windows.Forms.Label companyNameLabel;
        private System.Windows.Forms.Label pibLabel;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.Label postalLabel;
        private System.Windows.Forms.Label ownerLabel;
        private System.Windows.Forms.Label bankAccountLabel;
        private System.Windows.Forms.Label idNumberLabel;
        private System.Windows.Forms.Label bankLabel;
        private System.Windows.Forms.Label activityCodeLabel;
        private System.Windows.Forms.Label telephoneLabel;
        private System.Windows.Forms.Label mobilePhoneLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label faxLabel;
        private System.Windows.Forms.TextBox companyNameTextBox;
        private System.Windows.Forms.TextBox pibTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.TextBox postalCodeTextBox;
        private System.Windows.Forms.TextBox ownerTextBox;
        private System.Windows.Forms.TextBox bankAccountTextBox;
        private System.Windows.Forms.TextBox idNumberTextBox;
        private System.Windows.Forms.TextBox bankTextBox;
        private System.Windows.Forms.TextBox activityCodeTextBox;
        private System.Windows.Forms.TextBox telephoneTextBox;
        private System.Windows.Forms.TextBox mobileNumberTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox faxTextBox;
    }
}