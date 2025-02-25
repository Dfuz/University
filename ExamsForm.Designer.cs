﻿namespace University
{
    partial class ExamsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExamsForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.OkBT = new System.Windows.Forms.Button();
            this.ExamsDataGV = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.добавитьЭкзаменToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изменитьИнформациюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьИнформациюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ExamsDataGV)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.ExamsDataGV, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 91.46919F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.530806F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(754, 448);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.OkBT, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 412);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(748, 33);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // OkBT
            // 
            this.OkBT.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OkBT.Location = new System.Drawing.Point(3, 3);
            this.OkBT.Name = "OkBT";
            this.OkBT.Size = new System.Drawing.Size(742, 27);
            this.OkBT.TabIndex = 0;
            this.OkBT.Text = "Закрыть";
            this.OkBT.UseVisualStyleBackColor = true;
            this.OkBT.Click += new System.EventHandler(this.OkBT_Click);
            // 
            // ExamsDataGV
            // 
            this.ExamsDataGV.AllowUserToAddRows = false;
            this.ExamsDataGV.AllowUserToDeleteRows = false;
            this.ExamsDataGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.ExamsDataGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ExamsDataGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ExamsDataGV.Location = new System.Drawing.Point(3, 3);
            this.ExamsDataGV.Name = "ExamsDataGV";
            this.ExamsDataGV.ReadOnly = true;
            this.ExamsDataGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ExamsDataGV.Size = new System.Drawing.Size(748, 403);
            this.ExamsDataGV.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьЭкзаменToolStripMenuItem,
            this.изменитьИнформациюToolStripMenuItem,
            this.удалитьИнформациюToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(754, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // добавитьЭкзаменToolStripMenuItem
            // 
            this.добавитьЭкзаменToolStripMenuItem.Name = "добавитьЭкзаменToolStripMenuItem";
            this.добавитьЭкзаменToolStripMenuItem.Size = new System.Drawing.Size(119, 20);
            this.добавитьЭкзаменToolStripMenuItem.Text = "Добавить экзамен";
            this.добавитьЭкзаменToolStripMenuItem.Click += new System.EventHandler(this.добавитьЭкзаменToolStripMenuItem_Click);
            // 
            // изменитьИнформациюToolStripMenuItem
            // 
            this.изменитьИнформациюToolStripMenuItem.Name = "изменитьИнформациюToolStripMenuItem";
            this.изменитьИнформациюToolStripMenuItem.Size = new System.Drawing.Size(152, 20);
            this.изменитьИнформациюToolStripMenuItem.Text = "Изменить информацию";
            this.изменитьИнформациюToolStripMenuItem.Click += new System.EventHandler(this.изменитьИнформациюToolStripMenuItem_Click);
            // 
            // удалитьИнформациюToolStripMenuItem
            // 
            this.удалитьИнформациюToolStripMenuItem.Name = "удалитьИнформациюToolStripMenuItem";
            this.удалитьИнформациюToolStripMenuItem.Size = new System.Drawing.Size(142, 20);
            this.удалитьИнформациюToolStripMenuItem.Text = "Удалить информацию";
            this.удалитьИнформациюToolStripMenuItem.Click += new System.EventHandler(this.удалитьИнформациюToolStripMenuItem_Click);
            // 
            // ExamsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 472);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ExamsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Экзаменационный лист";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ExamsDataGV)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem добавитьЭкзаменToolStripMenuItem;
        protected internal System.Windows.Forms.DataGridView ExamsDataGV;
        private System.Windows.Forms.Button OkBT;
        private System.Windows.Forms.ToolStripMenuItem изменитьИнформациюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьИнформациюToolStripMenuItem;
    }
}