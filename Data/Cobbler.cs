using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace ExamTwoCodeQuestions.Data
{
    public class Cobbler : IOrderItem, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

         public virtual IEnumerable<FruitFilling> FruitValues => Enum.GetValues(typeof(FruitFilling)).Cast<FruitFilling>();

        /// <summary>
        /// The fruit used in the cobbler
        /// </summary>
        private FruitFilling fruit;
        public FruitFilling Fruit 
        { get => fruit;
            set 
            {
                fruit = value;
                PropertyChanged.Invoke(this, new PropertyChangedEventArgs("Fruit"));
            }
       }

        /// <summary>
        /// If the cobbler is served with ice cream
        /// </summary>
        private bool withicecream = true;
        public bool WithIceCream
        {
            get => withicecream;
            set
            {
                withicecream = value;
                PropertyChanged.Invoke(this, new PropertyChangedEventArgs("WithIceCream"));
            }
        }

        /// <summary>
        /// Gets the price of the Cobbler
        /// </summary>
        public double Price
        {
            get
            {
                if (WithIceCream) return 5.32;
                else return 4.25;
            }
        }

        /// <summary>
        /// Gets any special instructions for preparing this dessert
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                if(WithIceCream) { return new List<string>(); }
                else { return new List<string>() { "Hold Ice Cream" }; }
            }
        }

    }
}
