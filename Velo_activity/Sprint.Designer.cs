namespace Velo_Fitness
{
    partial class Sprint
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sprint));
            pictureBox1 = new PictureBox();
            getTime = new TextBox();
            getDis = new TextBox();
            getWeight = new TextBox();
            calculate = new Button();
            button1 = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox1 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(47, 103);
            pictureBox1.Margin = new Padding(5, 3, 5, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(395, 346);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 30;
            pictureBox1.TabStop = false;
            // 
            // getTime
            // 
            getTime.Location = new Point(59, 193);
            getTime.Margin = new Padding(5, 3, 5, 3);
            getTime.Name = "getTime";
            getTime.Size = new Size(277, 28);
            getTime.TabIndex = 29;
            // 
            // getDis
            // 
            getDis.Location = new Point(58, 60);
            getDis.Margin = new Padding(5, 3, 5, 3);
            getDis.Name = "getDis";
            getDis.Size = new Size(277, 28);
            getDis.TabIndex = 28;
            // 
            // getWeight
            // 
            getWeight.Location = new Point(58, 128);
            getWeight.Margin = new Padding(5, 3, 5, 3);
            getWeight.Name = "getWeight";
            getWeight.Size = new Size(277, 28);
            getWeight.TabIndex = 27;
            // 
            // calculate
            // 
            calculate.BackColor = Color.FromArgb(0, 240, 0);
            calculate.FlatStyle = FlatStyle.Flat;
            calculate.Location = new Point(58, 264);
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
            button1.Location = new Point(14, 12);
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
            label4.Location = new Point(143, 169);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(75, 21);
            label4.TabIndex = 24;
            label4.Text = "Time (s)";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(143, 104);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(102, 21);
            label3.TabIndex = 23;
            label3.Text = "Weight (kg)";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(143, 36);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(111, 21);
            label2.TabIndex = 22;
            label2.Text = "Distance (m)";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(480, 27);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(395, 33);
            label1.TabIndex = 21;
            label1.Text = "Calculate your calories burn";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(getTime);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(getDis);
            groupBox1.Controls.Add(calculate);
            groupBox1.Controls.Add(getWeight);
            groupBox1.Location = new Point(450, 76);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(425, 373);
            groupBox1.TabIndex = 31;
            groupBox1.TabStop = false;
            groupBox1.Text = "Sprint";
            // 
            // Sprint
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(889, 472);
            Controls.Add(groupBox1);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(label1);
            Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MaximizeBox = false;
            Name = "Sprint";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sprint";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox getTime;
        private System.Windows.Forms.TextBox getDis;
        private System.Windows.Forms.TextBox getWeight;
        private System.Windows.Forms.Button calculate;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private GroupBox groupBox1;
    }
}