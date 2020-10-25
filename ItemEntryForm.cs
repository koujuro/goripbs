using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GORIPBS
{
    public partial class ItemEntryForm : Form
    {
        private double VATRate = 20.00;
        private double fullPrice;
        private double priceWithoutVAT;

        public ItemEntryForm()
        {
            InitializeComponent();
        }

        private void fullPriceRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (checkIfFullPriceRadioButtonIsSelected())
            {
                fullPriceTextBox.ReadOnly = false;
                priceWithoutVATTextBox.ReadOnly = true;
                priceWithoutVATTextBox.Text = "";
                priceWithoutVAT = 0.0;
            }
            else
            {
                fullPriceTextBox.ReadOnly = true;
                priceWithoutVATTextBox.ReadOnly = false;
                fullPriceTextBox.Text = "";
                fullPrice = 0.0;
            }
        }

        private bool checkIfFullPriceRadioButtonIsSelected() 
        {
            return priceFormingGroupBox.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked).Name == "fullPriceRadioButton";
        }

        private void fullPriceTextBox_TextChanged(object sender, EventArgs e)
        {
            double fullPrice = parseValueInTextBox((TextBox)sender);

            if (fullPrice != 0.0)
            {
                this.fullPrice = fullPrice;
                calculatePricesAndSumsWithFullPrice();
            }
        }

        private void priceWithoutVATTextBox_TextChanged(object sender, EventArgs e)
        {
            double priceWithoutVAT = parseValueInTextBox((TextBox)sender);

            if (priceWithoutVAT != 0.0)
            {
                this.priceWithoutVAT = priceWithoutVAT;
                calculatePricesAndSumsWithoutVAT();
            }
        }

        private void VATRateTextBox_TextChanged(object sender, EventArgs e)
        {
            double VATRate = parseValueInTextBox((TextBox)sender);

            if (VATRate != -1)
            {
                this.VATRate = VATRate;
                if (checkIfFullPriceRadioButtonIsSelected())
                    calculatePricesAndSumsWithFullPrice();
                else
                    calculatePricesAndSumsWithoutVAT();
            }
        }

        private double parseValueInTextBox(TextBox textBox)
        {
            if (textBox.Text != "")
            {
                try
                {
                    double number = Double.Parse(textBox.Text);
                    return number;
                }
                catch (FormatException formatException)
                {
                    MessageBox.Show("Unesite brojčanu vrednost.");
                    textBox.Text = textBox.Text.Remove(textBox.Text.Length - 1, 1);
                    textBox.SelectionStart = textBox.Text.Length;
                    return 0.00;
                }
            }
            return 0.00;
        }

        private void calculatePricesAndSumsWithFullPrice()
        {
            double finalFullPrice = fullPrice;
            double finalSumVAT = (double)(fullPrice / (100 + VATRate) * VATRate);
            double finalPriceWithoutVAT = (double)(fullPrice - finalSumVAT);

            finalPriceWithoutVATTextBox.Text = finalPriceWithoutVAT.ToString("#,0.00");
            finalVATSumTextBox.Text = finalSumVAT.ToString("#,0.00");
            finalFullPriceTextBox.Text = finalFullPrice.ToString("#,0.00");

        }

        private void calculatePricesAndSumsWithoutVAT()
        {
            double finalPriceWithoutVAT = priceWithoutVAT;
            double finalSumVAT = priceWithoutVAT / 100 * VATRate;
            double finalFullPrice = priceWithoutVAT + finalSumVAT;

            finalPriceWithoutVATTextBox.Text = finalPriceWithoutVAT.ToString("#,0.00");
            finalVATSumTextBox.Text = finalSumVAT.ToString("#,0.00");
            finalFullPriceTextBox.Text = finalFullPrice.ToString("#,0.00");
        }

        private void entryPriceSPTextBox_TextChanged(object sender, EventArgs e)
        {
            double entryPriceSP = parseValueInTextBox((TextBox)sender);

            if (entryPriceSP != 0.0)
            {
                double entryPriceBP = entryPriceSP - (entryPriceSP / (100 + VATRate) * VATRate);
                entryPriceWVTextBox.Text = entryPriceBP.ToString("#,0.00");
            }
        }
    }
}
