﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CandySorting
{
    public partial class Form1 : Form
    {
        private List<Candy> candies;

        public Form1()
        {
            InitializeComponent();
			
            string[] candyNames = { "Mars", "Gummi bear", "Lollipop", "Jelly beans", "Toblerone", "Liquorice", "Peppermints", "Chewygum", "Snickers" };
            double[] prices = { 1, 0.5, 0.2, 1, 1.5, 0.8, 0.8, 1.2, 1 };
            candies = new List<Candy>();
            for (int i = 0; i < candyNames.Length; i++)
            {
                Candy candy = new Candy(candyNames[i], prices[i]);
                candies.Add(candy);
            }
            UpdateDisplay();
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            candies.Sort();
            UpdateDisplay();
        }

        private void UpdateDisplay()
        {
            lbCandy.Items.Clear();
            lbCandy.Items.AddRange(candies.ToArray());
            lbCandy.DisplayMember = "Name";
        }
    }
}
