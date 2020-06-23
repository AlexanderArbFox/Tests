namespace Тестирование
{
    partial class MyNowResults
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyNowResults));
            this.lbTrue = new System.Windows.Forms.Label();
            this.lbFalse = new System.Windows.Forms.Label();
            this.lbLine = new System.Windows.Forms.Label();
            this.listBoxTrue = new System.Windows.Forms.ListBox();
            this.listBoxFalse = new System.Windows.Forms.ListBox();
            this.imageAlladin = new System.Windows.Forms.PictureBox();
            this.lbOverDown = new System.Windows.Forms.Label();
            this.btnMenu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imageAlladin)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTrue
            // 
            this.lbTrue.AutoSize = true;
            this.lbTrue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbTrue.Location = new System.Drawing.Point(24, 96);
            this.lbTrue.Name = "lbTrue";
            this.lbTrue.Size = new System.Drawing.Size(201, 25);
            this.lbTrue.TabIndex = 0;
            this.lbTrue.Text = "Правильные ответы";
            // 
            // lbFalse
            // 
            this.lbFalse.AutoSize = true;
            this.lbFalse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbFalse.Location = new System.Drawing.Point(24, 281);
            this.lbFalse.Name = "lbFalse";
            this.lbFalse.Size = new System.Drawing.Size(222, 25);
            this.lbFalse.TabIndex = 1;
            this.lbFalse.Text = "Неправильные ответы";
            // 
            // lbLine
            // 
            this.lbLine.AutoSize = true;
            this.lbLine.Location = new System.Drawing.Point(12, 184);
            this.lbLine.Name = "lbLine";
            this.lbLine.Size = new System.Drawing.Size(504, 20);
            this.lbLine.TabIndex = 2;
            this.lbLine.Text = "_______________________________________________________";
            // 
            // listBoxTrue
            // 
            this.listBoxTrue.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBoxTrue.FormattingEnabled = true;
            this.listBoxTrue.ItemHeight = 64;
            this.listBoxTrue.Location = new System.Drawing.Point(264, 58);
            this.listBoxTrue.Name = "listBoxTrue";
            this.listBoxTrue.Size = new System.Drawing.Size(167, 132);
            this.listBoxTrue.TabIndex = 3;
            // 
            // listBoxFalse
            // 
            this.listBoxFalse.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBoxFalse.FormattingEnabled = true;
            this.listBoxFalse.ItemHeight = 64;
            this.listBoxFalse.Location = new System.Drawing.Point(264, 257);
            this.listBoxFalse.Name = "listBoxFalse";
            this.listBoxFalse.Size = new System.Drawing.Size(167, 132);
            this.listBoxFalse.TabIndex = 4;
            // 
            // imageAlladin
            // 
            this.imageAlladin.Image = global::Тестирование.Properties.Resources.Алладин;
            this.imageAlladin.Location = new System.Drawing.Point(464, 43);
            this.imageAlladin.Name = "imageAlladin";
            this.imageAlladin.Size = new System.Drawing.Size(324, 346);
            this.imageAlladin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageAlladin.TabIndex = 5;
            this.imageAlladin.TabStop = false;
            // 
            // lbOverDown
            // 
            this.lbOverDown.AutoSize = true;
            this.lbOverDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbOverDown.Location = new System.Drawing.Point(258, 96);
            this.lbOverDown.Name = "lbOverDown";
            this.lbOverDown.Size = new System.Drawing.Size(0, 25);
            this.lbOverDown.TabIndex = 6;
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.SkyBlue;
            this.btnMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnMenu.Location = new System.Drawing.Point(243, 435);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(222, 50);
            this.btnMenu.TabIndex = 7;
            this.btnMenu.Text = "Меню";
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // MyNowResults
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(808, 508);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.lbOverDown);
            this.Controls.Add(this.imageAlladin);
            this.Controls.Add(this.listBoxFalse);
            this.Controls.Add(this.listBoxTrue);
            this.Controls.Add(this.lbLine);
            this.Controls.Add(this.lbFalse);
            this.Controls.Add(this.lbTrue);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MyNowResults";
            this.Text = "Результат";
            ((System.ComponentModel.ISupportInitialize)(this.imageAlladin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTrue;
        private System.Windows.Forms.Label lbLine;
        public System.Windows.Forms.ListBox listBoxTrue;
        public System.Windows.Forms.ListBox listBoxFalse;
        private System.Windows.Forms.PictureBox imageAlladin;
        public System.Windows.Forms.Label lbOverDown;
        public System.Windows.Forms.Label lbFalse;
        private System.Windows.Forms.Button btnMenu;
    }
}