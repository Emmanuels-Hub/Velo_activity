namespace Velo_Fitness
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            label6 = new Label();
            getUser = new TextBox();
            getPass = new TextBox();
            getcomPass = new TextBox();
            create = new Button();
            signPage = new Button();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(15, 14);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(364, 523);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(405, 63);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(224, 43);
            label1.TabIndex = 1;
            label1.Text = "Get Started.";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(411, 114);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(178, 23);
            label2.TabIndex = 2;
            label2.Text = "Create an Account.";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(408, 170);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(105, 23);
            label3.TabIndex = 3;
            label3.Text = "Username:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(408, 331);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(172, 23);
            label5.TabIndex = 5;
            label5.Text = "Confirm Password";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(411, 491);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(236, 23);
            label6.TabIndex = 6;
            label6.Text = "Already have an account?";
            label6.Click += label6_Click;
            // 
            // getUser
            // 
            getUser.Location = new Point(412, 196);
            getUser.Margin = new Padding(2, 3, 2, 3);
            getUser.Name = "getUser";
            getUser.Size = new Size(334, 30);
            getUser.TabIndex = 7;
            // 
            // getPass
            // 
            getPass.Location = new Point(412, 277);
            getPass.Margin = new Padding(2, 3, 2, 3);
            getPass.Name = "getPass";
            getPass.PasswordChar = '*';
            getPass.Size = new Size(334, 30);
            getPass.TabIndex = 8;
            // 
            // getcomPass
            // 
            getcomPass.Location = new Point(412, 357);
            getcomPass.Margin = new Padding(2, 3, 2, 3);
            getcomPass.Name = "getcomPass";
            getcomPass.PasswordChar = '*';
            getcomPass.Size = new Size(334, 30);
            getcomPass.TabIndex = 9;
            getcomPass.TextChanged += textBox3_TextChanged;
            // 
            // create
            // 
            create.BackColor = Color.FromArgb(0, 204, 0);
            create.FlatStyle = FlatStyle.Flat;
            create.Location = new Point(412, 416);
            create.Margin = new Padding(2, 3, 2, 3);
            create.Name = "create";
            create.Size = new Size(330, 35);
            create.TabIndex = 10;
            create.Text = "Register";
            create.UseVisualStyleBackColor = false;
            create.Click += create_Click;
            // 
            // signPage
            // 
            signPage.BackColor = Color.FromArgb(0, 204, 0);
            signPage.FlatStyle = FlatStyle.Flat;
            signPage.Font = new Font("Arial", 10F);
            signPage.Location = new Point(644, 485);
            signPage.Margin = new Padding(2, 3, 2, 3);
            signPage.Name = "signPage";
            signPage.Size = new Size(80, 35);
            signPage.TabIndex = 11;
            signPage.Text = "Sign in";
            signPage.UseVisualStyleBackColor = false;
            signPage.Click += signPage_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(411, 244);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(104, 23);
            label7.TabIndex = 13;
            label7.Text = "Password:";
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(794, 549);
            Controls.Add(label7);
            Controls.Add(signPage);
            Controls.Add(create);
            Controls.Add(getcomPass);
            Controls.Add(getPass);
            Controls.Add(getUser);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "Register";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Register";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox getUser;
        private System.Windows.Forms.TextBox getPass;
        private System.Windows.Forms.TextBox getcomPass;
        private System.Windows.Forms.Button create;
        private System.Windows.Forms.Button signPage;
        private System.Windows.Forms.Label label7;
    }
}

