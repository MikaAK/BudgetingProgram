using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Budgeting_Program
{
    public partial class Total : Form
    {
        public List<Item> itemList = new List<Item>();

        public Total()
        {
            InitializeComponent();
        }

        public Total(List<Item> i)
        {
            itemList = i;
            InitializeComponent();
        }


        private void Total_Load(object sender, EventArgs e)
        {
            double beforeTax = 0;
            double totalPrice = 0.00;
            const double PST = 0.05;
            const double GST = 0.07;
            
            for (int i = 0; i < itemList.Count; i++)
            {
                beforeTax += itemList[i].Price;
            }

            totalPrice = beforeTax.addTax(PST, GST);

            GSTnumber.Text = Convert.ToString(GST * 100) + "%";
            PSTnumber.Text = Convert.ToString(PST * 100) + "%";
            beforeTaxPrice.Text = "$" + Convert.ToString(beforeTax);
            afterTaxPrice.Text = "$" + Convert.ToString(Math.Round(totalPrice, 2));
        }
    }

    public static class Extentions
    {
        public static double addTax(this double Before, double tax1, double tax2 = 0)
        {
            return ((Before * tax1) + (Before * tax2)) + Before;
        }
    }
}
