namespace Inventory
{
    partial class NewInventoryItemForm
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnSaveItem = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblItemNum = new System.Windows.Forms.Label();
            this.lblDsrptn = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(218, 86);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(230, 26);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(218, 149);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(230, 26);
            this.textBox2.TabIndex = 1;
            // 
            // btnSaveItem
            // 
            this.btnSaveItem.Location = new System.Drawing.Point(95, 298);
            this.btnSaveItem.Name = "btnSaveItem";
            this.btnSaveItem.Size = new System.Drawing.Size(114, 45);
            this.btnSaveItem.TabIndex = 3;
            this.btnSaveItem.Text = "&Save Item";
            this.btnSaveItem.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(296, 298);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(114, 45);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // lblItemNum
            // 
            this.lblItemNum.AutoSize = true;
            this.lblItemNum.Location = new System.Drawing.Point(86, 89);
            this.lblItemNum.Name = "lblItemNum";
            this.lblItemNum.Size = new System.Drawing.Size(69, 20);
            this.lblItemNum.TabIndex = 5;
            this.lblItemNum.Text = "Item no:";
            // 
            // lblDsrptn
            // 
            this.lblDsrptn.AutoSize = true;
            this.lblDsrptn.Location = new System.Drawing.Point(86, 152);
            this.lblDsrptn.Name = "lblDsrptn";
            this.lblDsrptn.Size = new System.Drawing.Size(100, 20);
            this.lblDsrptn.TabIndex = 6;
            this.lblDsrptn.Text = "Description:";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(86, 215);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(53, 20);
            this.lblPrice.TabIndex = 7;
            this.lblPrice.Text = "Price:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.DecimalPlaces = 2;
            this.numericUpDown1.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.numericUpDown1.Location = new System.Drawing.Point(218, 213);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(161, 26);
            this.numericUpDown1.TabIndex = 8;
            // 
            // NewInventoryItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 407);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblDsrptn);
            this.Controls.Add(this.lblItemNum);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSaveItem);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "NewInventoryItemForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "New Inventory Item";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnSaveItem;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblItemNum;
        private System.Windows.Forms.Label lblDsrptn;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}