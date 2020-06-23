namespace Тестирование
{
    partial class OverDownForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OverDownForm));
            this.lbNumbQuestt = new System.Windows.Forms.Label();
            this.timerOverGame = new System.Windows.Forms.Timer(this.components);
            this.lbTimeOver = new System.Windows.Forms.Label();
            this.lbCap = new System.Windows.Forms.Label();
            this.lbIsQuestion = new System.Windows.Forms.Label();
            this.grBoxQuestions = new System.Windows.Forms.GroupBox();
            this.rbtnFourth = new System.Windows.Forms.RadioButton();
            this.rbtnFirst = new System.Windows.Forms.RadioButton();
            this.rbtnSecond = new System.Windows.Forms.RadioButton();
            this.rbtnThird = new System.Windows.Forms.RadioButton();
            this.btnEnds = new System.Windows.Forms.Button();
            this.btnNextQustions = new System.Windows.Forms.Button();
            this.lbQuestr = new System.Windows.Forms.Label();
            this.pictureDuck = new System.Windows.Forms.PictureBox();
            this.grBoxQuestions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureDuck)).BeginInit();
            this.SuspendLayout();
            // 
            // lbNumbQuestt
            // 
            this.lbNumbQuestt.AutoSize = true;
            this.lbNumbQuestt.BackColor = System.Drawing.Color.SkyBlue;
            this.lbNumbQuestt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbNumbQuestt.Location = new System.Drawing.Point(1235, 518);
            this.lbNumbQuestt.Name = "lbNumbQuestt";
            this.lbNumbQuestt.Size = new System.Drawing.Size(0, 32);
            this.lbNumbQuestt.TabIndex = 11;
            // 
            // timerOverGame
            // 
            this.timerOverGame.Tick += new System.EventHandler(this.timerOverGame_Tick);
            // 
            // lbTimeOver
            // 
            this.lbTimeOver.AutoSize = true;
            this.lbTimeOver.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbTimeOver.Location = new System.Drawing.Point(287, 186);
            this.lbTimeOver.Name = "lbTimeOver";
            this.lbTimeOver.Size = new System.Drawing.Size(0, 32);
            this.lbTimeOver.TabIndex = 17;
            // 
            // lbCap
            // 
            this.lbCap.AutoSize = true;
            this.lbCap.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbCap.Location = new System.Drawing.Point(12, 186);
            this.lbCap.Name = "lbCap";
            this.lbCap.Size = new System.Drawing.Size(269, 32);
            this.lbCap.TabIndex = 19;
            this.lbCap.Text = "Времени осталось:";
            // 
            // lbIsQuestion
            // 
            this.lbIsQuestion.AutoSize = true;
            this.lbIsQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbIsQuestion.Location = new System.Drawing.Point(827, 572);
            this.lbIsQuestion.Name = "lbIsQuestion";
            this.lbIsQuestion.Size = new System.Drawing.Size(70, 26);
            this.lbIsQuestion.TabIndex = 24;
            this.lbIsQuestion.Text = "label2";
            // 
            // grBoxQuestions
            // 
            this.grBoxQuestions.Controls.Add(this.rbtnFourth);
            this.grBoxQuestions.Controls.Add(this.rbtnFirst);
            this.grBoxQuestions.Controls.Add(this.rbtnSecond);
            this.grBoxQuestions.Controls.Add(this.rbtnThird);
            this.grBoxQuestions.Location = new System.Drawing.Point(708, 147);
            this.grBoxQuestions.Name = "grBoxQuestions";
            this.grBoxQuestions.Size = new System.Drawing.Size(615, 275);
            this.grBoxQuestions.TabIndex = 23;
            this.grBoxQuestions.TabStop = false;
            this.grBoxQuestions.Text = "Выберите правильный вариант ответов";
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
            // btnEnds
            // 
            this.btnEnds.BackColor = System.Drawing.Color.SkyBlue;
            this.btnEnds.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnEnds.Location = new System.Drawing.Point(708, 640);
            this.btnEnds.Name = "btnEnds";
            this.btnEnds.Size = new System.Drawing.Size(615, 50);
            this.btnEnds.TabIndex = 22;
            this.btnEnds.Text = "Завершить прямо сейчас";
            this.btnEnds.UseVisualStyleBackColor = false;
            this.btnEnds.Click += new System.EventHandler(this.btnEnds_Click);
            // 
            // btnNextQustions
            // 
            this.btnNextQustions.BackColor = System.Drawing.Color.SkyBlue;
            this.btnNextQustions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnNextQustions.Location = new System.Drawing.Point(708, 464);
            this.btnNextQustions.Name = "btnNextQustions";
            this.btnNextQustions.Size = new System.Drawing.Size(615, 51);
            this.btnNextQustions.TabIndex = 21;
            this.btnNextQustions.Text = "Следующий вопрос";
            this.btnNextQustions.UseVisualStyleBackColor = false;
            this.btnNextQustions.Click += new System.EventHandler(this.btnNextQustions_Click);
            // 
            // lbQuestr
            // 
            this.lbQuestr.AutoSize = true;
            this.lbQuestr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbQuestr.Location = new System.Drawing.Point(703, 106);
            this.lbQuestr.Name = "lbQuestr";
            this.lbQuestr.Size = new System.Drawing.Size(0, 25);
            this.lbQuestr.TabIndex = 25;
            // 
            // pictureDuck
            // 
            this.pictureDuck.Image = global::Тестирование.Properties.Resources.Скрудж;
            this.pictureDuck.Location = new System.Drawing.Point(18, 330);
            this.pictureDuck.Name = "pictureDuck";
            this.pictureDuck.Size = new System.Drawing.Size(400, 338);
            this.pictureDuck.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureDuck.TabIndex = 26;
            this.pictureDuck.TabStop = false;
            // 
            // OverDownForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1924, 1016);
            this.Controls.Add(this.pictureDuck);
            this.Controls.Add(this.lbQuestr);
            this.Controls.Add(this.lbIsQuestion);
            this.Controls.Add(this.grBoxQuestions);
            this.Controls.Add(this.btnEnds);
            this.Controls.Add(this.btnNextQustions);
            this.Controls.Add(this.lbCap);
            this.Controls.Add(this.lbTimeOver);
            this.Controls.Add(this.lbNumbQuestt);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "OverDownForm";
            this.Text = "Мультики";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.OverDownForm_Load);
            this.grBoxQuestions.ResumeLayout(false);
            this.grBoxQuestions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureDuck)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbNumbQuestt;
        private System.Windows.Forms.Label lbTimeOver;
        public System.Windows.Forms.Timer timerOverGame;
        private System.Windows.Forms.Label lbCap;
        private System.Windows.Forms.Label lbIsQuestion;
        private System.Windows.Forms.GroupBox grBoxQuestions;
        private System.Windows.Forms.RadioButton rbtnFourth;
        private System.Windows.Forms.RadioButton rbtnFirst;
        private System.Windows.Forms.RadioButton rbtnSecond;
        private System.Windows.Forms.RadioButton rbtnThird;
        private System.Windows.Forms.Button btnEnds;
        private System.Windows.Forms.Button btnNextQustions;
        private System.Windows.Forms.Label lbQuestr;
        private System.Windows.Forms.PictureBox pictureDuck;
    }
}