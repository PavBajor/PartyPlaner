using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp11
{
    public class DinnerParty : Party
    {
        
        private decimal costOfBeveragesPerPerson;
        private const decimal costOfFoodPerPerson = 25M;
        private decimal discount;
        
        public DinnerParty(int people, bool fancyDecorations, bool healthyOption)
            :base(people, fancyDecorations)
        {
            SetHealthyOption(healthyOption);
            CalculateCostOfDecorations(fancyDecorations);
        }
        

        public void SetHealthyOption(bool choice)
        {
            if (choice==true)
            {
                costOfBeveragesPerPerson = 5M;
                discount = 0.95M;
            }
            else
            {
                costOfBeveragesPerPerson = 20M;
                discount = 1;
            }
        }

        

        public override decimal CalculateCost()
        {
            return discount * (base.CalculateCost() + NumberOfPeople * costOfBeveragesPerPerson);
        }


    }
}
