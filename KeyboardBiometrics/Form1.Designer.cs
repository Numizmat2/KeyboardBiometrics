namespace KeyboardBiometrics
{
    partial class KeyboardBiometrics
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainPanel = new System.Windows.Forms.Panel();
            this.savePatternButton = new System.Windows.Forms.Button();
            this.validatePatternButton = new System.Windows.Forms.Button();
            this.savePatternPanel = new System.Windows.Forms.Panel();
            this.validatePanel = new System.Windows.Forms.Panel();
            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.mainPanel.Controls.Add(this.validatePatternButton);
            this.mainPanel.Controls.Add(this.savePatternButton);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(800, 450);
            this.mainPanel.TabIndex = 0;
            // 
            // savePatternButton
            // 
            this.savePatternButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.savePatternButton.Location = new System.Drawing.Point(59, 93);
            this.savePatternButton.Name = "savePatternButton";
            this.savePatternButton.Size = new System.Drawing.Size(290, 271);
            this.savePatternButton.TabIndex = 0;
            this.savePatternButton.Text = "Save Pattern";
            this.savePatternButton.UseVisualStyleBackColor = true;
            this.savePatternButton.Click += new System.EventHandler(this.savePatternButton_Click);
            // 
            // validatePatternButton
            // 
            this.validatePatternButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.validatePatternButton.Location = new System.Drawing.Point(452, 93);
            this.validatePatternButton.Name = "validatePatternButton";
            this.validatePatternButton.Size = new System.Drawing.Size(290, 271);
            this.validatePatternButton.TabIndex = 1;
            this.validatePatternButton.Text = "Validate";
            this.validatePatternButton.UseVisualStyleBackColor = true;
            this.validatePatternButton.Click += new System.EventHandler(this.validatePatternButton_Click);
            // 
            // savePatternPanel
            // 
            this.savePatternPanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.savePatternPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.savePatternPanel.Location = new System.Drawing.Point(0, 0);
            this.savePatternPanel.Name = "savePatternPanel";
            this.savePatternPanel.Size = new System.Drawing.Size(800, 450);
            this.savePatternPanel.TabIndex = 2;
            this.savePatternPanel.Visible = false;
            // 
            // validatePanel
            // 
            this.validatePanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.validatePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.validatePanel.Location = new System.Drawing.Point(0, 0);
            this.validatePanel.Name = "validatePanel";
            this.validatePanel.Size = new System.Drawing.Size(800, 450);
            this.validatePanel.TabIndex = 3;
            this.validatePanel.Visible = false;
            // 
            // KeyboardBiometrics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.savePatternPanel);
            this.Controls.Add(this.validatePanel);
            this.Controls.Add(this.mainPanel);
            this.Name = "KeyboardBiometrics";
            this.Text = "KeyboardsBiometrics";
            this.mainPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Button validatePatternButton;
        private System.Windows.Forms.Button savePatternButton;
        private System.Windows.Forms.Panel savePatternPanel;
        private System.Windows.Forms.Panel validatePanel;
    }
}

