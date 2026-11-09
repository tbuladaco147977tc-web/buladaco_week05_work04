using System;
using System.Globalization;
using System.Windows.Forms;

namespace Buladaco_week05_work004
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.AddRange(new object[] { "Food", "Beverage", "Household", "Electronics", "Other" });
            comboBox1.SelectedIndex = 0;
            lblLocal.Checked = true;
            lblActive.Checked = true;
            textBox6.ReadOnly = true;
            UpdatePrice();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            UpdatePrice();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            UpdatePrice();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            string barcode = textBox3.Text.Trim();
            bool available = barcode.Length > 0 && (ProductStore.Current == null || !string.Equals(ProductStore.Current.Barcode, barcode, StringComparison.OrdinalIgnoreCase));
            lblBarcodeIsAvailabe.Text = available ? "Barcode is available" : "Barcode is not available";
            lblBarcodeIsAvailabe.ForeColor = available ? System.Drawing.Color.SlateGray : System.Drawing.Color.Firebrick;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void lblBarcodeIsAvailabe_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            decimal cost;
            decimal markup;
            if (string.IsNullOrWhiteSpace(textBox3.Text) || string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("Barcode and name are required.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(textBox1.Text, NumberStyles.Number, CultureInfo.CurrentCulture, out cost) || cost < 0 ||
                !decimal.TryParse(textBox5.Text, NumberStyles.Number, CultureInfo.CurrentCulture, out markup) || markup < 0)
            {
                MessageBox.Show("Enter valid non-negative values for cost and markup.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (lblBarcodeIsAvailabe.Text != "Barcode is available")
            {
                MessageBox.Show("Enter a unique barcode.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ProductStore.Current = new Product
            {
                Barcode = textBox3.Text.Trim(),
                Name = textBox2.Text.Trim(),
                Description = textBox7.Text.Trim(),
                Category = comboBox1.Text,
                Origin = lblLocal.Checked ? "Local" : "Abroad",
                IsActive = lblActive.Checked,
                Cost = cost,
                Markup = markup,
                Price = cost * (1 + markup / 100m)
            };

            using (var listForm = new List())
            {
                Hide();
                listForm.ShowDialog(this);
            }
            Show();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            textBox3.Clear();
            textBox2.Clear();
            textBox7.Clear();
            comboBox1.SelectedIndex = 0;
            lblLocal.Checked = true;
            lblActive.Checked = true;
            textBox1.Clear();
            textBox5.Clear();
            UpdatePrice();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void UpdatePrice()
        {
            decimal cost;
            decimal markup;
            if (decimal.TryParse(textBox1.Text, NumberStyles.Number, CultureInfo.CurrentCulture, out cost) &&
                decimal.TryParse(textBox5.Text, NumberStyles.Number, CultureInfo.CurrentCulture, out markup))
            {
                textBox6.Text = (cost * (1 + markup / 100m)).ToString("0.00", CultureInfo.CurrentCulture);
            }
            else
            {
                textBox6.Clear();
            }
        }
    }
}
