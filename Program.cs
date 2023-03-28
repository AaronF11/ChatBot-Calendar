using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChatBot_Calendar.Class;
using MaterialSkin.Controls;

namespace ChatBot_Calendar
{
    internal static class Program
    {
        //---------------------------------------------------------------------
        // Attributes
        //---------------------------------------------------------------------
        private static Connection Conn;
        private static string Result;
        private static string True = "Dependecias importadas";

        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Conn = new Connection();
            Result = Conn.TestConnection().ToString();
            if (Result == True)
            {
                //MaterialMessageBox.Show(Result, "Conexión establecida"); //This is a test.
                Application.Run(new Main());
            }
            else
            {
                MaterialMessageBox.Show(Result, "Conexión fallida");
                Application.Exit();
            }
        }
    }
}
