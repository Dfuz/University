using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using University.DataModel;
using System.Data.Entity;

namespace University
{
    public partial class Form1 : Form
    {
        UniversityContext db;
        public Form1()
        {
            InitializeComponent();
            db = new UniversityContext();

            /*Загрузка данных из БД*/
            db.Enrollees.Load();
            db.Specialties.Load();
            db.ExamSheets.Load();
            db.Disciplines.Load();

            /*Заполение DataGridView*/
            EnrolleesDataGV.DataSource = db.Enrollees.Local.ToBindingList(); // абитуриенты
            DisciplinesDataGV.DataSource = db.Disciplines.Local.ToBindingList(); // дисциплины
        }

        // АБИТУРИЕНТ
        private void добавитьАбитуриентаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddEnrollee add = new AddEnrollee();
            if (add.ShowDialog(this) == DialogResult.OK)
            {
                try
                {
                    Enrollee enrollee = new Enrollee();
                    enrollee.Age = Convert.ToInt32(add.AgeNumericUpDown.Value);
                    enrollee.Firstname = add.firstnameTB.Text;
                    enrollee.Secondname = add.secondnameTB.Text;
                    enrollee.Patronymic = add.patronymicTB.Text;
                    db.Enrollees.Add(enrollee); // добавление абитуриента
                    db.SaveChanges();
                    MessageBox.Show("Абитуриент успешно добавлен!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                add.Close();
            }
        }

        private void изменитьДанныеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (EnrolleesDataGV.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow i in EnrolleesDataGV.SelectedRows)
                {
                    try
                    {
                        bool converted = Int32.TryParse(EnrolleesDataGV[0, i.Index].Value.ToString(), out int id);
                        if (converted == false)
                            return;

                        Enrollee enrollee = db.Enrollees.Find(id);
                        AddEnrollee add = new AddEnrollee(enrollee.Age, enrollee.Firstname,
                            enrollee.Secondname, enrollee.Patronymic);

                        if (add.ShowDialog(this) == DialogResult.OK)
                        {
                            try
                            {
                                enrollee.Age = Convert.ToInt32(add.AgeNumericUpDown.Value);
                                enrollee.Firstname = add.firstnameTB.Text;
                                enrollee.Secondname = add.secondnameTB.Text;
                                enrollee.Patronymic = add.patronymicTB.Text;
                                db.SaveChanges();
                                EnrolleesDataGV.Refresh();
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
                MessageBox.Show("Информация успешно обновлена!");
            }
        }

        private void удалитьАбитуриентаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (EnrolleesDataGV.SelectedRows.Count > 0)
            {
                try
                {
                    foreach (DataGridViewRow i in EnrolleesDataGV.SelectedRows)
                    {
                        bool converted = Int32.TryParse(EnrolleesDataGV[0, i.Index].Value.ToString(), out int id);
                        if (converted == false)
                            return;

                        Enrollee enrollee = db.Enrollees.Find(id); 
                        db.Enrollees.Remove(enrollee);
                        db.SaveChanges();
                    }
                    EnrolleesDataGV.Refresh();

                    MessageBox.Show("Удаление прошло успешно!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void EnrolleesDataGV_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                удалитьАбитуриентаToolStripMenuItem_Click(null, null);
            }
        }

        // ДИСЦИПЛИНА 
        private void изменитьДанныеToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (DisciplinesDataGV.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow i in DisciplinesDataGV.SelectedRows)
                {
                    try
                    {
                        bool converted = Int32.TryParse(DisciplinesDataGV[0, i.Index].Value.ToString(), out int id);
                        if (converted == false)
                            return;

                        Discipline discipline = db.Disciplines.Find(id);
                        AddDiscipline add = new AddDiscipline(discipline.Name, discipline.Code);

                        if (add.ShowDialog(this) == DialogResult.OK)
                        {
                            try
                            {
                                discipline.Name = add.nameTB.Text;
                                discipline.Code = add.codeTB.Text;
                                db.SaveChanges();
                                DisciplinesDataGV.Refresh();
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
                MessageBox.Show("Информация успешно обновлена!");
            }
        }

        private void удалитьДисциплинуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DisciplinesDataGV.SelectedRows.Count > 0)
            {
                try
                {
                    foreach (DataGridViewRow i in DisciplinesDataGV.SelectedRows)
                    {
                        bool converted = Int32.TryParse(DisciplinesDataGV[0, i.Index].Value.ToString(), out int id);
                        if (converted == false)
                            return;

                        Discipline discipline = db.Disciplines.Find(id);
                        db.Disciplines.Remove(discipline);
                        db.SaveChanges();
                    }
                    DisciplinesDataGV.Refresh();

                    MessageBox.Show("Удаление прошло успешно!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void добавитьДисциплинуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddDiscipline add = new AddDiscipline();
            if (add.ShowDialog(this) == DialogResult.OK)
            {
                try
                {
                    Discipline discipline = new Discipline();
                    discipline.Code = add.codeTB.Text;
                    discipline.Name = add.nameTB.Text;
                    db.Disciplines.Add(discipline);
                    db.SaveChanges();
                    DisciplinesDataGV.Refresh();
                    MessageBox.Show("Дисциплина успешно добавлена!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                add.Close();
            }
        }

        // ЭКЗАМЕНЫ
        private void информацияОбЭкзаменахToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (EnrolleesDataGV.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow i in EnrolleesDataGV.SelectedRows)
                {
                    bool converted = Int32.TryParse(EnrolleesDataGV[0, i.Index].Value.ToString(), out int id);
                    if (converted == false)
                        return;
                    ExamsForm exams = new ExamsForm(id);
                    //exams.ExamsDataGV.DataSource = db.ExamSheets.Local.ToBindingList().Where(idenrollee => idenrollee.EnrolleeId == id);
                    exams.ExamsDataGV.DataSource = db.ExamSheets.Where(idenrollee => idenrollee.EnrolleeId == id).ToList();
                    
                    exams.ShowDialog(this);
                }
            }
        }
    }
}
