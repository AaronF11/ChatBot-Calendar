using ChatBot_Calendar.Controls;
using IronPython.Runtime;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        List<string> errors = new List<string>();
        List<string> successes = new List<string>();
        string Question;

        //---------------------------------------------------------------------
        // Method: Methods
        // Description: This method is the constructor of the class.
        //---------------------------------------------------------------------
        public Methods(string Question) 
        {
            Conn = new Connection();
            errors = new List<string>
            {
                "Lo siento, no encontré información sobre esa fecha o evento.",
                "No tengo información disponible sobre esa fecha o evento.",
                "No puedo reconocer la fecha o el evento que mencionas.",
                "No tengo acceso a la información necesaria para responder a esa pregunta sobre fechas o eventos.",
                "Lo siento, no tengo la capacidad de proporcionar información sobre eventos hipotéticos.",
                "No tengo la capacidad de predecir eventos futuros.",
                "No puedo proporcionar una opinión sobre fechas o eventos específicos."
            };
            successes = new List<string>
            {
                "¡Claro! Con gusto te proporcionaré la información que buscas.",
                "¡Por supuesto! Estoy aquí para ayudarte en lo que necesites.",
                "¡Con mucho gusto! Me encanta ayudar a resolver dudas y preguntas.",
                "¡Definitivamente! Es un placer poder ayudarte en lo que necesites.",
                "¡Por supuesto que sí! Estoy aquí para ayudarte en lo que sea posible.",
                "¡Con mucho gusto! Estoy a tu disposición para responder cualquier pregunta que tengas."
            };
            this.Question = Question;
        }

        //---------------------------------------------------------------------
        // Method: Set_all_events
        // Description: This method is used to set all events.
        //---------------------------------------------------------------------
        public List<string> Set_all_events()
        {
            var resultado = Conn.script.set_all_events();

            List<string> listaEventos = new List<string>();

            foreach (var key in ((dynamic)resultado).keys())
            {
                string evento = "";
                evento += "Evento " + key.ToString() + ":\n";
                evento += "Fecha: " + ((dynamic)resultado)[key]["date"].ToString() + "\n";
                evento += "Título: " + ((dynamic)resultado)[key]["title"].ToString() + "\n";
                evento += "Descripción: " + ((dynamic)resultado)[key]["description"].ToString() + "\n";
                evento += "Lugar: " + ((dynamic)resultado)[key]["location"].ToString() + "\n";
                evento += "Hora: " + ((dynamic)resultado)[key]["time"].ToString() + "\n";
                evento += "Comentarios: " + ((dynamic)resultado)[key]["comments"].ToString() + "\n\n";
                listaEventos.Add(evento);
            }

            return listaEventos;
        }


        //public DataTable Set_all_events()
        //{
        //    var resultado = Conn.script.set_all_events();

        //    DataTable table = new DataTable();
        //    table.Columns.Add("Evento");
        //    table.Columns.Add("Fecha");
        //    table.Columns.Add("Título");
        //    table.Columns.Add("Descripción");
        //    table.Columns.Add("Lugar");
        //    table.Columns.Add("Hora");
        //    table.Columns.Add("Comentarios");

        //    foreach (var key in ((dynamic)resultado).keys())
        //    {
        //        DataRow row = table.NewRow();
        //        row["Evento"] = key.ToString();
        //        row["Fecha"] = ((dynamic)resultado)[key]["date"].ToString();
        //        row["Título"] = ((dynamic)resultado)[key]["title"].ToString();
        //        row["Descripción"] = ((dynamic)resultado)[key]["description"].ToString();
        //        row["Lugar"] = ((dynamic)resultado)[key]["location"].ToString();
        //        row["Hora"] = ((dynamic)resultado)[key]["time"].ToString();
        //        row["Comentarios"] = ((dynamic)resultado)[key]["comments"].ToString();
        //        table.Rows.Add(row);
        //    }

        //    return table;
        //}


        //---------------------------------------------------------------------
        // Method: Get_last_key
        // Description: This method is used to get the last key of the dict
        //---------------------------------------------------------------------
        public int Get_last_key()
        {
            var resultado = Conn.script.set_all_events();

            int lastKey = -1;

            foreach (var key in ((dynamic)resultado).keys())
            {
                int currentKey = Convert.ToInt32(key.ToString());
                if (currentKey > lastKey)
                {
                    lastKey = currentKey;
                }
            }

            return lastKey;
        }
    }
}
