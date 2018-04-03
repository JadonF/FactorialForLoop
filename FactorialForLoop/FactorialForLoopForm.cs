/*
 * Created by: Jadon Fournier
 * Created on: 03-Mar-2018
 * Created for: ICS3U Programming
 * Daily Assignment – Day # - FactorialForLoop
 * This program calculates factorials using a for loop
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FactorialForLoop
{
    public partial class frmFactorialForLoop : Form
    {
        //Create variables
        double factorialAnswer;
        double factorialNumber;
        int factorialCounter;

        public frmFactorialForLoop()
        {
            InitializeComponent();
            //Hide labels
            this.lblAnswer.Hide();
        }

        private void txtInput_TextChanged(object sender, EventArgs e)
        {
            factorialNumber = Convert.ToDouble(txtInput.Text);
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            //Clear the list
            this.lstList.Items.Clear();

            //Initialize answer to 1
            factorialAnswer = 1;

            for(factorialCounter = 1; factorialCounter <= factorialNumber; factorialCounter++)
            {
                //Add the counter to the list
                this.lstList.Items.Add(factorialCounter);

                //multiply counter by answer
                factorialAnswer = factorialAnswer * factorialCounter;
            }

            //change the label
            lblAnswer.Text = txtInput.Text + "! = " + Convert.ToString(factorialAnswer);

            //Show the label
            this.lblAnswer.Show();
        }
    }
}
