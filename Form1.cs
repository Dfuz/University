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
            if (db.Specialties.ToList().Count > 0)
            {
                SpecialtyDataGV.DataSource = new BindingSource
                {
                    DataSource = db.Specialties.ToList().Select(b =>
                    new { b.Id, b.Name }
                )};
            }
        }

        /*-----------------------------------------------------------------------*/
        /*             Методы связанные с таблицей АБИТУРИЕНТЫ                   */
        /*-----------------------------------------------------------------------*/
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

        /*-----------------------------------------------------------------------*/
        /*             Методы связанные с таблицей ДИСЦИПЛИНЫ                    */
        /*-----------------------------------------------------------------------*/
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
                    discipline.Specialties = new List<Specialty>();
                    if (db.Disciplines.Where(b => b.Code == discipline.Code).Count() > 0)
                    {
                        MessageBox.Show("Такая дисциплина уже существует!");
                        return;
                    }
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

        /*-----------------------------------------------------------------------*/
        /*             Методы связанные с таблицей ЭКЗАМЕНЫ                      */
        /*-----------------------------------------------------------------------*/
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
                    //exams.ExamsDataGV.DataSource = db.ExamSheets.Where(idenrollee => idenrollee.EnrolleeId == id).ToList();
                    if (db.ExamSheets.Where(idenrollee => idenrollee.EnrolleeId == id).ToList().Count > 0)
                    {
                        exams.ExamsDataGV.DataSource = new BindingSource
                        {
                            DataSource = db.ExamSheets.Where(idenrollee => idenrollee.EnrolleeId == id).ToList().Select(b =>
                            new { b.Id, b.EnrolleeId, b.Examiner, b.discipline.Name, b.Score, b.Comment }
                    ) };
                        exams.ExamsDataGV.Columns[0].HeaderText = "id";
                        exams.ExamsDataGV.Columns[1].HeaderText = "id абитуриента";
                        exams.ExamsDataGV.Columns[2].HeaderText = "Экзаменатор";
                        exams.ExamsDataGV.Columns[3].HeaderText = "Название дисциплины";
                        exams.ExamsDataGV.Columns[4].HeaderText = "Количество набранных баллов";
                        exams.ExamsDataGV.Columns[5].HeaderText = "Комментарий";
                    }  
                    exams.ShowDialog(this);
                }
            }
        }

        /*-----------------------------------------------------------------------*/
        /*             Методы связанные с таблицей СПЕЦИАЛЬНОСТИ                 */
        /*-----------------------------------------------------------------------*/
        private void добавитьСпециальностьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var add = new AddSpecialty();
            add.DisciplinesLB.DataSource = db.Disciplines.ToList();
            add.DisciplinesLB.DisplayMember = "Name";

            if (add.ShowDialog(this) == DialogResult.OK)
            {
                try
                {
                    Specialty specialty = new Specialty();
                    specialty.Disciplines = new List<Discipline>();
                    foreach (Object selecteditem in add.DisciplinesLB.SelectedItems)
                    {
                        specialty.Disciplines.Add((Discipline)selecteditem);
                    }
                    specialty.Name = add.SpecialtyMB.Text;
                    db.Specialties.Add(specialty); 
                    db.SaveChanges();
                    SpecialtyDataGV.DataSource = new BindingSource
                    {
                        DataSource = db.Specialties.ToList().Select(b =>
                        new { b.Id, b.Name }
               )
                    };
                   // SpecialtyDataGV.Refresh();
                    MessageBox.Show("Специальность успешно добавлена!");
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

        private void SpecialtyDataGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (SpecialtyDataGV.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow i in SpecialtyDataGV.SelectedRows)
                {
                    var info = new SpecialtyInfo();
                    bool converted = Int32.TryParse(SpecialtyDataGV[0, i.Index].Value.ToString(), out int id);
                    if (converted == false)
                        return;

                    Specialty specialty = db.Specialties.Find(id);
                    info.DisciplineLB.DataSource = specialty.Disciplines;
                    info.DisciplineLB.DisplayMember = "Name";
                    info.ShowDialog(this);
                }
            }
        }

        private void удалитьСпециальностьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (SpecialtyDataGV.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow i in SpecialtyDataGV.SelectedRows)
                {
                    bool converted = Int32.TryParse(SpecialtyDataGV[0, i.Index].Value.ToString(), out int id);
                    if (converted == false)
                        return;

                    Specialty specialty = db.Specialties.Find(id);
                    db.Specialties.Remove(specialty);
                    db.SaveChanges();
                }
                if (db.Specialties.ToList().Count == 0)
                {
                    SpecialtyDataGV.DataSource = null;
                }
                else
                {
                    SpecialtyDataGV.DataSource = new BindingSource
                    {
                        DataSource = db.Specialties.ToList().Select(b =>
                        new { b.Id, b.Name }
                       )};
                }
                MessageBox.Show("Информация успешно удалена");
            }
        }

        private void изменитьСпециальностьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (SpecialtyDataGV.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow i in SpecialtyDataGV.SelectedRows)
                {
                    bool converted = Int32.TryParse(SpecialtyDataGV[0, i.Index].Value.ToString(), out int id);
                    if (converted == false)
                        return;

                    Specialty specialty = db.Specialties.Find(id);

                    //db.Specialties.Remove(specialty);
                    var add = new AddSpecialty(); // создаем форму для изменения
                    add.DisciplinesLB.DataSource = db.Disciplines.ToList(); /// делаем привязку к таблице с дисциплинами
                    add.DisciplinesLB.DisplayMember = "Name";               /// выводим на экран значение атрибута Name
                    add.SpecialtyMB.Text = specialty.Name;
                    if (add.ShowDialog(this) == DialogResult.OK)
                    {
                        try
                        {
                            specialty.Disciplines.Clear(); // перед перезаписью очищаем список дисциплин
                            foreach (Object selecteditem in add.DisciplinesLB.SelectedItems)
                            {
                                specialty.Disciplines.Add((Discipline)selecteditem);
                            }
                            specialty.Name = add.SpecialtyMB.Text;
                            db.SaveChanges();
                            SpecialtyDataGV.DataSource = new BindingSource
                            {
                                DataSource = db.Specialties.ToList().Select(b =>
                                new { b.Id, b.Name }
                       )
                            };
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                } // по каждой выделенной строке

                // если в таблице 0 специальностей
                if (db.Specialties.ToList().Count == 0)
                {
                    SpecialtyDataGV.DataSource = null;
                }
                else
                {
                    SpecialtyDataGV.DataSource = new BindingSource
                    {
                        DataSource = db.Specialties.ToList().Select(b =>
                        new { b.Id, b.Name }
                       )
                    };
                }
                MessageBox.Show("Информация успешно изменена");
            }
        }
    }
}
