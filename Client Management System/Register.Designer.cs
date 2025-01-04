namespace Client_Management_System
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
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_register = new System.Windows.Forms.Button();
            this.check_passw = new System.Windows.Forms.CheckBox();
            this.txt_confirmp = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_passw = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_usern = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_cross = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS UI Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkViolet;
            this.label6.Location = new System.Drawing.Point(374, 424);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 17);
            this.label6.TabIndex = 23;
            this.label6.Text = "Back To Login";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS UI Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gray;
            this.label5.Location = new System.Drawing.Point(331, 395);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(215, 17);
            this.label5.TabIndex = 22;
            this.label5.Text = "Already Have an Account";
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.Color.DarkViolet;
            this.btn_clear.FlatAppearance.BorderSize = 0;
            this.btn_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clear.Font = new System.Drawing.Font("MS UI Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.ForeColor = System.Drawing.Color.White;
            this.btn_clear.Location = new System.Drawing.Point(295, 350);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(286, 31);
            this.btn_clear.TabIndex = 21;
            this.btn_clear.Text = "CLEAR";
            this.btn_clear.UseVisualStyleBackColor = false;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_register
            // 
            this.btn_register.BackColor = System.Drawing.Color.DarkViolet;
            this.btn_register.FlatAppearance.BorderSize = 0;
            this.btn_register.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_register.Font = new System.Drawing.Font("MS UI Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_register.ForeColor = System.Drawing.Color.White;
            this.btn_register.Location = new System.Drawing.Point(295, 298);
            this.btn_register.Name = "btn_register";
            this.btn_register.Size = new System.Drawing.Size(286, 31);
            this.btn_register.TabIndex = 20;
            this.btn_register.Text = "REGISTER";
            this.btn_register.UseVisualStyleBackColor = false;
            this.btn_register.Click += new System.EventHandler(this.btn_register_Click);
            // 
            // check_passw
            // 
            this.check_passw.AutoSize = true;
            this.check_passw.Font = new System.Drawing.Font("MS UI Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.check_passw.ForeColor = System.Drawing.Color.Gray;
            this.check_passw.Location = new System.Drawing.Point(426, 265);
            this.check_passw.Name = "check_passw";
            this.check_passw.Size = new System.Drawing.Size(155, 21);
            this.check_passw.TabIndex = 19;
            this.check_passw.Text = "Show Password";
            this.check_passw.UseVisualStyleBackColor = true;
            this.check_passw.CheckedChanged += new System.EventHandler(this.check_passw_CheckedChanged);
            // 
            // txt_confirmp
            // 
            this.txt_confirmp.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_confirmp.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_confirmp.Location = new System.Drawing.Point(295, 231);
            this.txt_confirmp.Name = "txt_confirmp";
            this.txt_confirmp.PasswordChar = '*';
            this.txt_confirmp.Size = new System.Drawing.Size(286, 30);
            this.txt_confirmp.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(292, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 17);
            this.label4.TabIndex = 17;
            this.label4.Text = "Confirm Password";
            // 
            // txt_passw
            // 
            this.txt_passw.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_passw.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_passw.Location = new System.Drawing.Point(295, 161);
            this.txt_passw.Name = "txt_passw";
            this.txt_passw.PasswordChar = '*';
            this.txt_passw.Size = new System.Drawing.Size(286, 30);
            this.txt_passw.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(292, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "Password";
            // 
            // txt_usern
            // 
            this.txt_usern.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_usern.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_usern.Location = new System.Drawing.Point(295, 91);
            this.txt_usern.Name = "txt_usern";
            this.txt_usern.Size = new System.Drawing.Size(286, 30);
            this.txt_usern.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(292, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Username";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkViolet;
            this.label1.Location = new System.Drawing.Point(289, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 33);
            this.label1.TabIndex = 12;
            this.label1.Text = "Get Started";
            // 
            // btn_cross
            // 
            this.btn_cross.BackColor = System.Drawing.Color.DarkViolet;
            this.btn_cross.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_cross.BackgroundImage")));
            this.btn_cross.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_cross.FlatAppearance.BorderSize = 0;
            this.btn_cross.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cross.ForeColor = System.Drawing.Color.Black;
            this.btn_cross.Location = new System.Drawing.Point(836, 0);
            this.btn_cross.Name = "btn_cross";
            this.btn_cross.Size = new System.Drawing.Size(36, 31);
            this.btn_cross.TabIndex = 37;
            this.btn_cross.UseVisualStyleBackColor = false;
            this.btn_cross.Click += new System.EventHandler(this.btn_cross_Click);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(871, 463);
            this.Controls.Add(this.btn_cross);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_register);
            this.Controls.Add(this.check_passw);
            this.Controls.Add(this.txt_confirmp);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_passw);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_usern);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.Load += new System.EventHandler(this.Register_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_register;
        private System.Windows.Forms.CheckBox check_passw;
        private System.Windows.Forms.TextBox txt_confirmp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_passw;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_usern;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_cross;
    }
}