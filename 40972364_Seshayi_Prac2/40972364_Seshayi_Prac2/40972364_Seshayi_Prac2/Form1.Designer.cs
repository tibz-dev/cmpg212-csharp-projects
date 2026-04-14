
namespace _40972364_Seshayi_Prac2
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
            this.dataGV = new System.Windows.Forms.DataGridView();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnShowAllData = new System.Windows.Forms.Button();
            this.btnMealAndPriceOnly = new System.Windows.Forms.Button();
            this.btnMealsWithCheaps = new System.Windows.Forms.Button();
            this.btnMealCostMoreThan150 = new System.Windows.Forms.Button();
            this.btnSortLowestToLargest = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGV)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGV
            // 
            this.dataGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGV.Location = new System.Drawing.Point(12, 12);
            this.dataGV.Name = "dataGV";
            this.dataGV.Size = new System.Drawing.Size(531, 426);
            this.dataGV.TabIndex = 0;
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(596, 12);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(111, 51);
            this.btnConnect.TabIndex = 1;
            this.btnConnect.Text = "ConnectDB / Clear";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnShowAllData
            // 
            this.btnShowAllData.Location = new System.Drawing.Point(596, 69);
            this.btnShowAllData.Name = "btnShowAllData";
            this.btnShowAllData.Size = new System.Drawing.Size(111, 51);
            this.btnShowAllData.TabIndex = 2;
            this.btnShowAllData.Text = "Show All Data";
            this.btnShowAllData.UseVisualStyleBackColor = true;
            this.btnShowAllData.Click += new System.EventHandler(this.btnShowAllData_Click);
            // 
            // btnMealAndPriceOnly
            // 
            this.btnMealAndPriceOnly.Location = new System.Drawing.Point(596, 136);
            this.btnMealAndPriceOnly.Name = "btnMealAndPriceOnly";
            this.btnMealAndPriceOnly.Size = new System.Drawing.Size(111, 51);
            this.btnMealAndPriceOnly.TabIndex = 3;
            this.btnMealAndPriceOnly.Text = "Meal And Price Only";
            this.btnMealAndPriceOnly.UseVisualStyleBackColor = true;
            this.btnMealAndPriceOnly.Click += new System.EventHandler(this.btnMealAndPriceOnly_Click);
            // 
            // btnMealsWithCheaps
            // 
            this.btnMealsWithCheaps.Location = new System.Drawing.Point(596, 205);
            this.btnMealsWithCheaps.Name = "btnMealsWithCheaps";
            this.btnMealsWithCheaps.Size = new System.Drawing.Size(111, 51);
            this.btnMealsWithCheaps.TabIndex = 4;
            this.btnMealsWithCheaps.Text = "Meals With Chips Only";
            this.btnMealsWithCheaps.UseVisualStyleBackColor = true;
            this.btnMealsWithCheaps.Click += new System.EventHandler(this.btnMealsWithCheaps_Click);
            // 
            // btnMealCostMoreThan150
            // 
            this.btnMealCostMoreThan150.Location = new System.Drawing.Point(596, 273);
            this.btnMealCostMoreThan150.Name = "btnMealCostMoreThan150";
            this.btnMealCostMoreThan150.Size = new System.Drawing.Size(111, 51);
            this.btnMealCostMoreThan150.TabIndex = 5;
            this.btnMealCostMoreThan150.Text = "Meals With Cost More Than 150";
            this.btnMealCostMoreThan150.UseVisualStyleBackColor = true;
            this.btnMealCostMoreThan150.Click += new System.EventHandler(this.btnMealCostMoreThan150_Click);
            // 
            // btnSortLowestToLargest
            // 
            this.btnSortLowestToLargest.Location = new System.Drawing.Point(596, 330);
            this.btnSortLowestToLargest.Name = "btnSortLowestToLargest";
            this.btnSortLowestToLargest.Size = new System.Drawing.Size(111, 51);
            this.btnSortLowestToLargest.TabIndex = 6;
            this.btnSortLowestToLargest.Text = "Sort By Price Lowest To Largest";
            this.btnSortLowestToLargest.UseVisualStyleBackColor = true;
            this.btnSortLowestToLargest.Click += new System.EventHandler(this.btnSortLowestToLargest_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(596, 387);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(111, 51);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSortLowestToLargest);
            this.Controls.Add(this.btnMealCostMoreThan150);
            this.Controls.Add(this.btnMealsWithCheaps);
            this.Controls.Add(this.btnMealAndPriceOnly);
            this.Controls.Add(this.btnShowAllData);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.dataGV);
            this.Name = "Form1";
            this.Text = " Bone’s_Kos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGV;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnShowAllData;
        private System.Windows.Forms.Button btnMealAndPriceOnly;
        private System.Windows.Forms.Button btnMealsWithCheaps;
        private System.Windows.Forms.Button btnMealCostMoreThan150;
        private System.Windows.Forms.Button btnSortLowestToLargest;
        private System.Windows.Forms.Button btnExit;
    }
}

