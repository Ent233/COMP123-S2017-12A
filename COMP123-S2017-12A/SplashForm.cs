﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*Name:LF
 * Date:August 8, 2017
 * Description: A calculator app with splash form
 * Version: 0.1
*/
namespace COMP123_S2017_12A
{
    public partial class SplashForm : Form
    {
        public SplashForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// event hander for the tick event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SplashFormTimer_Tick(object sender, EventArgs e)
        {
            Calculator calculatorForm = new Calculator();
            calculatorForm.Show();
            this.Hide();
            SplashFormTimer.Enabled = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
