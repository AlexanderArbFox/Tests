namespace Тестирование
{
    partial class RegistrationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrationForm));
            this.txtBoxSurname = new System.Windows.Forms.TextBox();
            this.txtBoxName = new System.Windows.Forms.TextBox();
            this.txtBoxPatronymic = new System.Windows.Forms.TextBox();
            this.txtBoxLogin = new System.Windows.Forms.TextBox();
            this.txtBoxParol = new System.Windows.Forms.TextBox();
            this.grBoxGender = new System.Windows.Forms.GroupBox();
            this.rbtnWomen = new System.Windows.Forms.RadioButton();
            this.rbtnMen = new System.Windows.Forms.RadioButton();
            this.lbSurname = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.lbPatronymic = new System.Windows.Forms.Label();
            this.lbDate = new System.Windows.Forms.Label();
            this.dateTP = new System.Windows.Forms.DateTimePicker();
            this.lbLogin = new System.Windows.Forms.Label();
            this.lbParol = new System.Windows.Forms.Label();
            this.btnStarted = new System.Windows.Forms.Button();
            this.btnStepBack = new System.Windows.Forms.Button();
            this.grBoxGender.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtBoxSurname
            // 
            this.txtBoxSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBoxSurname.Location = new System.Drawing.Point(159, 48);
            this.txtBoxSurname.Name = "txtBoxSurname";
            this.txtBoxSurname.Size = new System.Drawing.Size(396, 32);
            this.txtBoxSurname.TabIndex = 0;
            // 
            // txtBoxName
            // 
            this.txtBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBoxName.Location = new System.Drawing.Point(159, 95);
            this.txtBoxName.Name = "txtBoxName";
            this.txtBoxName.Size = new System.Drawing.Size(396, 32);
            this.txtBoxName.TabIndex = 1;
            // 
            // txtBoxPatronymic
            // 
            this.txtBoxPatronymic.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBoxPatronymic.Location = new System.Drawing.Point(159, 145);
            this.txtBoxPatronymic.Name = "txtBoxPatronymic";
            this.txtBoxPatronymic.Size = new System.Drawing.Size(396, 32);
            this.txtBoxPatronymic.TabIndex = 2;
            // 
            // txtBoxLogin
            // 
            this.txtBoxLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBoxLogin.Location = new System.Drawing.Point(159, 341);
            this.txtBoxLogin.Name = "txtBoxLogin";
            this.txtBoxLogin.Size = new System.Drawing.Size(396, 32);
            this.txtBoxLogin.TabIndex = 3;
            // 
            // txtBoxParol
            // 
            this.txtBoxParol.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBoxParol.Location = new System.Drawing.Point(159, 390);
            this.txtBoxParol.Name = "txtBoxParol";
            this.txtBoxParol.Size = new System.Drawing.Size(396, 32);
            this.txtBoxParol.TabIndex = 4;
            // 
            // grBoxGender
            // 
            this.grBoxGender.Controls.Add(this.rbtnWomen);
            this.grBoxGender.Controls.Add(this.rbtnMen);
            this.grBoxGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.grBoxGender.Location = new System.Drawing.Point(159, 197);
            this.grBoxGender.Name = "grBoxGender";
            this.grBoxGender.Size = new System.Drawing.Size(402, 74);
            this.grBoxGender.TabIndex = 5;
            this.grBoxGender.TabStop = false;
            this.grBoxGender.Text = "Пол";
            // 
            // rbtnWomen
            // 
            this.rbtnWomen.AutoSize = true;
            this.rbtnWomen.Location = new System.Drawing.Point(209, 31);
            this.rbtnWomen.Name = "rbtnWomen";
            this.rbtnWomen.Size = new System.Drawing.Size(127, 30);
            this.rbtnWomen.TabIndex = 1;
            this.rbtnWomen.TabStop = true;
            this.rbtnWomen.Text = "Женский";
            this.rbtnWomen.UseVisualStyleBackColor = true;
            // 
            // rbtnMen
            // 
            this.rbtnMen.AutoSize = true;
            this.rbtnMen.Location = new System.Drawing.Point(24, 31);
            this.rbtnMen.Name = "rbtnMen";
            this.rbtnMen.Size = new System.Drawing.Size(128, 30);
            this.rbtnMen.TabIndex = 0;
            this.rbtnMen.TabStop = true;
            this.rbtnMen.Text = "Мужской";
            this.rbtnMen.UseVisualStyleBackColor = true;
            // 
            // lbSurname
            // 
            this.lbSurname.AutoSize = true;
            this.lbSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbSurname.Location = new System.Drawing.Point(28, 45);
            this.lbSurname.Name = "lbSurname";
            this.lbSurname.Size = new System.Drawing.Size(108, 26);
            this.lbSurname.TabIndex = 6;
            this.lbSurname.Text = "Фамилия";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbName.Location = new System.Drawing.Point(50, 94);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(56, 26);
            this.lbName.TabIndex = 7;
            this.lbName.Text = "Имя";
            // 
            // lbPatronymic
            // 
            this.lbPatronymic.AutoSize = true;
            this.lbPatronymic.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbPatronymic.Location = new System.Drawing.Point(28, 145);
            this.lbPatronymic.Name = "lbPatronymic";
            this.lbPatronymic.Size = new System.Drawing.Size(108, 26);
            this.lbPatronymic.TabIndex = 8;
            this.lbPatronymic.Text = "Отчество";
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbDate.Location = new System.Drawing.Point(0, 288);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(161, 25);
            this.lbDate.TabIndex = 9;
            this.lbDate.Text = "Дата рождения";
            // 
            // dateTP
            // 
            this.dateTP.CustomFormat = "dd-MM-yyyy";
            this.dateTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTP.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTP.Location = new System.Drawing.Point(159, 288);
            this.dateTP.Name = "dateTP";
            this.dateTP.Size = new System.Drawing.Size(396, 32);
            this.dateTP.TabIndex = 10;
            // 
            // lbLogin
            // 
            this.lbLogin.AutoSize = true;
            this.lbLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbLogin.Location = new System.Drawing.Point(81, 341);
            this.lbLogin.Name = "lbLogin";
            this.lbLogin.Size = new System.Drawing.Size(72, 26);
            this.lbLogin.TabIndex = 11;
            this.lbLogin.Text = "Логин";
            // 
            // lbParol
            // 
            this.lbParol.AutoSize = true;
            this.lbParol.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbParol.Location = new System.Drawing.Point(64, 390);
            this.lbParol.Name = "lbParol";
            this.lbParol.Size = new System.Drawing.Size(89, 26);
            this.lbParol.TabIndex = 12;
            this.lbParol.Text = "Пароль";
            // 
            // btnStarted
            // 
            this.btnStarted.BackColor = System.Drawing.Color.SkyBlue;
            this.btnStarted.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnStarted.Location = new System.Drawing.Point(205, 456);
            this.btnStarted.Name = "btnStarted";
            this.btnStarted.Size = new System.Drawing.Size(290, 45);
            this.btnStarted.TabIndex = 13;
            this.btnStarted.Text = "Готово";
            this.btnStarted.UseVisualStyleBackColor = false;
            this.btnStarted.Click += new System.EventHandler(this.btnStarted_Click);
            // 
            // btnStepBack
            // 
            this.btnStepBack.BackColor = System.Drawing.Color.SkyBlue;
            this.btnStepBack.Location = new System.Drawing.Point(18, 588);
            this.btnStepBack.Name = "btnStepBack";
            this.btnStepBack.Size = new System.Drawing.Size(218, 38);
            this.btnStepBack.TabIndex = 14;
            this.btnStepBack.Text = "Отмена";
            this.btnStepBack.UseVisualStyleBackColor = false;
            this.btnStepBack.Click += new System.EventHandler(this.btnStepBack_Click);
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 647);
            this.Controls.Add(this.btnStepBack);
            this.Controls.Add(this.btnStarted);
            this.Controls.Add(this.lbParol);
            this.Controls.Add(this.lbLogin);
            this.Controls.Add(this.dateTP);
            this.Controls.Add(this.lbDate);
            this.Controls.Add(this.lbPatronymic);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.lbSurname);
            this.Controls.Add(this.grBoxGender);
            this.Controls.Add(this.txtBoxParol);
            this.Controls.Add(this.txtBoxLogin);
            this.Controls.Add(this.txtBoxPatronymic);
            this.Controls.Add(this.txtBoxName);
            this.Controls.Add(this.txtBoxSurname);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RegistrationForm";
            this.Text = "Регистрация";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.grBoxGender.ResumeLayout(false);
            this.grBoxGender.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxSurname;
        private System.Windows.Forms.TextBox txtBoxName;
        private System.Windows.Forms.TextBox txtBoxPatronymic;
        private System.Windows.Forms.TextBox txtBoxLogin;
        private System.Windows.Forms.TextBox txtBoxParol;
        private System.Windows.Forms.GroupBox grBoxGender;
        private System.Windows.Forms.RadioButton rbtnWomen;
        private System.Windows.Forms.RadioButton rbtnMen;
        private System.Windows.Forms.Label lbSurname;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbPatronymic;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.DateTimePicker dateTP;
        private System.Windows.Forms.Label lbLogin;
        private System.Windows.Forms.Label lbParol;
        private System.Windows.Forms.Button btnStarted;
        private System.Windows.Forms.Button btnStepBack;
    }
}