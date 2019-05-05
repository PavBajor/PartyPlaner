using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp11
{
    public partial class Form1 : Form
    {
        DinnerParty party;
        BirthdayParty birthdayParty;
        Party impreza;

        public Form1()
        {
            InitializeComponent();
            impreza = new Party(5, true);
            party = new DinnerParty(5, true, true);
            birthdayParty = new BirthdayParty(5, true, "");
            party.SetHealthyOption(checkBox2.Checked);
            party.CalculateCostOfDecorations(checkBox1.Checked);
            birthdayParty.CalculateCostOfDecorations(checkBox3.Checked);

            DisplayDinnerPartyCost();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            party.SetHealthyOption(checkBox2.Checked);
            DisplayDinnerPartyCost();


        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            party.CalculateCostOfDecorations(checkBox1.Checked);
            DisplayDinnerPartyCost();

        }
        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            birthdayParty.CalculateCostOfDecorations(checkBox3.Checked);
            DisplayBirthdayPartyCost();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            party.NumberOfPeople = (int)numericUpDown1.Value;
            DisplayDinnerPartyCost();
        }
        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            birthdayParty.NumberOfPeople = (int)numericUpDown2.Value;
            DisplayBirthdayPartyCost();
        }

        public void DisplayDinnerPartyCost()
        {
            decimal Cost = party.CalculateCost();
            costLabel.Text = Cost.ToString("c");
        }
        public void DisplayBirthdayPartyCost()
        {
            decimal Cost = birthdayParty.CalculateCost();
            BirthdayLabel.Text = Cost.ToString("c");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            birthdayParty.CakeWriting = textBox1.Text;
            DisplayBirthdayPartyCost();
        }
    }
}
