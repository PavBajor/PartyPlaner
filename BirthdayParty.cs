using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp11
{
    
    public class BirthdayParty : Party
    {
        private int cakeSize;
        public void CalculateCakeSize()
        {
            
                if (NumberOfPeople<=4)
                {
                    cakeSize = 8;
                }
                else
                {
                    cakeSize = 16;
                }
            
        }
        private string cakeWriting;
        public string CakeWriting
        {
            get
            {
                return cakeWriting;
            }
            set
            {
                int maxLength;
                if (cakeSize==8)
                {
                    maxLength = 16;
                }
                else
                {
                    maxLength = 40;
                }
                if (value.Length>maxLength)
                {
                    MessageBox.Show("To many words for " + maxLength + "inch cake");
                    if (maxLength > this.cakeWriting.Length)
                    {
                        maxLength = this.cakeWriting.Length;
                    }
                    this.cakeWriting = cakeWriting.Substring(0, maxLength);
                }
                else
                {
                    cakeWriting = value;
                }
            }
        }


        public BirthdayParty(int people, bool fancyDecorations, string cakeWriting)
            : base(people, fancyDecorations)
        {
            CalculateCakeSize();
            this.cakeWriting = cakeWriting;
            CalculateCostOfDecorations(fancyDecorations);
        }
                        
        public override decimal CalculateCost()
        {
            decimal cakeCost;
            if (cakeSize==8)
            {
                cakeCost = 40M + cakeWriting.Length * 0.25M;
            }
            else
            {
                cakeCost = 75M + cakeWriting.Length * 0.25M;
            }
            return base.CalculateCost() + cakeCost;
        }



    }
}
