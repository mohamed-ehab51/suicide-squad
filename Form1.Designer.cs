namespace suicide_squade
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            button1 = new Button();
            button2 = new Button();
            folderBrowserDialog1 = new FolderBrowserDialog();
            button3 = new Button();
            progressBar1 = new ProgressBar();
            label1 = new Label();
            openFileDialog1 = new OpenFileDialog();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            textBox2 = new TextBox();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(350, 66);
            button1.Name = "button1";
            button1.Size = new Size(99, 29);
            button1.TabIndex = 0;
            button1.Text = "Choose";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(350, 440);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 1;
            button2.Text = "start";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(355, 146);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 2;
            button3.Text = "choose";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(12, 405);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(776, 29);
            progressBar1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Location = new Point(376, 382);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 4;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(323, 114);
            label2.Name = "label2";
            label2.Size = new Size(150, 20);
            label2.TabIndex = 5;
            label2.Text = "Choose output folder";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(350, 27);
            label3.Name = "label3";
            label3.Size = new Size(99, 20);
            label3.TabIndex = 6;
            label3.Text = "Choose video";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(232, 222);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(135, 27);
            textBox1.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(232, 189);
            label4.Name = "label4";
            label4.Size = new Size(135, 20);
            label4.TabIndex = 8;
            label4.Text = "output video name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(36, 276);
            label5.Name = "label5";
            label5.Size = new Size(95, 20);
            label5.TabIndex = 9;
            label5.Text = "Input video : ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(36, 305);
            label6.Name = "label6";
            label6.Size = new Size(100, 20);
            label6.TabIndex = 10;
            label6.Text = "Output path : ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(36, 334);
            label7.Name = "label7";
            label7.Size = new Size(100, 20);
            label7.TabIndex = 11;
            label7.Text = "Video name : ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(416, 189);
            label8.Name = "label8";
            label8.Size = new Size(161, 20);
            label8.TabIndex = 12;
            label8.Text = "output video extension";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(430, 222);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(135, 27);
            textBox2.TabIndex = 13;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(137, 276);
            label9.Name = "label9";
            label9.Size = new Size(0, 20);
            label9.TabIndex = 14;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(137, 305);
            label10.Name = "label10";
            label10.Size = new Size(0, 20);
            label10.TabIndex = 15;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(137, 334);
            label11.Name = "label11";
            label11.Size = new Size(0, 20);
            label11.TabIndex = 16;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 481);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(textBox2);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(progressBar1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Suicide squad";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private FolderBrowserDialog folderBrowserDialog1;
        private Button button3;
        private ProgressBar progressBar1;
        private Label label1;
        private OpenFileDialog openFileDialog1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox textBox2;
        private Label label9;
        private Label label10;
        private Label label11;
    }
}