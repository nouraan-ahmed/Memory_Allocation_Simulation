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
        public List<Block> MEMORY;
        public int segment_count = 0;
        public int process_count = 1;
        public int Nu_seg;
        public string seg_name;
        public int seg_size;
        public Form1()
        {
            InitializeComponent();
            MEMORY = new List<Block>();
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
            if (MEMORY.Count == 0)
            {
                
                
            }
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Add_Process_Click(object sender, EventArgs e)
        {
            Nu_seg = int.Parse(Num_Segments.Text);
            if (segment_count == Nu_seg)
            {
                Segment.Enabled = false;
                //Deallocate_box.Items.Add("P" + process_count);
                //segment_count = 0;
                process_count++;
            }
            if (alloc_type == "First_Fit")
            {
                int i;
                for( i = 0; i < MEMORY.Count(); i++)
                {
                    if (MEMORY[i].Name == "Hole")
                    {
                        if (MEMORY[i].Size ==seg_size )
                        {
                            MEMORY[i].Name = "P" + process_count + ":" + seg_name;
                            segment_count++;
                            return;
                        }
                        else if (MEMORY[i].Size >seg_size )
                        {
                            MEMORY.Add(new Block("P" + process_count + ":" + seg_name
                                           , MEMORY[i].Start_add,seg_size ));

                            //new hole
                            MEMORY[i].Start_add = MEMORY[i].Start_add +seg_size ;
                            MEMORY[i].Size = MEMORY[i].Size -seg_size ;

                            //satr ma3gpnesh
                            segment_count++;
                            return;
                        }
                    }
                }
                if (i == MEMORY.Count)
                {
                    MessageBox.Show("Process doesn't fit");
                }
            }
        }

        private void Add_Segments_Click(object sender, EventArgs e)
        {
            if (MEMORY.Find(X => X.Name == "Hole") == null)
            {
                MessageBox.Show(" Memory is Busy , There's no Holes");
                return;
            }
            else
            {
                if ((Name_Segment.Text == "")||(Size_Segment.Text.Length==0)||(Num_Segments.Text.Length==0))
                {
                    MessageBox.Show("please enter Correct information");
                    return;
                }
                else
                {
                                             
                    seg_name = Name_Segment.Text;
                    seg_size = int.Parse(Size_Segment.Text);
                    
                }
            }

        }

        private void Size_Segment_TextChanged(object sender, EventArgs e)
        {

        }
    }
    public class Block
    {
        public int Start_add { get; set; }
        public int Size { get; set; }
        public string Name { get; set; }

        public int end => Size + Start_add;

        public Block(string n, int start, int limit)
        {
            Name = n;
            Start_add = start;
            Size = limit;

        }
    }
}
