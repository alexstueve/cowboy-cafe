﻿/*
 * Alex Stueve
 * DakotaDoubleBurger.cs
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    // A class defining the Dakota Double Burger entree
    public class DakotaDoubleBurger : Entree
    {

        /// <summary>
        /// The price of the burger
        /// </summary>
        public override double Price
        {
            get
            {
                return 5.20;
            }
        }

        /// <summary>
        /// The calories of the burger
        /// </summary>
        public override uint Calories
        {
            get
            {
                return 464;
            }
        }

        private bool bun = true;
        /// <summary>
        /// If the burger is served with a bun
        /// </summary>
        public bool Bun
        {
            get { return bun; }
            set { bun = value; NotifyOfPropertyChanged("Bun"); }
        }

        private bool ketchup = true;
        /// <summary>
        /// If the burger has ketchup on it
        /// </summary>
        public bool Ketchup
        {
            get { return ketchup; }
            set { ketchup = value; NotifyOfPropertyChanged("Ketchup"); }
        }

        private bool mustard = true;
        /// <summary>
        /// If the burger has mustard on it
        /// </summary>
        public bool Mustard
        {
            get { return mustard; }
            set { mustard = value; NotifyOfPropertyChanged("Mustard"); }
        }

        private bool pickle = true;
        /// <summary>
        /// If the burger is served with pickles
        /// </summary>
        public bool Pickle
        {
            get { return pickle; }
            set { pickle = value; NotifyOfPropertyChanged("Pickle"); }
        }

        private bool cheese = true;
        /// <summary>
        /// If the burger is served with cheese
        /// </summary>
        public bool Cheese
        {
            get { return cheese; }
            set { cheese = value; NotifyOfPropertyChanged("Cheese"); }
        }

        private bool tomato = true;
        /// <summary>
        /// If the burger is served with tomatoes
        /// </summary>
        public bool Tomato
        {
            get { return tomato; }
            set { tomato = value; NotifyOfPropertyChanged("Tomato"); }
        }

        private bool lettuce = true;
        /// <summary>
        /// If the burger is served with lettuce
        /// </summary>
        public bool Lettuce
        {
            get { return lettuce; }
            set { lettuce = value; NotifyOfPropertyChanged("Lettuce"); }
        }

        private bool mayo = true;
        /// <summary>
        /// If the burger has mayo on it
        /// </summary>
        public bool Mayo
        {
            get { return mayo; }
            set { mayo = value; NotifyOfPropertyChanged("Mayo"); }
        }

        /// <summary>
        /// Special instructions for the preparation of the burger
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();

                if (!bun) instructions.Add("hold bun");
                if (!ketchup) instructions.Add("hold ketchup");
                if (!mustard) instructions.Add("hold mustard");
                if (!pickle) instructions.Add("hold pickle");
                if (!cheese) instructions.Add("hold cheese");
                if (!tomato) instructions.Add("hold tomato");
                if (!lettuce) instructions.Add("hold lettuce");
                if (!mayo) instructions.Add("hold mayo");

                return instructions;
            }
        }

        /// <summary>
        /// Returns the string representation of this entree
        /// </summary>
        /// <returns>The string decribing the burger</returns>
        public override string ToString()
        {
            return "Dakota Double Burger";
        }

    }
}
