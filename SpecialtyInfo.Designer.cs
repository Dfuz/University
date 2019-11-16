namespace University
{
    partial class SpecialtyInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SpecialtyInfo));
            this.DisciplineLB = new System.Windows.Forms.ListBox();
            this.ДИСЦИПЛИНЫ = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DisciplineLB
            // 
            this.DisciplineLB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DisciplineLB.FormattingEnabled = true;
            this.DisciplineLB.Location = new System.Drawing.Point(133, 11);
            this.DisciplineLB.Name = "DisciplineLB";
            this.DisciplineLB.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.DisciplineLB.Size = new System.Drawing.Size(258, 108);
            this.DisciplineLB.TabIndex = 0;
            // 
            // ДИСЦИПЛИНЫ
            // 
            this.ДИСЦИПЛИНЫ.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ДИСЦИПЛИНЫ.AutoSize = true;
            this.ДИСЦИПЛИНЫ.Location = new System.Drawing.Point(11, 59);
            this.ДИСЦИПЛИНЫ.Name = "ДИСЦИПЛИНЫ";
            this.ДИСЦИПЛИНЫ.Size = new System.Drawing.Size(101, 13);
            this.ДИСЦИПЛИНЫ.TabIndex = 1;
            this.ДИСЦИПЛИНЫ.Text = "Список дисциплин";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.76923F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 69.23077F));
            this.tableLayoutPanel1.Controls.Add(this.DisciplineLB, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.ДИСЦИПЛИНЫ, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(402, 131);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // SpecialtyInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 131);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SpecialtyInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Список дисциплин для специальности";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        protected internal System.Windows.Forms.ListBox DisciplineLB;
        private System.Windows.Forms.Label ДИСЦИПЛИНЫ;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}