using System;
using System.Windows.Forms;

namespace WindowsFormsSamples
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Set the form that you want to run as the start-up form from here! Remember to instantiate it.
            Application.Run(new MenusAndToolbars());
        }
    }
}
