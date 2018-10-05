using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisplayLibrary
{
    public class Digit
    {
        public byte UpperLimit { set; get; }
        public byte LowerLimit { set; get; }
        public sbyte Increment { set; get; }
        public byte Value { set; get; }

        public Digit() {
            UpperLimit = 9;
            LowerLimit = 0;
            Increment = 1;
        }

        public void Increase() {
            if(Value < UpperLimit && Increment > 0)
                Value += (byte)Increment;
            else if(Value > LowerLimit && Increment < 0)
                Value -= (byte)Increment;
            else if (Value == UpperLimit && Increment > 0)
            {
                Value = LowerLimit;
                OnReset(EventArgs.Empty);
            }
            else if (Value == LowerLimit && Increment < 0)
            {
                Value = UpperLimit;
                OnReset(EventArgs.Empty);
            }
            OnChange(new EventArgsDigit() { Value = this.Value });
        }

        public event EventHandler<EventArgsDigit> Change;
        public event EventHandler<EventArgs> Reset;

        protected virtual void OnChange(EventArgsDigit e) {
            Change?.Invoke(this, e);
        }
        protected virtual void OnReset(EventArgs e)
        {
            Reset?.Invoke(this, e);
        }
    }
}
