using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DisplayLibrary
{
    public class Display
    {
        private Digit UnitSecond;
        private Digit TenSecond;
        private Digit UnitMinute;
        private Digit TenMinute;


        public Display() {
            UnitSecond = new Digit();
            UnitSecond.Change += ChangeDigitUnitSecond;
            UnitSecond.Reset += ResetDigitUnitSecond;
            TenSecond = new Digit();
            TenSecond.UpperLimit = 5;
            TenSecond.Change += ChangeDigitTenSecond;
            TenSecond.Reset += ResetDigitTenSecond;

            UnitMinute = new Digit();
            UnitMinute.Change += ChangeDigitUnitMinute;
            UnitMinute.Reset += ResetDigitUnitMinute;
            TenMinute = new Digit();
            TenMinute.UpperLimit = 5;
            TenMinute.Change += ChangeDigitTenMinute;
 
        }

        public void Increase() {
            UnitSecond.Increase();
        }

        private void ResetDigitUnitSecond(object sender, EventArgs e)
        {
            TenSecond.Increase();
        }
        private void ResetDigitTenSecond(object sender, EventArgs e)
        {
            UnitMinute.Increase();
        }
        private void ResetDigitUnitMinute(object sender, EventArgs e)
        {
            TenMinute.Increase();
        }

        private void ChangeDigitUnitSecond(object sender, EventArgsDigit e)
        {
            OnChangeUnitSecond(e);
        }

        private void ChangeDigitTenSecond(object sender, EventArgsDigit e)
        {
            OnChangeTenSecond(e);
        }

        private void ChangeDigitUnitMinute(object sender, EventArgsDigit e)
        {
            OnChangeUnitMinute(e);
        }

        private void ChangeDigitTenMinute(object sender, EventArgsDigit e)
        {
            OnChangeTenMinute(e);
        }


        public event EventHandler<EventArgsDigit> ChangeUnitSecond;
        public event EventHandler<EventArgsDigit> ChangeTenSecond;
        public event EventHandler<EventArgsDigit> ChangeUnitMinute;
        public event EventHandler<EventArgsDigit> ChangeTenMinute;

        protected virtual void OnChangeUnitSecond(EventArgsDigit e)
        {
            ChangeUnitSecond?.Invoke(this, e);
        }
        protected virtual void OnChangeTenSecond(EventArgsDigit e)
        {
            ChangeTenSecond?.Invoke(this, e);
        }
        protected virtual void OnChangeUnitMinute(EventArgsDigit e)
        {
            ChangeUnitMinute?.Invoke(this, e);
        }
        protected virtual void OnChangeTenMinute(EventArgsDigit e)
        {
            ChangeTenMinute?.Invoke(this, e);
        }


    }
}
