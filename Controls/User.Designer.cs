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
            this.LblQuestion = new MaterialSkin.Controls.MaterialLabel();
            this.PtbUser = new System.Windows.Forms.PictureBox();
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
            this.LblQuestion.Size = new System.Drawing.Size(5, 19);
            this.LblQuestion.TabIndex = 0;
            this.LblQuestion.Text = ".";
            // 
            // PtbUser
            // 
            this.PtbUser.BackgroundImage = global::ChatBot_Calendar.Properties.Resources.User;
            this.PtbUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PtbUser.Dock = System.Windows.Forms.DockStyle.Left;
            this.PtbUser.Location = new System.Drawing.Point(0, 0);
            this.PtbUser.Name = "PtbUser";
            this.PtbUser.Size = new System.Drawing.Size(40, 38);
            this.PtbUser.TabIndex = 1;
            this.PtbUser.TabStop = false;
            // 
            // User
            // 
            this.AutoScroll = true;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.LblQuestion);
            this.Controls.Add(this.PtbUser);
            this.Name = "User";
            this.Size = new System.Drawing.Size(148, 38);
            ((System.ComponentModel.ISupportInitialize)(this.PtbUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel LblQuestion;
        private System.Windows.Forms.PictureBox PtbUser;
    }
}
