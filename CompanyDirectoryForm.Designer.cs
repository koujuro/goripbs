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
            this.searchCompanyTextBox = new System.Windows.Forms.TextBox();
            this.searchCompanyButton = new System.Windows.Forms.Button();
            this.addNewCompanyButton = new System.Windows.Forms.Button();
            this.saveNewCompanyButton = new System.Windows.Forms.Button();
            this.deleteCompanyButton = new System.Windows.Forms.Button();
            this.exitFormButton = new System.Windows.Forms.Button();
            this.companiesDataGridView = new System.Windows.Forms.DataGridView();
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
            // searchCompanyTextBox
            // 
            this.searchCompanyTextBox.Location = new System.Drawing.Point(6, 31);
            this.searchCompanyTextBox.Name = "searchCompanyTextBox";
            this.searchCompanyTextBox.Size = new System.Drawing.Size(139, 20);
            this.searchCompanyTextBox.TabIndex = 1;
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
            // addNewCompanyButton
            // 
            this.addNewCompanyButton.Location = new System.Drawing.Point(218, 28);
            this.addNewCompanyButton.Name = "addNewCompanyButton";
            this.addNewCompanyButton.Size = new System.Drawing.Size(138, 49);
            this.addNewCompanyButton.TabIndex = 1;
            this.addNewCompanyButton.Text = "** Dodaj";
            this.addNewCompanyButton.UseVisualStyleBackColor = true;
            // 
            // saveNewCompanyButton
            // 
            this.saveNewCompanyButton.Location = new System.Drawing.Point(362, 28);
            this.saveNewCompanyButton.Name = "saveNewCompanyButton";
            this.saveNewCompanyButton.Size = new System.Drawing.Size(138, 49);
            this.saveNewCompanyButton.TabIndex = 2;
            this.saveNewCompanyButton.Text = "** Sačuvaj";
            this.saveNewCompanyButton.UseVisualStyleBackColor = true;
            // 
            // deleteCompanyButton
            // 
            this.deleteCompanyButton.Location = new System.Drawing.Point(506, 28);
            this.deleteCompanyButton.Name = "deleteCompanyButton";
            this.deleteCompanyButton.Size = new System.Drawing.Size(138, 49);
            this.deleteCompanyButton.TabIndex = 3;
            this.deleteCompanyButton.Text = "** Obriši";
            this.deleteCompanyButton.UseVisualStyleBackColor = true;
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
            this.companiesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.companiesDataGridView.Location = new System.Drawing.Point(12, 95);
            this.companiesDataGridView.Name = "companiesDataGridView";
            this.companiesDataGridView.Size = new System.Drawing.Size(407, 343);
            this.companiesDataGridView.TabIndex = 5;
            // 
            // CompanyDirectoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.companiesDataGridView);
            this.Controls.Add(this.exitFormButton);
            this.Controls.Add(this.deleteCompanyButton);
            this.Controls.Add(this.saveNewCompanyButton);
            this.Controls.Add(this.addNewCompanyButton);
            this.Controls.Add(this.searchCompanyGroupBox);
            this.Name = "CompanyDirectoryForm";
            this.Text = "CompanyDirectoryForm";
            this.searchCompanyGroupBox.ResumeLayout(false);
            this.searchCompanyGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.companiesDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox searchCompanyGroupBox;
        private System.Windows.Forms.Button searchCompanyButton;
        private System.Windows.Forms.TextBox searchCompanyTextBox;
        private System.Windows.Forms.Button addNewCompanyButton;
        private System.Windows.Forms.Button saveNewCompanyButton;
        private System.Windows.Forms.Button deleteCompanyButton;
        private System.Windows.Forms.Button exitFormButton;
        private System.Windows.Forms.DataGridView companiesDataGridView;
    }
}