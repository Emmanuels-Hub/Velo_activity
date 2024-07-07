namespace Velo_Fitness
{
    partial class Swimming
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Swimming));
            pictureBox1 = new PictureBox();
            getTime = new TextBox();
            getWeight = new TextBox();
            calculate = new Button();
            button1 = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            getStroke = new TextBox();
            label5 = new Label();
            levellap = new NumericUpDown();
            groupBox1 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)levellap).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(52, 71);
            pictureBox1.Margin = new Padding(5, 3, 5, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(398, 424);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 30;
            pictureBox1.TabStop = false;
            // 
            // getTime
            // 
            getTime.Location = new Point(91, 295);
            getTime.Margin = new Padding(5, 3, 5, 3);
            getTime.Name = "getTime";
            getTime.Size = new Size(277, 30);
            getTime.TabIndex = 29;
            // 
            // getWeight
            // 
            getWeight.Location = new Point(91, 136);
            getWeight.Margin = new Padding(5, 3, 5, 3);
            getWeight.Name = "getWeight";
            getWeight.Size = new Size(277, 30);
            getWeight.TabIndex = 27;
            // 
            // calculate
            // 
            calculate.BackColor = Color.FromArgb(0, 240, 0);
            calculate.FlatStyle = FlatStyle.Flat;
            calculate.Location = new Point(91, 349);
            calculate.Margin = new Padding(5, 3, 5, 3);
            calculate.Name = "calculate";
            calculate.Size = new Size(277, 49);
            calculate.TabIndex = 26;
            calculate.Text = "Calculate";
            calculate.UseVisualStyleBackColor = false;
            calculate.Click += calculate_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 240, 0);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(24, 21);
            button1.Margin = new Padding(5, 3, 5, 3);
            button1.Name = "button1";
            button1.Size = new Size(103, 36);
            button1.TabIndex = 25;
            button1.Text = "back";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(196, 269);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(82, 23);
            label4.TabIndex = 24;
            label4.Text = "Time (s)";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(175, 110);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(112, 23);
            label3.TabIndex = 23;
            label3.Text = "Weight (kg)";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(211, 31);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(43, 23);
            label2.TabIndex = 22;
            label2.Text = "Lap";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(530, 24);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(395, 33);
            label1.TabIndex = 21;
            label1.Text = "Calculate your calories burn";
            // 
            // getStroke
            // 
            getStroke.Location = new Point(91, 218);
            getStroke.Margin = new Padding(5, 3, 5, 3);
            getStroke.Name = "getStroke";
            getStroke.Size = new Size(277, 30);
            getStroke.TabIndex = 32;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(196, 192);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(68, 23);
            label5.TabIndex = 31;
            label5.Text = "Stroke";
            // 
            // levellap
            // 
            levellap.Location = new Point(91, 57);
            levellap.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            levellap.Name = "levellap";
            levellap.Size = new Size(277, 30);
            levellap.TabIndex = 33;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(levellap);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(getStroke);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(calculate);
            groupBox1.Controls.Add(getTime);
            groupBox1.Controls.Add(getWeight);
            groupBox1.Location = new Point(475, 80);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(479, 415);
            groupBox1.TabIndex = 34;
            groupBox1.TabStop = false;
            groupBox1.Text = "Swimming";
            // 
            // Swimming
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(978, 518);
            Controls.Add(groupBox1);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(label1);
            Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "Swimming";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Swimming";
            Load += Swimming_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)levellap).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox getTime;
        private System.Windows.Forms.TextBox getWeight;
        private System.Windows.Forms.Button calculate;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox getStroke;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown levellap;
        private GroupBox groupBox1;
    }
}