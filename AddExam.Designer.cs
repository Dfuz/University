namespace University
{
    partial class AddExam
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddExam));
            this.CancelBT = new System.Windows.Forms.Button();
            this.OkBT = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.ExaminerTB = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DisciplinesCB = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ScoreNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.CommentTB = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ScoreNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // CancelBT
            // 
            this.CancelBT.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelBT.Location = new System.Drawing.Point(204, 205);
            this.CancelBT.Name = "CancelBT";
            this.CancelBT.Size = new System.Drawing.Size(75, 23);
            this.CancelBT.TabIndex = 20;
            this.CancelBT.Text = "Отменить";
            this.CancelBT.UseVisualStyleBackColor = true;
            // 
            // OkBT
            // 
            this.OkBT.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OkBT.Location = new System.Drawing.Point(60, 205);
            this.OkBT.Name = "OkBT";
            this.OkBT.Size = new System.Drawing.Size(75, 23);
            this.OkBT.TabIndex = 19;
            this.OkBT.Text = "Принять";
            this.OkBT.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Предмет";
            // 
            // ExaminerTB
            // 
            this.ExaminerTB.Location = new System.Drawing.Point(113, 26);
            this.ExaminerTB.Name = "ExaminerTB";
            this.ExaminerTB.Size = new System.Drawing.Size(211, 20);
            this.ExaminerTB.TabIndex = 12;
            this.ExaminerTB.TextChanged += new System.EventHandler(this.ExaminerTB_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Экзаменатор";
            // 
            // DisciplinesCB
            // 
            this.DisciplinesCB.FormattingEnabled = true;
            this.DisciplinesCB.Location = new System.Drawing.Point(113, 69);
            this.DisciplinesCB.Name = "DisciplinesCB";
            this.DisciplinesCB.Size = new System.Drawing.Size(211, 21);
            this.DisciplinesCB.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Количество набранных баллов";
            // 
            // ScoreNumericUpDown
            // 
            this.ScoreNumericUpDown.Location = new System.Drawing.Point(204, 111);
            this.ScoreNumericUpDown.Name = "ScoreNumericUpDown";
            this.ScoreNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.ScoreNumericUpDown.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Комментарий";
            // 
            // CommentTB
            // 
            this.CommentTB.Location = new System.Drawing.Point(113, 157);
            this.CommentTB.Name = "CommentTB";
            this.CommentTB.Size = new System.Drawing.Size(211, 20);
            this.CommentTB.TabIndex = 25;
            this.CommentTB.TextChanged += new System.EventHandler(this.CommentTB_TextChanged);
            // 
            // AddExam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 251);
            this.Controls.Add(this.CommentTB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ScoreNumericUpDown);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DisciplinesCB);
            this.Controls.Add(this.CancelBT);
            this.Controls.Add(this.OkBT);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ExaminerTB);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddExam";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Добавление результатов экзамена";
            ((System.ComponentModel.ISupportInitialize)(this.ScoreNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CancelBT;
        private System.Windows.Forms.Button OkBT;
        private System.Windows.Forms.Label label2;
        protected internal System.Windows.Forms.MaskedTextBox ExaminerTB;
        private System.Windows.Forms.Label label1;
        protected internal System.Windows.Forms.ComboBox DisciplinesCB;
        private System.Windows.Forms.Label label3;
        protected internal System.Windows.Forms.NumericUpDown ScoreNumericUpDown;
        private System.Windows.Forms.Label label4;
        protected internal System.Windows.Forms.MaskedTextBox CommentTB;
    }
}