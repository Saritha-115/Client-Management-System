namespace Client_Management_System
{
    partial class Add
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add));
            this.label1 = new System.Windows.Forms.Label();
            this.txt_cID = new System.Windows.Forms.TextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_cn = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_vehicle_num = new System.Windows.Forms.TextBox();
            this.gdv = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.gdv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(8, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer ID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt_cID
            // 
            this.txt_cID.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_cID.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cID.Location = new System.Drawing.Point(8, 132);
            this.txt_cID.Name = "txt_cID";
            this.txt_cID.Size = new System.Drawing.Size(195, 27);
            this.txt_cID.TabIndex = 1;
            // 
            // txt_email
            // 
            this.txt_email.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_email.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_email.Location = new System.Drawing.Point(8, 291);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(195, 27);
            this.txt_email.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(8, 268);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "E-Mail";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txt_cn
            // 
            this.txt_cn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_cn.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cn.Location = new System.Drawing.Point(8, 344);
            this.txt_cn.Name = "txt_cn";
            this.txt_cn.Size = new System.Drawing.Size(195, 27);
            this.txt_cn.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(8, 321);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Contact number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(8, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Vehicle Number";
            // 
            // txt_vehicle_num
            // 
            this.txt_vehicle_num.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_vehicle_num.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_vehicle_num.Location = new System.Drawing.Point(8, 238);
            this.txt_vehicle_num.Name = "txt_vehicle_num";
            this.txt_vehicle_num.Size = new System.Drawing.Size(195, 27);
            this.txt_vehicle_num.TabIndex = 7;
            // 
            // gdv
            // 
            this.gdv.AllowUserToAddRows = false;
            this.gdv.AllowUserToDeleteRows = false;
            this.gdv.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gdv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.gdv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdv.Dock = System.Windows.Forms.DockStyle.Right;
            this.gdv.Location = new System.Drawing.Point(209, 0);
            this.gdv.Name = "gdv";
            this.gdv.ReadOnly = true;
            this.gdv.RowHeadersWidth = 51;
            this.gdv.RowTemplate.Height = 24;
            this.gdv.Size = new System.Drawing.Size(662, 425);
            this.gdv.TabIndex = 8;
            this.gdv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gdv_CellContentClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkViolet;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(8, 377);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 28);
            this.button1.TabIndex = 9;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkViolet;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(122, 377);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(81, 28);
            this.button2.TabIndex = 10;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txt_Name
            // 
            this.txt_Name.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_Name.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Name.Location = new System.Drawing.Point(8, 185);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(195, 27);
            this.txt_Name.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gray;
            this.label5.Location = new System.Drawing.Point(8, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Name";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(52, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 83);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(871, 425);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txt_Name);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_vehicle_num);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_cn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_cID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gdv);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Add";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add";
            this.Load += new System.EventHandler(this.Add_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gdv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_cID;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_cn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_vehicle_num;
        private System.Windows.Forms.DataGridView gdv;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}