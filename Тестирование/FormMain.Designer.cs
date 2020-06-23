namespace Тестирование
{
    partial class FormApps
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormApps));
            this.btnStart = new System.Windows.Forms.Button();
            this.btnExitAvtoriz = new System.Windows.Forms.Button();
            this.menuMainf = new System.Windows.Forms.MenuStrip();
            this.btnResultMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.btnBonusMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.btnInfoMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.SettingsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.MusOffMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.timerText = new System.Windows.Forms.Timer(this.components);
            this.groupPozn = new System.Windows.Forms.GroupBox();
            this.lbNum4 = new System.Windows.Forms.Label();
            this.lbLn3 = new System.Windows.Forms.Label();
            this.lbNum3 = new System.Windows.Forms.Label();
            this.lbLn2 = new System.Windows.Forms.Label();
            this.lbNum2 = new System.Windows.Forms.Label();
            this.lbLn1 = new System.Windows.Forms.Label();
            this.lbPraviloPoved = new System.Windows.Forms.Label();
            this.listBoxMultiplication = new System.Windows.Forms.ListBox();
            this.pictureWolf = new System.Windows.Forms.PictureBox();
            this.btnGameEx = new System.Windows.Forms.Button();
            this.ImageScore = new System.Windows.Forms.PictureBox();
            this.lbScore = new System.Windows.Forms.Label();
            this.lblNameUse = new System.Windows.Forms.Label();
            this.btnMaterial = new System.Windows.Forms.Button();
            this.menuMainf.SuspendLayout();
            this.groupPozn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureWolf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageScore)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.SkyBlue;
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnStart.Location = new System.Drawing.Point(741, 177);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(387, 99);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Начать проверку";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click_1);
            // 
            // btnExitAvtoriz
            // 
            this.btnExitAvtoriz.BackColor = System.Drawing.Color.SkyBlue;
            this.btnExitAvtoriz.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnExitAvtoriz.Location = new System.Drawing.Point(741, 666);
            this.btnExitAvtoriz.Name = "btnExitAvtoriz";
            this.btnExitAvtoriz.Size = new System.Drawing.Size(183, 75);
            this.btnExitAvtoriz.TabIndex = 2;
            this.btnExitAvtoriz.Text = "Выйти из профиля";
            this.btnExitAvtoriz.UseVisualStyleBackColor = false;
            this.btnExitAvtoriz.Click += new System.EventHandler(this.btnExitAvtoriz_Click);
            // 
            // menuMainf
            // 
            this.menuMainf.BackColor = System.Drawing.Color.White;
            this.menuMainf.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuMainf.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuMainf.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnResultMenu,
            this.btnBonusMenu,
            this.btnInfoMenu,
            this.SettingsMenu});
            this.menuMainf.Location = new System.Drawing.Point(0, 0);
            this.menuMainf.Name = "menuMainf";
            this.menuMainf.Size = new System.Drawing.Size(1923, 36);
            this.menuMainf.TabIndex = 3;
            this.menuMainf.Text = "menuStrip1";
            // 
            // btnResultMenu
            // 
            this.btnResultMenu.BackColor = System.Drawing.Color.SkyBlue;
            this.btnResultMenu.Name = "btnResultMenu";
            this.btnResultMenu.Size = new System.Drawing.Size(125, 32);
            this.btnResultMenu.Text = "Результаты";
            this.btnResultMenu.Click += new System.EventHandler(this.результатыToolStripMenuItem_Click);
            // 
            // btnBonusMenu
            // 
            this.btnBonusMenu.BackColor = System.Drawing.Color.SkyBlue;
            this.btnBonusMenu.Name = "btnBonusMenu";
            this.btnBonusMenu.Size = new System.Drawing.Size(138, 32);
            this.btnBonusMenu.Text = "Достижения";
            this.btnBonusMenu.Click += new System.EventHandler(this.бонусыToolStripMenuItem_Click);
            // 
            // btnInfoMenu
            // 
            this.btnInfoMenu.BackColor = System.Drawing.Color.SkyBlue;
            this.btnInfoMenu.Name = "btnInfoMenu";
            this.btnInfoMenu.Size = new System.Drawing.Size(297, 32);
            this.btnInfoMenu.Text = "Информация о разработчике";
            this.btnInfoMenu.Click += new System.EventHandler(this.информацияОРазработчикеToolStripMenuItem_Click);
            // 
            // SettingsMenu
            // 
            this.SettingsMenu.BackColor = System.Drawing.Color.SkyBlue;
            this.SettingsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MusOffMenu});
            this.SettingsMenu.Name = "SettingsMenu";
            this.SettingsMenu.Size = new System.Drawing.Size(123, 32);
            this.SettingsMenu.Text = "Настройки";
            // 
            // MusOffMenu
            // 
            this.MusOffMenu.BackColor = System.Drawing.Color.SkyBlue;
            this.MusOffMenu.Name = "MusOffMenu";
            this.MusOffMenu.Size = new System.Drawing.Size(269, 32);
            this.MusOffMenu.Text = "Отключить музыку";
            this.MusOffMenu.Click += new System.EventHandler(this.MusOffMenu_Click);
            // 
            // timerText
            // 
            this.timerText.Enabled = true;
            this.timerText.Interval = 400;
            this.timerText.Tick += new System.EventHandler(this.timerText_Tick);
            // 
            // groupPozn
            // 
            this.groupPozn.Controls.Add(this.lbNum4);
            this.groupPozn.Controls.Add(this.lbLn3);
            this.groupPozn.Controls.Add(this.lbNum3);
            this.groupPozn.Controls.Add(this.lbLn2);
            this.groupPozn.Controls.Add(this.lbNum2);
            this.groupPozn.Controls.Add(this.lbLn1);
            this.groupPozn.Controls.Add(this.lbPraviloPoved);
            this.groupPozn.Controls.Add(this.listBoxMultiplication);
            this.groupPozn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupPozn.Location = new System.Drawing.Point(1265, 216);
            this.groupPozn.Name = "groupPozn";
            this.groupPozn.Size = new System.Drawing.Size(596, 465);
            this.groupPozn.TabIndex = 6;
            this.groupPozn.TabStop = false;
            this.groupPozn.Text = "Страничка познания";
            // 
            // lbNum4
            // 
            this.lbNum4.AutoSize = true;
            this.lbNum4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbNum4.Location = new System.Drawing.Point(17, 400);
            this.lbNum4.Name = "lbNum4";
            this.lbNum4.Size = new System.Drawing.Size(0, 25);
            this.lbNum4.TabIndex = 19;
            // 
            // lbLn3
            // 
            this.lbLn3.AutoSize = true;
            this.lbLn3.Location = new System.Drawing.Point(6, 346);
            this.lbLn3.Name = "lbLn3";
            this.lbLn3.Size = new System.Drawing.Size(331, 25);
            this.lbLn3.TabIndex = 18;
            this.lbLn3.Text = "_____________________________";
            // 
            // lbNum3
            // 
            this.lbNum3.AutoSize = true;
            this.lbNum3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbNum3.Location = new System.Drawing.Point(17, 285);
            this.lbNum3.Name = "lbNum3";
            this.lbNum3.Size = new System.Drawing.Size(0, 25);
            this.lbNum3.TabIndex = 17;
            // 
            // lbLn2
            // 
            this.lbLn2.AutoSize = true;
            this.lbLn2.Location = new System.Drawing.Point(6, 221);
            this.lbLn2.Name = "lbLn2";
            this.lbLn2.Size = new System.Drawing.Size(331, 25);
            this.lbLn2.TabIndex = 16;
            this.lbLn2.Text = "_____________________________";
            // 
            // lbNum2
            // 
            this.lbNum2.AutoSize = true;
            this.lbNum2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbNum2.Location = new System.Drawing.Point(17, 166);
            this.lbNum2.Name = "lbNum2";
            this.lbNum2.Size = new System.Drawing.Size(0, 25);
            this.lbNum2.TabIndex = 15;
            // 
            // lbLn1
            // 
            this.lbLn1.AutoSize = true;
            this.lbLn1.Location = new System.Drawing.Point(6, 102);
            this.lbLn1.Name = "lbLn1";
            this.lbLn1.Size = new System.Drawing.Size(331, 25);
            this.lbLn1.TabIndex = 14;
            this.lbLn1.Text = "_____________________________";
            // 
            // lbPraviloPoved
            // 
            this.lbPraviloPoved.AutoSize = true;
            this.lbPraviloPoved.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbPraviloPoved.Location = new System.Drawing.Point(17, 42);
            this.lbPraviloPoved.Name = "lbPraviloPoved";
            this.lbPraviloPoved.Size = new System.Drawing.Size(0, 25);
            this.lbPraviloPoved.TabIndex = 13;
            // 
            // listBoxMultiplication
            // 
            this.listBoxMultiplication.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxMultiplication.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBoxMultiplication.FormattingEnabled = true;
            this.listBoxMultiplication.ItemHeight = 29;
            this.listBoxMultiplication.Location = new System.Drawing.Point(369, 11);
            this.listBoxMultiplication.Name = "listBoxMultiplication";
            this.listBoxMultiplication.Size = new System.Drawing.Size(227, 468);
            this.listBoxMultiplication.TabIndex = 9;
            this.listBoxMultiplication.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.listBoxMultiplication_DrawItem);
            // 
            // pictureWolf
            // 
            this.pictureWolf.Image = global::Тестирование.Properties.Resources.Волк;
            this.pictureWolf.Location = new System.Drawing.Point(0, 108);
            this.pictureWolf.Name = "pictureWolf";
            this.pictureWolf.Size = new System.Drawing.Size(630, 633);
            this.pictureWolf.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureWolf.TabIndex = 5;
            this.pictureWolf.TabStop = false;
            // 
            // btnGameEx
            // 
            this.btnGameEx.BackColor = System.Drawing.Color.SkyBlue;
            this.btnGameEx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnGameEx.Location = new System.Drawing.Point(945, 666);
            this.btnGameEx.Name = "btnGameEx";
            this.btnGameEx.Size = new System.Drawing.Size(183, 75);
            this.btnGameEx.TabIndex = 7;
            this.btnGameEx.Text = "Выйти из игры";
            this.btnGameEx.UseVisualStyleBackColor = false;
            this.btnGameEx.Click += new System.EventHandler(this.btnGameEx_Click);
            // 
            // ImageScore
            // 
            this.ImageScore.Image = global::Тестирование.Properties.Resources.Бонусы;
            this.ImageScore.Location = new System.Drawing.Point(1667, 49);
            this.ImageScore.Name = "ImageScore";
            this.ImageScore.Size = new System.Drawing.Size(149, 136);
            this.ImageScore.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImageScore.TabIndex = 8;
            this.ImageScore.TabStop = false;
            this.ImageScore.Visible = false;
            // 
            // lbScore
            // 
            this.lbScore.AutoSize = true;
            this.lbScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbScore.Location = new System.Drawing.Point(1459, 59);
            this.lbScore.Name = "lbScore";
            this.lbScore.Size = new System.Drawing.Size(0, 108);
            this.lbScore.TabIndex = 9;
            // 
            // lblNameUse
            // 
            this.lblNameUse.AutoSize = true;
            this.lblNameUse.Location = new System.Drawing.Point(1217, 63);
            this.lblNameUse.Name = "lblNameUse";
            this.lblNameUse.Size = new System.Drawing.Size(0, 20);
            this.lblNameUse.TabIndex = 10;
            // 
            // btnMaterial
            // 
            this.btnMaterial.BackColor = System.Drawing.Color.SkyBlue;
            this.btnMaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnMaterial.Location = new System.Drawing.Point(741, 407);
            this.btnMaterial.Name = "btnMaterial";
            this.btnMaterial.Size = new System.Drawing.Size(387, 99);
            this.btnMaterial.TabIndex = 11;
            this.btnMaterial.Text = "Узнайте новое о мире";
            this.btnMaterial.UseVisualStyleBackColor = false;
            this.btnMaterial.Click += new System.EventHandler(this.btnMaterial_Click);
            // 
            // FormApps
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1923, 952);
            this.Controls.Add(this.btnMaterial);
            this.Controls.Add(this.lblNameUse);
            this.Controls.Add(this.lbScore);
            this.Controls.Add(this.ImageScore);
            this.Controls.Add(this.btnGameEx);
            this.Controls.Add(this.groupPozn);
            this.Controls.Add(this.pictureWolf);
            this.Controls.Add(this.btnExitAvtoriz);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.menuMainf);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuMainf;
            this.Name = "FormApps";
            this.Text = "Вопрошайка";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormApps_FormClosing);
            this.Load += new System.EventHandler(this.FormApps_Load);
            this.menuMainf.ResumeLayout(false);
            this.menuMainf.PerformLayout();
            this.groupPozn.ResumeLayout(false);
            this.groupPozn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureWolf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageScore)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuMainf;
        private System.Windows.Forms.ToolStripMenuItem btnResultMenu;
        private System.Windows.Forms.ToolStripMenuItem btnBonusMenu;
        private System.Windows.Forms.ToolStripMenuItem btnInfoMenu;
        private System.Windows.Forms.PictureBox pictureWolf;
        private System.Windows.Forms.Timer timerText;
        private System.Windows.Forms.GroupBox groupPozn;
        private System.Windows.Forms.ListBox listBoxMultiplication;
        private System.Windows.Forms.ToolStripMenuItem SettingsMenu;
        public System.Windows.Forms.ToolStripMenuItem MusOffMenu;
        public System.Windows.Forms.Button btnStart;
        public System.Windows.Forms.Button btnExitAvtoriz;
        public System.Windows.Forms.Button btnGameEx;
        private System.Windows.Forms.Label lbPraviloPoved;
        private System.Windows.Forms.PictureBox ImageScore;
        public System.Windows.Forms.Label lblNameUse;
        public System.Windows.Forms.Button btnMaterial;
        public System.Windows.Forms.Label lbScore;
        private System.Windows.Forms.Label lbLn1;
        private System.Windows.Forms.Label lbNum2;
        private System.Windows.Forms.Label lbNum4;
        private System.Windows.Forms.Label lbLn3;
        private System.Windows.Forms.Label lbNum3;
        private System.Windows.Forms.Label lbLn2;
    }
}

