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
            this.LblAnswers = new MaterialSkin.Controls.MaterialLabel();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // LblAnswers
            // 
            this.LblAnswers.Depth = 0;
            this.LblAnswers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblAnswers.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.LblAnswers.Location = new System.Drawing.Point(0, 0);
            this.LblAnswers.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblAnswers.Name = "LblAnswers";
            this.LblAnswers.Size = new System.Drawing.Size(726, 578);
            this.LblAnswers.TabIndex = 0;
            this.LblAnswers.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Timer
            // 
            this.Timer.Enabled = true;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // Answer
            // 
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.LblAnswers);
            this.Name = "Answer";
            this.Size = new System.Drawing.Size(726, 578);
            //this.Load += new System.EventHandler(this.Answer_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel LblAnswers;
        private System.Windows.Forms.Timer Timer;
    }
}
