using ChatBot_Calendar.Class;
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

namespace ChatBot_Calendar.Controls
{
    //-------------------------------------------------------------------------
    // Class: Comment
    // Description: This class is used to create a user control that will be used
    // to create a new comment.
    // Date: 23/04/2023
    //-------------------------------------------------------------------------
    public partial class Comment : UserControl
    {
        //---------------------------------------------------------------------
        // Attributes
        //---------------------------------------------------------------------
        private Methods Methods;

        //---------------------------------------------------------------------
        // Method: Comment
        // Description: This method is the constructor of the class.    
        //---------------------------------------------------------------------
        public Comment()
        {
            InitializeComponent();
            Dock = DockStyle.Top;
        }

        //---------------------------------------------------------------------
        // Method: BtnSendEvent_Click
        // Description: This method is used to send the comment to the script.
        //---------------------------------------------------------------------
        private void BtnSendEvent_Click(object sender, EventArgs e)
        {
            if (TxtId.Text == string.Empty || TxtComments.Text == string.Empty)
            {
                MaterialMessageBox.Show("Por favor complete los apartados faltantes", "Aviso");
            }
            else
            {
                Methods = new Methods("");
                Methods.Document();
                var r = Methods.AddNewComment(Convert.ToInt32(TxtId.Text), TxtComments.Text);
                if (r)
                {
                    MaterialMessageBox.Show("Comentario registrado exitosamente", "Aviso");
                }
                else
                {
                    MaterialMessageBox.Show("Error al registrar el comentario, evento no encontrado", "Aviso");
                }
            }
            TxtId.Text = string.Empty;
            TxtComments.Text = string.Empty;
        }
    }
}
