namespace Velo_Fitness
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            label7 = new Label();
            regPage = new Button();
            enter = new Button();
            getlogpass = new TextBox();
            getloguser = new TextBox();
            label6 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(366, 247);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(94, 21);
            label7.TabIndex = 27;
            label7.Text = "Password:";
            // 
            // regPage
            // 
            regPage.BackColor = Color.FromArgb(0, 204, 0);
            regPage.FlatStyle = FlatStyle.Flat;
            regPage.Font = new Font("Arial", 10F);
            regPage.Location = new Point(437, 444);
            regPage.Margin = new Padding(2);
            regPage.Name = "regPage";
            regPage.Size = new Size(172, 32);
            regPage.TabIndex = 25;
            regPage.Text = "Create Account";
            regPage.UseVisualStyleBackColor = false;
            regPage.Click += regPage_Click;
            // 
            // enter
            // 
            enter.BackColor = Color.FromArgb(0, 204, 0);
            enter.FlatStyle = FlatStyle.Flat;
            enter.Location = new Point(369, 341);
            enter.Margin = new Padding(2);
            enter.Name = "enter";
            enter.Size = new Size(300, 32);
            enter.TabIndex = 24;
            enter.Text = "Login";
            enter.UseVisualStyleBackColor = false;
            enter.Click += create_Click;
            // 
            // getlogpass
            // 
            getlogpass.Location = new Point(369, 281);
            getlogpass.Margin = new Padding(2);
            getlogpass.Name = "getlogpass";
            getlogpass.PasswordChar = '*';
            getlogpass.Size = new Size(304, 28);
            getlogpass.TabIndex = 22;
            // 
            // getloguser
            // 
            getloguser.Location = new Point(372, 204);
            getloguser.Margin = new Padding(2);
            getloguser.Name = "getloguser";
            getloguser.Size = new Size(304, 28);
            getloguser.TabIndex = 21;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(421, 412);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(210, 21);
            label6.TabIndex = 20;
            label6.Text = "Do not have an Account?";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(369, 173);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(97, 21);
            label3.TabIndex = 18;
            label3.Text = "Username:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Narrow", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(369, 103);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(180, 29);
            label2.TabIndex = 17;
            label2.Text = "Login to Continue";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(364, 57);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(304, 43);
            label1.TabIndex = 16;
            label1.Text = "Welcome to Velo";
            label1.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(9, 12);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(331, 464);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(719, 507);
            Controls.Add(label7);
            Controls.Add(regPage);
            Controls.Add(enter);
            Controls.Add(getlogpass);
            Controls.Add(getloguser);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Login_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button regPage;
        private System.Windows.Forms.Button enter;
        private System.Windows.Forms.TextBox getlogpass;
        private System.Windows.Forms.TextBox getloguser;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}