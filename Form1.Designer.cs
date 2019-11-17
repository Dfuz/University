namespace University
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.EnrolleesDataGV = new System.Windows.Forms.DataGridView();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.добавитьАбитуриентаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изменитьДанныеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.информацияОбЭкзаменахToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьАбитуриентаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.DisciplinesDataGV = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.добавитьДисциплинуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изменитьДанныеToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьДисциплинуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.SpecialtyDataGV = new System.Windows.Forms.DataGridView();
            this.menuStrip3 = new System.Windows.Forms.MenuStrip();
            this.добавитьСпециальностьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изменитьСпециальностьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьСпециальностьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EnrolleesDataGV)).BeginInit();
            this.menuStrip2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DisciplinesDataGV)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SpecialtyDataGV)).BeginInit();
            this.menuStrip3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(839, 473);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.EnrolleesDataGV);
            this.tabPage1.Controls.Add(this.menuStrip2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(831, 447);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Абитуриенты";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // EnrolleesDataGV
            // 
            this.EnrolleesDataGV.AllowUserToAddRows = false;
            this.EnrolleesDataGV.AllowUserToDeleteRows = false;
            this.EnrolleesDataGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.EnrolleesDataGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EnrolleesDataGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EnrolleesDataGV.Location = new System.Drawing.Point(3, 27);
            this.EnrolleesDataGV.Name = "EnrolleesDataGV";
            this.EnrolleesDataGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.EnrolleesDataGV.Size = new System.Drawing.Size(825, 417);
            this.EnrolleesDataGV.TabIndex = 1;
            this.EnrolleesDataGV.KeyUp += new System.Windows.Forms.KeyEventHandler(this.EnrolleesDataGV_KeyUp);
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьАбитуриентаToolStripMenuItem,
            this.изменитьДанныеToolStripMenuItem,
            this.информацияОбЭкзаменахToolStripMenuItem,
            this.удалитьАбитуриентаToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(3, 3);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(825, 24);
            this.menuStrip2.TabIndex = 0;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // добавитьАбитуриентаToolStripMenuItem
            // 
            this.добавитьАбитуриентаToolStripMenuItem.Name = "добавитьАбитуриентаToolStripMenuItem";
            this.добавитьАбитуриентаToolStripMenuItem.Size = new System.Drawing.Size(143, 20);
            this.добавитьАбитуриентаToolStripMenuItem.Text = "Добавить абитуриента";
            this.добавитьАбитуриентаToolStripMenuItem.Click += new System.EventHandler(this.добавитьАбитуриентаToolStripMenuItem_Click);
            // 
            // изменитьДанныеToolStripMenuItem
            // 
            this.изменитьДанныеToolStripMenuItem.Name = "изменитьДанныеToolStripMenuItem";
            this.изменитьДанныеToolStripMenuItem.Size = new System.Drawing.Size(117, 20);
            this.изменитьДанныеToolStripMenuItem.Text = "Изменить данные";
            this.изменитьДанныеToolStripMenuItem.Click += new System.EventHandler(this.изменитьДанныеToolStripMenuItem_Click);
            // 
            // информацияОбЭкзаменахToolStripMenuItem
            // 
            this.информацияОбЭкзаменахToolStripMenuItem.Name = "информацияОбЭкзаменахToolStripMenuItem";
            this.информацияОбЭкзаменахToolStripMenuItem.Size = new System.Drawing.Size(170, 20);
            this.информацияОбЭкзаменахToolStripMenuItem.Text = "Информация об экзаменах";
            this.информацияОбЭкзаменахToolStripMenuItem.Click += new System.EventHandler(this.информацияОбЭкзаменахToolStripMenuItem_Click);
            // 
            // удалитьАбитуриентаToolStripMenuItem
            // 
            this.удалитьАбитуриентаToolStripMenuItem.Name = "удалитьАбитуриентаToolStripMenuItem";
            this.удалитьАбитуриентаToolStripMenuItem.Size = new System.Drawing.Size(135, 20);
            this.удалитьАбитуриентаToolStripMenuItem.Text = "Удалить абитуриента";
            this.удалитьАбитуриентаToolStripMenuItem.Click += new System.EventHandler(this.удалитьАбитуриентаToolStripMenuItem_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.DisciplinesDataGV);
            this.tabPage2.Controls.Add(this.menuStrip1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(831, 447);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Дисциплины";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // DisciplinesDataGV
            // 
            this.DisciplinesDataGV.AllowUserToAddRows = false;
            this.DisciplinesDataGV.AllowUserToDeleteRows = false;
            this.DisciplinesDataGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DisciplinesDataGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DisciplinesDataGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DisciplinesDataGV.Location = new System.Drawing.Point(3, 27);
            this.DisciplinesDataGV.Name = "DisciplinesDataGV";
            this.DisciplinesDataGV.Size = new System.Drawing.Size(825, 417);
            this.DisciplinesDataGV.TabIndex = 2;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьДисциплинуToolStripMenuItem,
            this.изменитьДанныеToolStripMenuItem1,
            this.удалитьДисциплинуToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(3, 3);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(825, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // добавитьДисциплинуToolStripMenuItem
            // 
            this.добавитьДисциплинуToolStripMenuItem.Name = "добавитьДисциплинуToolStripMenuItem";
            this.добавитьДисциплинуToolStripMenuItem.Size = new System.Drawing.Size(141, 20);
            this.добавитьДисциплинуToolStripMenuItem.Text = "Добавить дисциплину";
            this.добавитьДисциплинуToolStripMenuItem.Click += new System.EventHandler(this.добавитьДисциплинуToolStripMenuItem_Click);
            // 
            // изменитьДанныеToolStripMenuItem1
            // 
            this.изменитьДанныеToolStripMenuItem1.Name = "изменитьДанныеToolStripMenuItem1";
            this.изменитьДанныеToolStripMenuItem1.Size = new System.Drawing.Size(117, 20);
            this.изменитьДанныеToolStripMenuItem1.Text = "Изменить данные";
            this.изменитьДанныеToolStripMenuItem1.Click += new System.EventHandler(this.изменитьДанныеToolStripMenuItem1_Click);
            // 
            // удалитьДисциплинуToolStripMenuItem
            // 
            this.удалитьДисциплинуToolStripMenuItem.Name = "удалитьДисциплинуToolStripMenuItem";
            this.удалитьДисциплинуToolStripMenuItem.Size = new System.Drawing.Size(133, 20);
            this.удалитьДисциплинуToolStripMenuItem.Text = "Удалить дисциплину";
            this.удалитьДисциплинуToolStripMenuItem.Click += new System.EventHandler(this.удалитьДисциплинуToolStripMenuItem_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.SpecialtyDataGV);
            this.tabPage3.Controls.Add(this.menuStrip3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(831, 447);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Специальности";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // SpecialtyDataGV
            // 
            this.SpecialtyDataGV.AllowUserToAddRows = false;
            this.SpecialtyDataGV.AllowUserToDeleteRows = false;
            this.SpecialtyDataGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.SpecialtyDataGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SpecialtyDataGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SpecialtyDataGV.Location = new System.Drawing.Point(0, 24);
            this.SpecialtyDataGV.Name = "SpecialtyDataGV";
            this.SpecialtyDataGV.ReadOnly = true;
            this.SpecialtyDataGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.SpecialtyDataGV.Size = new System.Drawing.Size(831, 423);
            this.SpecialtyDataGV.TabIndex = 1;
            this.SpecialtyDataGV.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SpecialtyDataGV_CellDoubleClick);
            // 
            // menuStrip3
            // 
            this.menuStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьСпециальностьToolStripMenuItem,
            this.изменитьСпециальностьToolStripMenuItem,
            this.удалитьСпециальностьToolStripMenuItem});
            this.menuStrip3.Location = new System.Drawing.Point(0, 0);
            this.menuStrip3.Name = "menuStrip3";
            this.menuStrip3.Size = new System.Drawing.Size(831, 24);
            this.menuStrip3.TabIndex = 0;
            this.menuStrip3.Text = "menuStrip3";
            // 
            // добавитьСпециальностьToolStripMenuItem
            // 
            this.добавитьСпециальностьToolStripMenuItem.Name = "добавитьСпециальностьToolStripMenuItem";
            this.добавитьСпециальностьToolStripMenuItem.Size = new System.Drawing.Size(157, 20);
            this.добавитьСпециальностьToolStripMenuItem.Text = "Добавить специальность";
            this.добавитьСпециальностьToolStripMenuItem.Click += new System.EventHandler(this.добавитьСпециальностьToolStripMenuItem_Click);
            // 
            // изменитьСпециальностьToolStripMenuItem
            // 
            this.изменитьСпециальностьToolStripMenuItem.Name = "изменитьСпециальностьToolStripMenuItem";
            this.изменитьСпециальностьToolStripMenuItem.Size = new System.Drawing.Size(159, 20);
            this.изменитьСпециальностьToolStripMenuItem.Text = "Изменить специальность";
            this.изменитьСпециальностьToolStripMenuItem.Click += new System.EventHandler(this.изменитьСпециальностьToolStripMenuItem_Click);
            // 
            // удалитьСпециальностьToolStripMenuItem
            // 
            this.удалитьСпециальностьToolStripMenuItem.Name = "удалитьСпециальностьToolStripMenuItem";
            this.удалитьСпециальностьToolStripMenuItem.Size = new System.Drawing.Size(149, 20);
            this.удалитьСпециальностьToolStripMenuItem.Text = "Удалить специальность";
            this.удалитьСпециальностьToolStripMenuItem.Click += new System.EventHandler(this.удалитьСпециальностьToolStripMenuItem_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tabControl1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 93.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.888889F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(845, 515);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 482);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(839, 30);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(845, 515);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Приёмная комиссия";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EnrolleesDataGV)).EndInit();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DisciplinesDataGV)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SpecialtyDataGV)).EndInit();
            this.menuStrip3.ResumeLayout(false);
            this.menuStrip3.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem добавитьДисциплинуToolStripMenuItem;
        private System.Windows.Forms.DataGridView EnrolleesDataGV;
        private System.Windows.Forms.ToolStripMenuItem добавитьАбитуриентаToolStripMenuItem;
        private System.Windows.Forms.DataGridView DisciplinesDataGV;
        private System.Windows.Forms.ToolStripMenuItem изменитьДанныеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьАбитуриентаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem информацияОбЭкзаменахToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem изменитьДанныеToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem удалитьДисциплинуToolStripMenuItem;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.MenuStrip menuStrip3;
        private System.Windows.Forms.DataGridView SpecialtyDataGV;
        private System.Windows.Forms.ToolStripMenuItem добавитьСпециальностьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem изменитьСпециальностьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьСпециальностьToolStripMenuItem;
    }
}

