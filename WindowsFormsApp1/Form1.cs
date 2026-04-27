using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Numbers = textBox1.Text;
            string[] reserved = Numbers.Split(' ');

            int[] res = new int[reserved.Length];
            int numbner = 0; 
            for(int i=reserved.Length-1; i>=0;i--)
            {
                res[numbner] = int.Parse(reserved[i]);
                numbner++;
            }

            string Result = ""; 
            foreach(int item in res)
            {
                Result += item.ToString() + " "; 

            }

            MessageBox.Show("Reserved : " + Result); 
        }
    }
}
