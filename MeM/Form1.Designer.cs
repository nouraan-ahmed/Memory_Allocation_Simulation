
namespace Memory_Allocation_Segmentation
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Memory = new System.Windows.Forms.GroupBox();
            this.memory_size = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.Holes = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.num_holes = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Size_hole = new System.Windows.Forms.TextBox();
            this.Start_Address_hole = new System.Windows.Forms.TextBox();
            this.Add_Hole = new System.Windows.Forms.Button();
            this.Alloc_type = new System.Windows.Forms.GroupBox();
            this.Worst_Fit = new System.Windows.Forms.RadioButton();
            this.Best_Fit = new System.Windows.Forms.RadioButton();
            this.First_Fit = new System.Windows.Forms.RadioButton();
            this.Process = new System.Windows.Forms.GroupBox();
            this.Add_Process = new System.Windows.Forms.Button();
            this.Segment = new System.Windows.Forms.GroupBox();
            this.Add_Segments = new System.Windows.Forms.Button();
            this.Size_Segment = new System.Windows.Forms.TextBox();
            this.Name_Segment = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Num_Segments = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Dealloc_Process = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Deallocate = new System.Windows.Forms.ComboBox();
            this.Draw = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.Memory.SuspendLayout();
            this.Holes.SuspendLayout();
            this.Alloc_type.SuspendLayout();
            this.Process.SuspendLayout();
            this.Segment.SuspendLayout();
            this.Dealloc_Process.SuspendLayout();
            this.SuspendLayout();
            // 
            // Memory
            // 
            this.Memory.Controls.Add(this.memory_size);
            this.Memory.Controls.Add(this.button3);
            this.Memory.Controls.Add(this.label5);
            this.Memory.Location = new System.Drawing.Point(21, 26);
            this.Memory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Memory.Name = "Memory";
            this.Memory.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Memory.Size = new System.Drawing.Size(461, 122);
            this.Memory.TabIndex = 11;
            this.Memory.TabStop = false;
            this.Memory.Text = "Memory";
            // 
            // memory_size
            // 
            this.memory_size.Location = new System.Drawing.Point(169, 27);
            this.memory_size.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.memory_size.Name = "memory_size";
            this.memory_size.Size = new System.Drawing.Size(167, 22);
            this.memory_size.TabIndex = 9;
            this.memory_size.TextChanged += new System.EventHandler(this.memory_size_TextChanged);
            this.memory_size.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.memory_size_KeyPress);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(220, 65);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(115, 39);
            this.button3.TabIndex = 8;
            this.button3.Text = "OK";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Enter Memory Size";
            // 
            // Holes
            // 
            this.Holes.Controls.Add(this.label4);
            this.Holes.Controls.Add(this.num_holes);
            this.Holes.Controls.Add(this.label6);
            this.Holes.Controls.Add(this.label7);
            this.Holes.Controls.Add(this.Size_hole);
            this.Holes.Controls.Add(this.Start_Address_hole);
            this.Holes.Controls.Add(this.Add_Hole);
            this.Holes.Location = new System.Drawing.Point(21, 154);
            this.Holes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Holes.Name = "Holes";
            this.Holes.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Holes.Size = new System.Drawing.Size(461, 218);
            this.Holes.TabIndex = 10;
            this.Holes.TabStop = false;
            this.Holes.Text = "Holes";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Number of Holes";
            // 
            // num_holes
            // 
            this.num_holes.Location = new System.Drawing.Point(170, 29);
            this.num_holes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.num_holes.Name = "num_holes";
            this.num_holes.Size = new System.Drawing.Size(167, 22);
            this.num_holes.TabIndex = 8;
            this.num_holes.KeyDown += new System.Windows.Forms.KeyEventHandler(this.num_holes_KeyDown);
            this.num_holes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.num_holes_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "Size of Hole";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Starting Address";
            // 
            // Size_hole
            // 
            this.Size_hole.Location = new System.Drawing.Point(170, 117);
            this.Size_hole.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Size_hole.Name = "Size_hole";
            this.Size_hole.Size = new System.Drawing.Size(167, 22);
            this.Size_hole.TabIndex = 4;
            this.Size_hole.TextChanged += new System.EventHandler(this.Size_hole_TextChanged);
            this.Size_hole.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Size_hole_KeyPress);
            // 
            // Start_Address_hole
            // 
            this.Start_Address_hole.Location = new System.Drawing.Point(170, 75);
            this.Start_Address_hole.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Start_Address_hole.Name = "Start_Address_hole";
            this.Start_Address_hole.Size = new System.Drawing.Size(167, 22);
            this.Start_Address_hole.TabIndex = 3;
            this.Start_Address_hole.TextChanged += new System.EventHandler(this.Start_Address_hole_TextChanged);
            this.Start_Address_hole.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Start_Address_hole_KeyPress);
            // 
            // Add_Hole
            // 
            this.Add_Hole.Location = new System.Drawing.Point(169, 154);
            this.Add_Hole.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Add_Hole.Name = "Add_Hole";
            this.Add_Hole.Size = new System.Drawing.Size(168, 44);
            this.Add_Hole.TabIndex = 1;
            this.Add_Hole.Text = "Add New Hole";
            this.Add_Hole.UseVisualStyleBackColor = true;
            this.Add_Hole.Click += new System.EventHandler(this.Add_Hole_Click);
            // 
            // Alloc_type
            // 
            this.Alloc_type.Controls.Add(this.Worst_Fit);
            this.Alloc_type.Controls.Add(this.Best_Fit);
            this.Alloc_type.Controls.Add(this.First_Fit);
            this.Alloc_type.Location = new System.Drawing.Point(21, 384);
            this.Alloc_type.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Alloc_type.Name = "Alloc_type";
            this.Alloc_type.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Alloc_type.Size = new System.Drawing.Size(461, 134);
            this.Alloc_type.TabIndex = 12;
            this.Alloc_type.TabStop = false;
            this.Alloc_type.Text = "Set Allocation Type";
            // 
            // Worst_Fit
            // 
            this.Worst_Fit.AutoSize = true;
            this.Worst_Fit.Location = new System.Drawing.Point(21, 92);
            this.Worst_Fit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Worst_Fit.Name = "Worst_Fit";
            this.Worst_Fit.Size = new System.Drawing.Size(85, 21);
            this.Worst_Fit.TabIndex = 2;
            this.Worst_Fit.TabStop = true;
            this.Worst_Fit.Text = "Worst Fit";
            this.Worst_Fit.UseVisualStyleBackColor = true;
            this.Worst_Fit.CheckedChanged += new System.EventHandler(this.Worst_Fit_CheckedChanged);
            // 
            // Best_Fit
            // 
            this.Best_Fit.AutoSize = true;
            this.Best_Fit.Location = new System.Drawing.Point(21, 65);
            this.Best_Fit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Best_Fit.Name = "Best_Fit";
            this.Best_Fit.Size = new System.Drawing.Size(76, 21);
            this.Best_Fit.TabIndex = 1;
            this.Best_Fit.TabStop = true;
            this.Best_Fit.Text = "Best Fit";
            this.Best_Fit.UseVisualStyleBackColor = true;
            this.Best_Fit.CheckedChanged += new System.EventHandler(this.Best_Fit_CheckedChanged);
            // 
            // First_Fit
            // 
            this.First_Fit.AutoSize = true;
            this.First_Fit.Location = new System.Drawing.Point(21, 37);
            this.First_Fit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.First_Fit.Name = "First_Fit";
            this.First_Fit.Size = new System.Drawing.Size(75, 21);
            this.First_Fit.TabIndex = 0;
            this.First_Fit.TabStop = true;
            this.First_Fit.Text = "First Fit";
            this.First_Fit.UseVisualStyleBackColor = true;
            this.First_Fit.CheckedChanged += new System.EventHandler(this.First_Fit_CheckedChanged);
            // 
            // Process
            // 
            this.Process.Controls.Add(this.Add_Process);
            this.Process.Controls.Add(this.Segment);
            this.Process.Controls.Add(this.Num_Segments);
            this.Process.Controls.Add(this.label1);
            this.Process.Location = new System.Drawing.Point(21, 524);
            this.Process.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Process.Name = "Process";
            this.Process.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Process.Size = new System.Drawing.Size(461, 289);
            this.Process.TabIndex = 13;
            this.Process.TabStop = false;
            this.Process.Text = "Process";
            // 
            // Add_Process
            // 
            this.Add_Process.Location = new System.Drawing.Point(76, 226);
            this.Add_Process.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Add_Process.Name = "Add_Process";
            this.Add_Process.Size = new System.Drawing.Size(233, 42);
            this.Add_Process.TabIndex = 3;
            this.Add_Process.Text = "Add Process";
            this.Add_Process.UseVisualStyleBackColor = true;
            this.Add_Process.Click += new System.EventHandler(this.Add_Process_Click);
            // 
            // Segment
            // 
            this.Segment.Controls.Add(this.Add_Segments);
            this.Segment.Controls.Add(this.Size_Segment);
            this.Segment.Controls.Add(this.Name_Segment);
            this.Segment.Controls.Add(this.label3);
            this.Segment.Controls.Add(this.label2);
            this.Segment.Location = new System.Drawing.Point(11, 78);
            this.Segment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Segment.Name = "Segment";
            this.Segment.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Segment.Size = new System.Drawing.Size(428, 143);
            this.Segment.TabIndex = 2;
            this.Segment.TabStop = false;
            this.Segment.Text = "Segment";
            // 
            // Add_Segments
            // 
            this.Add_Segments.Location = new System.Drawing.Point(171, 101);
            this.Add_Segments.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Add_Segments.Name = "Add_Segments";
            this.Add_Segments.Size = new System.Drawing.Size(141, 36);
            this.Add_Segments.TabIndex = 4;
            this.Add_Segments.Text = "Add Segment";
            this.Add_Segments.UseVisualStyleBackColor = true;
            this.Add_Segments.Click += new System.EventHandler(this.Add_Segments_Click);
            // 
            // Size_Segment
            // 
            this.Size_Segment.Location = new System.Drawing.Point(157, 64);
            this.Size_Segment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Size_Segment.Name = "Size_Segment";
            this.Size_Segment.Size = new System.Drawing.Size(167, 22);
            this.Size_Segment.TabIndex = 3;
            this.Size_Segment.TextChanged += new System.EventHandler(this.Size_Segment_TextChanged);
            this.Size_Segment.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Size_Segment_KeyPress);
            // 
            // Name_Segment
            // 
            this.Name_Segment.Location = new System.Drawing.Point(157, 33);
            this.Name_Segment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name_Segment.Name = "Name_Segment";
            this.Name_Segment.Size = new System.Drawing.Size(167, 22);
            this.Name_Segment.TabIndex = 2;
            this.Name_Segment.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Name_Segment_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Size";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Name";
            // 
            // Num_Segments
            // 
            this.Num_Segments.Location = new System.Drawing.Point(167, 33);
            this.Num_Segments.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Num_Segments.Name = "Num_Segments";
            this.Num_Segments.Size = new System.Drawing.Size(167, 22);
            this.Num_Segments.TabIndex = 1;
            this.Num_Segments.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Num_Segments_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number Of Segments";
            // 
            // Dealloc_Process
            // 
            this.Dealloc_Process.Controls.Add(this.button1);
            this.Dealloc_Process.Controls.Add(this.Deallocate);
            this.Dealloc_Process.Location = new System.Drawing.Point(499, 26);
            this.Dealloc_Process.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Dealloc_Process.Name = "Dealloc_Process";
            this.Dealloc_Process.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Dealloc_Process.Size = new System.Drawing.Size(436, 122);
            this.Dealloc_Process.TabIndex = 14;
            this.Dealloc_Process.TabStop = false;
            this.Dealloc_Process.Text = "Deallocate Process";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(268, 46);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "DeAllocate";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Deallocate
            // 
            this.Deallocate.FormattingEnabled = true;
            this.Deallocate.Location = new System.Drawing.Point(17, 46);
            this.Deallocate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Deallocate.Name = "Deallocate";
            this.Deallocate.Size = new System.Drawing.Size(225, 24);
            this.Deallocate.TabIndex = 0;
            // 
            // Draw
            // 
            this.Draw.Location = new System.Drawing.Point(531, 177);
            this.Draw.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Draw.Name = "Draw";
            this.Draw.Size = new System.Drawing.Size(104, 23);
            this.Draw.TabIndex = 15;
            this.Draw.Text = "Draw";
            this.Draw.UseVisualStyleBackColor = true;
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(811, 177);
            this.Clear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(75, 23);
            this.Clear.TabIndex = 16;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 839);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.Draw);
            this.Controls.Add(this.Dealloc_Process);
            this.Controls.Add(this.Process);
            this.Controls.Add(this.Alloc_type);
            this.Controls.Add(this.Memory);
            this.Controls.Add(this.Holes);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Memory Allocation By Segmentation";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Memory.ResumeLayout(false);
            this.Memory.PerformLayout();
            this.Holes.ResumeLayout(false);
            this.Holes.PerformLayout();
            this.Alloc_type.ResumeLayout(false);
            this.Alloc_type.PerformLayout();
            this.Process.ResumeLayout(false);
            this.Process.PerformLayout();
            this.Segment.ResumeLayout(false);
            this.Segment.PerformLayout();
            this.Dealloc_Process.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Memory;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox Holes;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Size_hole;
        private System.Windows.Forms.TextBox Start_Address_hole;
        private System.Windows.Forms.Button Add_Hole;
        private System.Windows.Forms.TextBox memory_size;
        private System.Windows.Forms.GroupBox Alloc_type;
        private System.Windows.Forms.RadioButton Worst_Fit;
        private System.Windows.Forms.RadioButton Best_Fit;
        private System.Windows.Forms.RadioButton First_Fit;
        private System.Windows.Forms.GroupBox Process;
        private System.Windows.Forms.Button Add_Process;
        private System.Windows.Forms.GroupBox Segment;
        private System.Windows.Forms.Button Add_Segments;
        private System.Windows.Forms.TextBox Size_Segment;
        private System.Windows.Forms.TextBox Name_Segment;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Num_Segments;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox Dealloc_Process;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox Deallocate;
        private System.Windows.Forms.Button Draw;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox num_holes;
    }
}

