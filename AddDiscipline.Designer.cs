namespace University
{
    partial class AddDiscipline
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
            this.CancelBT = new System.Windows.Forms.Button();
            this.OkBT = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.codeTB = new System.Windows.Forms.MaskedTextBox();
            this.nameTB = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CancelBT
            // 
            this.CancelBT.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelBT.Location = new System.Drawing.Point(234, 138);
            this.CancelBT.Name = "CancelBT";
            this.CancelBT.Size = new System.Drawing.Size(75, 23);
            this.CancelBT.TabIndex = 20;
            this.CancelBT.Text = "Отменить";
            this.CancelBT.UseVisualStyleBackColor = true;
            // 
            // OkBT
            // 
            this.OkBT.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OkBT.Location = new System.Drawing.Point(90, 138);
            this.OkBT.Name = "OkBT";
            this.OkBT.Size = new System.Drawing.Size(75, 23);
            this.OkBT.TabIndex = 19;
            this.OkBT.Text = "Принять";
            this.OkBT.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Код дисциплины";
            // 
            // codeTB
            // 
            this.codeTB.Location = new System.Drawing.Point(140, 88);
            this.codeTB.Name = "codeTB";
            this.codeTB.Size = new System.Drawing.Size(211, 20);
            this.codeTB.TabIndex = 13;
            this.codeTB.TextChanged += new System.EventHandler(this.codeTB_TextChanged);
            // 
            // nameTB
            // 
            this.nameTB.Location = new System.Drawing.Point(140, 49);
            this.nameTB.Name = "nameTB";
            this.nameTB.Size = new System.Drawing.Size(211, 20);
            this.nameTB.TabIndex = 12;
            this.nameTB.TextChanged += new System.EventHandler(this.nameTB_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Название дисциплины";
            // 
            // AddDiscipline
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 185);
            this.Controls.Add(this.CancelBT);
            this.Controls.Add(this.OkBT);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.codeTB);
            this.Controls.Add(this.nameTB);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AddDiscipline";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AddDiscipline";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CancelBT;
        private System.Windows.Forms.Button OkBT;
        private System.Windows.Forms.Label label2;
        protected internal System.Windows.Forms.MaskedTextBox codeTB;
        protected internal System.Windows.Forms.MaskedTextBox nameTB;
        private System.Windows.Forms.Label label1;
    }
}