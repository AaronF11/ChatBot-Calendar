namespace ChatBot_Calendar.Controls
{
    partial class Bot
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.LblAnswer = new MaterialSkin.Controls.MaterialLabel();
            this.PtbBot = new System.Windows.Forms.PictureBox();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PtbBot)).BeginInit();
            this.SuspendLayout();
            // 
            // LblAnswer
            // 
            this.LblAnswer.AutoSize = true;
            this.LblAnswer.Depth = 0;
            this.LblAnswer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblAnswer.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.LblAnswer.Location = new System.Drawing.Point(40, 0);
            this.LblAnswer.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblAnswer.Name = "LblAnswer";
            this.LblAnswer.Size = new System.Drawing.Size(1, 0);
            this.LblAnswer.TabIndex = 0;
            // 
            // PtbBot
            // 
            this.PtbBot.BackgroundImage = global::ChatBot_Calendar.Properties.Resources.Bot_Answer;
            this.PtbBot.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PtbBot.Dock = System.Windows.Forms.DockStyle.Left;
            this.PtbBot.Location = new System.Drawing.Point(0, 0);
            this.PtbBot.Name = "PtbBot";
            this.PtbBot.Size = new System.Drawing.Size(40, 50);
            this.PtbBot.TabIndex = 1;
            this.PtbBot.TabStop = false;
            // 
            // Timer
            // 
            this.Timer.Enabled = true;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // Bot
            // 
            this.AutoScroll = true;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.LblAnswer);
            this.Controls.Add(this.PtbBot);
            this.Name = "Bot";
            this.Size = new System.Drawing.Size(146, 50);
            this.Load += new System.EventHandler(this.Bot_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PtbBot)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel LblAnswer;
        private System.Windows.Forms.PictureBox PtbBot;
        private System.Windows.Forms.Timer Timer;
    }
}
