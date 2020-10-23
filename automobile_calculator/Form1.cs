using System;
using System.Windows.Forms;

namespace automobile_calculator
{
    public partial class frmAutoCost : Form
    {
        public frmAutoCost()
        {
            InitializeComponent();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmAutoCost_Load(object sender, EventArgs e)
        {

        }

        private void submitExpense(object sender, EventArgs e)
        {
            /* 1. Get The Data from the Users Inputs
             * a. Get Text From Input Text Fields*/
            String carNoteStr = InTxtCarNote.Text;
            String carInsureStr = InTxtCarInsure.Text;
            String carGasStr = InTxtCarGas.Text;
            String carOilStr = InTxtCarOil.Text;
            String carRepairStr = InTxtCarRepairs.Text;
            String carRegStr = InTxtCarRegistration.Text;


            /* b. Convert Text Fields To double Data Types To Do Calcylations*/
            Double carNoteDb1 = Convert.ToDouble(carNoteStr);
            Double carInsureDb1 = Convert.ToDouble(carInsureStr);
            Double cargasDb1 = Convert.ToDouble(carGasStr);
            Double carOilDb1 = Convert.ToDouble(carOilStr);
            Double carRepairDb1 = Convert.ToDouble(carRepairStr);
            Double carRegDb1 = Convert.ToDouble(carRegStr);



            /*2. Calculate The Monthly Expense & annual Expense*/
            Double monthlyExpense = carNoteDb1 + cargasDb1 + carOilDb1 + carRepairDb1 + carRegDb1;
            Double yearlyExpense = monthlyExpense * 12;
            /* 3. Create the Formulas needed to solve Monthly/Yearly Expenses*/
            outTxtResults.Text = ""; //Clear Text Area


            outTxtResults.Text = "***Final Results***" + Environment.NewLine;  //Add final results to output
            outTxtResults.AppendText("Total Monthly Cost: " + monthlyExpense.ToString("C") + Environment.NewLine);
            outTxtResults.AppendText("Total Yearly Cost: " + yearlyExpense.ToString("C") + Environment.NewLine);

            /* 4. Output that data into a text box.
            */
        }
    }
}
