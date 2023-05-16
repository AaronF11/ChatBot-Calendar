using ChatBot_Calendar.Controls;
using IronPython.Runtime;
using MaterialSkin.Controls;
using MimeKit;
using OfficeOpenXml;
using OfficeOpenXml.Style;
using Org.BouncyCastle.Cms;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static IronPython.SQLite.PythonSQLite;
using static Microsoft.IO.RecyclableMemoryStreamManager;
using MimeKit;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;

namespace ChatBot_Calendar.Class
{
    //-------------------------------------------------------------------------
    // Class: Methods
    // Description: This class is use the connection with the script
    // of python to execute the methods.
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
                        worksheet.Cells[1, 1, 1, 7].Style.Fill.PatternType = ExcelFillStyle.Solid;
                        worksheet.Cells[1, 1, 1, 7].Style.Fill.BackgroundColor.SetColor(Color.FromArgb(79, 129, 189));
                        worksheet.Cells[1, 1, 1, 7].Style.Font.Color.SetColor(Color.White);

                        worksheet.Cells[1, 1, 1, 7].AutoFitColumns();
                        worksheet.View.FreezePanes(2, 1);
                        package.Save();
                    }

                    var x = ((dynamic)resultado).keys().Count;
                    int row = x + 1;
                    foreach (var key in ((dynamic)resultado).keys())
                    {
                        var evento = ((dynamic)resultado)[key];
                        worksheet.Cells[row, 1].Value = Convert.ToInt32(key);
                        worksheet.Cells[row, 2].Value = evento["date"].ToString();
                        worksheet.Cells[row, 3].Value = evento["title"].ToString();
                        worksheet.Cells[row, 4].Value = evento["description"].ToString();
                        worksheet.Cells[row, 5].Value = evento["location"].ToString();
                        worksheet.Cells[row, 6].Value = evento["time"].ToString();
                        worksheet.Cells[row, 7].Value = evento["comments"].ToString();
                        worksheet.Cells[row, 1, row, 7].Style.Font.Size = 12;
                        worksheet.Row(row).Height = 20;
                        worksheet.Cells[row, 1, row, 7].Style.Border.Top.Style = ExcelBorderStyle.Thin;
                        worksheet.Cells[row, 1, row, 7].Style.Border.Bottom.Style = ExcelBorderStyle.Thin;
                        worksheet.Cells[row, 1, row, 7].Style.Border.Left.Style = ExcelBorderStyle.Thin;
                        worksheet.Cells[row, 1, row, 7].Style.Border.Right.Style = ExcelBorderStyle.Thin;
                        worksheet.Cells[row, row, row, 7].AutoFitColumns();
                        row--;
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
                    string today = DateTime.Today.ToString("dd/MM/yyyy");
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
                worksheet.Cells[newRow, 1, newRow, 7].Style.Font.Size = 12;
                worksheet.Row(newRow).Height = 20;
                worksheet.Cells[newRow, 1, newRow, 7].Style.Border.Top.Style = ExcelBorderStyle.Thin;
                worksheet.Cells[newRow, 1, newRow, 7].Style.Border.Bottom.Style = ExcelBorderStyle.Thin;
                worksheet.Cells[newRow, 1, newRow, 7].Style.Border.Left.Style = ExcelBorderStyle.Thin;
                worksheet.Cells[newRow, 1, newRow, 7].Style.Border.Right.Style = ExcelBorderStyle.Thin;
                worksheet.Cells[newRow, newRow, newRow, 7].AutoFitColumns();

                package.Save();
            }
        }

        //---------------------------------------------------------------------
        // Method: ModifyEvent
        // Description: This method is used to modify an event.
        //---------------------------------------------------------------------
        public bool ModifyEvent(int eventNumber, string date, string title, string description, string location, string time, string comments)
        {
            var Url = @"..\..\Doc\Eventos.xlsx";
            using (var package = new ExcelPackage(new FileInfo(Url)))
            {
                var worksheet = package.Workbook.Worksheets[0];
                var start = worksheet.Dimension.Start;
                var end = worksheet.Dimension.End;

                for (int row = start.Row + 1; row <= end.Row; row++)
                {
                    if (int.Parse(worksheet.Cells[row, 1].Value.ToString()) == eventNumber)
                    {
                        worksheet.Cells[row, 2].Value = date;
                        worksheet.Cells[row, 3].Value = title;
                        worksheet.Cells[row, 4].Value = description;
                        worksheet.Cells[row, 5].Value = location;
                        worksheet.Cells[row, 6].Value = time;
                        worksheet.Cells[row, 7].Value = comments;
                        worksheet.Cells[row, 1, row, 7].Style.Font.Size = 12;
                        worksheet.Row(row).Height = 20;
                        worksheet.Cells[row, 1, row, 7].Style.Border.Top.Style = ExcelBorderStyle.Thin;
                        worksheet.Cells[row, 1, row, 7].Style.Border.Bottom.Style = ExcelBorderStyle.Thin;
                        worksheet.Cells[row, 1, row, 7].Style.Border.Left.Style = ExcelBorderStyle.Thin;
                        worksheet.Cells[row, 1, row, 7].Style.Border.Right.Style = ExcelBorderStyle.Thin;
                        worksheet.Cells[row, row, row, 7].AutoFitColumns();

                        package.Save();
                        return true;
                    }
                }

                return false;
            }
        }

        //---------------------------------------------------------------------
        // Method: DeleteEvent
        // Description: This method is used to delete an event.
        //---------------------------------------------------------------------
        public bool DeleteEvent(int eventNumber)
        {
            var Url = @"..\..\Doc\Eventos.xlsx";
            using (var package = new ExcelPackage(new FileInfo(Url)))
            {
                var worksheet = package.Workbook.Worksheets[0];
                var start = worksheet.Dimension.Start;
                var end = worksheet.Dimension.End;

                for (int row = start.Row + 1; row <= end.Row; row++)
                {
                    if (int.Parse(worksheet.Cells[row, 1].Value.ToString()) == eventNumber)
                    {
                        worksheet.DeleteRow(row, 1);
                        worksheet.Cells[row, 1, row, 7].Style.Font.Size = 12;
                        worksheet.Row(row).Height = 20;
                        worksheet.Cells[row, 1, row, 7].Style.Border.Top.Style = ExcelBorderStyle.Thin;
                        worksheet.Cells[row, 1, row, 7].Style.Border.Bottom.Style = ExcelBorderStyle.Thin;
                        worksheet.Cells[row, 1, row, 7].Style.Border.Left.Style = ExcelBorderStyle.Thin;
                        worksheet.Cells[row, 1, row, 7].Style.Border.Right.Style = ExcelBorderStyle.Thin;
                        worksheet.Cells[row, row, row, 7].AutoFitColumns();
                        package.Save();
                        return true;
                    }
                }

                return false;
            }
        }

        //---------------------------------------------------------------------
        // Method: AddNewComment
        // Description: This method is used to add a new comment for the event.
        //---------------------------------------------------------------------
        public bool AddNewComment(int eventNumber, string comment)
        {
            var Url = @"..\..\Doc\Eventos.xlsx";
            using (var package = new ExcelPackage(new FileInfo(Url)))
            {
                var worksheet = package.Workbook.Worksheets[0];
                var start = worksheet.Dimension.Start;
                var end = worksheet.Dimension.End;

                for (int row = start.Row + 1; row <= end.Row; row++)
                {
                    if (int.Parse(worksheet.Cells[row, 1].Value.ToString()) == eventNumber)
                    {
                        worksheet.Cells[row, 7].Value = comment;
                        package.Save();
                        return true;
                    }
                }

                return false;
            }
        }

        //---------------------------------------------------------------------
        // Method: Help
        // Description: This method is used to help the user's.
        //---------------------------------------------------------------------
        public List<string> Help()
        {
            string Op = "";
            Op += "Estas son las opciones que puedes utilizar para preguntar sobre fechas y eventos:\n";
            Op += "- \"Dame todos los eventos\" ó \"Dame todas las fehas con evento agendado\"\n";
            Op += "- \"Dame los eventos de hoy\" ó \"Dame los eventos del dia\"\n";
            Op += "- \"¿Qué eventos hay en la fecha DD/MM/AAAA?\" ó \"¿Qué eventos hay el DD/MM/AAAA?\"\n";
            Op += "- \"Agregar evento\" ó \"Crear evento\"\n";
            Op += "- \"Agregar comentario\" ó \"Crear comentario\"\n";

            List<string> args = new List<string>
            {
                Op
            };

            return args;
        }

        //---------------------------------------------------------------------
        // Method: SendWhatsApp
        // Description: This method is used to send a message to WhatsApp.
        // State: *In production*
        //---------------------------------------------------------------------
        public void SendWhatsApp()
        {
            var accountSid = "ACf7f398b17e15b4bf54a7ead081169300";
            var authToken = "a6ebbd5b4a690eee7bfebca916c3b7fa";
            TwilioClient.Init(accountSid, authToken);

            var messageOptions = new CreateMessageOptions(
              new PhoneNumber("whatsapp:+5213223624573"));
            messageOptions.From = new PhoneNumber("whatsapp:+14155238886");
            foreach (var item in Set_all_events())
            {
                messageOptions.Body += item;
            }

            var message = MessageResource.Create(messageOptions);
            MessageBox.Show(message.ToString());
        }
    }
}