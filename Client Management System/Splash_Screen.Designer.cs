namespace Client_Management_System
{
    partial class Splash_Screen
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Splash_Screen));
            this.panel_l = new System.Windows.Forms.Panel();
            this.loading_p = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.loading_t = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.panel_l.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_l
            // 
            this.panel_l.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel_l.Controls.Add(this.loading_p);
            this.panel_l.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_l.Location = new System.Drawing.Point(0, 452);
            this.panel_l.Name = "panel_l";
            this.panel_l.Size = new System.Drawing.Size(871, 11);
            this.panel_l.TabIndex = 0;
            this.panel_l.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_l_Paint);
            // 
            // loading_p
            // 
            this.loading_p.BackColor = System.Drawing.Color.White;
            this.loading_p.Location = new System.Drawing.Point(0, 1);
            this.loading_p.Name = "loading_p";
            this.loading_p.Size = new System.Drawing.Size(78, 10);
            this.loading_p.TabIndex = 1;
            this.loading_p.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 431);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Loading...";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // loading_t
            // 
            this.loading_t.Enabled = true;
            this.loading_t.Interval = 10;
            this.loading_t.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(201, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(503, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "Customer Details Management System";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Splash_Screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(871, 463);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel_l);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Splash_Screen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Splash_Screen";
            this.Load += new System.EventHandler(this.Splash_Screen_Load);
            this.panel_l.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_l;
        private System.Windows.Forms.Panel loading_p;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer loading_t;
        private System.Windows.Forms.Label label2;
    }
}