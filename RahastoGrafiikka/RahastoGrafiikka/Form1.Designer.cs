namespace RahastoGrafiikka
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
            this.RahastotDG = new System.Windows.Forms.DataGridView();
            this.LataaPainike = new System.Windows.Forms.Button();
            this.tulosTaulu = new LiveCharts.WinForms.CartesianChart();
            ((System.ComponentModel.ISupportInitialize)(this.RahastotDG)).BeginInit();
            this.SuspendLayout();
            // 
            // RahastotDG
            // 
            this.RahastotDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RahastotDG.Location = new System.Drawing.Point(13, 277);
            this.RahastotDG.Name = "RahastotDG";
            this.RahastotDG.Size = new System.Drawing.Size(635, 150);
            this.RahastotDG.TabIndex = 1;
            this.RahastotDG.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // LataaPainike
            // 
            this.LataaPainike.Location = new System.Drawing.Point(666, 403);
            this.LataaPainike.Name = "LataaPainike";
            this.LataaPainike.Size = new System.Drawing.Size(75, 23);
            this.LataaPainike.TabIndex = 2;
            this.LataaPainike.Text = "Lataa";
            this.LataaPainike.UseVisualStyleBackColor = true;
            this.LataaPainike.Click += new System.EventHandler(this.LataaPainike_Click);
            // 
            // tulosTaulu
            // 
            this.tulosTaulu.Location = new System.Drawing.Point(13, 12);
            this.tulosTaulu.Name = "tulosTaulu";
            this.tulosTaulu.Size = new System.Drawing.Size(775, 259);
            this.tulosTaulu.TabIndex = 3;
            this.tulosTaulu.Text = "cartesianChart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tulosTaulu);
            this.Controls.Add(this.LataaPainike);
            this.Controls.Add(this.RahastotDG);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RahastotDG)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView RahastotDG;
        private System.Windows.Forms.Button LataaPainike;
        private LiveCharts.WinForms.CartesianChart tulosTaulu;
    }
}

