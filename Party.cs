using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp11
{
    public class Party
    {
        private bool fancyDecorations;
        
        public Party(int people, bool fancyDecorations)
        {
            this.NumberOfPeople = people;
            this.fancyDecorations = fancyDecorations;
        }
        
        protected int numberOfPeople;
        protected decimal bonus;
        public int NumberOfPeople
        {
            get
            {
                return numberOfPeople;
            }
            set
            {
                numberOfPeople = value;
                CalculateCostOfDecorations(fancyDecorations);
            }
        }
        protected decimal costOfDecorations = 0;
        public void CalculateCostOfDecorations(bool choice)
        {
            fancyDecorations = choice;
            if (choice == true)
            {
                costOfDecorations = (NumberOfPeople * 15M)+ 50M;
                
            }
            else
            {
                costOfDecorations = (NumberOfPeople * 7.5M) + 30M;
                
            }
        }
        public void SetBonus()
        {
            if (numberOfPeople>12)
            {
                bonus = 100M;
            }
            else
            {
                bonus = 0M;
            }
        }
        public virtual decimal CalculateCost()
        {
            decimal TotalCost = costOfDecorations + (25M * NumberOfPeople);
            if (NumberOfPeople>12)
            {
                TotalCost += 100M;
            }
            return TotalCost;
        }
        
    }
}
