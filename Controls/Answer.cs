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
    // Class: Answer
    // Description: This class is used to create a user control that will be used
    // to display the user's answers.
    // Author: Aarón Flores Pasos
    // Date: 02/04/2023
    //-------------------------------------------------------------------------
    public partial class Answer : UserControl
    {
        //---------------------------------------------------------------------
        // Attributes
        //---------------------------------------------------------------------
        private string Complete;
        private int PosActual = 0;

        //---------------------------------------------------------------------
        // Method: Answer
        // Description: This method is the constructor of the class.
        //---------------------------------------------------------------------
        public Answer(string Answer)
        {
            InitializeComponent();
            Complete = Answer;
            Dock = DockStyle.Fill;
        }

        //---------------------------------------------------------------------
        // Method: User_Load
        // Description: This method is the event of the load of the user control.
        //---------------------------------------------------------------------
        private void Answer_Load(object sender, EventArgs e)
        {
            Timer.Interval = 5;
            Timer.Start();
        }

        //---------------------------------------------------------------------
        // Method: Timer_Tick
        // Description: This method is the event of the timer.
        //---------------------------------------------------------------------
        private void Timer_Tick(object sender, EventArgs e)
        {
            string Parcial = Complete.Substring(0, PosActual);

            LblAnswers.Text = Parcial;

            PosActual++;

            if (PosActual > Complete.Length)
            {
                Timer.Stop();
            }
        }
    }
}
