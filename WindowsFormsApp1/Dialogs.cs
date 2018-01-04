using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsSamples
{
    public partial class Dialogs : Form
    {
        public Dialogs()
        {
            InitializeComponent();

            FruitsListBox.Items.Add("Grapes");
            FruitsListBox.Items.Add("Bananas");
            FruitsListBox.Items.Add("Apples");
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            var customDialog = new CustomDialog();
            DialogResult dialogResult = customDialog.ShowDialog();
            if (dialogResult == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void SelectButton_Click(object sender, EventArgs e)
        {
            if (FruitsListBox.SelectedIndex == -1)
            {
                bool doIt = false;
                while (!doIt)
                {
                    DialogResult dialogResult = MessageBox.Show("You have to select an item!", "You should select one.", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.No)
                    {
                        MessageBox.Show("No!");
                    }
                    else
                    {
                        doIt = true;
                    }
                }
            }
            else
            {
                SelectedLabel.Text = FruitsListBox.SelectedItem.ToString();
            }
        }
    }
}
