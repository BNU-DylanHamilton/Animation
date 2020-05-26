namespace Animation
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnQuit = new System.Windows.Forms.Button();
            this.helicopterPictureBox = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.speedScrollBar = new System.Windows.Forms.HScrollBar();
            this.stopRadioButton = new System.Windows.Forms.RadioButton();
            this.startRadioButton = new System.Windows.Forms.RadioButton();
            this.pigPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.helicopterPictureBox)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pigPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.animatePicture);
            // 
            // btnQuit
            // 
            this.btnQuit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnQuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuit.Location = new System.Drawing.Point(492, 307);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(88, 43);
            this.btnQuit.TabIndex = 0;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.closeApplication);
            // 
            // helicopterPictureBox
            // 
            this.helicopterPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.helicopterPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.helicopterPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("helicopterPictureBox.Image")));
            this.helicopterPictureBox.Location = new System.Drawing.Point(128, 12);
            this.helicopterPictureBox.Name = "helicopterPictureBox";
            this.helicopterPictureBox.Size = new System.Drawing.Size(185, 135);
            this.helicopterPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.helicopterPictureBox.TabIndex = 4;
            this.helicopterPictureBox.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.speedScrollBar);
            this.panel2.Controls.Add(this.stopRadioButton);
            this.panel2.Controls.Add(this.startRadioButton);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.ForeColor = System.Drawing.Color.Red;
            this.panel2.Location = new System.Drawing.Point(12, 275);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(339, 75);
            this.panel2.TabIndex = 7;
            // 
            // speedScrollBar
            // 
            this.speedScrollBar.Location = new System.Drawing.Point(25, 41);
            this.speedScrollBar.Name = "speedScrollBar";
            this.speedScrollBar.Size = new System.Drawing.Size(288, 21);
            this.speedScrollBar.TabIndex = 3;
            this.speedScrollBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.setSpeed);
            // 
            // stopRadioButton
            // 
            this.stopRadioButton.AutoSize = true;
            this.stopRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stopRadioButton.Location = new System.Drawing.Point(140, 9);
            this.stopRadioButton.Name = "stopRadioButton";
            this.stopRadioButton.Size = new System.Drawing.Size(74, 29);
            this.stopRadioButton.TabIndex = 2;
            this.stopRadioButton.TabStop = true;
            this.stopRadioButton.Text = "Stop";
            this.stopRadioButton.UseVisualStyleBackColor = true;
            this.stopRadioButton.CheckedChanged += new System.EventHandler(this.stopTimer);
            // 
            // startRadioButton
            // 
            this.startRadioButton.AutoSize = true;
            this.startRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startRadioButton.Location = new System.Drawing.Point(11, 9);
            this.startRadioButton.Name = "startRadioButton";
            this.startRadioButton.Size = new System.Drawing.Size(74, 29);
            this.startRadioButton.TabIndex = 1;
            this.startRadioButton.TabStop = true;
            this.startRadioButton.Text = "Start";
            this.startRadioButton.UseVisualStyleBackColor = true;
            this.startRadioButton.CheckedChanged += new System.EventHandler(this.startTimer);
            // 
            // pigPictureBox
            // 
            this.pigPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.pigPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pigPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("pigPictureBox.Image")));
            this.pigPictureBox.Location = new System.Drawing.Point(319, 12);
            this.pigPictureBox.Name = "pigPictureBox";
            this.pigPictureBox.Size = new System.Drawing.Size(185, 135);
            this.pigPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pigPictureBox.TabIndex = 8;
            this.pigPictureBox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Animation.Properties.Resources.City1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(622, 362);
            this.Controls.Add(this.pigPictureBox);
            this.Controls.Add(this.helicopterPictureBox);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnQuit);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Come Fly with Me";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.loadForm);
            ((System.ComponentModel.ISupportInitialize)(this.helicopterPictureBox)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pigPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.PictureBox helicopterPictureBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton stopRadioButton;
        private System.Windows.Forms.RadioButton startRadioButton;
        private System.Windows.Forms.HScrollBar speedScrollBar;
        private System.Windows.Forms.PictureBox pigPictureBox;
    }
}

