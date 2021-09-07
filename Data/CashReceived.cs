using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace CowboyCafe.Data
{
    public class CashReceived : INotifyPropertyChanged
    {
        /// <summary>
        /// Property changed event
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Total value of cash received
        /// </summary>
        public double CashTotal { 
            get
            {
                double calcTotal = 0;
                
                calcTotal += _pennies * 0.01;
                calcTotal += _nickels * 0.05;
                calcTotal += _dimes * 0.1;
                calcTotal += _quarters * 0.25;
                calcTotal += _halfDollars * 0.5;
                calcTotal += _dollars;
                calcTotal += _ones;
                calcTotal += _twos * 2;
                calcTotal += _fives * 5;
                calcTotal += _tens * 10;
                calcTotal += _twenties * 20;
                calcTotal += _fifties * 50;
                calcTotal += _hundreds * 100;

                return calcTotal;
            }
        }

        private int _pennies;
        /// <summary>
        /// Pennies received
        /// </summary>
        public int Pennies { get => _pennies; set { if (value >= 0) _pennies = value; InvokePropertyChanged("Pennies"); } }

        private int _nickels;
        /// <summary>
        /// Nickels received
        /// </summary>
        public int Nickels { get => _nickels; set { if (value >= 0) _nickels = value; InvokePropertyChanged("Nickels"); } }

        private int _dimes;
        /// <summary>
        /// Dimes received
        /// </summary>
        public int Dimes { get => _dimes; set { if (value >= 0) _dimes = value; InvokePropertyChanged("Dimes"); } }

        private int _quarters;
        /// <summary>
        /// Quarters received
        /// </summary>
        public int Quarters { get => _quarters; set { if (value >= 0) _quarters = value; InvokePropertyChanged("Quarters"); } }

        private int _halfDollars;
        /// <summary>
        /// HalfDollars received
        /// </summary>
        public int HalfDollars { get => _halfDollars; set { if (value >= 0) _halfDollars = value; InvokePropertyChanged("HalfDollars"); } }

        private int _dollars;
        /// <summary>
        /// Dollars received
        /// </summary>
        public int Dollars { get => _dollars; set { if (value >= 0) _dollars = value; InvokePropertyChanged("Dollars"); } }

        private int _ones;
        /// <summary>
        /// Ones received
        /// </summary>
        public int Ones { get => _ones; set { if (value >= 0) _ones = value; InvokePropertyChanged("Ones"); } }

        private int _twos;
        /// <summary>
        /// Twos received
        /// </summary>
        public int Twos { get => _twos; set { if (value >= 0) _twos = value; InvokePropertyChanged("Twos"); } }

        private int _fives;
        /// <summary>
        /// Fives received
        /// </summary>
        public int Fives { get => _fives; set { if (value >= 0) _fives = value; InvokePropertyChanged("Fives"); } }

        private int _tens;
        /// <summary>
        /// Tens received
        /// </summary>
        public int Tens { get => _tens; set { if (value >= 0) _tens = value; InvokePropertyChanged("Tens"); } }

        private int _twenties;
        /// <summary>
        /// Twenties received
        /// </summary>
        public int Twenties { get => _twenties; set { if (value >= 0) _twenties = value; InvokePropertyChanged("Twenties"); } }

        private int _fifties;
        /// <summary>
        /// Fifties received
        /// </summary>
        public int Fifties { get => _fifties; set { if (value >= 0) _fifties = value; InvokePropertyChanged("Fifties"); } }

        private int _hundreds;
        /// <summary>
        /// Hundreds received
        /// </summary>
        public int Hundreds { get => _hundreds; set { if (value >= 0) _hundreds = value; InvokePropertyChanged("Hundreds"); } }

        /// <summary>
        /// Helper method to trigger PropertyChanged events
        /// </summary>
        /// <param name="propertyName"></param>
        protected void InvokePropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
