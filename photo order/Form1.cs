﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace photo_order
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbxSize.Items.Add("Small");
            cbxSize.Items.Add("Medium");
            cbxSize.Items.Add("Large");

            cbxSize.SelectedIndex = 0; //selecting the first size

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (Int32.TryParse(txtQuantity.Text, out int quantity) == false)
            {
                MessageBox.Show("Quantity Must be a Number", "Error");
                return;
            }
          
            string size = cbxSize.SelectedItem.ToString();

            double price;

            switch (size)
            {
                case "Small":
                    price = 0.20;
                    break;
                case "Medium":
                    price = 0.30;
                    break;
                case "Large":
                    price = 0.40;
                    break;
                      case " Extra Large":
                    price = 0.50;
                    break;
                   
                default:
                    MessageBox.Show("Uknown size");
                    return;   //stop processing this event
                    

            }
            txtPrice.Text = price.ToString("c"); //fotmating as currency
        }
        
    }
}
