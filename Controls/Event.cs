using ChatBot_Calendar.Class;
using IronPython.Runtime;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace ChatBot_Calendar.Controls
{
    //-------------------------------------------------------------------------
    // Class: Event
    // Description: This class is used to create a user control that will be used
    // to create a new event.
    // Author: Aarón Flores Pasos
    // Date: 23/04/2023
    //-------------------------------------------------------------------------
    public partial class Event : UserControl
    {
        //---------------------------------------------------------------------
        // Attributes
        //---------------------------------------------------------------------
        private Methods Methods;

        //---------------------------------------------------------------------
        // Method: Event
        // Description: This method is the constructor of the class.
        //---------------------------------------------------------------------
        public Event()
        {
            InitializeComponent();
            Dock = DockStyle.Top;
        }

        //---------------------------------------------------------------------
        // Method: BtnSendEvent_Click
        // Description: This method is used to send the event to the script.
        //---------------------------------------------------------------------
        private void BtnSendEvent_Click(object sender, EventArgs e)
        {
            if (TxtDate.Text == string.Empty || TxtTitle.Text == string.Empty 
                || TxtDescription.Text == string.Empty || TxtLocation.Text == string.Empty
                || TxtHour.Text == string.Empty || TxtComments.Text == string.Empty)
            {
                MaterialMessageBox.Show("Por favor complete los apartados faltantes", "Aviso");
            }
            else
            {
                Methods = new Methods("");
                Methods.Document();
                Methods.AddNewEvent(TxtDate.Text, TxtTitle.Text, TxtDescription.Text, TxtLocation.Text, TxtHour.Text, TxtComments.Text);
                MaterialMessageBox.Show("Evento registrado exitosamente", "Aviso");
            }
        }
    }
}
