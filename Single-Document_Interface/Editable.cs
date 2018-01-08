using System;
using System.Windows.Forms;

namespace Single_Document_Interface
{
    public partial class Editable : Form
    {
        public Editable()
        {
            InitializeComponent();
        }

        private static int _counter = 0;

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog();
            dialog.Filter = "Ritch text file |*.rtf";
            var result = dialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                this.editableTextBox.LoadFile(dialog.FileName);
                this.Text = dialog.FileName;
            }
        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            CreateEditable();
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.editableTextBox.Undo();
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.editableTextBox.Redo();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.editableTextBox.Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.editableTextBox.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.editableTextBox.Paste();
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.editableTextBox.SelectAll();
        }

        private void CloseToolstripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
                var dialog = new SaveFileDialog();
                dialog.Filter = "Ritch text file |*.rtf";
                dialog.AddExtension = true;
                var result = dialog.ShowDialog();
                if (result == DialogResult.OK)
                {
                    this.editableTextBox.SaveFile(dialog.FileName);
                    this.editableTextBox.Text = dialog.FileName;
                }
        }

        public static Editable CreateEditable()
        {
            var editable = new Editable();
            editable.Text = "I am nr." + ++_counter;
            SDIApp.Instance.ApplicationContext.MainForm = editable;
            editable.Show();

            return editable;
        }

        private void arrangeToolStripMenuItem_DropDownOpening(object sender, EventArgs e)
        {
            if (arrangeToolStripMenuItem.DropDownItems.Count > 0)
            {
                arrangeToolStripMenuItem.DropDown.Dispose();
            }
            arrangeToolStripMenuItem.DropDown = new ToolStripDropDown();
            foreach (Form form in Application.OpenForms)
            {
                ToolStripMenuItem child = new ToolStripMenuItem();
                child.Text = form.Text;
                child.Tag = form;
                arrangeToolStripMenuItem.DropDownItems.Add(child);
            }

        }

        private void arrangeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var menuitem = (ToolStripMenuItem)(sender);
            var form = (Form)(menuitem.Tag);
            //form.Activate();
        }
    }
}
