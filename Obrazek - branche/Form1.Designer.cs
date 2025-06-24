namespace Obrazek___branche
{
    partial class Form1
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
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.load = new System.Windows.Forms.Button();
            this.rotate = new System.Windows.Forms.Button();
            this.rb90 = new System.Windows.Forms.RadioButton();
            this.rb180 = new System.Windows.Forms.RadioButton();
            this.rb270 = new System.Windows.Forms.RadioButton();
            this.invert = new System.Windows.Forms.Button();
            this.ups = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(347, 53);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(366, 308);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // load
            // 
            this.load.Location = new System.Drawing.Point(166, 251);
            this.load.Name = "load";
            this.load.Size = new System.Drawing.Size(75, 23);
            this.load.TabIndex = 1;
            this.load.Text = "load";
            this.load.UseVisualStyleBackColor = true;
            this.load.Click += new System.EventHandler(this.load_Click);
            // 
            // rotate
            // 
            this.rotate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.rotate.Location = new System.Drawing.Point(166, 133);
            this.rotate.Name = "rotate";
            this.rotate.Size = new System.Drawing.Size(75, 23);
            this.rotate.TabIndex = 2;
            this.rotate.Text = "rotate";
            this.rotate.UseVisualStyleBackColor = false;
            this.rotate.Click += new System.EventHandler(this.rotate_Click);
            // 
            // rb90
            // 
            this.rb90.AutoSize = true;
            this.rb90.Location = new System.Drawing.Point(166, 36);
            this.rb90.Name = "rb90";
            this.rb90.Size = new System.Drawing.Size(37, 17);
            this.rb90.TabIndex = 3;
            this.rb90.TabStop = true;
            this.rb90.Text = "90";
            this.rb90.UseVisualStyleBackColor = true;
            // 
            // rb180
            // 
            this.rb180.AutoSize = true;
            this.rb180.Location = new System.Drawing.Point(166, 60);
            this.rb180.Name = "rb180";
            this.rb180.Size = new System.Drawing.Size(43, 17);
            this.rb180.TabIndex = 4;
            this.rb180.TabStop = true;
            this.rb180.Text = "180";
            this.rb180.UseVisualStyleBackColor = true;
            // 
            // rb270
            // 
            this.rb270.AutoSize = true;
            this.rb270.Location = new System.Drawing.Point(166, 84);
            this.rb270.Name = "rb270";
            this.rb270.Size = new System.Drawing.Size(43, 17);
            this.rb270.TabIndex = 5;
            this.rb270.TabStop = true;
            this.rb270.Text = "270";
            this.rb270.UseVisualStyleBackColor = true;
            // 
            // invert
            // 
            this.invert.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.invert.Location = new System.Drawing.Point(166, 163);
            this.invert.Name = "invert";
            this.invert.Size = new System.Drawing.Size(75, 23);
            this.invert.TabIndex = 6;
            this.invert.Text = "invert";
            this.invert.UseVisualStyleBackColor = false;
            this.invert.Click += new System.EventHandler(this.invert_Click);
            // 
            // ups
            // 
            this.ups.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ups.Location = new System.Drawing.Point(166, 193);
            this.ups.Name = "ups";
            this.ups.Size = new System.Drawing.Size(75, 23);
            this.ups.TabIndex = 7;
            this.ups.Text = "upsite down";
            this.ups.UseVisualStyleBackColor = false;
            this.ups.Click += new System.EventHandler(this.ups_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ups);
            this.Controls.Add(this.invert);
            this.Controls.Add(this.rb270);
            this.Controls.Add(this.rb180);
            this.Controls.Add(this.rb90);
            this.Controls.Add(this.rotate);
            this.Controls.Add(this.load);
            this.Controls.Add(this.pictureBox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button load;
        private System.Windows.Forms.Button rotate;
        private System.Windows.Forms.RadioButton rb90;
        private System.Windows.Forms.RadioButton rb180;
        private System.Windows.Forms.RadioButton rb270;
        private System.Windows.Forms.Button invert;
        private System.Windows.Forms.Button ups;
    }
}

