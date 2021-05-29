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
        public int start_address;//for Hole
        public int size_hole;
        public string alloc_type;//for mem type as first fit (radio button selection)
        public List<Block> MEMORY;// memory including holes and segments
        public List<Block> SortedHoles=new List<Block>();
        public int segment_count = 0;
        public int process_count = 1;
        public int Nu_seg;
        public string seg_name;
        public int seg_size;
        public int count_holes = 0; //number of holes
        public int mem_count=0;
        public int old_count = 0;


        public Form1()
        {
            InitializeComponent();
            MEMORY = new List<Block>();
            Holes.Enabled = false;
            Dealloc_Process.Enabled = false;
            Alloc_type.Enabled = false;
            Process.Enabled = false;
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
                Memory.Enabled = false;
                Holes.Enabled = true;
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
            int holes = int.Parse(num_holes.Text);
            int start_add = int.Parse(Start_Address_hole.Text);
            int hole_size = int.Parse(Size_hole.Text);
            int end_add = start_add+ hole_size;
            int prev = mem_count - 1;

            num_holes.Enabled = false;
            

            if (Start_Address_hole.Text == "")
            {
                MessageBox.Show("Please Enter Starting Address ");
                return;
            }
           
            if (Size_hole.Text == "")
            {
                MessageBox.Show("Please Enter Size Of Holes ");
                return;
            }
            if (end_add > Mem_Size)
            {
                MessageBox.Show("You Exceeded the memory size");
            }
            else
            {
                if (MEMORY.Count != 0)
                {

                    //case 1: start of memory > start of hole input
                    if (MEMORY[prev].Start_add > start_add)
                    {
                        if (MEMORY[prev].Start_add > end_add)
                        {
                            MEMORY.Add(new Block("Hole", start_add, hole_size));
                            mem_count++;
                        }
                        else if (MEMORY[prev].end >= end_add)
                        {
                            MEMORY[prev].Size = MEMORY[prev].end - start_add;
                            MEMORY[prev].Start_add = start_add;
                            holes--;
                        }
                    }
                    //case 2: start of memory = start of hole input
                    else if (MEMORY[prev].Start_add == start_add)
                    {
                        if (MEMORY[prev].end >= end_add)
                        {
                            MessageBox.Show("Hole Already Exist");
                            holes--;
                        }
                        else
                        {
                            MEMORY[prev].Size = size_hole;
                            holes--;
                        }
                    }
                    //case 3 : start of memory < start of hole input
                    else
                    {
                        if (MEMORY[prev].end < start_add)
                        {
                            MEMORY.Add(new Block("Hole", start_add, hole_size));
                            mem_count++;
                        }
                        else if (MEMORY[prev].end == start_add)
                        {
                            MEMORY[prev].Size += size_hole;
                            holes--;
                        }
                        else if(MEMORY[prev].end>start_add )
                        {
                            if (end_add >= MEMORY[prev].end)
                            {
                                MEMORY[prev].Size = end_add - MEMORY[prev].Start_add;
                                holes--;
                            }
                            else //end l adema akbar mn l gdeda
                            {
                                MessageBox.Show("Hole Already Exist");
                                holes--;
                            }
                        }
                    }
                }
                else
                {
                    MEMORY.Add(new Block("Hole", start_add, hole_size));
                    mem_count++;
                }


            }


            if (mem_count == holes)
            {
                Holes.Enabled = false;
                Alloc_type.Enabled = true;
                Process.Enabled = true;

                allocate_old_process();

            }
            Start_Address_hole.Clear();
            Size_hole.Clear();

        }
        public void allocate_old_process()
        {

            MEMORY = MEMORY.OrderBy(v => v.Start_add).ToList();
            if (MEMORY[0].Start_add != 0)
            {
                MEMORY.Add(new Block("Old Process" + old_count, 0, MEMORY[0].Start_add));
                Deallocate.Items.Add("Old Process" + old_count);
                old_count++;
            }
            int old_start =0 ;
            int old_size = 0;
            for(int i = 0; i <mem_count-1; i++)
            {
                old_start = MEMORY[i].end;
                old_size = MEMORY[i + 1].Start_add-old_start;
                MEMORY.Add(new Block("Old Process" + old_count, old_start, old_size));
                Deallocate.Items.Add("Old Process" + old_count);
                old_count++;
            }

            if(MEMORY[mem_count-1].end != Mem_Size)
            {
                old_start = MEMORY[mem_count - 1].end;
                old_size = Mem_Size-old_start;
                MEMORY.Add(new Block("Old Process" + old_count, old_start, old_size));
                Deallocate.Items.Add("Old Process" + old_count);
                old_count++;
            }

            MEMORY = MEMORY.OrderBy(v => v.Start_add).ToList();

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
            Num_Segments.Enabled = true;
            Nu_seg = int.Parse(Num_Segments.Text); //take number of segments from user
            Dealloc_Process.Enabled = true;
            
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
            else if (alloc_type == "Best Fit")
            {
                int k;
                for (k = 0; k < MEMORY.Count; k++)
                {
                    if (MEMORY[k].Name == "Hole")
                    {
                        SortedHoles.Add(new Block("Hole", MEMORY[k].Start_add, MEMORY[k].Size));
                    }
                }
                // sort the list of holes ascending (size)
                SortedHoles = SortedHoles.OrderBy(v => v.Size).ToList();
                int i;
                for (i = 0; i < SortedHoles.Count(); i++)
                {
                    if (SortedHoles[i].Size == seg_size)
                    {
                        SortedHoles[i].Name = "P" + process_count + ":" + seg_name;
                        segment_count++;
                        return;
                    }
                    else if (SortedHoles[i].Size > seg_size)
                    {
                        SortedHoles.Add(new Block("P" + process_count + ":" + seg_name
                                       , SortedHoles[i].Start_add, seg_size));

                        //new hole
                        SortedHoles[i].Start_add = SortedHoles[i].Start_add + seg_size;
                        SortedHoles[i].Size = SortedHoles[i].Size - seg_size;

                        segment_count++;
                        return;
                    }
                }

                    MEMORY.RemoveAll(r => r.Name == "Hole");
                    for(int j = 0; j < SortedHoles.Count; j++)
                    {
                        MEMORY.Add(new Block(SortedHoles[j].Name, SortedHoles[j].Size, SortedHoles[j].Size));
                    }
                    MEMORY.OrderBy(r => r.Start_add).ToList();
                if (i == SortedHoles.Count)
                {
                    MessageBox.Show("Memory Limit Exceeded");
                    //deallocate
                    segment_count = 0;
                }

            }

            else if (alloc_type == "Worst Fit")
            {
                int k;
                for (k = 0; k < MEMORY.Count; k++)
                {
                    if (MEMORY[k].Name == "Hole")
                    {
                        SortedHoles.Add(new Block("Hole", MEMORY[k].Start_add, MEMORY[k].Size));
                    }
                }
                // sort the list of holes ascending (size)
                SortedHoles = SortedHoles.OrderBy(v => v.Size).ToList();
                int i;
                for (i = SortedHoles.Count()-1; i >=0; i--)
                {
                    if (SortedHoles[i].Size == seg_size)
                    {
                        SortedHoles[i].Name = "P" + process_count + ":" + seg_name;
                        segment_count++;
                        return;
                    }
                    else if (SortedHoles[i].Size > seg_size)
                    {
                        SortedHoles.Add(new Block("P" + process_count + ":" + seg_name
                                       , SortedHoles[i].Start_add, seg_size));

                        //new hole
                        SortedHoles[i].Start_add = SortedHoles[i].Start_add + seg_size;
                        SortedHoles[i].Size = SortedHoles[i].Size - seg_size;

                        segment_count++;
                        return;
                    }
                }
                // remove holes
                MEMORY.RemoveAll(r => r.Name == "Hole");
                for (int j = 0; j < SortedHoles.Count; j++)
                {
                    MEMORY.Add(new Block(SortedHoles[j].Name, SortedHoles[j].Size, SortedHoles[j].Size));
                }
                MEMORY.OrderBy(r => r.Start_add).ToList();
                if (i == -1)
                {
                    MessageBox.Show("Memory Limit Exceeded");
                    //deallocate
                    segment_count = 0;
                }

            }

            if (segment_count == Nu_seg)
            {
                Segment.Enabled = false;
                //Deallocate_box.Items.Add("P" + process_count);
                //segment_count = 0;
                process_count++;
            }

        }

        private void Add_Segments_Click(object sender, EventArgs e)
        {
            Num_Segments.Enabled = false;
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
            Name_Segment.Clear();
            Size_Segment.Clear();

        }

        private void Size_Segment_TextChanged(object sender, EventArgs e)
        {

        }

        private void num_holes_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void num_holes_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void Num_Segments_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void Name_Segment_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void Size_Segment_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
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
