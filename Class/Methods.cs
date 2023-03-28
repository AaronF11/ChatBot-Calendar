using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatBot_Calendar.Class
{
    //-------------------------------------------------------------------------
    // Class: Methods
    // Description: This class is use the connection with the script
    // of python to execute the methods.
    // Author: Aarón Flores Pasos
    // Date: 27/03/2023
    //-------------------------------------------------------------------------
    public class Methods
    {
        //---------------------------------------------------------------------
        // Attributes
        //---------------------------------------------------------------------
        Connection Conn;

        //---------------------------------------------------------------------
        // Method: Methods
        // Description: This method is the constructor of the class.
        //---------------------------------------------------------------------
        public Methods() 
        {
            Conn = new Connection();
        }

        //---------------------------------------------------------------------
        // Method: Example
        // Description: This method is used to execute the method of the script.
        //---------------------------------------------------------------------
        public string Example()
        {
            return Conn.script.example();
        }
    }
}
