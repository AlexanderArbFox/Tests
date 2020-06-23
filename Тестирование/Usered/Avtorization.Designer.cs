namespace Тестирование
{
    partial class Avtorization
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Avtorization));
            this.CbVlan = new System.Windows.Forms.CheckBox();
            this.TBPar = new System.Windows.Forms.TextBox();
            this.TBLog = new System.Windows.Forms.TextBox();
            this.ParolLb = new System.Windows.Forms.Label();
            this.LogInLb = new System.Windows.Forms.Label();
            this.VhodBut = new System.Windows.Forms.Button();
            this.btnRegistration = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // CbVlan
            // 
            this.CbVlan.AutoSize = true;
            this.CbVlan.Location = new System.Drawing.Point(419, 172);
            this.CbVlan.Name = "CbVlan";
            this.CbVlan.Size = new System.Drawing.Size(121, 24);
            this.CbVlan.TabIndex = 12;
            this.CbVlan.Text = "Видимость";
            this.CbVlan.UseVisualStyleBackColor = true;
            this.CbVlan.CheckedChanged += new System.EventHandler(this.CbVlan_CheckedChanged);
            // 
            // TBPar
            // 
            this.TBPar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TBPar.Location = new System.Drawing.Point(194, 172);
            this.TBPar.Margin = new System.Windows.Forms.Padding(2);
            this.TBPar.Name = "TBPar";
            this.TBPar.Size = new System.Drawing.Size(208, 26);
            this.TBPar.TabIndex = 11;
            this.TBPar.UseSystemPasswordChar = true;
            // 
            // TBLog
            // 
            this.TBLog.Location = new System.Drawing.Point(194, 127);
            this.TBLog.Margin = new System.Windows.Forms.Padding(2);
            this.TBLog.Name = "TBLog";
            this.TBLog.Size = new System.Drawing.Size(208, 26);
            this.TBLog.TabIndex = 10;
            // 
            // ParolLb
            // 
            this.ParolLb.AutoSize = true;
            this.ParolLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ParolLb.Location = new System.Drawing.Point(70, 166);
            this.ParolLb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ParolLb.Name = "ParolLb";
            this.ParolLb.Size = new System.Drawing.Size(120, 32);
            this.ParolLb.TabIndex = 9;
            this.ParolLb.Text = "Пароль";
            // 
            // LogInLb
            // 
            this.LogInLb.AutoSize = true;
            this.LogInLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LogInLb.Location = new System.Drawing.Point(88, 120);
            this.LogInLb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LogInLb.Name = "LogInLb";
            this.LogInLb.Size = new System.Drawing.Size(99, 32);
            this.LogInLb.TabIndex = 8;
            this.LogInLb.Text = "Логин";
            // 
            // VhodBut
            // 
            this.VhodBut.BackColor = System.Drawing.Color.SkyBlue;
            this.VhodBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.VhodBut.Location = new System.Drawing.Point(210, 214);
            this.VhodBut.Margin = new System.Windows.Forms.Padding(2);
            this.VhodBut.Name = "VhodBut";
            this.VhodBut.Size = new System.Drawing.Size(177, 41);
            this.VhodBut.TabIndex = 7;
            this.VhodBut.Text = "Вход";
            this.VhodBut.UseVisualStyleBackColor = false;
            this.VhodBut.Click += new System.EventHandler(this.VhodBut_Click);
            // 
            // btnRegistration
            // 
            this.btnRegistration.BackColor = System.Drawing.Color.SkyBlue;
            this.btnRegistration.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRegistration.Location = new System.Drawing.Point(210, 260);
            this.btnRegistration.Name = "btnRegistration";
            this.btnRegistration.Size = new System.Drawing.Size(176, 41);
            this.btnRegistration.TabIndex = 13;
            this.btnRegistration.Text = "Регистрация";
            this.btnRegistration.UseVisualStyleBackColor = false;
            this.btnRegistration.Click += new System.EventHandler(this.btnRegistration_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Тестирование.Properties.Resources.MashaNewsStart_jpg_large;
            this.pictureBox1.Location = new System.Drawing.Point(536, 71);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(252, 315);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // Avtorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnRegistration);
            this.Controls.Add(this.CbVlan);
            this.Controls.Add(this.TBPar);
            this.Controls.Add(this.TBLog);
            this.Controls.Add(this.ParolLb);
            this.Controls.Add(this.LogInLb);
            this.Controls.Add(this.VhodBut);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Avtorization";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox CbVlan;
        private System.Windows.Forms.TextBox TBPar;
        private System.Windows.Forms.TextBox TBLog;
        private System.Windows.Forms.Label ParolLb;
        private System.Windows.Forms.Label LogInLb;
        private System.Windows.Forms.Button VhodBut;
        private System.Windows.Forms.Button btnRegistration;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}