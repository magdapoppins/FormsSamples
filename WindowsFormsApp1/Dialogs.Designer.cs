namespace WindowsFormsSamples
{
    partial class Dialogs
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
            this.SelectButton = new System.Windows.Forms.Button();
            this.SelectedLabel = new System.Windows.Forms.Label();
            this.FruitsListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // SelectButton
            // 
            this.SelectButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SelectButton.Location = new System.Drawing.Point(12, 240);
            this.SelectButton.Name = "SelectButton";
            this.SelectButton.Size = new System.Drawing.Size(319, 23);
            this.SelectButton.TabIndex = 0;
            this.SelectButton.Text = "Select one!";
            this.SelectButton.UseVisualStyleBackColor = true;
            this.SelectButton.Click += new System.EventHandler(this.SelectButton_Click);
            // 
            // SelectedLabel
            // 
            this.SelectedLabel.Location = new System.Drawing.Point(12, 277);
            this.SelectedLabel.Name = "SelectedLabel";
            this.SelectedLabel.Size = new System.Drawing.Size(319, 20);
            this.SelectedLabel.TabIndex = 1;
            this.SelectedLabel.Text = "[selected]";
            // 
            // FruitsListBox
            // 
            this.FruitsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FruitsListBox.FormattingEnabled = true;
            this.FruitsListBox.Location = new System.Drawing.Point(12, 13);
            this.FruitsListBox.Name = "FruitsListBox";
            this.FruitsListBox.Size = new System.Drawing.Size(319, 199);
            this.FruitsListBox.TabIndex = 2;
            // 
            // Dialogs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 311);
            this.Controls.Add(this.FruitsListBox);
            this.Controls.Add(this.SelectedLabel);
            this.Controls.Add(this.SelectButton);
            this.Name = "Dialogs";
            this.Text = "Dialogs";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SelectButton;
        private System.Windows.Forms.Label SelectedLabel;
        private System.Windows.Forms.ListBox FruitsListBox;
    }
}

