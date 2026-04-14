namespace _40972364_Seshayi_Prac3
{
    partial class frmDVDNew
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnActionMoviesS = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.scrollBar = new System.Windows.Forms.HScrollBar();
            this.lblAge = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(21, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(878, 418);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnActionMoviesS
            // 
            this.btnActionMoviesS.Location = new System.Drawing.Point(21, 475);
            this.btnActionMoviesS.Name = "btnActionMoviesS";
            this.btnActionMoviesS.Size = new System.Drawing.Size(250, 45);
            this.btnActionMoviesS.TabIndex = 1;
            this.btnActionMoviesS.Text = "Action Movies";
            this.btnActionMoviesS.UseVisualStyleBackColor = true;
            this.btnActionMoviesS.Click += new System.EventHandler(this.btnActionMoviesS_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(515, 489);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select your age:";
            // 
            // scrollBar
            // 
            this.scrollBar.Location = new System.Drawing.Point(640, 489);
            this.scrollBar.Name = "scrollBar";
            this.scrollBar.Size = new System.Drawing.Size(259, 21);
            this.scrollBar.TabIndex = 3;
            this.scrollBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.scrollBar_Scroll);
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(724, 510);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(14, 16);
            this.lblAge.TabIndex = 4;
            this.lblAge.Text = "0";
            // 
            // frmDVDNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 568);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.scrollBar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnActionMoviesS);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmDVDNew";
            this.Text = "DVD List";
            this.Load += new System.EventHandler(this.frmDVDNew_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnActionMoviesS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.HScrollBar scrollBar;
        private System.Windows.Forms.Label lblAge;
    }
}