﻿namespace ChatBot_Calendar
{
    partial class Main
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.TcOptions = new MaterialSkin.Controls.MaterialTabControl();
            this.Home = new System.Windows.Forms.TabPage();
            this.TlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.TlpQuestions = new System.Windows.Forms.TableLayoutPanel();
            this.PnlQuestions = new System.Windows.Forms.Panel();
            this.TlpQuestionsDivisor = new System.Windows.Forms.TableLayoutPanel();
            this.BtnQuestions = new MaterialSkin.Controls.MaterialButton();
            this.BtnClear = new MaterialSkin.Controls.MaterialButton();
            this.TxtQuestions = new MaterialSkin.Controls.MaterialTextBox();
            this.PnlResults = new System.Windows.Forms.Panel();
            this.Settings = new System.Windows.Forms.TabPage();
            this.ImageList = new System.Windows.Forms.ImageList(this.components);
            this.TcOptions.SuspendLayout();
            this.Home.SuspendLayout();
            this.TlpMain.SuspendLayout();
            this.TlpQuestions.SuspendLayout();
            this.TlpQuestionsDivisor.SuspendLayout();
            this.SuspendLayout();
            // 
            // TcOptions
            // 
            this.TcOptions.Controls.Add(this.Home);
            this.TcOptions.Controls.Add(this.Settings);
            this.TcOptions.Depth = 0;
            this.TcOptions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TcOptions.ImageList = this.ImageList;
            this.TcOptions.Location = new System.Drawing.Point(3, 64);
            this.TcOptions.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TcOptions.MouseState = MaterialSkin.MouseState.HOVER;
            this.TcOptions.Multiline = true;
            this.TcOptions.Name = "TcOptions";
            this.TcOptions.SelectedIndex = 0;
            this.TcOptions.Size = new System.Drawing.Size(1394, 634);
            this.TcOptions.TabIndex = 0;
            // 
            // Home
            // 
            this.Home.Controls.Add(this.TlpMain);
            this.Home.ImageKey = "Home.png";
            this.Home.Location = new System.Drawing.Point(4, 39);
            this.Home.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Home.Name = "Home";
            this.Home.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Home.Size = new System.Drawing.Size(1386, 591);
            this.Home.TabIndex = 0;
            this.Home.Text = "Principal";
            this.Home.UseVisualStyleBackColor = true;
            // 
            // TlpMain
            // 
            this.TlpMain.ColumnCount = 2;
            this.TlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 56.88406F));
            this.TlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.11594F));
            this.TlpMain.Controls.Add(this.TlpQuestions, 1, 0);
            this.TlpMain.Controls.Add(this.PnlResults, 0, 0);
            this.TlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TlpMain.Location = new System.Drawing.Point(3, 2);
            this.TlpMain.Name = "TlpMain";
            this.TlpMain.RowCount = 1;
            this.TlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TlpMain.Size = new System.Drawing.Size(1380, 587);
            this.TlpMain.TabIndex = 0;
            // 
            // TlpQuestions
            // 
            this.TlpQuestions.AutoSize = true;
            this.TlpQuestions.BackColor = System.Drawing.Color.Transparent;
            this.TlpQuestions.ColumnCount = 1;
            this.TlpQuestions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TlpQuestions.Controls.Add(this.PnlQuestions, 0, 0);
            this.TlpQuestions.Controls.Add(this.TlpQuestionsDivisor, 0, 1);
            this.TlpQuestions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TlpQuestions.Location = new System.Drawing.Point(788, 2);
            this.TlpQuestions.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TlpQuestions.Name = "TlpQuestions";
            this.TlpQuestions.RowCount = 2;
            this.TlpQuestions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TlpQuestions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.TlpQuestions.Size = new System.Drawing.Size(589, 583);
            this.TlpQuestions.TabIndex = 0;
            // 
            // PnlQuestions
            // 
            this.PnlQuestions.AutoScroll = true;
            this.PnlQuestions.AutoSize = true;
            this.PnlQuestions.BackColor = System.Drawing.Color.White;
            this.PnlQuestions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnlQuestions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlQuestions.Location = new System.Drawing.Point(3, 2);
            this.PnlQuestions.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PnlQuestions.Name = "PnlQuestions";
            this.PnlQuestions.Padding = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.PnlQuestions.Size = new System.Drawing.Size(583, 509);
            this.PnlQuestions.TabIndex = 0;
            // 
            // TlpQuestionsDivisor
            // 
            this.TlpQuestionsDivisor.ColumnCount = 3;
            this.TlpQuestionsDivisor.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TlpQuestionsDivisor.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.TlpQuestionsDivisor.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.TlpQuestionsDivisor.Controls.Add(this.BtnQuestions, 1, 0);
            this.TlpQuestionsDivisor.Controls.Add(this.BtnClear, 2, 0);
            this.TlpQuestionsDivisor.Controls.Add(this.TxtQuestions, 0, 0);
            this.TlpQuestionsDivisor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TlpQuestionsDivisor.Location = new System.Drawing.Point(3, 515);
            this.TlpQuestionsDivisor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TlpQuestionsDivisor.Name = "TlpQuestionsDivisor";
            this.TlpQuestionsDivisor.RowCount = 1;
            this.TlpQuestionsDivisor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TlpQuestionsDivisor.Size = new System.Drawing.Size(583, 66);
            this.TlpQuestionsDivisor.TabIndex = 0;
            // 
            // BtnQuestions
            // 
            this.BtnQuestions.AutoSize = false;
            this.BtnQuestions.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnQuestions.BackColor = System.Drawing.Color.Transparent;
            this.BtnQuestions.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnQuestions.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.BtnQuestions.Depth = 0;
            this.BtnQuestions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnQuestions.HighEmphasis = true;
            this.BtnQuestions.Icon = ((System.Drawing.Image)(resources.GetObject("BtnQuestions.Icon")));
            this.BtnQuestions.Location = new System.Drawing.Point(478, 6);
            this.BtnQuestions.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.BtnQuestions.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnQuestions.Name = "BtnQuestions";
            this.BtnQuestions.NoAccentTextColor = System.Drawing.Color.Empty;
            this.BtnQuestions.Size = new System.Drawing.Size(45, 54);
            this.BtnQuestions.TabIndex = 1;
            this.BtnQuestions.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.BtnQuestions.UseAccentColor = false;
            this.BtnQuestions.UseVisualStyleBackColor = false;
            this.BtnQuestions.Click += new System.EventHandler(this.BtnQuestions_Click);
            // 
            // BtnClear
            // 
            this.BtnClear.AutoSize = false;
            this.BtnClear.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnClear.BackColor = System.Drawing.Color.Transparent;
            this.BtnClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnClear.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.BtnClear.Depth = 0;
            this.BtnClear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnClear.HighEmphasis = true;
            this.BtnClear.Icon = ((System.Drawing.Image)(resources.GetObject("BtnClear.Icon")));
            this.BtnClear.Location = new System.Drawing.Point(533, 6);
            this.BtnClear.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.BtnClear.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.NoAccentTextColor = System.Drawing.Color.Empty;
            this.BtnClear.Size = new System.Drawing.Size(45, 54);
            this.BtnClear.TabIndex = 2;
            this.BtnClear.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.BtnClear.UseAccentColor = false;
            this.BtnClear.UseVisualStyleBackColor = false;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // TxtQuestions
            // 
            this.TxtQuestions.AnimateReadOnly = false;
            this.TxtQuestions.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtQuestions.Depth = 0;
            this.TxtQuestions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtQuestions.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TxtQuestions.LeadingIcon = null;
            this.TxtQuestions.Location = new System.Drawing.Point(3, 2);
            this.TxtQuestions.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtQuestions.MaxLength = 500;
            this.TxtQuestions.MouseState = MaterialSkin.MouseState.OUT;
            this.TxtQuestions.Multiline = false;
            this.TxtQuestions.Name = "TxtQuestions";
            this.TxtQuestions.Size = new System.Drawing.Size(467, 50);
            this.TxtQuestions.TabIndex = 0;
            this.TxtQuestions.Tag = "";
            this.TxtQuestions.Text = "";
            this.TxtQuestions.TrailingIcon = null;
            this.TxtQuestions.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtQuestions_KeyDown);
            // 
            // PnlResults
            // 
            this.PnlResults.AutoScroll = true;
            this.PnlResults.AutoSize = true;
            this.PnlResults.BackColor = System.Drawing.Color.White;
            this.PnlResults.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnlResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlResults.Location = new System.Drawing.Point(3, 2);
            this.PnlResults.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PnlResults.Name = "PnlResults";
            this.PnlResults.Size = new System.Drawing.Size(779, 583);
            this.PnlResults.TabIndex = 2;
            // 
            // Settings
            // 
            this.Settings.ImageKey = "Settings.png";
            this.Settings.Location = new System.Drawing.Point(4, 39);
            this.Settings.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Settings.Name = "Settings";
            this.Settings.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Settings.Size = new System.Drawing.Size(1386, 591);
            this.Settings.TabIndex = 1;
            this.Settings.Text = "Configuración";
            this.Settings.UseVisualStyleBackColor = true;
            // 
            // ImageList
            // 
            this.ImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImageList.ImageStream")));
            this.ImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.ImageList.Images.SetKeyName(0, "Home.png");
            this.ImageList.Images.SetKeyName(1, "Settings.png");
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1400, 700);
            this.Controls.Add(this.TcOptions);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.TcOptions;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Main";
            this.Padding = new System.Windows.Forms.Padding(3, 64, 3, 2);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChatBot Calendar";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.TcOptions.ResumeLayout(false);
            this.Home.ResumeLayout(false);
            this.TlpMain.ResumeLayout(false);
            this.TlpMain.PerformLayout();
            this.TlpQuestions.ResumeLayout(false);
            this.TlpQuestions.PerformLayout();
            this.TlpQuestionsDivisor.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl TcOptions;
        private System.Windows.Forms.TabPage Home;
        private System.Windows.Forms.TabPage Settings;
        private System.Windows.Forms.ImageList ImageList;
        private System.Windows.Forms.Panel PnlResults;
        private System.Windows.Forms.TableLayoutPanel TlpQuestions;
        private System.Windows.Forms.TableLayoutPanel TlpQuestionsDivisor;
        private MaterialSkin.Controls.MaterialButton BtnQuestions;
        private MaterialSkin.Controls.MaterialButton BtnClear;
        public System.Windows.Forms.Panel PnlQuestions;
        public MaterialSkin.Controls.MaterialTextBox TxtQuestions;
        private System.Windows.Forms.TableLayoutPanel TlpMain;
    }
}

