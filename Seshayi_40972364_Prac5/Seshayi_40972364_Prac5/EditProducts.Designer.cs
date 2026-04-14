namespace Seshayi_40972364_Prac5
{
    partial class EditProducts
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
            this.tab = new System.Windows.Forms.TabControl();
            this.tabAdd = new System.Windows.Forms.TabPage();
            this.btnInsert = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtBPrice = new System.Windows.Forms.TextBox();
            this.txtBcategory = new System.Windows.Forms.TextBox();
            this.txtBName = new System.Windows.Forms.TextBox();
            this.txtBID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabDelete = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnDelAll = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.btnDelCategory = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDelID = new System.Windows.Forms.Button();
            this.txtBDelID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tab.SuspendLayout();
            this.tabAdd.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabDelete.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab
            // 
            this.tab.Controls.Add(this.tabAdd);
            this.tab.Controls.Add(this.tabDelete);
            this.tab.Location = new System.Drawing.Point(16, 15);
            this.tab.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tab.Name = "tab";
            this.tab.SelectedIndex = 0;
            this.tab.Size = new System.Drawing.Size(1701, 907);
            this.tab.TabIndex = 1;
            this.tab.Tag = "";
            // 
            // tabAdd
            // 
            this.tabAdd.Controls.Add(this.btnInsert);
            this.tabAdd.Controls.Add(this.groupBox2);
            this.tabAdd.Location = new System.Drawing.Point(4, 25);
            this.tabAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabAdd.Name = "tabAdd";
            this.tabAdd.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabAdd.Size = new System.Drawing.Size(1693, 878);
            this.tabAdd.TabIndex = 0;
            this.tabAdd.Text = "Add new Product";
            this.tabAdd.UseVisualStyleBackColor = true;
            // 
            // btnInsert
            // 
            this.btnInsert.BackColor = System.Drawing.Color.LightGray;
            this.btnInsert.Location = new System.Drawing.Point(964, 631);
            this.btnInsert.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(265, 80);
            this.btnInsert.TabIndex = 1;
            this.btnInsert.Text = "Insert Product";
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtBPrice);
            this.groupBox2.Controls.Add(this.txtBcategory);
            this.groupBox2.Controls.Add(this.txtBName);
            this.groupBox2.Controls.Add(this.txtBID);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(32, 71);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(764, 495);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Product Details";
            // 
            // txtBPrice
            // 
            this.txtBPrice.Location = new System.Drawing.Point(247, 347);
            this.txtBPrice.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBPrice.Name = "txtBPrice";
            this.txtBPrice.Size = new System.Drawing.Size(389, 22);
            this.txtBPrice.TabIndex = 7;
            // 
            // txtBcategory
            // 
            this.txtBcategory.Location = new System.Drawing.Point(247, 249);
            this.txtBcategory.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBcategory.Name = "txtBcategory";
            this.txtBcategory.Size = new System.Drawing.Size(389, 22);
            this.txtBcategory.TabIndex = 6;
            // 
            // txtBName
            // 
            this.txtBName.Location = new System.Drawing.Point(247, 153);
            this.txtBName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBName.Name = "txtBName";
            this.txtBName.Size = new System.Drawing.Size(389, 22);
            this.txtBName.TabIndex = 5;
            // 
            // txtBID
            // 
            this.txtBID.Location = new System.Drawing.Point(247, 57);
            this.txtBID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBID.Name = "txtBID";
            this.txtBID.Size = new System.Drawing.Size(389, 22);
            this.txtBID.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 347);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Product Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 252);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Product Category";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 161);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Product Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 66);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Product ID";
            // 
            // tabDelete
            // 
            this.tabDelete.Controls.Add(this.groupBox4);
            this.tabDelete.Controls.Add(this.groupBox3);
            this.tabDelete.Controls.Add(this.groupBox1);
            this.tabDelete.Location = new System.Drawing.Point(4, 25);
            this.tabDelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabDelete.Name = "tabDelete";
            this.tabDelete.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabDelete.Size = new System.Drawing.Size(1693, 878);
            this.tabDelete.TabIndex = 1;
            this.tabDelete.Text = "Delete Product";
            this.tabDelete.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnDelAll);
            this.groupBox4.Location = new System.Drawing.Point(1151, 297);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox4.Size = new System.Drawing.Size(467, 299);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Delete All";
            // 
            // btnDelAll
            // 
            this.btnDelAll.BackColor = System.Drawing.Color.Red;
            this.btnDelAll.Location = new System.Drawing.Point(124, 110);
            this.btnDelAll.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDelAll.Name = "btnDelAll";
            this.btnDelAll.Size = new System.Drawing.Size(240, 95);
            this.btnDelAll.TabIndex = 3;
            this.btnDelAll.Text = "Delete All Products";
            this.btnDelAll.UseVisualStyleBackColor = false;
            this.btnDelAll.Click += new System.EventHandler(this.btnDelAll_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.comboBox2);
            this.groupBox3.Controls.Add(this.btnDelCategory);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(611, 297);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Size = new System.Drawing.Size(467, 299);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Delete Product by Category";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Books",
            "Pens",
            "Pencils",
            "Calculators"});
            this.comboBox2.Location = new System.Drawing.Point(77, 87);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(332, 24);
            this.comboBox2.TabIndex = 4;
            this.comboBox2.Text = "Select Cartegory";
            // 
            // btnDelCategory
            // 
            this.btnDelCategory.BackColor = System.Drawing.Color.IndianRed;
            this.btnDelCategory.Location = new System.Drawing.Point(148, 182);
            this.btnDelCategory.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDelCategory.Name = "btnDelCategory";
            this.btnDelCategory.Size = new System.Drawing.Size(193, 50);
            this.btnDelCategory.TabIndex = 3;
            this.btnDelCategory.Text = "Delete Category";
            this.btnDelCategory.UseVisualStyleBackColor = false;
            this.btnDelCategory.Click += new System.EventHandler(this.btnDelCategory_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 98);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 16);
            this.label6.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDelID);
            this.groupBox1.Controls.Add(this.txtBDelID);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(63, 297);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(467, 299);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Delete Product by ID";
            // 
            // btnDelID
            // 
            this.btnDelID.BackColor = System.Drawing.Color.IndianRed;
            this.btnDelID.Location = new System.Drawing.Point(133, 182);
            this.btnDelID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDelID.Name = "btnDelID";
            this.btnDelID.Size = new System.Drawing.Size(193, 50);
            this.btnDelID.TabIndex = 2;
            this.btnDelID.Text = "Delete Product";
            this.btnDelID.UseVisualStyleBackColor = false;
            this.btnDelID.Click += new System.EventHandler(this.btnDelID_Click);
            // 
            // txtBDelID
            // 
            this.txtBDelID.Location = new System.Drawing.Point(177, 89);
            this.txtBDelID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBDelID.Name = "txtBDelID";
            this.txtBDelID.Size = new System.Drawing.Size(261, 22);
            this.txtBDelID.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 98);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Enter Product ID";
            // 
            // EditProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1685, 923);
            this.Controls.Add(this.tab);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "EditProducts";
            this.Text = "EditProducts";
            this.Load += new System.EventHandler(this.EditProducts_Load);
            this.tab.ResumeLayout(false);
            this.tabAdd.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabDelete.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tab;
        private System.Windows.Forms.TabPage tabAdd;
        private System.Windows.Forms.TabPage tabDelete;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.TextBox txtBPrice;
        private System.Windows.Forms.TextBox txtBcategory;
        private System.Windows.Forms.TextBox txtBName;
        private System.Windows.Forms.TextBox txtBID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDelAll;
        private System.Windows.Forms.Button btnDelCategory;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnDelID;
        private System.Windows.Forms.TextBox txtBDelID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox2;
    }
}