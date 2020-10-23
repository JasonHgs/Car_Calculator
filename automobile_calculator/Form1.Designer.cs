namespace automobile_calculator
{
    partial class frmAutoCost
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
            this.CarNote = new System.Windows.Forms.Label();
            this.CarInsurance = new System.Windows.Forms.Label();
            this.Gas = new System.Windows.Forms.Label();
            this.Oil = new System.Windows.Forms.Label();
            this.Repairs = new System.Windows.Forms.Label();
            this.Registration = new System.Windows.Forms.Label();
            this.InTxtCarNote = new System.Windows.Forms.TextBox();
            this.InTxtCarOil = new System.Windows.Forms.TextBox();
            this.InTxtCarGas = new System.Windows.Forms.TextBox();
            this.InTxtCarInsure = new System.Windows.Forms.TextBox();
            this.InTxtCarRepairs = new System.Windows.Forms.TextBox();
            this.InTxtCarRegistration = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.outTxtResults = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CarNote
            // 
            this.CarNote.AutoSize = true;
            this.CarNote.Location = new System.Drawing.Point(88, 62);
            this.CarNote.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CarNote.Name = "CarNote";
            this.CarNote.Size = new System.Drawing.Size(97, 25);
            this.CarNote.TabIndex = 0;
            this.CarNote.Text = "Car Note";
            // 
            // CarInsurance
            // 
            this.CarInsurance.AutoSize = true;
            this.CarInsurance.Location = new System.Drawing.Point(40, 121);
            this.CarInsurance.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CarInsurance.Name = "CarInsurance";
            this.CarInsurance.Size = new System.Drawing.Size(146, 25);
            this.CarInsurance.TabIndex = 1;
            this.CarInsurance.Text = "Car Insurance";
            // 
            // Gas
            // 
            this.Gas.AutoSize = true;
            this.Gas.Location = new System.Drawing.Point(134, 173);
            this.Gas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Gas.Name = "Gas";
            this.Gas.Size = new System.Drawing.Size(51, 25);
            this.Gas.TabIndex = 2;
            this.Gas.Text = "Gas";
            // 
            // Oil
            // 
            this.Oil.AutoSize = true;
            this.Oil.Location = new System.Drawing.Point(148, 238);
            this.Oil.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Oil.Name = "Oil";
            this.Oil.Size = new System.Drawing.Size(38, 25);
            this.Oil.TabIndex = 3;
            this.Oil.Text = "Oil";
            // 
            // Repairs
            // 
            this.Repairs.AutoSize = true;
            this.Repairs.Location = new System.Drawing.Point(100, 323);
            this.Repairs.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Repairs.Name = "Repairs";
            this.Repairs.Size = new System.Drawing.Size(86, 25);
            this.Repairs.TabIndex = 4;
            this.Repairs.Text = "Repairs";
            // 
            // Registration
            // 
            this.Registration.AutoSize = true;
            this.Registration.Location = new System.Drawing.Point(60, 388);
            this.Registration.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Registration.Name = "Registration";
            this.Registration.Size = new System.Drawing.Size(127, 25);
            this.Registration.TabIndex = 5;
            this.Registration.Text = "Registration";
            // 
            // InTxtCarNote
            // 
            this.InTxtCarNote.Location = new System.Drawing.Point(214, 56);
            this.InTxtCarNote.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.InTxtCarNote.Multiline = true;
            this.InTxtCarNote.Name = "InTxtCarNote";
            this.InTxtCarNote.Size = new System.Drawing.Size(288, 44);
            this.InTxtCarNote.TabIndex = 7;
            // 
            // InTxtCarOil
            // 
            this.InTxtCarOil.Location = new System.Drawing.Point(214, 238);
            this.InTxtCarOil.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.InTxtCarOil.Multiline = true;
            this.InTxtCarOil.Name = "InTxtCarOil";
            this.InTxtCarOil.Size = new System.Drawing.Size(288, 50);
            this.InTxtCarOil.TabIndex = 8;
            // 
            // InTxtCarGas
            // 
            this.InTxtCarGas.Location = new System.Drawing.Point(214, 173);
            this.InTxtCarGas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.InTxtCarGas.Multiline = true;
            this.InTxtCarGas.Name = "InTxtCarGas";
            this.InTxtCarGas.Size = new System.Drawing.Size(288, 42);
            this.InTxtCarGas.TabIndex = 9;
            // 
            // InTxtCarInsure
            // 
            this.InTxtCarInsure.Location = new System.Drawing.Point(214, 115);
            this.InTxtCarInsure.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.InTxtCarInsure.Multiline = true;
            this.InTxtCarInsure.Name = "InTxtCarInsure";
            this.InTxtCarInsure.Size = new System.Drawing.Size(288, 41);
            this.InTxtCarInsure.TabIndex = 10;
            // 
            // InTxtCarRepairs
            // 
            this.InTxtCarRepairs.Location = new System.Drawing.Point(214, 317);
            this.InTxtCarRepairs.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.InTxtCarRepairs.Multiline = true;
            this.InTxtCarRepairs.Name = "InTxtCarRepairs";
            this.InTxtCarRepairs.Size = new System.Drawing.Size(288, 46);
            this.InTxtCarRepairs.TabIndex = 11;
            this.InTxtCarRepairs.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // InTxtCarRegistration
            // 
            this.InTxtCarRegistration.Location = new System.Drawing.Point(214, 383);
            this.InTxtCarRegistration.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.InTxtCarRegistration.Multiline = true;
            this.InTxtCarRegistration.Name = "InTxtCarRegistration";
            this.InTxtCarRegistration.Size = new System.Drawing.Size(288, 46);
            this.InTxtCarRegistration.TabIndex = 12;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(406, 452);
            this.btnCalculate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(124, 79);
            this.btnCalculate.TabIndex = 13;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.submitExpense);
            // 
            // outTxtResults
            // 
            this.outTxtResults.Location = new System.Drawing.Point(46, 573);
            this.outTxtResults.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.outTxtResults.Multiline = true;
            this.outTxtResults.Name = "outTxtResults";
            this.outTxtResults.Size = new System.Drawing.Size(492, 262);
            this.outTxtResults.TabIndex = 14;
            this.outTxtResults.Text = " ***Final Results***\r\nTotal Monthly Cost: $\r\nTotal Annual Cost: $";
            // 
            // frmAutoCost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 1079);
            this.Controls.Add(this.outTxtResults);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.InTxtCarRegistration);
            this.Controls.Add(this.InTxtCarRepairs);
            this.Controls.Add(this.InTxtCarInsure);
            this.Controls.Add(this.InTxtCarGas);
            this.Controls.Add(this.InTxtCarOil);
            this.Controls.Add(this.InTxtCarNote);
            this.Controls.Add(this.Registration);
            this.Controls.Add(this.Repairs);
            this.Controls.Add(this.Oil);
            this.Controls.Add(this.Gas);
            this.Controls.Add(this.CarInsurance);
            this.Controls.Add(this.CarNote);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmAutoCost";
            this.Text = "Auto Cost";
            this.Load += new System.EventHandler(this.frmAutoCost_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CarNote;
        private System.Windows.Forms.Label CarInsurance;
        private System.Windows.Forms.Label Gas;
        private System.Windows.Forms.Label Oil;
        private System.Windows.Forms.Label Repairs;
        private System.Windows.Forms.Label Registration;
        private System.Windows.Forms.TextBox InTxtCarNote;
        private System.Windows.Forms.TextBox InTxtCarOil;
        private System.Windows.Forms.TextBox InTxtCarGas;
        private System.Windows.Forms.TextBox InTxtCarInsure;
        private System.Windows.Forms.TextBox InTxtCarRepairs;
        private System.Windows.Forms.TextBox InTxtCarRegistration;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox outTxtResults;
    }
}

