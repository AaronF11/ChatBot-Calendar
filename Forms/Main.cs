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
using ChatBot_Calendar.Controls;

namespace ChatBot_Calendar
{
    //-------------------------------------------------------------------------
    // Class: Main
    // Description: This class is the main form of the application.
    // Author: Aarón Flores Pasos
    // Date: 24/03/2023
    //-------------------------------------------------------------------------
    public partial class Main : MaterialSkin.Controls.MaterialForm
    {
        //---------------------------------------------------------------------
        // Attributes
        //---------------------------------------------------------------------
        private MaterialSkinManager materialSkinManager;
        private User User;

        //---------------------------------------------------------------------
        // Method: Main
        // Description: This method is the constructor of the class.
        //---------------------------------------------------------------------
        public Main()
        {
            InitializeComponent();
            SettingsScheme();
        }

        public void SettingsScheme()
        {
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Amber700,
                Primary.Amber900,
                Primary.Amber500,
                Accent.Amber400,
                TextShade.WHITE);
        }
        //---------------------------------------------------------------------
        // Method: BtnQuestions_Click
        // Description: This method is the event of the button questions
        // to send question to UscQuestions.
        //---------------------------------------------------------------------
        private void BtnQuestions_Click(object sender, EventArgs e)
        {
            if(!TxtQuestions.Text.Equals(""))
            {
                //int NewWidth = PnlQuestions.Width / 2;

                //UscQuestions.Question = TxtQuestions.Text;//Assigning the question to the label
                //UscQuestions = new UscQuestions(NewWidth);//Creating a new instance of UscQuestions
                //UscQuestions.Dock = DockStyle.Bottom;//Instancing the dock of the UscQuestions
                //PnlQuestions.Controls.Add(UscQuestions);//Adding the new UscQuestions

                //UscBot.Answer = "Respuestasssssssssssssssssssssssssss";
                //UscBot = new UscBot(NewWidth);
                //UscBot.Dock = DockStyle.Bottom;
                //PnlQuestions.Controls.Add(UscBot);
                User = new User(TxtQuestions);
                PnlQuestions.Controls.Add(User);
            }
            else
            {
                MaterialMessageBox.Show("Por favor escriba una pregunta", "Aviso");
            }
        }

        //---------------------------------------------------------------------
        // Method: BtnClear_Click
        // Description: This method is the event of the button clear to clear
        // the questions and answers.
        //---------------------------------------------------------------------
        private void BtnClear_Click(object sender, EventArgs e)
        {
            if (PnlQuestions.Controls.Count != 0)
            {
                DialogResult answer = MaterialMessageBox.Show("¿Seguro quieres borrar el chat?", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.None);
                if (answer == DialogResult.OK)
                {
                    PnlQuestions.Controls.Clear();
                    PnlResults.Controls.Clear();
                }
            }
        }
    }
}
