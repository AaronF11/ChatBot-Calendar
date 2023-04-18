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

        //---------------------------------------------------------------------
        // Method: Set_today_events
        // Description: This method is used to set all today events.
        //---------------------------------------------------------------------
        public List<string> Set_today_events()
        {
            var resultado = Conn.script.set_today_events();

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

        //---------------------------------------------------------------------
        // Method: Set_date_events
        // Description: This method is used to set all events of the date.
        //---------------------------------------------------------------------
        public List<string> Set_date_events(string date)
        {
            var resultado = Conn.script.set_date_events(date);

            List<string> listaEventos = new List<string>();

            if (resultado != "No hay eventos en la fecha especificada.")
            {
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
            }
            else
            {
                listaEventos.Add(resultado);
            }

            return listaEventos;
        }

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
