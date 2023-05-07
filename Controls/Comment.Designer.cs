namespace ChatBot_Calendar.Controls
{
    partial class Comment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Comment));
            this.BtnSendEvent = new MaterialSkin.Controls.MaterialButton();
            this.TxtComments = new MaterialSkin.Controls.MaterialTextBox();
            this.LblComments = new MaterialSkin.Controls.MaterialLabel();
            this.TxtId = new MaterialSkin.Controls.MaterialTextBox();
            this.LblId = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // BtnSendEvent
            // 
            this.BtnSendEvent.AutoSize = false;
            this.BtnSendEvent.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnSendEvent.BackColor = System.Drawing.Color.Transparent;
            this.BtnSendEvent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnSendEvent.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.BtnSendEvent.Depth = 0;
            this.BtnSendEvent.HighEmphasis = true;
            this.BtnSendEvent.Icon = ((System.Drawing.Image)(resources.GetObject("BtnSendEvent.Icon")));
            this.BtnSendEvent.Location = new System.Drawing.Point(36, 266);
            this.BtnSendEvent.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.BtnSendEvent.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnSendEvent.Name = "BtnSendEvent";
            this.BtnSendEvent.NoAccentTextColor = System.Drawing.Color.Empty;
            this.BtnSendEvent.Size = new System.Drawing.Size(45, 54);
            this.BtnSendEvent.TabIndex = 17;
            this.BtnSendEvent.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.BtnSendEvent.UseAccentColor = false;
            this.BtnSendEvent.UseVisualStyleBackColor = false;
            this.BtnSendEvent.Click += new System.EventHandler(this.BtnSendEvent_Click);
            // 
            // TxtComments
            // 
            this.TxtComments.AnimateReadOnly = false;
            this.TxtComments.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtComments.Depth = 0;
            this.TxtComments.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TxtComments.LeadingIcon = null;
            this.TxtComments.Location = new System.Drawing.Point(33, 192);
            this.TxtComments.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtComments.MaxLength = 500;
            this.TxtComments.MouseState = MaterialSkin.MouseState.OUT;
            this.TxtComments.Multiline = false;
            this.TxtComments.Name = "TxtComments";
            this.TxtComments.Size = new System.Drawing.Size(715, 50);
            this.TxtComments.TabIndex = 16;
            this.TxtComments.Tag = "";
            this.TxtComments.Text = "";
            this.TxtComments.TrailingIcon = null;
            // 
            // LblComments
            // 
            this.LblComments.AutoSize = true;
            this.LblComments.Depth = 0;
            this.LblComments.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.LblComments.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.LblComments.Location = new System.Drawing.Point(32, 156);
            this.LblComments.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblComments.Name = "LblComments";
            this.LblComments.Size = new System.Drawing.Size(120, 24);
            this.LblComments.TabIndex = 15;
            this.LblComments.Text = "Comentarios:";
            // 
            // TxtId
            // 
            this.TxtId.AnimateReadOnly = false;
            this.TxtId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtId.Depth = 0;
            this.TxtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TxtId.LeadingIcon = null;
            this.TxtId.Location = new System.Drawing.Point(33, 66);
            this.TxtId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtId.MaxLength = 500;
            this.TxtId.MouseState = MaterialSkin.MouseState.OUT;
            this.TxtId.Multiline = false;
            this.TxtId.Name = "TxtId";
            this.TxtId.Size = new System.Drawing.Size(247, 50);
            this.TxtId.TabIndex = 19;
            this.TxtId.Tag = "";
            this.TxtId.Text = "";
            this.TxtId.TrailingIcon = null;
            // 
            // LblId
            // 
            this.LblId.AutoSize = true;
            this.LblId.Depth = 0;
            this.LblId.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.LblId.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.LblId.Location = new System.Drawing.Point(32, 30);
            this.LblId.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblId.Name = "LblId";
            this.LblId.Size = new System.Drawing.Size(170, 24);
            this.LblId.TabIndex = 18;
            this.LblId.Text = "Número de evento:";
            // 
            // Comment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TxtId);
            this.Controls.Add(this.LblId);
            this.Controls.Add(this.BtnSendEvent);
            this.Controls.Add(this.TxtComments);
            this.Controls.Add(this.LblComments);
            this.Name = "Comment";
            this.Size = new System.Drawing.Size(776, 349);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton BtnSendEvent;
        public MaterialSkin.Controls.MaterialTextBox TxtComments;
        private MaterialSkin.Controls.MaterialLabel LblComments;
        public MaterialSkin.Controls.MaterialTextBox TxtId;
        private MaterialSkin.Controls.MaterialLabel LblId;
    }
}
