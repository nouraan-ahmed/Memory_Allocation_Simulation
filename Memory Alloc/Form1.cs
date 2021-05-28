using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Memory_Allocation_Segmentation
{
    public partial class Form1 : Form
    {
        public int Mem_Size;
        public int start_address;//for Holl
        public int size_hole;
        public String alloc_type;//for mem type as first fit
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        private void memory_size_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (memory_size.Text.Length == 0)
            {
                MessageBox.Show("Choose Number");
                return;
            }
            else
            {
                Mem_Size = int.Parse(memory_size.Text);
            }
        }

       
        private void memory_size_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar)&&(!char.IsControl(e.KeyChar))) 
            {
                e.Handled = true;
            }
        }

        private void Start_Address_hole_TextChanged(object sender, EventArgs e)
        {

        }

        private void Start_Address_hole_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void Size_hole_TextChanged(object sender, EventArgs e)
        {

        }

        private void Size_hole_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }

        }

        private void Add_Hole_Click(object sender, EventArgs e)
        {
            if (memory_size.Text.Length == 0)
            {
                MessageBox.Show("Please Enter Starting Address ");
                return;
            }
            else
            {
                start_address = int.Parse(Start_Address_hole.Text);
            }
            if (memory_size.Text.Length == 0)
            {
                MessageBox.Show("Please Enter Size Of Holes ");
                return;
            }
            else
            {
                size_hole = int.Parse(Size_hole.Text);
            }
        }

        private void First_Fit_CheckedChanged(object sender, EventArgs e)
        {
            alloc_type = First_Fit.Text.ToString();

        }

        private void Best_Fit_CheckedChanged(object sender, EventArgs e)
        {
            alloc_type = Best_Fit.Text.ToString();
        }

        private void Worst_Fit_CheckedChanged(object sender, EventArgs e)
        {
            alloc_type = Worst_Fit.Text.ToString();
        }
    }
}
