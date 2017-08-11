﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _10082017
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= checkedListBox1.Items.Count-1; i++)
            {
                checkedListBox1.SetItemChecked(i, true);
            }
            label1.Text = checkedListBox1.CheckedItems.Count + "Eleman Seçili";
        }

        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            int sayi = checkedListBox1.CheckedItems.Count;
            if (e.NewValue == CheckState.Checked) { ++sayi; }
            if (e.NewValue == CheckState.Unchecked) { --sayi; }
            label1.Text = sayi.ToString() + "Eleman Seçili";
            {

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= checkedListBox1.Items.Count - 1; i++)
            {
                checkedListBox1.SetItemChecked(i, false);
            }
            label1.Text = checkedListBox1.CheckedItems.Count + "Eleman Seçili";
        }

        private void button3_Click(object sender, EventArgs e)
        {

            for (int i = 0; i <= checkedListBox1.CheckedItems.Count - 1; i++)


                listBox1.Items.Add(checkedListBox1.CheckedItems[i]);
        }
    }
}
