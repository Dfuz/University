namespace University
{
    partial class AddSpecialty
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddSpecialty));
            this.label1 = new System.Windows.Forms.Label();
            this.DisciplinesLB = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SpecialtyMB = new System.Windows.Forms.MaskedTextBox();
            this.CancelBT = new System.Windows.Forms.Button();
            this.OkBT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Дисциплины";
            // 
            // DisciplinesLB
            // 
            this.DisciplinesLB.FormattingEnabled = true;
            this.DisciplinesLB.HorizontalScrollbar = true;
            this.DisciplinesLB.Location = new System.Drawing.Point(155, 12);
            this.DisciplinesLB.Name = "DisciplinesLB";
            this.DisciplinesLB.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.DisciplinesLB.Size = new System.Drawing.Size(268, 69);
            this.DisciplinesLB.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Специальность";
            // 
            // SpecialtyMB
            // 
            this.SpecialtyMB.Location = new System.Drawing.Point(155, 111);
            this.SpecialtyMB.Name = "SpecialtyMB";
            this.SpecialtyMB.Size = new System.Drawing.Size(268, 20);
            this.SpecialtyMB.TabIndex = 3;
            // 
            // CancelBT
            // 
            this.CancelBT.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelBT.Location = new System.Drawing.Point(248, 153);
            this.CancelBT.Name = "CancelBT";
            this.CancelBT.Size = new System.Drawing.Size(75, 23);
            this.CancelBT.TabIndex = 22;
            this.CancelBT.Text = "Отменить";
            this.CancelBT.UseVisualStyleBackColor = true;
            // 
            // OkBT
            // 
            this.OkBT.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OkBT.Location = new System.Drawing.Point(104, 153);
            this.OkBT.Name = "OkBT";
            this.OkBT.Size = new System.Drawing.Size(75, 23);
            this.OkBT.TabIndex = 21;
            this.OkBT.Text = "Принять";
            this.OkBT.UseVisualStyleBackColor = true;
            // 
            // AddSpecialty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 194);
            this.Controls.Add(this.CancelBT);
            this.Controls.Add(this.OkBT);
            this.Controls.Add(this.SpecialtyMB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DisciplinesLB);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AddSpecialty";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Добавление специальности";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button CancelBT;
        private System.Windows.Forms.Button OkBT;
        protected internal System.Windows.Forms.ListBox DisciplinesLB;
        protected internal System.Windows.Forms.MaskedTextBox SpecialtyMB;
    }
}