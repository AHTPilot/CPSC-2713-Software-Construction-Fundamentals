using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DormAndMealSelector
{
     public partial class PlanSelection : Form
     {
          int totalCost = 0;
          public PlanSelection()
          {
               InitializeComponent();
               
          }

          public void button1_Click(object sender, EventArgs e)
          {
               TotalCharges total = new TotalCharges();
               
               {

                    int dormCost = 0;
                    int mealCost = 0;
                    
                    if (radioButtonAllen.Checked)
                         dormCost = 1500;
                    else if (radioButtonPike.Checked)
                         dormCost = 1600;
                    else if (radioButtonFarthing.Checked)
                         dormCost = 1800;
                    else if (radioButtonSuites.Checked)
                         dormCost = 2500;

                    if (radioButton7Meals.Checked)
                         mealCost = 600;
                    else if (radioButton14Meals.Checked)
                         mealCost = 1200;
                    else if (radioButtonUnlimited.Checked)
                         mealCost = 1700;

                    totalCost = dormCost + mealCost;

                    total.label1.Text = "Your total will be $" + totalCost + " per semester";

                    total.ShowDialog();
                    totalCost = 0;
                    
                    
               }

          }

              
          }
}
