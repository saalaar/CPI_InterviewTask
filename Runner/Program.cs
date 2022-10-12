using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Runner.Extensions;

namespace Runner
{
    static class Program
    {
        static MainForm _mainForm;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.ThreadException += Application_ThreadException;
            AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new MainForm());
            _mainForm = new MainForm();
            Application.Run(_mainForm);
        }

        static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            printExceptionToUI(e.ExceptionObject as Exception);
        }
        static void Application_ThreadException(object sender, System.Threading.ThreadExceptionEventArgs e)
        {
            printExceptionToUI(e.Exception);
        }

        static void printExceptionToUI(Exception ex)
        {
            if (ex != null)
            {
                if (ex.IsSystemException())
                {
                    _mainForm.ErrorText = "System Exception, There is no Logging System!  Please contact moghimi.salar@gmail.com to check !!! ";
                }
                else
                {
                    _mainForm.ErrorText = ex.Message;
                }
            }
        }
    }
}
