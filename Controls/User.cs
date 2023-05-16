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
    // Class: User
    // Description: This class is used to create a user control that will be used
    // to display the user's questions.
    // Date: 26/03/2023
    //-------------------------------------------------------------------------
    public partial class User : UserControl
    {
        //---------------------------------------------------------------------
        // Attributes
        //---------------------------------------------------------------------
        private string Complete;
        private int PosActual = 0;

        //---------------------------------------------------------------------
        // Method: User
        // Description: This method is the constructor of the class.
        //---------------------------------------------------------------------
        public User(string Question)
        {
            InitializeComponent();
            Complete = Question;
            Dock = DockStyle.Top;
            AutoScroll = true;
        }

        //---------------------------------------------------------------------
        // Method: User_Load
        // Description: This method is the event of the load of the user control.
        //---------------------------------------------------------------------
        private void User_Load(object sender, EventArgs e)
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
            try
            {
                string Parcial = Complete.Substring(0, PosActual);

                LblQuestion.Text = Parcial;

                PosActual++;

                if (PosActual > Complete.Length)
                {
                    Timer.Stop();
                }
            }
            catch (Exception)
            {

                
            }
            
        }
    }
}
