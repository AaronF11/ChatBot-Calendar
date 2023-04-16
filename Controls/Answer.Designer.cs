namespace ChatBot_Calendar.Controls
{
    partial class Answer
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
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // LblAnswer
            // 
            this.LblAnswer.Depth = 0;
            this.LblAnswer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblAnswer.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.LblAnswer.Location = new System.Drawing.Point(0, 0);
            this.LblAnswer.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblAnswer.Name = "LblAnswer";
            this.LblAnswer.Size = new System.Drawing.Size(872, 200);
            this.LblAnswer.TabIndex = 0;
            this.LblAnswer.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Timer
            // 
            this.Timer.Enabled = true;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // Answer
            // 
            this.AutoScroll = true;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.LblAnswer);
            this.Name = "Answer";
            this.Size = new System.Drawing.Size(872, 200);
            this.Load += new System.EventHandler(this.Answer_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel LblAnswer;
        private System.Windows.Forms.Timer Timer;
    }
}
