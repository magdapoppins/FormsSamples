using System;
using System.Windows.Forms;

namespace Multiple_Document_Interface
{
    public partial class MainForm : Form
    {
        private int _counter = 0; 

        public MainForm()
        {
            InitializeComponent();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var child = new ChildForm();
            child.MdiParent = this;
            _counter += 1;
            child.Text = "Edit me #" + _counter;
            child.Show();
        }

        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void verticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void horizintalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
            {
                ChildForm child = (ChildForm)(this.ActiveMdiChild);
                child.EditTB.Undo();
            }
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
            {
                ChildForm child = (ChildForm)(this.ActiveMdiChild);
                child.EditTB.Redo();
            }
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
            {
                ChildForm child = (ChildForm)(this.ActiveMdiChild);
                child.EditTB.Cut();
            }
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
            {
                ChildForm child = (ChildForm)(this.ActiveMdiChild);
                child.EditTB.Copy();
            }
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
            {
                ChildForm child = (ChildForm)(this.ActiveMdiChild);
                child.EditTB.Paste();
            }
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
            {
                ChildForm child = (ChildForm)(this.ActiveMdiChild);
                child.EditTB.SelectAll();
            }
        }

        private void CloseToolstripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
            {
                this.ActiveMdiChild.Close();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
            {
                ChildForm child = (ChildForm)(this.ActiveMdiChild);
                var dialog = new SaveFileDialog();
                dialog.Filter = "Ritch text file |*.rtf";
                dialog.AddExtension = true;
                var result = dialog.ShowDialog();
                if (result == DialogResult.OK)
                {
                    child.EditTB.SaveFile(dialog.FileName);
                    child.Text = dialog.FileName;
                }
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog();
            dialog.Filter = "Ritch text file |*.rtf";
            var result = dialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                var child = new ChildForm();
                child.EditTB.LoadFile(dialog.FileName);
                child.Text = dialog.FileName;
                child.MdiParent = this;
                child.Show();
            }
        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            newToolStripMenuItem_Click(sender, e);
        }
    }
}
