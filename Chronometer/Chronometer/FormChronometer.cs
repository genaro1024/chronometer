using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DisplayLibrary;

namespace Chronometer
{
    public partial class FormChronometer : Form
    {
        Timer timer;
        Display display;

        public FormChronometer()
        {
            InitializeComponent();
        }

        private void FormChronometer_Load(object sender, EventArgs e)
        {
            timer = new Timer();
            display = new Display();
            display.ChangeUnitSecond += ChangeUnitSecond;
            display.ChangeTenSecond += ChangeTenSecond;
            display.ChangeUnitMinute += ChangeUnitMinute;
            display.ChangeTenMinute += ChangeTenMinute;

            timer.Tick += this.Tick;
            timer.Interval = 1000;
            timer.Start();

        }



        private void Tick(object sender, EventArgs e) {
            display.Increase();
        }
        
        private void ChangeUnitSecond(object sender, EventArgsDigit e)
        {
            LUnitSecond.Text = e.Value.ToString();
        }

        private void ChangeTenSecond(object sender, EventArgsDigit e)
        {
            LTenSecond.Text = e.Value.ToString();
        }

        private void ChangeUnitMinute(object sender, EventArgsDigit e)
        {
            LUnitMinute.Text = e.Value.ToString();
        }

        private void ChangeTenMinute(object sender, EventArgsDigit e)
        {
            LTenMinute.Text = e.Value.ToString();
        }

    }
}
