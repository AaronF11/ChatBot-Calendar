using IronPython.Hosting;
using Microsoft.Scripting.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatBot_Calendar.Class
{
    //-------------------------------------------------------------------------
    // Class: Connection
    // Description: This class is used to create a connection with the script
    // of python.
    // Author: Aarón Flores Pasos
    // Date: 27/03/2023
    //-------------------------------------------------------------------------
    public class Connection
    {
        //---------------------------------------------------------------------
        // Attributes
        //---------------------------------------------------------------------
        private string Path = @"..\..\Python\script.py"; //Path of the script.
        private ScriptRuntime py = Python.CreateRuntime(); //Method to execute the script.
        public dynamic script; //Var to execute the script.

        //---------------------------------------------------------------------
        // Method: Connection
        // Description: This method is the constructor of the class.
        //---------------------------------------------------------------------
        public Connection()
        {
            script = py.UseFile(Path); //Execute the script.
        }

        //---------------------------------------------------------------------
        // Method: TestConnection
        // Description: This method is used to import the dependencies of the
        // script.
        //---------------------------------------------------------------------
        public string TestConnection()
        {
            return script.import_dependencies();
        }

    }
}
