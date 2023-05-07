namespace ChatBot_Calendar.Controls
{
    partial class Event
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Event));
            this.LblDate = new MaterialSkin.Controls.MaterialLabel();
            this.TxtDate = new MaterialSkin.Controls.MaterialTextBox();
            this.TxtTitle = new MaterialSkin.Controls.MaterialTextBox();
            this.LblTitle = new MaterialSkin.Controls.MaterialLabel();
            this.TxtDescription = new MaterialSkin.Controls.MaterialTextBox();
            this.LblDescription = new MaterialSkin.Controls.MaterialLabel();
            this.TxtComments = new MaterialSkin.Controls.MaterialTextBox();
            this.LblComments = new MaterialSkin.Controls.MaterialLabel();
            this.TxtHour = new MaterialSkin.Controls.MaterialTextBox();
            this.LblHour = new MaterialSkin.Controls.MaterialLabel();
            this.TxtLocation = new MaterialSkin.Controls.MaterialTextBox();
            this.LblLocation = new MaterialSkin.Controls.MaterialLabel();
            this.BtnSendEvent = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // LblDate
            // 
            this.LblDate.AutoSize = true;
            this.LblDate.Depth = 0;
            this.LblDate.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.LblDate.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.LblDate.Location = new System.Drawing.Point(25, 35);
            this.LblDate.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblDate.Name = "LblDate";
            this.LblDate.Size = new System.Drawing.Size(60, 24);
            this.LblDate.TabIndex = 0;
            this.LblDate.Text = "Fecha:";
            // 
            // TxtDate
            // 
            this.TxtDate.AnimateReadOnly = false;
            this.TxtDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtDate.Depth = 0;
            this.TxtDate.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TxtDate.LeadingIcon = null;
            this.TxtDate.Location = new System.Drawing.Point(26, 71);
            this.TxtDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtDate.MaxLength = 500;
            this.TxtDate.MouseState = MaterialSkin.MouseState.OUT;
            this.TxtDate.Multiline = false;
            this.TxtDate.Name = "TxtDate";
            this.TxtDate.Size = new System.Drawing.Size(247, 50);
            this.TxtDate.TabIndex = 1;
            this.TxtDate.Tag = "";
            this.TxtDate.Text = "";
            this.TxtDate.TrailingIcon = null;
            // 
            // TxtTitle
            // 
            this.TxtTitle.AnimateReadOnly = false;
            this.TxtTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtTitle.Depth = 0;
            this.TxtTitle.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TxtTitle.LeadingIcon = null;
            this.TxtTitle.Location = new System.Drawing.Point(310, 71);
            this.TxtTitle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtTitle.MaxLength = 500;
            this.TxtTitle.MouseState = MaterialSkin.MouseState.OUT;
            this.TxtTitle.Multiline = false;
            this.TxtTitle.Name = "TxtTitle";
            this.TxtTitle.Size = new System.Drawing.Size(434, 50);
            this.TxtTitle.TabIndex = 3;
            this.TxtTitle.Tag = "";
            this.TxtTitle.Text = "";
            this.TxtTitle.TrailingIcon = null;
            // 
            // LblTitle
            // 
            this.LblTitle.AutoSize = true;
            this.LblTitle.Depth = 0;
            this.LblTitle.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.LblTitle.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.LblTitle.Location = new System.Drawing.Point(309, 35);
            this.LblTitle.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(57, 24);
            this.LblTitle.TabIndex = 2;
            this.LblTitle.Text = "Título:";
            // 
            // TxtDescription
            // 
            this.TxtDescription.AnimateReadOnly = false;
            this.TxtDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtDescription.Depth = 0;
            this.TxtDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TxtDescription.LeadingIcon = null;
            this.TxtDescription.Location = new System.Drawing.Point(29, 196);
            this.TxtDescription.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtDescription.MaxLength = 500;
            this.TxtDescription.MouseState = MaterialSkin.MouseState.OUT;
            this.TxtDescription.Multiline = false;
            this.TxtDescription.Name = "TxtDescription";
            this.TxtDescription.Size = new System.Drawing.Size(715, 50);
            this.TxtDescription.TabIndex = 5;
            this.TxtDescription.Tag = "";
            this.TxtDescription.Text = "";
            this.TxtDescription.TrailingIcon = null;
            // 
            // LblDescription
            // 
            this.LblDescription.AutoSize = true;
            this.LblDescription.Depth = 0;
            this.LblDescription.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.LblDescription.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.LblDescription.Location = new System.Drawing.Point(28, 160);
            this.LblDescription.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblDescription.Name = "LblDescription";
            this.LblDescription.Size = new System.Drawing.Size(110, 24);
            this.LblDescription.TabIndex = 4;
            this.LblDescription.Text = "Descripción:";
            // 
            // TxtComments
            // 
            this.TxtComments.AnimateReadOnly = false;
            this.TxtComments.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtComments.Depth = 0;
            this.TxtComments.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TxtComments.LeadingIcon = null;
            this.TxtComments.Location = new System.Drawing.Point(29, 449);
            this.TxtComments.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtComments.MaxLength = 500;
            this.TxtComments.MouseState = MaterialSkin.MouseState.OUT;
            this.TxtComments.Multiline = false;
            this.TxtComments.Name = "TxtComments";
            this.TxtComments.Size = new System.Drawing.Size(715, 50);
            this.TxtComments.TabIndex = 11;
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
            this.LblComments.Location = new System.Drawing.Point(28, 413);
            this.LblComments.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblComments.Name = "LblComments";
            this.LblComments.Size = new System.Drawing.Size(120, 24);
            this.LblComments.TabIndex = 10;
            this.LblComments.Text = "Comentarios:";
            // 
            // TxtHour
            // 
            this.TxtHour.AnimateReadOnly = false;
            this.TxtHour.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtHour.Depth = 0;
            this.TxtHour.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TxtHour.LeadingIcon = null;
            this.TxtHour.Location = new System.Drawing.Point(310, 324);
            this.TxtHour.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtHour.MaxLength = 500;
            this.TxtHour.MouseState = MaterialSkin.MouseState.OUT;
            this.TxtHour.Multiline = false;
            this.TxtHour.Name = "TxtHour";
            this.TxtHour.Size = new System.Drawing.Size(434, 50);
            this.TxtHour.TabIndex = 9;
            this.TxtHour.Tag = "";
            this.TxtHour.Text = "";
            this.TxtHour.TrailingIcon = null;
            // 
            // LblHour
            // 
            this.LblHour.AutoSize = true;
            this.LblHour.Depth = 0;
            this.LblHour.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.LblHour.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.LblHour.Location = new System.Drawing.Point(309, 288);
            this.LblHour.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblHour.Name = "LblHour";
            this.LblHour.Size = new System.Drawing.Size(49, 24);
            this.LblHour.TabIndex = 8;
            this.LblHour.Text = "Hora:";
            // 
            // TxtLocation
            // 
            this.TxtLocation.AnimateReadOnly = false;
            this.TxtLocation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtLocation.Depth = 0;
            this.TxtLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TxtLocation.LeadingIcon = null;
            this.TxtLocation.Location = new System.Drawing.Point(26, 324);
            this.TxtLocation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtLocation.MaxLength = 500;
            this.TxtLocation.MouseState = MaterialSkin.MouseState.OUT;
            this.TxtLocation.Multiline = false;
            this.TxtLocation.Name = "TxtLocation";
            this.TxtLocation.Size = new System.Drawing.Size(247, 50);
            this.TxtLocation.TabIndex = 7;
            this.TxtLocation.Tag = "";
            this.TxtLocation.Text = "";
            this.TxtLocation.TrailingIcon = null;
            // 
            // LblLocation
            // 
            this.LblLocation.AutoSize = true;
            this.LblLocation.Depth = 0;
            this.LblLocation.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.LblLocation.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.LblLocation.Location = new System.Drawing.Point(25, 288);
            this.LblLocation.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblLocation.Name = "LblLocation";
            this.LblLocation.Size = new System.Drawing.Size(57, 24);
            this.LblLocation.TabIndex = 6;
            this.LblLocation.Text = "Lugar:";
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
            this.BtnSendEvent.Location = new System.Drawing.Point(32, 523);
            this.BtnSendEvent.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.BtnSendEvent.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnSendEvent.Name = "BtnSendEvent";
            this.BtnSendEvent.NoAccentTextColor = System.Drawing.Color.Empty;
            this.BtnSendEvent.Size = new System.Drawing.Size(45, 54);
            this.BtnSendEvent.TabIndex = 12;
            this.BtnSendEvent.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.BtnSendEvent.UseAccentColor = false;
            this.BtnSendEvent.UseVisualStyleBackColor = false;
            this.BtnSendEvent.Click += new System.EventHandler(this.BtnSendEvent_Click);
            // 
            // Event
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.BtnSendEvent);
            this.Controls.Add(this.TxtComments);
            this.Controls.Add(this.LblComments);
            this.Controls.Add(this.TxtHour);
            this.Controls.Add(this.LblHour);
            this.Controls.Add(this.TxtLocation);
            this.Controls.Add(this.LblLocation);
            this.Controls.Add(this.TxtDescription);
            this.Controls.Add(this.LblDescription);
            this.Controls.Add(this.TxtTitle);
            this.Controls.Add(this.LblTitle);
            this.Controls.Add(this.TxtDate);
            this.Controls.Add(this.LblDate);
            this.Name = "Event";
            this.Size = new System.Drawing.Size(776, 583);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel LblDate;
        public MaterialSkin.Controls.MaterialTextBox TxtDate;
        public MaterialSkin.Controls.MaterialTextBox TxtTitle;
        private MaterialSkin.Controls.MaterialLabel LblTitle;
        public MaterialSkin.Controls.MaterialTextBox TxtDescription;
        private MaterialSkin.Controls.MaterialLabel LblDescription;
        public MaterialSkin.Controls.MaterialTextBox TxtComments;
        private MaterialSkin.Controls.MaterialLabel LblComments;
        public MaterialSkin.Controls.MaterialTextBox TxtHour;
        private MaterialSkin.Controls.MaterialLabel LblHour;
        public MaterialSkin.Controls.MaterialTextBox TxtLocation;
        private MaterialSkin.Controls.MaterialLabel LblLocation;
        private MaterialSkin.Controls.MaterialButton BtnSendEvent;
    }
}
