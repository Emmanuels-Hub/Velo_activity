namespace Velo_Fitness
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            label7 = new Label();
            setcal = new Button();
            getCal = new TextBox();
            calData = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            runPage = new Button();
            weightPage = new Button();
            swimPage = new Button();
            sprintPage = new Button();
            cycPage = new Button();
            yogaPage = new Button();
            label2 = new Label();
            groupBox1 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(60, 104);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(124, 23);
            label7.TabIndex = 26;
            label7.Text = "Set Calories:";
            // 
            // setcal
            // 
            setcal.BackColor = Color.FromArgb(0, 204, 0);
            setcal.FlatStyle = FlatStyle.Flat;
            setcal.Location = new Point(178, 143);
            setcal.Margin = new Padding(2, 3, 2, 3);
            setcal.Name = "setcal";
            setcal.Size = new Size(66, 35);
            setcal.TabIndex = 24;
            setcal.Text = "Set";
            setcal.UseVisualStyleBackColor = false;
            setcal.Click += setcal_Click;
            // 
            // getCal
            // 
            getCal.Location = new Point(64, 148);
            getCal.Margin = new Padding(2, 3, 2, 3);
            getCal.Name = "getCal";
            getCal.Size = new Size(94, 30);
            getCal.TabIndex = 22;
            getCal.TextChanged += getCal_TextChanged;
            // 
            // calData
            // 
            calData.AutoSize = true;
            calData.Font = new Font("Arial Black", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            calData.Location = new Point(182, 96);
            calData.Margin = new Padding(2, 0, 2, 0);
            calData.Name = "calData";
            calData.Size = new Size(36, 40);
            calData.TabIndex = 20;
            calData.Text = "0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(18, 26);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(475, 43);
            label1.TabIndex = 16;
            label1.Text = "Choose a Suitable Acttivity";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(11, 27);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(364, 483);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // runPage
            // 
            runPage.BackColor = Color.FromArgb(0, 204, 0);
            runPage.FlatStyle = FlatStyle.Flat;
            runPage.Location = new Point(57, 277);
            runPage.Margin = new Padding(2, 3, 2, 3);
            runPage.Name = "runPage";
            runPage.Size = new Size(171, 35);
            runPage.TabIndex = 29;
            runPage.Text = "Runing";
            runPage.UseVisualStyleBackColor = false;
            runPage.Click += runPage_Click;
            // 
            // weightPage
            // 
            weightPage.BackColor = Color.FromArgb(0, 204, 0);
            weightPage.FlatStyle = FlatStyle.Flat;
            weightPage.Location = new Point(259, 277);
            weightPage.Margin = new Padding(2, 3, 2, 3);
            weightPage.Name = "weightPage";
            weightPage.Size = new Size(171, 35);
            weightPage.TabIndex = 31;
            weightPage.Text = "Weight Training";
            weightPage.UseVisualStyleBackColor = false;
            weightPage.Click += weightPage_Click;
            // 
            // swimPage
            // 
            swimPage.BackColor = Color.FromArgb(0, 204, 0);
            swimPage.FlatStyle = FlatStyle.Flat;
            swimPage.Location = new Point(57, 355);
            swimPage.Margin = new Padding(2, 3, 2, 3);
            swimPage.Name = "swimPage";
            swimPage.Size = new Size(171, 35);
            swimPage.TabIndex = 32;
            swimPage.Text = "Swimming";
            swimPage.UseVisualStyleBackColor = false;
            swimPage.Click += swimPage_Click;
            // 
            // sprintPage
            // 
            sprintPage.BackColor = Color.FromArgb(0, 204, 0);
            sprintPage.FlatStyle = FlatStyle.Flat;
            sprintPage.Location = new Point(259, 355);
            sprintPage.Margin = new Padding(2, 3, 2, 3);
            sprintPage.Name = "sprintPage";
            sprintPage.Size = new Size(171, 35);
            sprintPage.TabIndex = 33;
            sprintPage.Text = "Sprinting";
            sprintPage.UseVisualStyleBackColor = false;
            sprintPage.Click += sprintPage_Click;
            // 
            // cycPage
            // 
            cycPage.BackColor = Color.FromArgb(0, 204, 0);
            cycPage.FlatStyle = FlatStyle.Flat;
            cycPage.Location = new Point(259, 429);
            cycPage.Margin = new Padding(2, 3, 2, 3);
            cycPage.Name = "cycPage";
            cycPage.Size = new Size(171, 35);
            cycPage.TabIndex = 34;
            cycPage.Text = "Cycling";
            cycPage.UseVisualStyleBackColor = false;
            cycPage.Click += cycPage_Click;
            // 
            // yogaPage
            // 
            yogaPage.BackColor = Color.FromArgb(0, 204, 0);
            yogaPage.FlatStyle = FlatStyle.Flat;
            yogaPage.Location = new Point(57, 429);
            yogaPage.Margin = new Padding(2, 3, 2, 3);
            yogaPage.Name = "yogaPage";
            yogaPage.Size = new Size(171, 35);
            yogaPage.TabIndex = 35;
            yogaPage.Text = "Yoga";
            yogaPage.UseVisualStyleBackColor = false;
            yogaPage.Click += yogaPage_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(127, 223);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(187, 23);
            label2.TabIndex = 36;
            label2.Text = "Choose your activity";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(calData);
            groupBox1.Controls.Add(yogaPage);
            groupBox1.Controls.Add(getCal);
            groupBox1.Controls.Add(cycPage);
            groupBox1.Controls.Add(setcal);
            groupBox1.Controls.Add(sprintPage);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(swimPage);
            groupBox1.Controls.Add(runPage);
            groupBox1.Controls.Add(weightPage);
            groupBox1.Location = new Point(382, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(499, 498);
            groupBox1.TabIndex = 37;
            groupBox1.TabStop = false;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(893, 542);
            Controls.Add(groupBox1);
            Controls.Add(pictureBox1);
            Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "Home";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Home";
            Load += Home_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button setcal;
        private System.Windows.Forms.TextBox getCal;
        private System.Windows.Forms.Label calData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button runPage;
        private System.Windows.Forms.Button weightPage;
        private System.Windows.Forms.Button swimPage;
        private System.Windows.Forms.Button sprintPage;
        private System.Windows.Forms.Button cycPage;
        private System.Windows.Forms.Button yogaPage;
        private System.Windows.Forms.Label label2;
        private GroupBox groupBox1;
    }
}