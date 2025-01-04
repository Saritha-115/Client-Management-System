namespace Client_Management_System
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_home = new System.Windows.Forms.Button();
            this.p_slide = new System.Windows.Forms.Panel();
            this.btn_cross = new System.Windows.Forms.Button();
            this.label_dash = new System.Windows.Forms.Label();
            this.btn_report = new System.Windows.Forms.Button();
            this.btn_editdlt = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.panel_f = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btn_home);
            this.panel1.Controls.Add(this.p_slide);
            this.panel1.Controls.Add(this.btn_cross);
            this.panel1.Controls.Add(this.label_dash);
            this.panel1.Controls.Add(this.btn_report);
            this.panel1.Controls.Add(this.btn_editdlt);
            this.panel1.Controls.Add(this.btn_add);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(871, 38);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkViolet;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(703, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 23);
            this.button1.TabIndex = 38;
            this.button1.Text = "Logout";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_home
            // 
            this.btn_home.BackColor = System.Drawing.Color.DarkViolet;
            this.btn_home.FlatAppearance.BorderSize = 0;
            this.btn_home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_home.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_home.ForeColor = System.Drawing.Color.White;
            this.btn_home.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_home.Location = new System.Drawing.Point(307, 3);
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(96, 23);
            this.btn_home.TabIndex = 3;
            this.btn_home.Text = "Home";
            this.btn_home.UseVisualStyleBackColor = false;
            this.btn_home.Click += new System.EventHandler(this.button3_Click);
            // 
            // p_slide
            // 
            this.p_slide.BackColor = System.Drawing.Color.Gray;
            this.p_slide.Location = new System.Drawing.Point(307, 28);
            this.p_slide.Name = "p_slide";
            this.p_slide.Size = new System.Drawing.Size(96, 10);
            this.p_slide.TabIndex = 1;
            this.p_slide.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // btn_cross
            // 
            this.btn_cross.BackColor = System.Drawing.Color.DarkViolet;
            this.btn_cross.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_cross.BackgroundImage")));
            this.btn_cross.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_cross.FlatAppearance.BorderSize = 0;
            this.btn_cross.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cross.ForeColor = System.Drawing.Color.Black;
            this.btn_cross.Location = new System.Drawing.Point(833, 3);
            this.btn_cross.Name = "btn_cross";
            this.btn_cross.Size = new System.Drawing.Size(36, 31);
            this.btn_cross.TabIndex = 37;
            this.btn_cross.UseVisualStyleBackColor = false;
            this.btn_cross.Click += new System.EventHandler(this.btn_cross_Click);
            // 
            // label_dash
            // 
            this.label_dash.AutoSize = true;
            this.label_dash.BackColor = System.Drawing.Color.DarkViolet;
            this.label_dash.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_dash.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_dash.ForeColor = System.Drawing.Color.White;
            this.label_dash.Location = new System.Drawing.Point(2, 5);
            this.label_dash.Name = "label_dash";
            this.label_dash.Padding = new System.Windows.Forms.Padding(1);
            this.label_dash.Size = new System.Drawing.Size(148, 27);
            this.label_dash.TabIndex = 5;
            this.label_dash.Text = "DASHBOARD";
            this.label_dash.Click += new System.EventHandler(this.label1_Click);
            // 
            // btn_report
            // 
            this.btn_report.BackColor = System.Drawing.Color.DarkViolet;
            this.btn_report.FlatAppearance.BorderSize = 0;
            this.btn_report.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_report.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_report.ForeColor = System.Drawing.Color.White;
            this.btn_report.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_report.Location = new System.Drawing.Point(604, 3);
            this.btn_report.Name = "btn_report";
            this.btn_report.Size = new System.Drawing.Size(96, 23);
            this.btn_report.TabIndex = 4;
            this.btn_report.Text = "Report";
            this.btn_report.UseVisualStyleBackColor = false;
            this.btn_report.Click += new System.EventHandler(this.btn_report_Click);
            // 
            // btn_editdlt
            // 
            this.btn_editdlt.BackColor = System.Drawing.Color.DarkViolet;
            this.btn_editdlt.FlatAppearance.BorderSize = 0;
            this.btn_editdlt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_editdlt.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_editdlt.ForeColor = System.Drawing.Color.White;
            this.btn_editdlt.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_editdlt.Location = new System.Drawing.Point(505, 3);
            this.btn_editdlt.Name = "btn_editdlt";
            this.btn_editdlt.Size = new System.Drawing.Size(96, 23);
            this.btn_editdlt.TabIndex = 2;
            this.btn_editdlt.Text = "Edit/Dlt";
            this.btn_editdlt.UseVisualStyleBackColor = false;
            this.btn_editdlt.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.DarkViolet;
            this.btn_add.FlatAppearance.BorderSize = 0;
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.ForeColor = System.Drawing.Color.White;
            this.btn_add.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_add.Location = new System.Drawing.Point(406, 3);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(96, 23);
            this.btn_add.TabIndex = 1;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // panel_f
            // 
            this.panel_f.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel_f.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_f.Location = new System.Drawing.Point(0, 38);
            this.panel_f.Name = "panel_f";
            this.panel_f.Size = new System.Drawing.Size(871, 425);
            this.panel_f.TabIndex = 1;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(871, 463);
            this.Controls.Add(this.panel_f);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_dash;
        private System.Windows.Forms.Button btn_report;
        private System.Windows.Forms.Button btn_home;
        private System.Windows.Forms.Button btn_editdlt;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_cross;
        private System.Windows.Forms.Panel p_slide;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel_f;
    }
}