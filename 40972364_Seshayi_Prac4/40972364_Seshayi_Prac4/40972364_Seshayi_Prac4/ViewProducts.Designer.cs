namespace _40972364_Seshayi_Prac4
{
    partial class ViewProducts
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
            this.comboBoxSelectBrand = new System.Windows.Forms.ComboBox();
            this.tbProductName = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 123);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(835, 385);
            this.dataGridView1.TabIndex = 0;
            // 
            // comboBoxSelectBrand
            // 
            this.comboBoxSelectBrand.FormattingEnabled = true;
            this.comboBoxSelectBrand.Items.AddRange(new object[] {
            "Adidas",
            "K-Way",
            "Nike"});
            this.comboBoxSelectBrand.Location = new System.Drawing.Point(74, 65);
            this.comboBoxSelectBrand.Name = "comboBoxSelectBrand";
            this.comboBoxSelectBrand.Size = new System.Drawing.Size(218, 24);
            this.comboBoxSelectBrand.TabIndex = 1;
            this.comboBoxSelectBrand.Text = "Select Brand";
            // 
            // tbProductName
            // 
            this.tbProductName.Location = new System.Drawing.Point(352, 64);
            this.tbProductName.Multiline = true;
            this.tbProductName.Name = "tbProductName";
            this.tbProductName.Size = new System.Drawing.Size(180, 24);
            this.tbProductName.TabIndex = 2;
            this.tbProductName.Text = "Type Product Name...";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnSearch.Location = new System.Drawing.Point(564, 65);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(136, 23);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnRefresh.Location = new System.Drawing.Point(717, 66);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(136, 23);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // ViewProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 520);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.tbProductName);
            this.Controls.Add(this.comboBoxSelectBrand);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ViewProducts";
            this.Text = "ViewProducts";
            this.Load += new System.EventHandler(this.ViewProducts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBoxSelectBrand;
        private System.Windows.Forms.TextBox tbProductName;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnRefresh;
    }
}