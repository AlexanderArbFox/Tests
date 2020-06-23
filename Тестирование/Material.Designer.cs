namespace Тестирование
{
    partial class Material
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Material));
            this.groupSelect = new System.Windows.Forms.GroupBox();
            this.btnPhisik = new System.Windows.Forms.Button();
            this.btnHistory = new System.Windows.Forms.Button();
            this.btnGeograph = new System.Windows.Forms.Button();
            this.btnAnimal = new System.Windows.Forms.Button();
            this.btnMults = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnBack = new System.Windows.Forms.ToolStripMenuItem();
            this.groupReading = new System.Windows.Forms.GroupBox();
            this.listInfo = new System.Windows.Forms.ListBox();
            this.btnRedactTxt = new System.Windows.Forms.Button();
            this.groupSelect.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupReading.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupSelect
            // 
            this.groupSelect.Controls.Add(this.btnRedactTxt);
            this.groupSelect.Controls.Add(this.btnPhisik);
            this.groupSelect.Controls.Add(this.btnHistory);
            this.groupSelect.Controls.Add(this.btnGeograph);
            this.groupSelect.Controls.Add(this.btnAnimal);
            this.groupSelect.Controls.Add(this.btnMults);
            this.groupSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupSelect.Location = new System.Drawing.Point(12, 57);
            this.groupSelect.Name = "groupSelect";
            this.groupSelect.Size = new System.Drawing.Size(256, 705);
            this.groupSelect.TabIndex = 0;
            this.groupSelect.TabStop = false;
            this.groupSelect.Text = "О чем вы хотите знать?";
            // 
            // btnPhisik
            // 
            this.btnPhisik.BackColor = System.Drawing.Color.SkyBlue;
            this.btnPhisik.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPhisik.Location = new System.Drawing.Point(6, 537);
            this.btnPhisik.Name = "btnPhisik";
            this.btnPhisik.Size = new System.Drawing.Size(244, 72);
            this.btnPhisik.TabIndex = 2;
            this.btnPhisik.Text = "Физика";
            this.btnPhisik.UseVisualStyleBackColor = false;
            this.btnPhisik.Click += new System.EventHandler(this.btnPhisik_Click);
            // 
            // btnHistory
            // 
            this.btnHistory.BackColor = System.Drawing.Color.SkyBlue;
            this.btnHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnHistory.Location = new System.Drawing.Point(6, 427);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Size = new System.Drawing.Size(244, 72);
            this.btnHistory.TabIndex = 4;
            this.btnHistory.Text = "История";
            this.btnHistory.UseVisualStyleBackColor = false;
            this.btnHistory.Click += new System.EventHandler(this.btnHistory_Click);
            // 
            // btnGeograph
            // 
            this.btnGeograph.BackColor = System.Drawing.Color.SkyBlue;
            this.btnGeograph.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnGeograph.Location = new System.Drawing.Point(6, 318);
            this.btnGeograph.Name = "btnGeograph";
            this.btnGeograph.Size = new System.Drawing.Size(244, 72);
            this.btnGeograph.TabIndex = 3;
            this.btnGeograph.Text = "География";
            this.btnGeograph.UseVisualStyleBackColor = false;
            this.btnGeograph.Click += new System.EventHandler(this.btnGeograph_Click);
            // 
            // btnAnimal
            // 
            this.btnAnimal.BackColor = System.Drawing.Color.SkyBlue;
            this.btnAnimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAnimal.Location = new System.Drawing.Point(6, 206);
            this.btnAnimal.Name = "btnAnimal";
            this.btnAnimal.Size = new System.Drawing.Size(244, 72);
            this.btnAnimal.TabIndex = 2;
            this.btnAnimal.Text = "Животные";
            this.btnAnimal.UseVisualStyleBackColor = false;
            this.btnAnimal.Click += new System.EventHandler(this.btnAnimal_Click);
            // 
            // btnMults
            // 
            this.btnMults.BackColor = System.Drawing.Color.SkyBlue;
            this.btnMults.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnMults.Location = new System.Drawing.Point(6, 86);
            this.btnMults.Name = "btnMults";
            this.btnMults.Size = new System.Drawing.Size(244, 72);
            this.btnMults.TabIndex = 1;
            this.btnMults.Text = "Мультики";
            this.btnMults.UseVisualStyleBackColor = false;
            this.btnMults.Click += new System.EventHandler(this.btnMults_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnBack});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1924, 33);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btnBack
            // 
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(73, 29);
            this.btnBack.Text = "Назад";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // groupReading
            // 
            this.groupReading.Controls.Add(this.listInfo);
            this.groupReading.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupReading.Location = new System.Drawing.Point(294, 57);
            this.groupReading.Name = "groupReading";
            this.groupReading.Size = new System.Drawing.Size(1598, 961);
            this.groupReading.TabIndex = 2;
            this.groupReading.TabStop = false;
            this.groupReading.Text = "Здесь много интересного";
            // 
            // listInfo
            // 
            this.listInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listInfo.FormattingEnabled = true;
            this.listInfo.ItemHeight = 29;
            this.listInfo.Location = new System.Drawing.Point(3, 31);
            this.listInfo.Name = "listInfo";
            this.listInfo.Size = new System.Drawing.Size(1592, 927);
            this.listInfo.TabIndex = 0;
            // 
            // btnRedactTxt
            // 
            this.btnRedactTxt.BackColor = System.Drawing.Color.SkyBlue;
            this.btnRedactTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRedactTxt.Location = new System.Drawing.Point(6, 625);
            this.btnRedactTxt.Name = "btnRedactTxt";
            this.btnRedactTxt.Size = new System.Drawing.Size(244, 66);
            this.btnRedactTxt.TabIndex = 1;
            this.btnRedactTxt.Text = "Редактировать ";
            this.btnRedactTxt.UseVisualStyleBackColor = false;
            this.btnRedactTxt.Click += new System.EventHandler(this.btnRedactTxt_Click);
            // 
            // Material
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1924, 1030);
            this.Controls.Add(this.groupReading);
            this.Controls.Add(this.groupSelect);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Material";
            this.Text = "Материал";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Material_Load);
            this.groupSelect.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupReading.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupSelect;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btnBack;
        private System.Windows.Forms.GroupBox groupReading;
        private System.Windows.Forms.ListBox listInfo;
        public System.Windows.Forms.Button btnAnimal;
        public System.Windows.Forms.Button btnMults;
        public System.Windows.Forms.Button btnPhisik;
        public System.Windows.Forms.Button btnHistory;
        public System.Windows.Forms.Button btnGeograph;
        private System.Windows.Forms.Button btnRedactTxt;
    }
}