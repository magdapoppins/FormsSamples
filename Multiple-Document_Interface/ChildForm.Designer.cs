namespace Multiple_Document_Interface
{
    partial class ChildForm
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
            this.EditTB = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // EditTB
            // 
            this.EditTB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EditTB.Location = new System.Drawing.Point(0, 0);
            this.EditTB.Name = "EditTB";
            this.EditTB.Size = new System.Drawing.Size(422, 381);
            this.EditTB.TabIndex = 0;
            this.EditTB.Text = "";
            // 
            // ChildForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 381);
            this.Controls.Add(this.EditTB);
            this.Name = "ChildForm";
            this.Text = "Edit in me!";
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.RichTextBox EditTB;
    }
}