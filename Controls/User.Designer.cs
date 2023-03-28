namespace ChatBot_Calendar.Controls
{
    partial class User
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
            this.LblQuestion = new MaterialSkin.Controls.MaterialLabel();
            this.PtbUser = new System.Windows.Forms.PictureBox();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PtbUser)).BeginInit();
            this.SuspendLayout();
            // 
            // LblQuestion
            // 
            this.LblQuestion.AutoSize = true;
            this.LblQuestion.Depth = 0;
            this.LblQuestion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblQuestion.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.LblQuestion.Location = new System.Drawing.Point(40, 0);
            this.LblQuestion.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblQuestion.Name = "LblQuestion";
            this.LblQuestion.Size = new System.Drawing.Size(1, 0);
            this.LblQuestion.TabIndex = 0;
            // 
            // PtbUser
            // 
            this.PtbUser.BackgroundImage = global::ChatBot_Calendar.Properties.Resources.User;
            this.PtbUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PtbUser.Dock = System.Windows.Forms.DockStyle.Left;
            this.PtbUser.Location = new System.Drawing.Point(0, 0);
            this.PtbUser.Name = "PtbUser";
            this.PtbUser.Size = new System.Drawing.Size(40, 36);
            this.PtbUser.TabIndex = 1;
            this.PtbUser.TabStop = false;
            // 
            // Timer
            // 
            this.Timer.Enabled = true;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // User
            // 
            this.AutoScroll = true;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.LblQuestion);
            this.Controls.Add(this.PtbUser);
            this.Name = "User";
            this.Size = new System.Drawing.Size(146, 36);
            this.Load += new System.EventHandler(this.User_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PtbUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel LblQuestion;
        private System.Windows.Forms.PictureBox PtbUser;
        private System.Windows.Forms.Timer Timer;
    }
}
