using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace m2k
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBoxIn_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9')
            {
                return;
            }
            if (e.KeyChar == '.')
            {
                e.KeyChar = ',';
            }
            if (e.KeyChar == ',')
            {
                if (textBoxIn.Text.IndexOf(',') != -1) 
                {
                    e.Handled = true;
                }
                return;

            }
            if (Char.IsControl(e.KeyChar))
            {
                if (e.KeyChar == (char)Keys.Enter)
                    button1.Focus();
                return;
            }
            e.Handled = true;
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            double mile = 0;
            double km = 0;
            try
            {
                mile = Convert.ToDouble(textBoxIn.Text);
                km = mile * 1.609344;
                labelOut.Text = km.ToString("n") + " км";
            }
            catch
            {
                textBoxIn.Focus();                
            }
        }
    }
}
