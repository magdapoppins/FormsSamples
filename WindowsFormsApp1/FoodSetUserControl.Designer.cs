namespace WindowsFormsApp1
{
    partial class FoodSetUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.starterTextBox = new System.Windows.Forms.TextBox();
            this.mainTextBox = new System.Windows.Forms.TextBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.dessertCheckBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // starterTextBox
            // 
            this.starterTextBox.Location = new System.Drawing.Point(125, 24);
            this.starterTextBox.Name = "starterTextBox";
            this.starterTextBox.Size = new System.Drawing.Size(100, 20);
            this.starterTextBox.TabIndex = 0;
            // 
            // mainTextBox
            // 
            this.mainTextBox.Location = new System.Drawing.Point(125, 49);
            this.mainTextBox.Name = "mainTextBox";
            this.mainTextBox.Size = new System.Drawing.Size(100, 20);
            this.mainTextBox.TabIndex = 1;
            // 
            // priceTextBox
            // 
            this.priceTextBox.Location = new System.Drawing.Point(125, 73);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(100, 20);
            this.priceTextBox.TabIndex = 2;
            // 
            // dessertCheckBox
            // 
            this.dessertCheckBox.AutoSize = true;
            this.dessertCheckBox.Location = new System.Drawing.Point(27, 106);
            this.dessertCheckBox.Name = "dessertCheckBox";
            this.dessertCheckBox.Size = new System.Drawing.Size(62, 17);
            this.dessertCheckBox.TabIndex = 3;
            this.dessertCheckBox.Text = "Dessert";
            this.dessertCheckBox.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Starter";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Main Course";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Price";
            // 
            // FoodSetUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dessertCheckBox);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(this.mainTextBox);
            this.Controls.Add(this.starterTextBox);
            this.Name = "FoodSetUserControl";
            this.Size = new System.Drawing.Size(253, 145);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox starterTextBox;
        private System.Windows.Forms.TextBox mainTextBox;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.CheckBox dessertCheckBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}
