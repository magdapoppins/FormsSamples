using Microsoft.VisualBasic.ApplicationServices;

namespace Single_Document_Interface
{
    public class SDIApp : WindowsFormsApplicationBase
    {
        private static SDIApp _instance = null;

        public SDIApp()
        {
            this.IsSingleInstance = true;
            this.ShutdownStyle = ShutdownMode.AfterAllFormsClose;
        }

        public static SDIApp Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SDIApp();
                }

                return _instance;
            }
        }

        protected override void OnCreateMainForm()
        {
            Editable.CreateEditable();
        }
        protected override void OnStartupNextInstance(StartupNextInstanceEventArgs eventArgs)
        {
            Editable.CreateEditable();
        }
    }
}
