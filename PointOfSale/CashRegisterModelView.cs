using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using CashRegister;

namespace PointOfSale
{
    public class CashRegisterModelView : INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;

        private static CashDrawer Drawer = new CashDrawer();

        /// <summary>
        /// Total cash in the drawer
        /// </summary>
        public double TotalValue { get => Drawer.TotalValue; }

        private double orderValue = 0;
        /// <summary>
        /// The value of the current order
        /// </summary>
        public double OrderValue { get => orderValue; set => orderValue = value; }

        private double amountPaid = 0;
        /// <summary>
        /// The amount paid by the customer
        /// </summary>
        public double AmountPaid { get => amountPaid; set => amountPaid = value; }

        /// <summary>
        /// Gets and sets the amount of pennies
        /// </summary>
        public int Pennies
        {
            get => Drawer.Pennies;
            set
            {
                if (Drawer.Pennies == value || value < 0) return;
                var quantity = value - Drawer.Pennies;
                if (quantity > 0) Drawer.AddCoin(Coins.Penny, quantity);
                else Drawer.RemoveCoin(Coins.Penny, -quantity);
                InvokePropertyChanged("Pennies");
            }
        }

        /// <summary>
        /// Gets and sets the amount of nickels
        /// </summary>
        public int Nickels
        {
            get => Drawer.Nickels;
            set
            {
                if (Drawer.Nickels == value || value < 0) return;
                var quantity = value - Drawer.Nickels;
                if (quantity > 0) Drawer.AddCoin(Coins.Nickel, quantity);
                else Drawer.RemoveCoin(Coins.Nickel, -quantity);
                InvokePropertyChanged("Nickels");
            }
        }

        /// <summary>
        /// Gets and sets the amount of dimes
        /// </summary>
        public int Dimes
        {
            get => Drawer.Dimes;
            set
            {
                if (Drawer.Dimes == value || value < 0) return;
                var quantity = value - Drawer.Dimes;
                if (quantity > 0) Drawer.AddCoin(Coins.Dime, quantity);
                else Drawer.RemoveCoin(Coins.Dime, -quantity);
                InvokePropertyChanged("Dimes");
            }
        }

        /// <summary>
        /// Gets and sets the amount of quarters
        /// </summary>
        public int Quarters
        {
            get => Drawer.Quarters;
            set
            {
                if (Drawer.Quarters == value || value < 0) return;
                var quantity = value - Drawer.Quarters;
                if (quantity > 0) Drawer.AddCoin(Coins.Quarter, quantity);
                else Drawer.RemoveCoin(Coins.Quarter, -quantity);
                InvokePropertyChanged("Quarters");
            }
        }

        /// <summary>
        /// Gets and sets the amount of half dollars
        /// </summary>
        public int HalfDollars
        {
            get => Drawer.HalfDollars;
            set
            {
                if (Drawer.HalfDollars == value || value < 0) return;
                var quantity = value - Drawer.HalfDollars;
                if (quantity > 0) Drawer.AddCoin(Coins.HalfDollar, quantity);
                else Drawer.RemoveCoin(Coins.HalfDollar, -quantity);
                InvokePropertyChanged("HalfDollars");
            }
        }

        /// <summary>
        /// Gets and sets the amount of dollar coins
        /// </summary>
        public int Dollars
        {
            get => Drawer.Dollars;
            set
            {
                if (Drawer.Dollars == value || value < 0) return;
                var quantity = value - Drawer.Dollars;
                if (quantity > 0) Drawer.AddCoin(Coins.Dollar, quantity);
                else Drawer.RemoveCoin(Coins.Dollar, -quantity);
                InvokePropertyChanged("Dollars");
            }
        }

        /// <summary>
        /// Gets and sets the amount of ones
        /// </summary>
        public int Ones
        {
            get => Drawer.Ones;
            set
            {
                if (Drawer.Ones == value || value < 0) return;
                var quantity = value - Drawer.Ones;
                if (quantity > 0) Drawer.AddBill(Bills.One, quantity);
                else Drawer.RemoveBill(Bills.One, -quantity);
                InvokePropertyChanged("Ones");
            }
        }

        /// <summary>
        /// Gets and sets the amount of two dollar bills
        /// </summary>
        public int Twos
        {
            get => Drawer.Twos;
            set
            {
                if (Drawer.Twos == value || value < 0) return;
                var quantity = value - Drawer.Twos;
                if (quantity > 0) Drawer.AddBill(Bills.Two, quantity);
                else Drawer.RemoveBill(Bills.Two, -quantity);
                InvokePropertyChanged("Twos");
            }
        }

        /// <summary>
        /// Gets and sets the amount of fives
        /// </summary>
        public int Fives
        {
            get => Drawer.Fives;
            set
            {
                if (Drawer.Fives == value || value < 0) return;
                var quantity = value - Drawer.Fives;
                if (quantity > 0) Drawer.AddBill(Bills.Five, quantity);
                else Drawer.RemoveBill(Bills.Five, -quantity);
                InvokePropertyChanged("Fives");
            }
        }

        /// <summary>
        /// Gets and sets the amount of tens
        /// </summary>
        public int Tens
        {
            get => Drawer.Tens;
            set
            {
                if (Drawer.Tens == value || value < 0) return;
                var quantity = value - Drawer.Tens;
                if (quantity > 0) Drawer.AddBill(Bills.Ten, quantity);
                else Drawer.RemoveBill(Bills.Ten, -quantity);
                InvokePropertyChanged("Tens");
            }
        }

        /// <summary>
        /// Gets and sets the amount of twenties
        /// </summary>
        public int Twenties
        {
            get => Drawer.Twenties;
            set
            {
                if (Drawer.Twenties == value || value < 0) return;
                var quantity = value - Drawer.Twenties;
                if (quantity > 0) Drawer.AddBill(Bills.Twenty, quantity);
                else Drawer.RemoveBill(Bills.Twenty, -quantity);
                InvokePropertyChanged("Twenties");
            }
        }

        /// <summary>
        /// Gets and sets the amount of fifties
        /// </summary>
        public int Fifties
        {
            get => Drawer.Fifties;
            set
            {
                if (Drawer.Fifties == value || value < 0) return;
                var quantity = value - Drawer.Fifties;
                if (quantity > 0) Drawer.AddBill(Bills.Fifty, quantity);
                else Drawer.RemoveBill(Bills.Fifty, -quantity);
                InvokePropertyChanged("Fifties");
            }
        }

        /// <summary>
        /// Gets and sets the amount of hundreds
        /// </summary>
        public int Hundreds
        {
            get => Drawer.Hundreds;
            set
            {
                if (Drawer.Hundreds == value || value < 0) return;
                var quantity = value - Drawer.Hundreds;
                if (quantity > 0) Drawer.AddBill(Bills.Hundred, quantity);
                else Drawer.RemoveBill(Bills.Hundred, -quantity);
                InvokePropertyChanged("Hundreds");
            }
        }

        /// <summary>
        /// When one of the denomination properties has changed, will update
        /// </summary>
        /// <param name="denomination"></param>
        void InvokePropertyChanged(string denomination)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(denomination));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TotalValue"));
        }

    }
}
