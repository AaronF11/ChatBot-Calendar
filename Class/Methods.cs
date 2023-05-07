using ChatBot_Calendar.Controls;
using IronPython.Runtime;
using MaterialSkin.Controls;
using OfficeOpenXml;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static Microsoft.IO.RecyclableMemoryStreamManager;

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
        List<string> listaEventos = new List<string>();
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
        // Method: Document
        // Description: This method is use to document the events in the
        // excel file.
        //---------------------------------------------------------------------
        public void Document()
        {
            var resultado = Conn.script.set_all_events();

            listaEventos = new List<string>();

            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            var rutaArchivo = @"..\..\Doc\Eventos.xlsx";
            var archivo = new FileInfo(rutaArchivo);


            if (!archivo.Exists)
            {
                using (var package = new ExcelPackage(archivo))
                {
                    package.Workbook.Worksheets.Add("Eventos");
                    package.Save();
                }

                using (var package = new ExcelPackage(archivo))
                {
                    var worksheet = package.Workbook.Worksheets["Eventos"];

                    if (worksheet.Dimension == null)
                    {
                        worksheet.Cells[1, 1].Value = "Evento";
                        worksheet.Cells[1, 2].Value = "Fecha";
                        worksheet.Cells[1, 3].Value = "Título";
                        worksheet.Cells[1, 4].Value = "Descripción";
                        worksheet.Cells[1, 5].Value = "Lugar";
                        worksheet.Cells[1, 6].Value = "Hora";
                        worksheet.Cells[1, 7].Value = "Comentarios";
                        worksheet.Cells[1, 1, 1, 7].Style.Font.Bold = true;
                        worksheet.Cells[1, 1, 1, 7].AutoFitColumns();
                        worksheet.View.FreezePanes(2, 1);
                        package.Save();
                    }

                    int row = worksheet.Dimension.End.Row + 1;
                    foreach (var key in ((dynamic)resultado).keys())
                    {
                        var evento = ((dynamic)resultado)[key];
                        worksheet.Cells[row, 1].Value = key.ToString();
                        worksheet.Cells[row, 2].Value = evento["date"].ToString();
                        worksheet.Cells[row, 3].Value = evento["title"].ToString();
                        worksheet.Cells[row, 4].Value = evento["description"].ToString();
                        worksheet.Cells[row, 5].Value = evento["location"].ToString();
                        worksheet.Cells[row, 6].Value = evento["time"].ToString();
                        worksheet.Cells[row, 7].Value = evento["comments"].ToString();
                        row++;
                    }

                    package.Save();
                }

            }

        }

        //---------------------------------------------------------------------
        // Method: Set_all_events
        // Description: This method is used to set all events.
        //---------------------------------------------------------------------
        public List<string> Set_all_events()
        {
            List<Evento> eventos = new List<Evento>();

            var Url = @"..\..\Doc\Eventos.xlsx";
            using (var package = new ExcelPackage(new FileInfo(Url)))
            {
                var worksheet = package.Workbook.Worksheets[0];
                var start = worksheet.Dimension.Start;
                var end = worksheet.Dimension.End;

                for (int row = start.Row + 1; row <= end.Row; row++)
                {
                    var evento = new Evento()
                    {
                        Fecha = worksheet.Cells[row, 2].Value.ToString(),
                        Titulo = worksheet.Cells[row, 3].Value.ToString(),
                        Descripcion = worksheet.Cells[row, 4].Value.ToString(),
                        Lugar = worksheet.Cells[row, 5].Value.ToString(),
                        Hora = worksheet.Cells[row, 6].Value.ToString(),
                        Comentarios = worksheet.Cells[row, 7].Value.ToString()
                    };

                    eventos.Add(evento);
                }
            }

            List<string> listaEventos = new List<string>();
            int i = 1;
            foreach (Evento evento in eventos)
            {
                string eventoStr = "";
                eventoStr += $"Evento: {i}\n";
                eventoStr += $"Fecha: {evento.Fecha}\n";
                eventoStr += $"Título: {evento.Titulo}\n";
                eventoStr += $"Descripción: {evento.Descripcion}\n";
                eventoStr += $"Lugar: {evento.Lugar}\n";
                eventoStr += $"Hora: {evento.Hora}\n";
                eventoStr += $"Comentarios: {evento.Comentarios}\n\n";
                listaEventos.Add(eventoStr);
                i++;
            }

            return listaEventos;
        }


        //---------------------------------------------------------------------
        // Method: Set_today_events
        // Description: This method is used to set all today events.
        //---------------------------------------------------------------------
        public List<string> Set_today_events()
        {
            List<Evento> eventos = new List<Evento>();

            var Url = @"..\..\Doc\Eventos.xlsx";
            using (var package = new ExcelPackage(new FileInfo(Url)))
            {
                var worksheet = package.Workbook.Worksheets[0];
                var start = worksheet.Dimension.Start;
                var end = worksheet.Dimension.End;

                for (int row = start.Row + 1; row <= end.Row; row++)
                {
                    var fechaStr = worksheet.Cells[row, 2].Value.ToString();
                    string today = DateTime.Today.ToString("dd/MM/yy");
                    if (today == fechaStr)
                    {
                        var evento = new Evento()
                        {
                            Fecha = fechaStr,
                            Titulo = worksheet.Cells[row, 3].Value.ToString(),
                            Descripcion = worksheet.Cells[row, 4].Value.ToString(),
                            Lugar = worksheet.Cells[row, 5].Value.ToString(),
                            Hora = worksheet.Cells[row, 6].Value.ToString(),
                            Comentarios = worksheet.Cells[row, 7].Value.ToString()
                        };

                        eventos.Add(evento);
                    }
                }
            }

            List<string> listaEventos = new List<string>();
            int i = 1;
            foreach (Evento evento in eventos)
            {
                string eventoStr = "";
                eventoStr += $"Evento: {i}\n";
                eventoStr += $"Fecha: {evento.Fecha}\n";
                eventoStr += $"Título: {evento.Titulo}\n";
                eventoStr += $"Descripción: {evento.Descripcion}\n";
                eventoStr += $"Lugar: {evento.Lugar}\n";
                eventoStr += $"Hora: {evento.Hora}\n";
                eventoStr += $"Comentarios: {evento.Comentarios}\n\n";
                listaEventos.Add(eventoStr);
                i++;
            }

            return listaEventos;
        }

        //---------------------------------------------------------------------
        // Method: Set_date_events
        // Description: This method is used to set all events of the date.
        //---------------------------------------------------------------------
        public List<string> Set_date_events(string date)
        {
            List<Evento> eventos = new List<Evento>();

            Regex regex = new Regex(@"\d{2}/\d{2}/\d{4}");
            Match match = regex.Match(date);
            if (match.Success)
            {
                date = match.Value;
            }
            else
            {
                return new List<string>();
            }

            var Url = @"..\..\Doc\Eventos.xlsx";
            using (var package = new ExcelPackage(new FileInfo(Url)))
            {
                var worksheet = package.Workbook.Worksheets[0];
                var start = worksheet.Dimension.Start;
                var end = worksheet.Dimension.End;

                for (int row = start.Row + 1; row <= end.Row; row++)
                {
                    var evento = new Evento()
                    {
                        Fecha = worksheet.Cells[row, 2].Value.ToString(),
                        Titulo = worksheet.Cells[row, 3].Value.ToString(),
                        Descripcion = worksheet.Cells[row, 4].Value.ToString(),
                        Lugar = worksheet.Cells[row, 5].Value.ToString(),
                        Hora = worksheet.Cells[row, 6].Value.ToString(),
                        Comentarios = worksheet.Cells[row, 7].Value.ToString()
                    };

                    eventos.Add(evento);
                }
            }

            List<string> listaEventos = new List<string>();
            int i = 1;
            foreach (Evento evento in eventos)
            {
                if (evento.Fecha == date)
                {
                    string eventoStr = "";
                    eventoStr += $"Evento: {i}\n";
                    eventoStr += $"Fecha: {evento.Fecha}\n";
                    eventoStr += $"Título: {evento.Titulo}\n";
                    eventoStr += $"Descripción: {evento.Descripcion}\n";
                    eventoStr += $"Lugar: {evento.Lugar}\n";
                    eventoStr += $"Hora: {evento.Hora}\n";
                    eventoStr += $"Comentarios: {evento.Comentarios}\n\n";
                    listaEventos.Add(eventoStr);
                    i++;
                }
            }

            return listaEventos;
        }


        //---------------------------------------------------------------------
        // Method: Set_today_events
        // Description: This method is used to set all today events.
        //---------------------------------------------------------------------
        public List<string> Help()
        {
            string Op = "";
            Op += "Estas son las opciones que puedes utilizar para preguntar sobre fechas y eventos:\n";
            Op += "- \"Dame todos los eventos\" ó \"Dame todas las fehas con evento agendada\"\n";
            Op += "- \"Dame todos los eventos de hoy\" ó \"Dame todos los eventos del dia\"\n";
            Op += "- \"¿Qué eventos hay en la fecha DD/MM/AAAA?\" ó \"¿Qué eventos hay el DD/MM/AAAA?\"\n";
            Op += "- \"Agregar evento\" ó \"Agendar evento\"\n";
            Op += "- \"Agregar comentario\" ó \"Incluir comentario\"\n";

            List<string> args = new List<string>
            {
                Op
            };

            return args;
        }

        //---------------------------------------------------------------------
        // Method: AddNewEvent
        // Description: This method is used to add a new event.
        //---------------------------------------------------------------------
        public void AddNewEvent(string date, string title, string description, string location, string time, string comments)
        {
            var Url = @"..\..\Doc\Eventos.xlsx";
            FileInfo existingFile = new FileInfo(Url);

            using (ExcelPackage package = new ExcelPackage(existingFile))
            {
                ExcelWorksheet worksheet = package.Workbook.Worksheets[0];

                int lastRow = worksheet.Dimension.End.Row;
                int newRow = lastRow + 1;

                worksheet.Cells[newRow, 1].Value = newRow - 1;
                worksheet.Cells[newRow, 2].Value = date;
                worksheet.Cells[newRow, 3].Value = title;
                worksheet.Cells[newRow, 4].Value = description;
                worksheet.Cells[newRow, 5].Value = location;
                worksheet.Cells[newRow, 6].Value = time;
                worksheet.Cells[newRow, 7].Value = comments;

                package.Save();
            }
        }

        //---------------------------------------------------------------------
        // Method: AddNewComment
        // Description: This method is used to add a new comment for the event.
        //---------------------------------------------------------------------
        public bool AddNewComment(int eventNumber, string comment)
        {
            var url = @"..\..\Doc\Eventos.xlsx";
            using (var package = new ExcelPackage(new FileInfo(url)))
            {
                var worksheet = package.Workbook.Worksheets[0];
                var start = worksheet.Dimension.Start;
                var end = worksheet.Dimension.End;

                for (int row = start.Row + 1; row <= end.Row; row++)
                {
                    if (int.Parse(worksheet.Cells[row, 1].Value.ToString()) == eventNumber)
                    {
                        worksheet.Cells[row, 7].Value = comment;
                        break;
                    }
                    else
                    {
                        return false;
                    }
                }

                package.Save();
            }
            return true;
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