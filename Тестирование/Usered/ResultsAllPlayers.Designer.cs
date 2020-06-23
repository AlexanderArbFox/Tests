namespace Тестирование
{
    partial class ResultsAllPlayers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResultsAllPlayers));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnBack = new System.Windows.Forms.ToolStripMenuItem();
            this.datagridSorts = new System.Windows.Forms.DataGridView();
            this.NameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ScoreCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NagradaCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patronymicDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датарожденияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loginDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parolDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rolessDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scoreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registrationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.proversDataSet = new Тестирование.ProversDataSet();
            this.registrationTableAdapter = new Тестирование.ProversDataSetTableAdapters.RegistrationTableAdapter();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSearchLog = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridSorts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.registrationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proversDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnBack});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1164, 33);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btnBack
            // 
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(73, 29);
            this.btnBack.Text = "Назад";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // datagridSorts
            // 
            this.datagridSorts.AutoGenerateColumns = false;
            this.datagridSorts.BackgroundColor = System.Drawing.Color.White;
            this.datagridSorts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridSorts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameCol,
            this.ScoreCol,
            this.NagradaCol,
            this.idDataGridViewTextBoxColumn,
            this.surnameDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.patronymicDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.датарожденияDataGridViewTextBoxColumn,
            this.loginDataGridViewTextBoxColumn,
            this.parolDataGridViewTextBoxColumn,
            this.rolessDataGridViewTextBoxColumn,
            this.scoreDataGridViewTextBoxColumn});
            this.datagridSorts.DataSource = this.registrationBindingSource;
            this.datagridSorts.Location = new System.Drawing.Point(51, 134);
            this.datagridSorts.Name = "datagridSorts";
            this.datagridSorts.ReadOnly = true;
            this.datagridSorts.RowTemplate.Height = 28;
            this.datagridSorts.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.datagridSorts.Size = new System.Drawing.Size(770, 485);
            this.datagridSorts.TabIndex = 4;
            // 
            // NameCol
            // 
            this.NameCol.HeaderText = "Имя";
            this.NameCol.Name = "NameCol";
            this.NameCol.ReadOnly = true;
            this.NameCol.Visible = false;
            this.NameCol.Width = 250;
            // 
            // ScoreCol
            // 
            this.ScoreCol.HeaderText = "Количество баллов";
            this.ScoreCol.Name = "ScoreCol";
            this.ScoreCol.ReadOnly = true;
            this.ScoreCol.Visible = false;
            // 
            // NagradaCol
            // 
            this.NagradaCol.HeaderText = "Награды";
            this.NagradaCol.Name = "NagradaCol";
            this.NagradaCol.ReadOnly = true;
            this.NagradaCol.Visible = false;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 70;
            // 
            // surnameDataGridViewTextBoxColumn
            // 
            this.surnameDataGridViewTextBoxColumn.DataPropertyName = "Surname";
            this.surnameDataGridViewTextBoxColumn.HeaderText = "Surname";
            this.surnameDataGridViewTextBoxColumn.Name = "surnameDataGridViewTextBoxColumn";
            this.surnameDataGridViewTextBoxColumn.ReadOnly = true;
            this.surnameDataGridViewTextBoxColumn.Visible = false;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Имя";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 180;
            // 
            // patronymicDataGridViewTextBoxColumn
            // 
            this.patronymicDataGridViewTextBoxColumn.DataPropertyName = "Patronymic";
            this.patronymicDataGridViewTextBoxColumn.HeaderText = "Patronymic";
            this.patronymicDataGridViewTextBoxColumn.Name = "patronymicDataGridViewTextBoxColumn";
            this.patronymicDataGridViewTextBoxColumn.ReadOnly = true;
            this.patronymicDataGridViewTextBoxColumn.Visible = false;
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "Gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "Gender";
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            this.genderDataGridViewTextBoxColumn.ReadOnly = true;
            this.genderDataGridViewTextBoxColumn.Visible = false;
            // 
            // датарожденияDataGridViewTextBoxColumn
            // 
            this.датарожденияDataGridViewTextBoxColumn.DataPropertyName = "Дата_рождения";
            this.датарожденияDataGridViewTextBoxColumn.HeaderText = "Дата_рождения";
            this.датарожденияDataGridViewTextBoxColumn.Name = "датарожденияDataGridViewTextBoxColumn";
            this.датарожденияDataGridViewTextBoxColumn.ReadOnly = true;
            this.датарожденияDataGridViewTextBoxColumn.Visible = false;
            // 
            // loginDataGridViewTextBoxColumn
            // 
            this.loginDataGridViewTextBoxColumn.DataPropertyName = "Login";
            this.loginDataGridViewTextBoxColumn.HeaderText = "Login";
            this.loginDataGridViewTextBoxColumn.Name = "loginDataGridViewTextBoxColumn";
            this.loginDataGridViewTextBoxColumn.ReadOnly = true;
            this.loginDataGridViewTextBoxColumn.Width = 150;
            // 
            // parolDataGridViewTextBoxColumn
            // 
            this.parolDataGridViewTextBoxColumn.DataPropertyName = "Parol";
            this.parolDataGridViewTextBoxColumn.HeaderText = "Parol";
            this.parolDataGridViewTextBoxColumn.Name = "parolDataGridViewTextBoxColumn";
            this.parolDataGridViewTextBoxColumn.ReadOnly = true;
            this.parolDataGridViewTextBoxColumn.Visible = false;
            // 
            // rolessDataGridViewTextBoxColumn
            // 
            this.rolessDataGridViewTextBoxColumn.DataPropertyName = "Roless";
            this.rolessDataGridViewTextBoxColumn.HeaderText = "Roless";
            this.rolessDataGridViewTextBoxColumn.Name = "rolessDataGridViewTextBoxColumn";
            this.rolessDataGridViewTextBoxColumn.ReadOnly = true;
            this.rolessDataGridViewTextBoxColumn.Visible = false;
            // 
            // scoreDataGridViewTextBoxColumn
            // 
            this.scoreDataGridViewTextBoxColumn.DataPropertyName = "Score";
            this.scoreDataGridViewTextBoxColumn.FillWeight = 130F;
            this.scoreDataGridViewTextBoxColumn.HeaderText = "Количество баллов";
            this.scoreDataGridViewTextBoxColumn.Name = "scoreDataGridViewTextBoxColumn";
            this.scoreDataGridViewTextBoxColumn.ReadOnly = true;
            this.scoreDataGridViewTextBoxColumn.Width = 70;
            // 
            // registrationBindingSource
            // 
            this.registrationBindingSource.DataMember = "Registration";
            this.registrationBindingSource.DataSource = this.proversDataSet;
            // 
            // proversDataSet
            // 
            this.proversDataSet.DataSetName = "ProversDataSet";
            this.proversDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // registrationTableAdapter
            // 
            this.registrationTableAdapter.ClearBeforeFill = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Тестирование.Properties.Resources.Кубок;
            this.pictureBox1.Location = new System.Drawing.Point(827, 134);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(320, 485);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(406, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Поиск по логину";
            // 
            // txtSearchLog
            // 
            this.txtSearchLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtSearchLog.Location = new System.Drawing.Point(51, 55);
            this.txtSearchLog.Name = "txtSearchLog";
            this.txtSearchLog.Size = new System.Drawing.Size(770, 30);
            this.txtSearchLog.TabIndex = 7;
            this.txtSearchLog.TextChanged += new System.EventHandler(this.txtSearchLog_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(12, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 32);
            this.label1.TabIndex = 8;
            this.label1.Text = "1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Silver;
            this.label3.Location = new System.Drawing.Point(12, 235);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 32);
            this.label3.TabIndex = 9;
            this.label3.Text = "2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.Chocolate;
            this.label4.Location = new System.Drawing.Point(12, 285);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 32);
            this.label4.TabIndex = 10;
            this.label4.Text = "3";
            // 
            // ResultsAllPlayers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1164, 650);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSearchLog);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.datagridSorts);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ResultsAllPlayers";
            this.Text = "Результаты всех игроков";
            this.Load += new System.EventHandler(this.ResultsAllPlayers_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridSorts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.registrationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proversDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btnBack;
        private System.Windows.Forms.DataGridView datagridSorts;
        private ProversDataSet proversDataSet;
        private System.Windows.Forms.BindingSource registrationBindingSource;
        private ProversDataSetTableAdapters.RegistrationTableAdapter registrationTableAdapter;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSearchLog;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn ScoreCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn NagradaCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patronymicDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датарожденияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn loginDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn parolDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rolessDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn scoreDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}