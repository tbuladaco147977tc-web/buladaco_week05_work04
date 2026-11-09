namespace Buladaco_week05_work004
{
    partial class Form1
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
            this.lblBarcode = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblOrigin = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblCost = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblMarkup = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblLocal = new System.Windows.Forms.RadioButton();
            this.lblAbroad = new System.Windows.Forms.RadioButton();
            this.lblManufactured = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblActive = new System.Windows.Forms.CheckBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.bntCancel = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblBarcodeIsAvailabe = new System.Windows.Forms.Label();
            this.lblManufactured.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblBarcode
            // 
            this.lblBarcode.AutoSize = true;
            this.lblBarcode.Location = new System.Drawing.Point(25, 28);
            this.lblBarcode.Name = "lblBarcode";
            this.lblBarcode.Size = new System.Drawing.Size(59, 16);
            this.lblBarcode.TabIndex = 0;
            this.lblBarcode.Text = "Barcode";
            this.lblBarcode.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(25, 86);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(44, 16);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(25, 215);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(62, 16);
            this.lblCategory.TabIndex = 2;
            this.lblCategory.Text = "Category";
            // 
            // lblOrigin
            // 
            this.lblOrigin.AutoSize = true;
            this.lblOrigin.Location = new System.Drawing.Point(25, 260);
            this.lblOrigin.Name = "lblOrigin";
            this.lblOrigin.Size = new System.Drawing.Size(42, 16);
            this.lblOrigin.TabIndex = 3;
            this.lblOrigin.Text = "Origin";
            this.lblOrigin.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(25, 119);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(75, 16);
            this.lblDescription.TabIndex = 4;
            this.lblDescription.Text = "Description";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(25, 339);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(44, 16);
            this.lblStatus.TabIndex = 5;
            this.lblStatus.Text = "Status";
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Location = new System.Drawing.Point(25, 381);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(34, 16);
            this.lblCost.TabIndex = 6;
            this.lblCost.Text = "Cost";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(296, 405);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 16);
            this.label3.TabIndex = 7;
            // 
            // lblMarkup
            // 
            this.lblMarkup.AutoSize = true;
            this.lblMarkup.Location = new System.Drawing.Point(289, 381);
            this.lblMarkup.Name = "lblMarkup";
            this.lblMarkup.Size = new System.Drawing.Size(72, 16);
            this.lblMarkup.TabIndex = 8;
            this.lblMarkup.Text = "Markup(%)";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(154, 381);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(38, 16);
            this.lblPrice.TabIndex = 9;
            this.lblPrice.Text = "Price";
            this.lblPrice.Click += new System.EventHandler(this.label5_Click);
            // 
            // lblLocal
            // 
            this.lblLocal.AutoSize = true;
            this.lblLocal.Location = new System.Drawing.Point(37, 21);
            this.lblLocal.Name = "lblLocal";
            this.lblLocal.Size = new System.Drawing.Size(61, 20);
            this.lblLocal.TabIndex = 10;
            this.lblLocal.TabStop = true;
            this.lblLocal.Text = "Local";
            this.lblLocal.UseVisualStyleBackColor = true;
            this.lblLocal.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // lblAbroad
            // 
            this.lblAbroad.AutoSize = true;
            this.lblAbroad.Location = new System.Drawing.Point(142, 21);
            this.lblAbroad.Name = "lblAbroad";
            this.lblAbroad.Size = new System.Drawing.Size(73, 20);
            this.lblAbroad.TabIndex = 11;
            this.lblAbroad.TabStop = true;
            this.lblAbroad.Text = "Abroad";
            this.lblAbroad.UseVisualStyleBackColor = true;
            // 
            // lblManufactured
            // 
            this.lblManufactured.Controls.Add(this.lblLocal);
            this.lblManufactured.Controls.Add(this.lblAbroad);
            this.lblManufactured.Location = new System.Drawing.Point(119, 260);
            this.lblManufactured.Name = "lblManufactured";
            this.lblManufactured.Size = new System.Drawing.Size(273, 63);
            this.lblManufactured.TabIndex = 12;
            this.lblManufactured.TabStop = false;
            this.lblManufactured.Text = "Manufactured";
            this.lblManufactured.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(28, 405);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 13;
            // 
            // lblActive
            // 
            this.lblActive.AutoSize = true;
            this.lblActive.Location = new System.Drawing.Point(119, 335);
            this.lblActive.Name = "lblActive";
            this.lblActive.Size = new System.Drawing.Size(66, 20);
            this.lblActive.TabIndex = 14;
            this.lblActive.Text = "Active";
            this.lblActive.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(119, 83);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(273, 22);
            this.textBox2.TabIndex = 15;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(119, 28);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(273, 22);
            this.textBox3.TabIndex = 16;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(292, 405);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 22);
            this.textBox5.TabIndex = 18;
            this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(145, 405);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 22);
            this.textBox6.TabIndex = 19;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(120, 116);
            this.textBox7.Multiline = true;
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(272, 78);
            this.textBox7.TabIndex = 20;
            // 
            // bntCancel
            // 
            this.bntCancel.BackColor = System.Drawing.Color.Salmon;
            this.bntCancel.Location = new System.Drawing.Point(28, 450);
            this.bntCancel.Name = "bntCancel";
            this.bntCancel.Size = new System.Drawing.Size(93, 36);
            this.bntCancel.TabIndex = 22;
            this.bntCancel.Text = "Cancel";
            this.bntCancel.UseVisualStyleBackColor = false;
            this.bntCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.DarkOrange;
            this.btnClear.Location = new System.Drawing.Point(145, 450);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(93, 36);
            this.btnClear.TabIndex = 23;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.RosyBrown;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(299, 450);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(93, 36);
            this.btnSave.TabIndex = 24;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(119, 212);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(273, 24);
            this.comboBox1.TabIndex = 25;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lblBarcodeIsAvailabe
            // 
            this.lblBarcodeIsAvailabe.AutoSize = true;
            this.lblBarcodeIsAvailabe.Font = new System.Drawing.Font("Adobe Devanagari", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBarcodeIsAvailabe.ForeColor = System.Drawing.Color.SlateGray;
            this.lblBarcodeIsAvailabe.Location = new System.Drawing.Point(119, 53);
            this.lblBarcodeIsAvailabe.Name = "lblBarcodeIsAvailabe";
            this.lblBarcodeIsAvailabe.Size = new System.Drawing.Size(121, 20);
            this.lblBarcodeIsAvailabe.TabIndex = 26;
            this.lblBarcodeIsAvailabe.Text = "Barcode is available";
            this.lblBarcodeIsAvailabe.Click += new System.EventHandler(this.lblBarcodeIsAvailabe_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 512);
            this.Controls.Add(this.lblBarcodeIsAvailabe);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.bntCancel);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.lblActive);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblManufactured);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblMarkup);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblCost);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblOrigin);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblBarcode);
            this.Name = "Form1";
            this.Text = "Product Form";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.lblManufactured.ResumeLayout(false);
            this.lblManufactured.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBarcode;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblOrigin;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblMarkup;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.RadioButton lblLocal;
        private System.Windows.Forms.RadioButton lblAbroad;
        private System.Windows.Forms.GroupBox lblManufactured;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox lblActive;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Button bntCancel;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblBarcodeIsAvailabe;
    }
}

