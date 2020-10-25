namespace GORIPBS
{
    partial class ItemEntryForm
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
            this.itemIDLabel = new System.Windows.Forms.Label();
            this.itemIdTextBox = new System.Windows.Forms.TextBox();
            this.ItemNameLabel = new System.Windows.Forms.Label();
            this.ItemNameTextBox = new System.Windows.Forms.TextBox();
            this.priceFormingGroupBox = new System.Windows.Forms.GroupBox();
            this.priceWithoutVATRadioButton = new System.Windows.Forms.RadioButton();
            this.priceWithoutVATTextBox = new System.Windows.Forms.TextBox();
            this.fullPriceRadioButton = new System.Windows.Forms.RadioButton();
            this.fullPriceTextBox = new System.Windows.Forms.TextBox();
            this.entryPriceSPTextBox = new System.Windows.Forms.TextBox();
            this.VATRateTextBox = new System.Windows.Forms.TextBox();
            this.VATRateLabel = new System.Windows.Forms.Label();
            this.entryPriceSPLabel = new System.Windows.Forms.Label();
            this.startingStateTextBox = new System.Windows.Forms.TextBox();
            this.startingStateLabel = new System.Windows.Forms.Label();
            this.supplierLabel = new System.Windows.Forms.Label();
            this.supplierTextBox = new System.Windows.Forms.TextBox();
            this.suppliersListBox = new System.Windows.Forms.ListBox();
            this.unitOfMeasureLabel = new System.Windows.Forms.Label();
            this.unitOfMeasureTextBox = new System.Windows.Forms.TextBox();
            this.quantityLabel = new System.Windows.Forms.Label();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.priceWithoutVATLabel = new System.Windows.Forms.Label();
            this.finalPriceWithoutVATTextBox = new System.Windows.Forms.TextBox();
            this.VATSumLabel = new System.Windows.Forms.Label();
            this.finalVATSumTextBox = new System.Windows.Forms.TextBox();
            this.finalFullPriceTextBox = new System.Windows.Forms.TextBox();
            this.entryPriceWVLabel = new System.Windows.Forms.Label();
            this.entryPriceWVTextBox = new System.Windows.Forms.TextBox();
            this.priceLabel = new System.Windows.Forms.Label();
            this.saveItemEntryButton = new System.Windows.Forms.Button();
            this.closeFormButton = new System.Windows.Forms.Button();
            this.priceFormingGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // itemIDLabel
            // 
            this.itemIDLabel.AutoSize = true;
            this.itemIDLabel.Location = new System.Drawing.Point(9, 20);
            this.itemIDLabel.Name = "itemIDLabel";
            this.itemIDLabel.Size = new System.Drawing.Size(31, 13);
            this.itemIDLabel.TabIndex = 0;
            this.itemIDLabel.Text = "Šifra:";
            // 
            // itemIdTextBox
            // 
            this.itemIdTextBox.Location = new System.Drawing.Point(46, 17);
            this.itemIdTextBox.Name = "itemIdTextBox";
            this.itemIdTextBox.Size = new System.Drawing.Size(119, 20);
            this.itemIdTextBox.TabIndex = 1;
            // 
            // ItemNameLabel
            // 
            this.ItemNameLabel.AutoSize = true;
            this.ItemNameLabel.Location = new System.Drawing.Point(215, 20);
            this.ItemNameLabel.Name = "ItemNameLabel";
            this.ItemNameLabel.Size = new System.Drawing.Size(31, 13);
            this.ItemNameLabel.TabIndex = 0;
            this.ItemNameLabel.Text = "Opis:";
            // 
            // ItemNameTextBox
            // 
            this.ItemNameTextBox.Location = new System.Drawing.Point(249, 17);
            this.ItemNameTextBox.Multiline = true;
            this.ItemNameTextBox.Name = "ItemNameTextBox";
            this.ItemNameTextBox.Size = new System.Drawing.Size(192, 93);
            this.ItemNameTextBox.TabIndex = 2;
            // 
            // priceFormingGroupBox
            // 
            this.priceFormingGroupBox.Controls.Add(this.priceWithoutVATRadioButton);
            this.priceFormingGroupBox.Controls.Add(this.priceWithoutVATTextBox);
            this.priceFormingGroupBox.Controls.Add(this.fullPriceRadioButton);
            this.priceFormingGroupBox.Controls.Add(this.fullPriceTextBox);
            this.priceFormingGroupBox.Controls.Add(this.entryPriceSPTextBox);
            this.priceFormingGroupBox.Controls.Add(this.VATRateTextBox);
            this.priceFormingGroupBox.Controls.Add(this.VATRateLabel);
            this.priceFormingGroupBox.Controls.Add(this.entryPriceSPLabel);
            this.priceFormingGroupBox.Controls.Add(this.startingStateTextBox);
            this.priceFormingGroupBox.Controls.Add(this.startingStateLabel);
            this.priceFormingGroupBox.Location = new System.Drawing.Point(12, 43);
            this.priceFormingGroupBox.Name = "priceFormingGroupBox";
            this.priceFormingGroupBox.Size = new System.Drawing.Size(198, 278);
            this.priceFormingGroupBox.TabIndex = 3;
            this.priceFormingGroupBox.TabStop = false;
            this.priceFormingGroupBox.Text = "FORMIRANJE CENE";
            // 
            // priceWithoutVATRadioButton
            // 
            this.priceWithoutVATRadioButton.AutoSize = true;
            this.priceWithoutVATRadioButton.Checked = true;
            this.priceWithoutVATRadioButton.Location = new System.Drawing.Point(9, 138);
            this.priceWithoutVATRadioButton.Name = "priceWithoutVATRadioButton";
            this.priceWithoutVATRadioButton.Size = new System.Drawing.Size(96, 17);
            this.priceWithoutVATRadioButton.TabIndex = 4;
            this.priceWithoutVATRadioButton.TabStop = true;
            this.priceWithoutVATRadioButton.Text = "Cena Bez PDV";
            this.priceWithoutVATRadioButton.UseVisualStyleBackColor = true;
            // 
            // priceWithoutVATTextBox
            // 
            this.priceWithoutVATTextBox.Location = new System.Drawing.Point(9, 161);
            this.priceWithoutVATTextBox.Name = "priceWithoutVATTextBox";
            this.priceWithoutVATTextBox.Size = new System.Drawing.Size(129, 20);
            this.priceWithoutVATTextBox.TabIndex = 1;
            this.priceWithoutVATTextBox.TextChanged += new System.EventHandler(this.priceWithoutVATTextBox_TextChanged);
            // 
            // fullPriceRadioButton
            // 
            this.fullPriceRadioButton.AutoSize = true;
            this.fullPriceRadioButton.Location = new System.Drawing.Point(9, 80);
            this.fullPriceRadioButton.Name = "fullPriceRadioButton";
            this.fullPriceRadioButton.Size = new System.Drawing.Size(96, 17);
            this.fullPriceRadioButton.TabIndex = 4;
            this.fullPriceRadioButton.TabStop = true;
            this.fullPriceRadioButton.Text = "Konačna Cena";
            this.fullPriceRadioButton.UseVisualStyleBackColor = true;
            this.fullPriceRadioButton.CheckedChanged += new System.EventHandler(this.fullPriceRadioButton_CheckedChanged);
            // 
            // fullPriceTextBox
            // 
            this.fullPriceTextBox.Location = new System.Drawing.Point(9, 103);
            this.fullPriceTextBox.Name = "fullPriceTextBox";
            this.fullPriceTextBox.ReadOnly = true;
            this.fullPriceTextBox.Size = new System.Drawing.Size(129, 20);
            this.fullPriceTextBox.TabIndex = 1;
            this.fullPriceTextBox.TextChanged += new System.EventHandler(this.fullPriceTextBox_TextChanged);
            // 
            // entryPriceSPTextBox
            // 
            this.entryPriceSPTextBox.Location = new System.Drawing.Point(9, 213);
            this.entryPriceSPTextBox.Name = "entryPriceSPTextBox";
            this.entryPriceSPTextBox.Size = new System.Drawing.Size(129, 20);
            this.entryPriceSPTextBox.TabIndex = 1;
            this.entryPriceSPTextBox.Text = "0.00";
            this.entryPriceSPTextBox.TextChanged += new System.EventHandler(this.entryPriceSPTextBox_TextChanged);
            // 
            // VATRateTextBox
            // 
            this.VATRateTextBox.Location = new System.Drawing.Point(9, 45);
            this.VATRateTextBox.Name = "VATRateTextBox";
            this.VATRateTextBox.Size = new System.Drawing.Size(129, 20);
            this.VATRateTextBox.TabIndex = 1;
            this.VATRateTextBox.Text = "20.00";
            this.VATRateTextBox.TextChanged += new System.EventHandler(this.VATRateTextBox_TextChanged);
            // 
            // VATRateLabel
            // 
            this.VATRateLabel.AutoSize = true;
            this.VATRateLabel.Location = new System.Drawing.Point(6, 29);
            this.VATRateLabel.Name = "VATRateLabel";
            this.VATRateLabel.Size = new System.Drawing.Size(63, 13);
            this.VATRateLabel.TabIndex = 0;
            this.VATRateLabel.Text = "Stopa PDV:";
            // 
            // entryPriceSPLabel
            // 
            this.entryPriceSPLabel.AutoSize = true;
            this.entryPriceSPLabel.Location = new System.Drawing.Point(6, 197);
            this.entryPriceSPLabel.Name = "entryPriceSPLabel";
            this.entryPriceSPLabel.Size = new System.Drawing.Size(88, 13);
            this.entryPriceSPLabel.TabIndex = 0;
            this.entryPriceSPLabel.Text = "Ulazna Cena SP:";
            // 
            // startingStateTextBox
            // 
            this.startingStateTextBox.Location = new System.Drawing.Point(74, 243);
            this.startingStateTextBox.Name = "startingStateTextBox";
            this.startingStateTextBox.Size = new System.Drawing.Size(108, 20);
            this.startingStateTextBox.TabIndex = 1;
            this.startingStateTextBox.Text = "0";
            // 
            // startingStateLabel
            // 
            this.startingStateLabel.AutoSize = true;
            this.startingStateLabel.Location = new System.Drawing.Point(10, 247);
            this.startingStateLabel.Name = "startingStateLabel";
            this.startingStateLabel.Size = new System.Drawing.Size(50, 13);
            this.startingStateLabel.TabIndex = 0;
            this.startingStateLabel.Text = "Početno:";
            // 
            // supplierLabel
            // 
            this.supplierLabel.AutoSize = true;
            this.supplierLabel.Location = new System.Drawing.Point(217, 126);
            this.supplierLabel.Name = "supplierLabel";
            this.supplierLabel.Size = new System.Drawing.Size(58, 13);
            this.supplierLabel.TabIndex = 0;
            this.supplierLabel.Text = "Dobavljač:";
            // 
            // supplierTextBox
            // 
            this.supplierTextBox.Location = new System.Drawing.Point(281, 123);
            this.supplierTextBox.Name = "supplierTextBox";
            this.supplierTextBox.Size = new System.Drawing.Size(160, 20);
            this.supplierTextBox.TabIndex = 1;
            // 
            // suppliersListBox
            // 
            this.suppliersListBox.FormattingEnabled = true;
            this.suppliersListBox.Location = new System.Drawing.Point(281, 149);
            this.suppliersListBox.Name = "suppliersListBox";
            this.suppliersListBox.Size = new System.Drawing.Size(160, 147);
            this.suppliersListBox.TabIndex = 4;
            // 
            // unitOfMeasureLabel
            // 
            this.unitOfMeasureLabel.AutoSize = true;
            this.unitOfMeasureLabel.Location = new System.Drawing.Point(12, 330);
            this.unitOfMeasureLabel.Name = "unitOfMeasureLabel";
            this.unitOfMeasureLabel.Size = new System.Drawing.Size(24, 13);
            this.unitOfMeasureLabel.TabIndex = 0;
            this.unitOfMeasureLabel.Text = "JM:";
            // 
            // unitOfMeasureTextBox
            // 
            this.unitOfMeasureTextBox.Location = new System.Drawing.Point(96, 327);
            this.unitOfMeasureTextBox.Name = "unitOfMeasureTextBox";
            this.unitOfMeasureTextBox.Size = new System.Drawing.Size(114, 20);
            this.unitOfMeasureTextBox.TabIndex = 1;
            this.unitOfMeasureTextBox.Text = "Kom";
            // 
            // quantityLabel
            // 
            this.quantityLabel.AutoSize = true;
            this.quantityLabel.Location = new System.Drawing.Point(12, 356);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(47, 13);
            this.quantityLabel.TabIndex = 0;
            this.quantityLabel.Text = "Količina:";
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.Location = new System.Drawing.Point(96, 353);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(114, 20);
            this.quantityTextBox.TabIndex = 1;
            this.quantityTextBox.Text = "0";
            // 
            // priceWithoutVATLabel
            // 
            this.priceWithoutVATLabel.AutoSize = true;
            this.priceWithoutVATLabel.Location = new System.Drawing.Point(226, 330);
            this.priceWithoutVATLabel.Name = "priceWithoutVATLabel";
            this.priceWithoutVATLabel.Size = new System.Drawing.Size(80, 13);
            this.priceWithoutVATLabel.TabIndex = 0;
            this.priceWithoutVATLabel.Text = "Cena bez PDV:";
            // 
            // finalPriceWithoutVATTextBox
            // 
            this.finalPriceWithoutVATTextBox.Location = new System.Drawing.Point(327, 327);
            this.finalPriceWithoutVATTextBox.Name = "finalPriceWithoutVATTextBox";
            this.finalPriceWithoutVATTextBox.ReadOnly = true;
            this.finalPriceWithoutVATTextBox.Size = new System.Drawing.Size(114, 20);
            this.finalPriceWithoutVATTextBox.TabIndex = 1;
            // 
            // VATSumLabel
            // 
            this.VATSumLabel.AutoSize = true;
            this.VATSumLabel.Location = new System.Drawing.Point(226, 356);
            this.VATSumLabel.Name = "VATSumLabel";
            this.VATSumLabel.Size = new System.Drawing.Size(62, 13);
            this.VATSumLabel.TabIndex = 0;
            this.VATSumLabel.Text = "Suma PDV:";
            // 
            // finalVATSumTextBox
            // 
            this.finalVATSumTextBox.Location = new System.Drawing.Point(327, 353);
            this.finalVATSumTextBox.Name = "finalVATSumTextBox";
            this.finalVATSumTextBox.ReadOnly = true;
            this.finalVATSumTextBox.Size = new System.Drawing.Size(114, 20);
            this.finalVATSumTextBox.TabIndex = 1;
            // 
            // finalFullPriceTextBox
            // 
            this.finalFullPriceTextBox.Location = new System.Drawing.Point(327, 379);
            this.finalFullPriceTextBox.Name = "finalFullPriceTextBox";
            this.finalFullPriceTextBox.ReadOnly = true;
            this.finalFullPriceTextBox.Size = new System.Drawing.Size(114, 20);
            this.finalFullPriceTextBox.TabIndex = 1;
            // 
            // entryPriceWVLabel
            // 
            this.entryPriceWVLabel.AutoSize = true;
            this.entryPriceWVLabel.Location = new System.Drawing.Point(12, 382);
            this.entryPriceWVLabel.Name = "entryPriceWVLabel";
            this.entryPriceWVLabel.Size = new System.Drawing.Size(79, 13);
            this.entryPriceWVLabel.TabIndex = 0;
            this.entryPriceWVLabel.Text = "Ulaz. Cena BP:";
            // 
            // entryPriceWVTextBox
            // 
            this.entryPriceWVTextBox.Location = new System.Drawing.Point(97, 379);
            this.entryPriceWVTextBox.Name = "entryPriceWVTextBox";
            this.entryPriceWVTextBox.ReadOnly = true;
            this.entryPriceWVTextBox.Size = new System.Drawing.Size(114, 20);
            this.entryPriceWVTextBox.TabIndex = 1;
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(226, 382);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(35, 13);
            this.priceLabel.TabIndex = 0;
            this.priceLabel.Text = "Cena:";
            // 
            // saveItemEntryButton
            // 
            this.saveItemEntryButton.Location = new System.Drawing.Point(12, 447);
            this.saveItemEntryButton.Name = "saveItemEntryButton";
            this.saveItemEntryButton.Size = new System.Drawing.Size(211, 47);
            this.saveItemEntryButton.TabIndex = 5;
            this.saveItemEntryButton.Text = "** Sačuvaj Unos";
            this.saveItemEntryButton.UseVisualStyleBackColor = true;
            // 
            // closeFormButton
            // 
            this.closeFormButton.Location = new System.Drawing.Point(229, 447);
            this.closeFormButton.Name = "closeFormButton";
            this.closeFormButton.Size = new System.Drawing.Size(212, 47);
            this.closeFormButton.TabIndex = 5;
            this.closeFormButton.Text = "** Zatvori";
            this.closeFormButton.UseVisualStyleBackColor = true;
            // 
            // ItemEntryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 519);
            this.Controls.Add(this.closeFormButton);
            this.Controls.Add(this.saveItemEntryButton);
            this.Controls.Add(this.suppliersListBox);
            this.Controls.Add(this.priceFormingGroupBox);
            this.Controls.Add(this.ItemNameTextBox);
            this.Controls.Add(this.itemIdTextBox);
            this.Controls.Add(this.ItemNameLabel);
            this.Controls.Add(this.finalVATSumTextBox);
            this.Controls.Add(this.finalPriceWithoutVATTextBox);
            this.Controls.Add(this.VATSumLabel);
            this.Controls.Add(this.quantityTextBox);
            this.Controls.Add(this.priceWithoutVATLabel);
            this.Controls.Add(this.entryPriceWVTextBox);
            this.Controls.Add(this.finalFullPriceTextBox);
            this.Controls.Add(this.unitOfMeasureTextBox);
            this.Controls.Add(this.entryPriceWVLabel);
            this.Controls.Add(this.quantityLabel);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.supplierTextBox);
            this.Controls.Add(this.unitOfMeasureLabel);
            this.Controls.Add(this.itemIDLabel);
            this.Controls.Add(this.supplierLabel);
            this.Name = "ItemEntryForm";
            this.Text = "ItemEntryForm";
            this.priceFormingGroupBox.ResumeLayout(false);
            this.priceFormingGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label itemIDLabel;
        private System.Windows.Forms.TextBox itemIdTextBox;
        private System.Windows.Forms.Label ItemNameLabel;
        private System.Windows.Forms.TextBox ItemNameTextBox;
        private System.Windows.Forms.GroupBox priceFormingGroupBox;
        private System.Windows.Forms.Label VATRateLabel;
        private System.Windows.Forms.TextBox VATRateTextBox;
        private System.Windows.Forms.RadioButton priceWithoutVATRadioButton;
        private System.Windows.Forms.TextBox priceWithoutVATTextBox;
        private System.Windows.Forms.RadioButton fullPriceRadioButton;
        private System.Windows.Forms.TextBox fullPriceTextBox;
        private System.Windows.Forms.TextBox entryPriceSPTextBox;
        private System.Windows.Forms.Label entryPriceSPLabel;
        private System.Windows.Forms.Label startingStateLabel;
        private System.Windows.Forms.TextBox startingStateTextBox;
        private System.Windows.Forms.Label supplierLabel;
        private System.Windows.Forms.TextBox supplierTextBox;
        private System.Windows.Forms.ListBox suppliersListBox;
        private System.Windows.Forms.Label unitOfMeasureLabel;
        private System.Windows.Forms.TextBox unitOfMeasureTextBox;
        private System.Windows.Forms.Label quantityLabel;
        private System.Windows.Forms.TextBox quantityTextBox;
        private System.Windows.Forms.Label priceWithoutVATLabel;
        private System.Windows.Forms.TextBox finalPriceWithoutVATTextBox;
        private System.Windows.Forms.Label VATSumLabel;
        private System.Windows.Forms.TextBox finalVATSumTextBox;
        private System.Windows.Forms.TextBox finalFullPriceTextBox;
        private System.Windows.Forms.Label entryPriceWVLabel;
        private System.Windows.Forms.TextBox entryPriceWVTextBox;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Button saveItemEntryButton;
        private System.Windows.Forms.Button closeFormButton;
    }
}