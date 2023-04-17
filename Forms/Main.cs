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
using ChatBot_Calendar.Class;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Text.RegularExpressions;

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
        private Methods Methods;
        private User User;
        private Bot Bot;
        private Answer Answer;
        private List<string> errors;
        private List<string> all_events;


        //---------------------------------------------------------------------
        // Method: Main
        // Description: This method is the constructor of the class.
        //---------------------------------------------------------------------
        public Main()
        {
            InitializeComponent();
            SettingsScheme(1);
            errors = new List<string>()
            {
                "Disculpa, no comprendí lo que preguntaste.",
                "Perdón, no logro entender la pregunta que hiciste.",
                "Lo siento, ¿podrías reformular tu pregunta? No la entendí bien."
            };
            all_events = new List<string>()
            {
                "Por supuesto, aquí tienes la lista de eventos programados.",
                "Claro, te muestro los eventos que tienes agendados.",
                "Sin problema, aquí tienes los eventos que tienes programados en tu calendario."
            };

            PnlQuestions.AutoScroll = true;
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
                        Primary.Indigo500,
                        Primary.Indigo700,
                        Primary.Indigo100,
                        Accent.LightBlue700,
                        TextShade.WHITE
                    );
                    break;
                case 2:
                    materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
                    materialSkinManager.ColorScheme = new ColorScheme(
                        Primary.Amber700,
                        Primary.Amber900,
                        Primary.Amber500,
                        Accent.Amber400,
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
            if (!TxtQuestions.Text.Equals(""))
            {
                PnlResults.Controls.Clear();

                Random random = new Random();
                string AnswerFinal;
                string Question = TxtQuestions.Text.ToString();
                List<string> eventos;

                Methods = new Methods(Question);
                User = new User(Question);

                Question = Question.ToLower();

                switch (Question)
                {
                    case string s when s.Contains("todos") || s.Contains("todas"):
                        AnswerFinal = all_events[random.Next(0, all_events.Count)];
                        Bot = new Bot(AnswerFinal);
                        PnlQuestions.Controls.Add(Bot);
                        eventos = Methods.Set_all_events();
                        foreach (string evento in eventos)
                        {
                            Answer = new Answer(evento);
                            PnlResults.Controls.Add(Answer);
                        }
                        break;
                    case string s when s.Contains("hoy") || s.Contains("del dia"):
                        AnswerFinal = all_events[random.Next(0, all_events.Count)];
                        Bot = new Bot(AnswerFinal);
                        PnlQuestions.Controls.Add(Bot);
                        eventos = Methods.Set_today_events();
                        foreach (string evento in eventos)
                        {
                            Answer = new Answer(evento);
                            PnlResults.Controls.Add(Answer);
                        }
                        break;
                    case string s when s.Contains("fecha") || s.Contains("el"):
                        AnswerFinal = all_events[random.Next(0, all_events.Count)];
                        Bot = new Bot(AnswerFinal);
                        PnlQuestions.Controls.Add(Bot);
                        eventos = Methods.Set_date_events(TxtQuestions.Text);
                        foreach (string evento in eventos)
                        {
                            Answer = new Answer(evento);
                            PnlResults.Controls.Add(Answer);
                        }
                        break;
                    default:
                        AnswerFinal = errors[random.Next(0, errors.Count)];
                        Bot = new Bot(AnswerFinal);
                        PnlQuestions.Controls.Add(Bot);
                        break;
                }

                PnlQuestions.Controls.Add(User);

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
