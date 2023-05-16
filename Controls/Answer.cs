using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace ChatBot_Calendar.Controls
{
    //-------------------------------------------------------------------------
    // Class: Bot
    // Description: This class is used to create a user control that will be used
    // to display the user's questions.
    // Date: 26/03/2023
    //-------------------------------------------------------------------------
    public partial class Answer : UserControl
    {
        //---------------------------------------------------------------------
        // Attributes
        //---------------------------------------------------------------------
        public string Complete;
        private int PosActual = 0;

        //---------------------------------------------------------------------
        // Method: Bot
        // Description: This method is the constructor of the class.
        //---------------------------------------------------------------------
        public Answer(string Text)
        {
            InitializeComponent();
            Complete = Text;
            Dock = DockStyle.Top;
        }

        //---------------------------------------------------------------------
        // Method: Bot_Load
        // Description: This method is the event of the load of the user control.
        //---------------------------------------------------------------------
        private void Answer_Load(object sender, EventArgs e)
        {
            Timer.Interval = 10;
            Timer.Start();
        }

        //---------------------------------------------------------------------
        // Method: Timer_Tick
        // Description: This method is the event of the timer.
        //---------------------------------------------------------------------
        private void Timer_Tick(object sender, EventArgs e)
        {
            string Parcial = Complete.Substring(0, PosActual);

            LblAnswer.Text = Parcial;

            PosActual++;

            if (PosActual > Complete.Length)
            {
                Timer.Stop();
            }
        }
    }
}
