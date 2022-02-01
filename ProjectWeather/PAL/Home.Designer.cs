namespace ProjectWeather.PAL
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnReport = new System.Windows.Forms.Button();
            this.btnFertilizer = new System.Windows.Forms.Button();
            this.btnCrops = new System.Windows.Forms.Button();
            this.btnWeather = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.btnReport);
            this.panel1.Controls.Add(this.btnFertilizer);
            this.panel1.Controls.Add(this.btnCrops);
            this.panel1.Controls.Add(this.btnWeather);
            this.panel1.Location = new System.Drawing.Point(53, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(458, 183);
            this.panel1.TabIndex = 0;
            // 
            // btnReport
            // 
            this.btnReport.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnReport.Font = new System.Drawing.Font("Century Gothic", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReport.ForeColor = System.Drawing.SystemColors.Control;
            this.btnReport.Location = new System.Drawing.Point(262, 95);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(148, 66);
            this.btnReport.TabIndex = 3;
            this.btnReport.Text = "Search Fertilizer";
            this.btnReport.UseVisualStyleBackColor = false;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // btnFertilizer
            // 
            this.btnFertilizer.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnFertilizer.Font = new System.Drawing.Font("Century Gothic", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFertilizer.ForeColor = System.Drawing.SystemColors.Control;
            this.btnFertilizer.Location = new System.Drawing.Point(54, 95);
            this.btnFertilizer.Name = "btnFertilizer";
            this.btnFertilizer.Size = new System.Drawing.Size(148, 66);
            this.btnFertilizer.TabIndex = 3;
            this.btnFertilizer.Text = "Search Insects";
            this.btnFertilizer.UseVisualStyleBackColor = false;
            this.btnFertilizer.Click += new System.EventHandler(this.btnFertilizer_Click);
            // 
            // btnCrops
            // 
            this.btnCrops.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnCrops.Font = new System.Drawing.Font("Century Gothic", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrops.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCrops.Location = new System.Drawing.Point(262, 23);
            this.btnCrops.Name = "btnCrops";
            this.btnCrops.Size = new System.Drawing.Size(148, 66);
            this.btnCrops.TabIndex = 2;
            this.btnCrops.Text = "Add";
            this.btnCrops.UseVisualStyleBackColor = false;
            this.btnCrops.Click += new System.EventHandler(this.btnCrops_Click);
            // 
            // btnWeather
            // 
            this.btnWeather.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnWeather.Font = new System.Drawing.Font("Century Gothic", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWeather.ForeColor = System.Drawing.SystemColors.Control;
            this.btnWeather.Location = new System.Drawing.Point(54, 23);
            this.btnWeather.Name = "btnWeather";
            this.btnWeather.Size = new System.Drawing.Size(148, 66);
            this.btnWeather.TabIndex = 1;
            this.btnWeather.Text = "Water Alert";
            this.btnWeather.UseVisualStyleBackColor = false;
            this.btnWeather.Click += new System.EventHandler(this.btnWeather_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(235, 255);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 37);
            this.button1.TabIndex = 1;
            this.button1.Text = "Logout";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(158, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 33);
            this.label1.TabIndex = 2;
            this.label1.Text = "Agriculture System";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 304);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Button btnFertilizer;
        private System.Windows.Forms.Button btnCrops;
        private System.Windows.Forms.Button btnWeather;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}