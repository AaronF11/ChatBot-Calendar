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
    public partial class User : UserControl
    {
        public User(MaterialTextBox TxtQuestions)
        {
            InitializeComponent();
            LblQuestion.Text = TxtQuestions.Text;
            Dock = DockStyle.Bottom;
        }
    }
}
