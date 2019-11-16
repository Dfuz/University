﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using University.DataModel;

namespace University
{
    public partial class ExamsForm : Form
    {
        UniversityContext db;
        protected internal int currentEnrolleeId;
        public ExamsForm (int _currentEnrolleeId)
        {
            InitializeComponent();
            currentEnrolleeId = _currentEnrolleeId;
            db = new UniversityContext();
            db.Disciplines.Load();
        }

        private void OkBT_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void добавитьЭкзаменToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var add = new AddExam();
            add.DisciplinesCB.DataSource = db.Disciplines.Local.ToBindingList(); // дисциплины
            add.DisciplinesCB.DisplayMember = "Name";
            if (add.ShowDialog() == DialogResult.OK)
            {
                ExamSheet examSheet = new ExamSheet();
                examSheet.Examiner = add.ExaminerTB.Text;
                examSheet.Comment = add.CommentTB.Text;
                examSheet.Score = Convert.ToInt32(add.ScoreNumericUpDown.Value);
                examSheet.EnrolleeId = currentEnrolleeId;
                examSheet.discipline = (Discipline)add.DisciplinesCB.SelectedItem;
                db.ExamSheets.Add(examSheet); // добавление абитуриента
                db.SaveChanges();
                ExamsDataGV.DataSource = db.ExamSheets.Where(idenrollee => idenrollee.EnrolleeId == currentEnrolleeId).ToList();
                ExamsDataGV.Refresh();
            }
        }

        private void изменитьИнформациюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ExamsDataGV.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow i in ExamsDataGV.SelectedRows)
                {
                    try
                    {
                        bool converted = Int32.TryParse(ExamsDataGV[0, i.Index].Value.ToString(), out int id);
                        if (converted == false)
                            return;

                        ExamSheet examSheet = db.ExamSheets.Find(id);
                        var add = new AddExam(examSheet.Examiner, examSheet.Comment, examSheet.Score);
                        add.DisciplinesCB.DataSource = db.Disciplines.Local.ToBindingList(); // дисциплины
                        add.DisciplinesCB.DisplayMember = "Name";
                        if (add.ShowDialog(this) == DialogResult.OK)
                        {
                            try
                            {
                                examSheet.Examiner = add.ExaminerTB.Text;
                                examSheet.Comment = add.CommentTB.Text;
                                examSheet.Score = Convert.ToInt32(add.ScoreNumericUpDown.Value);
                                examSheet.discipline = (Discipline)add.DisciplinesCB.SelectedItem;
                                db.SaveChanges();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                        }
                        else
                        {
                            add.Close(); // если нажали кнопку отмены
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                ExamsDataGV.DataSource = db.ExamSheets.Where(idenrollee => idenrollee.EnrolleeId == currentEnrolleeId).ToList();
                ExamsDataGV.Refresh();
                MessageBox.Show("Информация успешно обновлена!");
            }
        }

        private void удалитьИнформациюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ExamsDataGV.SelectedRows.Count > 0)
            {
                try
                {
                    foreach (DataGridViewRow i in ExamsDataGV.SelectedRows)
                    {
                        bool converted = Int32.TryParse(ExamsDataGV[0, i.Index].Value.ToString(), out int id);
                        if (converted == false)
                            return;

                        ExamSheet examSheet = db.ExamSheets.Find(id);
                        db.ExamSheets.Remove(examSheet);
                        db.SaveChanges();
                    }
                    ExamsDataGV.DataSource = db.ExamSheets.Where(idenrollee => idenrollee.EnrolleeId == currentEnrolleeId).ToList();
                    ExamsDataGV.Refresh();

                    MessageBox.Show("Удаление прошло успешно!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
