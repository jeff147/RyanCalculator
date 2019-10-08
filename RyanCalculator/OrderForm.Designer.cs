namespace RyanCalculator
{
    partial class OrderForm
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
            this.lblStitchCount = new System.Windows.Forms.Label();
            this.txtStitchCount = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.txtNumColors = new System.Windows.Forms.TextBox();
            this.lblNumColors = new System.Windows.Forms.Label();
            this.txtNumPlacements = new System.Windows.Forms.TextBox();
            this.lblNumPlacements = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblStitchCount
            // 
            this.lblStitchCount.AutoSize = true;
            this.lblStitchCount.Location = new System.Drawing.Point(47, 54);
            this.lblStitchCount.Name = "lblStitchCount";
            this.lblStitchCount.Size = new System.Drawing.Size(65, 13);
            this.lblStitchCount.TabIndex = 0;
            this.lblStitchCount.Text = "Stitch Count";
            // 
            // txtStitchCount
            // 
            this.txtStitchCount.Location = new System.Drawing.Point(50, 70);
            this.txtStitchCount.Name = "txtStitchCount";
            this.txtStitchCount.Size = new System.Drawing.Size(100, 20);
            this.txtStitchCount.TabIndex = 1;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(194, 70);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(100, 20);
            this.txtQuantity.TabIndex = 3;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(191, 54);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(46, 13);
            this.lblQuantity.TabIndex = 2;
            this.lblQuantity.Text = "Quantity";
            // 
            // txtNumColors
            // 
            this.txtNumColors.Location = new System.Drawing.Point(339, 70);
            this.txtNumColors.Name = "txtNumColors";
            this.txtNumColors.Size = new System.Drawing.Size(100, 20);
            this.txtNumColors.TabIndex = 5;
            // 
            // lblNumColors
            // 
            this.lblNumColors.AutoSize = true;
            this.lblNumColors.Location = new System.Drawing.Point(336, 54);
            this.lblNumColors.Name = "lblNumColors";
            this.lblNumColors.Size = new System.Drawing.Size(88, 13);
            this.lblNumColors.TabIndex = 4;
            this.lblNumColors.Text = "Number of Colors";
            // 
            // txtNumPlacements
            // 
            this.txtNumPlacements.Location = new System.Drawing.Point(482, 70);
            this.txtNumPlacements.Name = "txtNumPlacements";
            this.txtNumPlacements.Size = new System.Drawing.Size(100, 20);
            this.txtNumPlacements.TabIndex = 7;
            // 
            // lblNumPlacements
            // 
            this.lblNumPlacements.AutoSize = true;
            this.lblNumPlacements.Location = new System.Drawing.Point(479, 54);
            this.lblNumPlacements.Name = "lblNumPlacements";
            this.lblNumPlacements.Size = new System.Drawing.Size(114, 13);
            this.lblNumPlacements.TabIndex = 6;
            this.lblNumPlacements.Text = "Number of Placements";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(630, 66);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 8;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(630, 95);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(100, 20);
            this.txtResult.TabIndex = 9;
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtNumPlacements);
            this.Controls.Add(this.lblNumPlacements);
            this.Controls.Add(this.txtNumColors);
            this.Controls.Add(this.lblNumColors);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.txtStitchCount);
            this.Controls.Add(this.lblStitchCount);
            this.Name = "OrderForm";
            this.Text = "Order Calculator";
            this.Load += new System.EventHandler(this.OrderForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStitchCount;
        private System.Windows.Forms.TextBox txtStitchCount;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.TextBox txtNumColors;
        private System.Windows.Forms.Label lblNumColors;
        private System.Windows.Forms.TextBox txtNumPlacements;
        private System.Windows.Forms.Label lblNumPlacements;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox txtResult;
    }
}

