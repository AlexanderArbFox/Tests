namespace Тестирование
{
    partial class Tests
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tests));
            this.rbtnFirst = new System.Windows.Forms.RadioButton();
            this.rbtnSecond = new System.Windows.Forms.RadioButton();
            this.rbtnThird = new System.Windows.Forms.RadioButton();
            this.rbtnFourth = new System.Windows.Forms.RadioButton();
            this.btnNextQustions = new System.Windows.Forms.Button();
            this.btnEnds = new System.Windows.Forms.Button();
            this.grBoxQuestions = new System.Windows.Forms.GroupBox();
            this.timeStart = new System.Windows.Forms.Timer(this.components);
            this.lbTimeStart = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lbal = new System.Windows.Forms.Label();
            this.lbQuestr = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbIsQuestion = new System.Windows.Forms.Label();
            this.grBoxQuestions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // rbtnFirst
            // 
            this.rbtnFirst.AutoSize = true;
            this.rbtnFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbtnFirst.Location = new System.Drawing.Point(27, 39);
            this.rbtnFirst.Name = "rbtnFirst";
            this.rbtnFirst.Size = new System.Drawing.Size(48, 29);
            this.rbtnFirst.TabIndex = 0;
            this.rbtnFirst.TabStop = true;
            this.rbtnFirst.Text = "1";
            this.rbtnFirst.UseVisualStyleBackColor = true;
            // 
            // rbtnSecond
            // 
            this.rbtnSecond.AutoSize = true;
            this.rbtnSecond.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbtnSecond.Location = new System.Drawing.Point(27, 102);
            this.rbtnSecond.Name = "rbtnSecond";
            this.rbtnSecond.Size = new System.Drawing.Size(48, 29);
            this.rbtnSecond.TabIndex = 1;
            this.rbtnSecond.TabStop = true;
            this.rbtnSecond.Text = "2";
            this.rbtnSecond.UseVisualStyleBackColor = true;
            // 
            // rbtnThird
            // 
            this.rbtnThird.AutoSize = true;
            this.rbtnThird.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbtnThird.Location = new System.Drawing.Point(27, 156);
            this.rbtnThird.Name = "rbtnThird";
            this.rbtnThird.Size = new System.Drawing.Size(48, 29);
            this.rbtnThird.TabIndex = 2;
            this.rbtnThird.TabStop = true;
            this.rbtnThird.Text = "3";
            this.rbtnThird.UseVisualStyleBackColor = true;
            // 
            // rbtnFourth
            // 
            this.rbtnFourth.AutoSize = true;
            this.rbtnFourth.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbtnFourth.Location = new System.Drawing.Point(27, 210);
            this.rbtnFourth.Name = "rbtnFourth";
            this.rbtnFourth.Size = new System.Drawing.Size(48, 29);
            this.rbtnFourth.TabIndex = 3;
            this.rbtnFourth.TabStop = true;
            this.rbtnFourth.Text = "4";
            this.rbtnFourth.UseVisualStyleBackColor = true;
            // 
            // btnNextQustions
            // 
            this.btnNextQustions.BackColor = System.Drawing.Color.SkyBlue;
            this.btnNextQustions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnNextQustions.Location = new System.Drawing.Point(714, 450);
            this.btnNextQustions.Name = "btnNextQustions";
            this.btnNextQustions.Size = new System.Drawing.Size(615, 51);
            this.btnNextQustions.TabIndex = 7;
            this.btnNextQustions.Text = "Следующий вопрос";
            this.btnNextQustions.UseVisualStyleBackColor = false;
            this.btnNextQustions.Click += new System.EventHandler(this.btnNextQustions_Click);
            // 
            // btnEnds
            // 
            this.btnEnds.BackColor = System.Drawing.Color.SkyBlue;
            this.btnEnds.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnEnds.Location = new System.Drawing.Point(714, 633);
            this.btnEnds.Name = "btnEnds";
            this.btnEnds.Size = new System.Drawing.Size(615, 50);
            this.btnEnds.TabIndex = 8;
            this.btnEnds.Text = "Завершить прямо сейчас";
            this.btnEnds.UseVisualStyleBackColor = false;
            this.btnEnds.Click += new System.EventHandler(this.btnEnds_Click_1);
            // 
            // grBoxQuestions
            // 
            this.grBoxQuestions.Controls.Add(this.rbtnFourth);
            this.grBoxQuestions.Controls.Add(this.rbtnFirst);
            this.grBoxQuestions.Controls.Add(this.rbtnSecond);
            this.grBoxQuestions.Controls.Add(this.rbtnThird);
            this.grBoxQuestions.Location = new System.Drawing.Point(714, 140);
            this.grBoxQuestions.Name = "grBoxQuestions";
            this.grBoxQuestions.Size = new System.Drawing.Size(615, 275);
            this.grBoxQuestions.TabIndex = 9;
            this.grBoxQuestions.TabStop = false;
            this.grBoxQuestions.Text = "Выберите правильный вариант ответов";
            // 
            // timeStart
            // 
            this.timeStart.Interval = 1000;
            this.timeStart.Tick += new System.EventHandler(this.timeStart_Tick);
            // 
            // lbTimeStart
            // 
            this.lbTimeStart.AutoSize = true;
            this.lbTimeStart.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTimeStart.Location = new System.Drawing.Point(224, 83);
            this.lbTimeStart.Name = "lbTimeStart";
            this.lbTimeStart.Size = new System.Drawing.Size(0, 33);
            this.lbTimeStart.TabIndex = 11;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Тестирование.Properties.Resources.Flying_Horse_PNG_Transparent_Image;
            this.pictureBox1.Location = new System.Drawing.Point(31, 296);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(497, 430);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pictureBox2.Image = global::Тестирование.Properties.Resources.трава;
            this.pictureBox2.Location = new System.Drawing.Point(0, 732);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1924, 233);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            // 
            // lbal
            // 
            this.lbal.AutoSize = true;
            this.lbal.Location = new System.Drawing.Point(528, 201);
            this.lbal.Name = "lbal";
            this.lbal.Size = new System.Drawing.Size(0, 20);
            this.lbal.TabIndex = 17;
            // 
            // lbQuestr
            // 
            this.lbQuestr.AutoSize = true;
            this.lbQuestr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbQuestr.Location = new System.Drawing.Point(709, 59);
            this.lbQuestr.Name = "lbQuestr";
            this.lbQuestr.Size = new System.Drawing.Size(0, 25);
            this.lbQuestr.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 25);
            this.label1.TabIndex = 19;
            this.label1.Text = "Времени осталось";
            // 
            // lbIsQuestion
            // 
            this.lbIsQuestion.AutoSize = true;
            this.lbIsQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbIsQuestion.Location = new System.Drawing.Point(833, 565);
            this.lbIsQuestion.Name = "lbIsQuestion";
            this.lbIsQuestion.Size = new System.Drawing.Size(70, 26);
            this.lbIsQuestion.TabIndex = 20;
            this.lbIsQuestion.Text = "label2";
            // 
            // Tests
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1924, 965);
            this.Controls.Add(this.lbIsQuestion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbQuestr);
            this.Controls.Add(this.lbal);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lbTimeStart);
            this.Controls.Add(this.grBoxQuestions);
            this.Controls.Add(this.btnEnds);
            this.Controls.Add(this.btnNextQustions);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Tests";
            this.Text = "Животные";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.grBoxQuestions.ResumeLayout(false);
            this.grBoxQuestions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbtnFirst;
        private System.Windows.Forms.RadioButton rbtnSecond;
        private System.Windows.Forms.RadioButton rbtnThird;
        private System.Windows.Forms.RadioButton rbtnFourth;
        private System.Windows.Forms.Button btnNextQustions;
        private System.Windows.Forms.Button btnEnds;
        private System.Windows.Forms.GroupBox grBoxQuestions;
        private System.Windows.Forms.Label lbTimeStart;
        public System.Windows.Forms.Timer timeStart;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lbal;
        private System.Windows.Forms.Label lbQuestr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbIsQuestion;
    }
}