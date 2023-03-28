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
        private Bot Bot;

        //---------------------------------------------------------------------
        // Method: Main
        // Description: This method is the constructor of the class.
        //---------------------------------------------------------------------
        public Main()
        {
            InitializeComponent();
            SettingsScheme(1);
        }

        public void SettingsScheme(int op)
        {
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            switch (op)
            {
                case 1:
                    materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
                    materialSkinManager.ColorScheme = new ColorScheme(
                        Primary.Amber700,
                        Primary.Amber900,
                        Primary.Amber500,
                        Accent.Amber400,
                        TextShade.WHITE);
                    break;
                case 2:
                    materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
                    materialSkinManager.ColorScheme = new ColorScheme(
                        Primary.BlueGrey900,
                        Primary.BlueGrey900,
                        Primary.BlueGrey500,
                        Accent.LightBlue200,
                        TextShade.WHITE);
                    break;
            }
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
                User = new User(TxtQuestions);
                Bot = new Bot(TxtQuestions);
                PnlQuestions.Controls.Add(User);
                PnlQuestions.Controls.Add(Bot);
                TxtQuestions.Text = string.Empty; 
                TxtQuestions.Focus();
            }
            else
            {
                MaterialMessageBox.Show("Por favor escriba una pregunta", "Aviso", HelpButton);
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
                DialogResult answer = MaterialMessageBox.Show("¿Seguro quieres borrar el chat?", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.None, HelpButton);
                if (answer == DialogResult.OK)
                {
                    PnlQuestions.Controls.Clear();
                    PnlResults.Controls.Clear();
                    TxtQuestions.Text = string.Empty;
                    TxtQuestions.Focus();
                }
            }
        }

        //---------------------------------------------------------------------
        // Method: TxtQuestions_KeyDown
        // Description: This method is the event of the button BtnQuestions_Click
        // to send question to PnlQuestions.
        //---------------------------------------------------------------------
        private void TxtQuestions_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BtnQuestions_Click(null, null);
            }
        }
    }
}
