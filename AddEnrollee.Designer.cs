namespace University
{
    partial class AddEnrollee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddEnrollee));
            this.label1 = new System.Windows.Forms.Label();
            this.secondnameTB = new System.Windows.Forms.MaskedTextBox();
            this.firstnameTB = new System.Windows.Forms.MaskedTextBox();
            this.patronymicTB = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.AgeNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.OkBT = new System.Windows.Forms.Button();
            this.CancelBT = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.AgeNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Фамилия";
            // 
            // secondnameTB
            // 
            this.secondnameTB.AsciiOnly = true;
            this.secondnameTB.BeepOnError = true;
            this.secondnameTB.Location = new System.Drawing.Point(111, 31);
            this.secondnameTB.Name = "secondnameTB";
            this.secondnameTB.Size = new System.Drawing.Size(211, 20);
            this.secondnameTB.TabIndex = 1;
            this.secondnameTB.TextChanged += new System.EventHandler(this.secondnameTB_TextChanged);
            // 
            // firstnameTB
            // 
            this.firstnameTB.AsciiOnly = true;
            this.firstnameTB.Location = new System.Drawing.Point(111, 70);
            this.firstnameTB.Name = "firstnameTB";
            this.firstnameTB.Size = new System.Drawing.Size(211, 20);
            this.firstnameTB.TabIndex = 2;
            this.firstnameTB.TextChanged += new System.EventHandler(this.firstnameTB_TextChanged);
            // 
            // patronymicTB
            // 
            this.patronymicTB.AsciiOnly = true;
            this.patronymicTB.Location = new System.Drawing.Point(111, 111);
            this.patronymicTB.Name = "patronymicTB";
            this.patronymicTB.Size = new System.Drawing.Size(211, 20);
            this.patronymicTB.TabIndex = 3;
            this.patronymicTB.TextChanged += new System.EventHandler(this.patronymicTB_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Имя";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Отчество";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Возраст";
            // 
            // AgeNumericUpDown
            // 
            this.AgeNumericUpDown.Location = new System.Drawing.Point(111, 151);
            this.AgeNumericUpDown.Maximum = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.AgeNumericUpDown.Name = "AgeNumericUpDown";
            this.AgeNumericUpDown.Size = new System.Drawing.Size(211, 20);
            this.AgeNumericUpDown.TabIndex = 8;
            this.AgeNumericUpDown.ValueChanged += new System.EventHandler(this.AgeNumericUpDown_ValueChanged);
            this.AgeNumericUpDown.KeyUp += new System.Windows.Forms.KeyEventHandler(this.AgeNumericUpDown_KeyUp);
            // 
            // OkBT
            // 
            this.OkBT.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OkBT.Location = new System.Drawing.Point(80, 213);
            this.OkBT.Name = "OkBT";
            this.OkBT.Size = new System.Drawing.Size(75, 23);
            this.OkBT.TabIndex = 9;
            this.OkBT.Text = "Принять";
            this.OkBT.UseVisualStyleBackColor = true;
            // 
            // CancelBT
            // 
            this.CancelBT.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelBT.Location = new System.Drawing.Point(224, 213);
            this.CancelBT.Name = "CancelBT";
            this.CancelBT.Size = new System.Drawing.Size(75, 23);
            this.CancelBT.TabIndex = 10;
            this.CancelBT.Text = "Отменить";
            this.CancelBT.UseVisualStyleBackColor = true;
            // 
            // AddEnrollee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 258);
            this.Controls.Add(this.CancelBT);
            this.Controls.Add(this.OkBT);
            this.Controls.Add(this.AgeNumericUpDown);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.patronymicTB);
            this.Controls.Add(this.firstnameTB);
            this.Controls.Add(this.secondnameTB);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AddEnrollee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Добавление абитуриента";
            ((System.ComponentModel.ISupportInitialize)(this.AgeNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button OkBT;
        private System.Windows.Forms.Button CancelBT;
        protected internal System.Windows.Forms.MaskedTextBox secondnameTB;
        protected internal System.Windows.Forms.MaskedTextBox firstnameTB;
        protected internal System.Windows.Forms.MaskedTextBox patronymicTB;
        protected internal System.Windows.Forms.NumericUpDown AgeNumericUpDown;
    }
}