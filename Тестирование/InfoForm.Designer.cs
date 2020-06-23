namespace Тестирование
{
    partial class InfoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InfoForm));
            this.listBoxInfo = new System.Windows.Forms.ListBox();
            this.pictureBoxATG = new System.Windows.Forms.PictureBox();
            this.lbSsl = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxATG)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxInfo
            // 
            this.listBoxInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBoxInfo.FormattingEnabled = true;
            this.listBoxInfo.ItemHeight = 26;
            this.listBoxInfo.Items.AddRange(new object[] {
            "Разработчик: Architecture Technology Game.",
            "Компания занимающаяся разработкой приложений и игр для пк."});
            this.listBoxInfo.Location = new System.Drawing.Point(2, 0);
            this.listBoxInfo.Name = "listBoxInfo";
            this.listBoxInfo.Size = new System.Drawing.Size(733, 784);
            this.listBoxInfo.TabIndex = 0;
            // 
            // pictureBoxATG
            // 
            this.pictureBoxATG.BackColor = System.Drawing.Color.White;
            this.pictureBoxATG.Image = global::Тестирование.Properties.Resources.Компания_диплом;
            this.pictureBoxATG.Location = new System.Drawing.Point(29, 117);
            this.pictureBoxATG.Name = "pictureBoxATG";
            this.pictureBoxATG.Size = new System.Drawing.Size(692, 531);
            this.pictureBoxATG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxATG.TabIndex = 1;
            this.pictureBoxATG.TabStop = false;
            // 
            // lbSsl
            // 
            this.lbSsl.AutoSize = true;
            this.lbSsl.BackColor = System.Drawing.Color.White;
            this.lbSsl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbSsl.ForeColor = System.Drawing.Color.Red;
            this.lbSsl.Location = new System.Drawing.Point(205, 72);
            this.lbSsl.Name = "lbSsl";
            this.lbSsl.Size = new System.Drawing.Size(245, 29);
            this.lbSsl.TabIndex = 2;
            this.lbSsl.Text = "Ссылка на наш сайт";
            this.lbSsl.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.SkyBlue;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnClose.Location = new System.Drawing.Point(135, 681);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(465, 45);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Закрыть";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // InfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 753);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lbSsl);
            this.Controls.Add(this.pictureBoxATG);
            this.Controls.Add(this.listBoxInfo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InfoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Информация о разработчике";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxATG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxInfo;
        private System.Windows.Forms.PictureBox pictureBoxATG;
        private System.Windows.Forms.Label lbSsl;
        private System.Windows.Forms.Button btnClose;
    }
}