namespace IVMS_APP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panlogin = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Role = new System.Windows.Forms.ComboBox();
            this.LOGIN = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Username = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panlogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // panlogin
            // 
            this.panlogin.Controls.Add(this.label5);
            this.panlogin.Controls.Add(this.Password);
            this.panlogin.Controls.Add(this.Username);
            this.panlogin.Controls.Add(this.label4);
            this.panlogin.Controls.Add(this.label3);
            this.panlogin.Controls.Add(this.label2);
            this.panlogin.Controls.Add(this.LOGIN);
            this.panlogin.Controls.Add(this.Role);
            this.panlogin.Controls.Add(this.label1);
            this.panlogin.Location = new System.Drawing.Point(271, 12);
            this.panlogin.Name = "panlogin";
            this.panlogin.Size = new System.Drawing.Size(294, 370);
            this.panlogin.TabIndex = 0;
            this.panlogin.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(93, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "LOG-IN";
            // 
            // Role
            // 
            this.Role.BackColor = System.Drawing.Color.CornflowerBlue;
            this.Role.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Role.FormattingEnabled = true;
            this.Role.Items.AddRange(new object[] {
            "ADMIN",
            "CASHIER"});
            this.Role.Location = new System.Drawing.Point(88, 211);
            this.Role.Name = "Role";
            this.Role.Size = new System.Drawing.Size(181, 23);
            this.Role.TabIndex = 3;
            this.Role.Text = "SELECT ROLE";
            this.Role.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // LOGIN
            // 
            this.LOGIN.BackColor = System.Drawing.Color.CornflowerBlue;
            this.LOGIN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LOGIN.Location = new System.Drawing.Point(98, 257);
            this.LOGIN.Name = "LOGIN";
            this.LOGIN.Size = new System.Drawing.Size(152, 38);
            this.LOGIN.TabIndex = 4;
            this.LOGIN.Text = "LOGIN";
            this.LOGIN.UseVisualStyleBackColor = false;
            this.LOGIN.Click += new System.EventHandler(this.LOGIN_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 25);
            this.label2.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Username";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "Password";
            // 
            // Username
            // 
            this.Username.BackColor = System.Drawing.Color.CornflowerBlue;
            this.Username.Location = new System.Drawing.Point(112, 98);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(157, 20);
            this.Username.TabIndex = 8;
            this.Username.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Password
            // 
            this.Password.BackColor = System.Drawing.Color.CornflowerBlue;
            this.Password.Location = new System.Drawing.Point(112, 153);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(157, 20);
            this.Password.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label5.Location = new System.Drawing.Point(270, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "x";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(622, 450);
            this.Controls.Add(this.panlogin);
            this.Name = "Form1";
            this.Text = "LOGIN PAGE";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panlogin.ResumeLayout(false);
            this.panlogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panlogin;
        private System.Windows.Forms.Button LOGIN;
        private System.Windows.Forms.ComboBox Role;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.TextBox Username;
        private System.Windows.Forms.Label label5;
    }
}

