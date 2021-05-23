using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sharpRPA
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //exception handler
            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);
            AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(CurrentDomain_UnhandledException);

            //if the exe was passed a filename argument then run the script
            if (args.Length > 0)
            {
                string filePath = args[0];

                if (!System.IO.File.Exists(filePath))
                {
                    using (System.Diagnostics.EventLog eventLog = new System.Diagnostics.EventLog("Application"))
                    {
                        eventLog.Source = "Application";
                        eventLog.WriteEntry("An attempt was made to run a sharpRPA script file from '" + filePath + "' but the file was not found.  Please verify that the file exists at the path indicated.", System.Diagnostics.EventLogEntryType.Error, 101, 1);
                    }
                    //MessageBox.Show("Please pass a valid file as the parameter!", "Invalid File", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Exit();
                    return;
                }

                Application.Run(new UI.Forms.frmScriptEngine(filePath, null));
            }
            else
            {
                Application.Run(new UI.Forms.frmScriptBuilder());
            }
        }

        static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            MessageBox.Show("An unhandled exception occured: " + (e.ExceptionObject as Exception).Message, "Oops");
        }
    }
}