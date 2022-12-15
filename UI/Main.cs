using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static University.DataManager;
using University.Data;
using System.Data.SqlClient;
using University.UI;
using Help = University.UI.Help;

namespace University
{
    public partial class Main : Form
    {

        readonly Auth auth;
        public Data.university_dsTableAdapters.ПользователиTableAdapter users;
        public DataManager dm;
        public User user;
        string default_filter = "1 = 1";

        public Main()
        {
            InitializeComponent();
            auth = new Auth(this);
            dm = new DataManager(this);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
            if (!auth.auth(Properties.Settings.Default.login, Properties.Settings.Default.pass))
            {
                auth.ShowDialog();
                this.Hide();
            }
            dataGridView1.AutoGenerateColumns = true;
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.login = "";
            Properties.Settings.Default.pass = "";
            Properties.Settings.Default.Save();
            auth.Show();
            this.Hide();
        }



        private void Main_VisibleChanged(object sender, EventArgs e)
        {
            if (Visible)
            {
                user = dm.GetUser();
                l_name.Text = user.name;
                l_id.Text = "ID: " + user.id;
                switch (user.type)
                {
                    case "admin":
                        l_class.Text = "Администратор";
                        l_info.Text = "";
                        break;
                    case "stud":
                        Student student = (Student)user;
                        l_class.Text = "Студент";
                        l_info.Text = $"Группа: {student.group}\n" +
                            $"Курс: {student.kurs}\n" +
                            $"Форма обучения: {student.learnType}\n" +
                            $"Специальность: {student.specId}\n{student.spec}\n" +
                            $"Факультет: {student.facult}\n" +
                            $"{student.faculty}\n\n" +
                            $"Телефон: {student.phone}\n" +
                            $"Дата рождения: {student.birthday}\n" +
                            $"Адрес: {student.address}";
                        break;
                    case "prep":
                        Teacher teacher = (Teacher)user;
                        l_class.Text = "Преподаватель";
                        l_info.Text = $"Кафедра: {teacher.group}\n" +
                            $"Факультет: {teacher.facult}\n" +
                            $"{teacher.faculty}\n\n" +
                            $"Телефон: {teacher.phone}\n" +
                            $"Дата рождения: {teacher.birthday}\n" +
                            $"Адрес: {teacher.address}";
                        break;
                }
                panel1.Controls.Clear();
                AddMainButtons();
                ((Button)panel1.Controls[0]).PerformClick();
            }
        }

        private void LoadData()
        {
            ta_преподаватель_ПИ.Fill(university_ds.Информация_о_преподе);
            ta_студент_ПИ.Fill(university_ds.Информация_о_студенте);
            ta_факультеты.Fill(university_ds.Факультеты);
            ta_учебплан.Fill(university_ds.Учебный_план);
            ta_студенты.Fill(university_ds.Студенты);
            ta_специальности.Fill(university_ds.Специальности);
            ta_преподаватели.Fill(university_ds.Преподаватели);
            ta_пользователи.Fill(university_ds.Пользователи);
            ta_кафедры.Fill(university_ds.Кафедры);
            ta_дисциплины.Fill(university_ds.Дисциплины);
            ta_группы.Fill(university_ds.Группы);
            ta_ведомость.Fill(university_ds.Ведомость);
        }

        private void SaveData()
        {
            int changes = 0;

            Validate();
            changes += ta_manager.UpdateAll(this.university_ds);
            changes += ведомость_ПреподаTableAdapter.Update(this.university_ds);
            l_warn.Text = "Было изменено записей: " + changes;
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            var filter = "";
            var search_text = tb_search.Text.Trim();
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                filter += string.Format("Convert([{0}], System.String) LIKE '%{1}%' OR ", column.DataPropertyName, search_text);
            }
            SetFilter(default_filter + " AND (" + filter + "1 < 0)");
        }

        private void SetFilter(string filter)
        {
            (dataGridView1.DataSource as BindingSource).Filter = filter;
            var CountRows = dataGridView1.Rows.Count;
            if (dataGridView1.AllowUserToAddRows) CountRows--;
            l_warn.Text = CountRows > 0 ? "Загружено записей: " + CountRows : "Нет данных";
        }

        private void btn_load_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            SaveData();
        }

        private readonly string[] BtnsTitles = new string[]
        {
            "Факультеты",       // 0
            "Кафедры",          // 1
            "Группы",           // 2
            "Студенты",         // 3
            "Ведомости",        // 4
            "Учебный план",     // 5
            "Специальности",    // 6
            "Дисциплины",       // 7
            "Преподаватели",    // 8
            "Пользователи",     // 9
        };

        private readonly int[][] BtnsShowing = new int[][]
        {
            new int[] { 3, 4, 5, 7, 8 },                // Stud
            new int[] { 2, 3, 4, 5, 6, 8 },             // Prep
            new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 }, // Admin
        };

        private void AddMainButtons()
        {
            Button btn;
            int[] btns;
            switch (user.type)
            {
                case "stud":
                    btns = BtnsShowing[0];
                    l_info.Visible = true;
                    button2.Visible = false;
                    break;
                case "prep":
                    btns = BtnsShowing[1];
                    l_info.Visible = true;
                    button2.Visible = false;
                    break;
                case "admin":
                default:
                    btns = BtnsShowing[2];
                    l_info.Visible = false;
                    button2.Visible = true;
                    break;
            }
            Size btn_size = new System.Drawing.Size(panel1.Width, 30);
            var start = panel1.Size.Height - 5 - btn_size.Height;
            for (int i = 0; i < btns.Length; i++)
            {
                btn = new Button();
                panel1.Controls.Add(btn);
                btn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
                btn.Text = BtnsTitles[btns[i]];
                btn.Location = new System.Drawing.Point(0, start);
                btn.Name = "btn_a" + i;
                btn.Size = btn_size;
                btn.Tag = btns[i];
                btn.Click += BtnsClick;
                start -= btn_size.Height + 5;
            }
        }

        private void BtnsClick(object sender, EventArgs e)
        {
            BtnClick((int)((Button)sender).Tag);
        }

        private void BtnClick(int index)
        {
            default_filter = "1 = 1";
            bool edit = false, add = false, remove = false;
            if (user.type == "admin")
            {
                edit = add = remove = true;
            }
            switch (index)
            {
                case 0: // Факультеты
                    OpenInGrid(edit, remove, add, факультетыBindingSource);
                    break;
                case 1: // Кафедры
                    OpenInGrid(edit, remove, add, кафедрыBindingSource);
                    break;
                case 2: // Группы
                    OpenInGrid(edit, remove, add, группыBindingSource);
                    break;
                case 3: // Студенты
                    if (user.type == "stud")
                    {
                        default_filter = "Группа = " + user.groupId;
                    }
                    OpenInGrid(edit, remove, add, студентыBindingSource);
                    break;
                case 4: // Ведомости
                    if (user.type == "stud")
                    {
                        //default_filter = "Студент = " + user.id;
                        ведомостьСтудентаTableAdapter.Fill(university_ds.ВедомостьСтудента, user.id, 0, 0);
                        OpenInGrid(edit, remove, add, ведомостьСтудентаBindingSource);
                    }
                    else if (user.type == "prep")
                    {
                        edit = true;
                        ведомость_ПреподаTableAdapter.Fill(university_ds.Ведомость_Препода, user.id, 0, 0);
                        OpenInGrid(edit, remove, add, ведомость_ПреподаBindingSource);
                    }
                    else
                    {
                        OpenInGrid(edit, remove, add, ведомостьBindingSource);
                    }
                    break;
                case 5: // Учебный план
                    if (user.type == "stud")
                    {
                        default_filter = "Специальность = '" + dm.SelectOne("SELECT Специальности.Код FROM Специальности LEFT JOIN Группы ON Специальности.Код = Группы.Специальность WHERE Группы.Код = " + user.groupId, "Код") + "'";
                    }
                    OpenInGrid(edit, remove, add, учебный_планBindingSource);
                    break;
                case 6: // Специальности
                    OpenInGrid(edit, remove, add, специальностиBindingSource);
                    break;
                case 7: // Дисциплины

                    
                    if (user.type == "stud" || user.type == "prep")
                    {
                        var q = "SELECT Дисциплины.Код " +
                            "FROM(Ведомость INNER JOIN[Учебный план] ON[Учебный план].Код = Ведомость.План) " +
                            "INNER JOIN Дисциплины ON[Учебный план].Дисциплина = Дисциплины.Код " +
                            "WHERE {0} = {1} GROUP BY Дисциплины.Код";
                        if (user.type == "stud")
                            q = string.Format(q, "Студент", user.id);
                        else if (user.type == "prep")
                            q = string.Format(q, "Преподаватель", user.id);
                        SqlConnection connection = new SqlConnection(Properties.Settings.Default.university_db);
                        connection.Open();
                        SqlCommand command = new SqlCommand(q, connection);
                        q = "";
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                q += reader["Код"] + ",";
                            }
                        }
                        q = q.Substring(0, q.Length - 1);
                        connection.Close();
                        default_filter = "Код IN ("+q+")";
                    }
                    OpenInGrid(edit, remove, add, дисциплиныBindingSource);
                    break;
                case 8: // Преподаватели
                    if (user.type == "stud")
                    {
                        преподыTableAdapter.Fill(university_ds.Преподы, user.id, 0);
                        OpenInGrid(edit, remove, add, преподыBindingSource);
                    }
                    else if (user.type == "prep")
                    {
                        преподыTableAdapter.Fill(university_ds.Преподы, 0, user.groupId);
                        OpenInGrid(edit, remove, add, преподыBindingSource);
                    }
                    else
                    {
                        OpenInGrid(edit, remove, add, преподавателиBindingSource);
                    }
                    break;
                case 9: // Пользователи
                    OpenInGrid(edit, remove, add, пользователиBindingSource);
                    break;
            }
            data_title.Text = BtnsTitles[index];
        }


        private void OpenInGrid(bool CanEdit, bool CanRemove, bool CanAdd, BindingSource source)
        {
            dataGridView1.DataSource = source;
            changeAllow(CanEdit, CanRemove, CanAdd);
            SetFilter(default_filter);
        }

        private void changeAllow(bool CanEdit, bool CanRemove, bool CanAdd)
        {
            dataGridView1.AllowUserToAddRows = CanAdd;
            dataGridView1.AllowUserToDeleteRows = CanRemove;
            dataGridView1.ReadOnly = !CanEdit;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex > dataGridView1.Rows.Count - (dataGridView1.AllowUserToAddRows?2:1))
                return;
            var current_cell = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];
            int nid = 0; 
            switch (current_cell.OwningColumn.DataPropertyName.Trim())
            {
                case "Группа":
                    if (current_cell.ValueType == typeof(string))
                    {
                        nid = (int)current_cell.OwningRow.Cells["Код"].Value;
                        BtnClick(3);
                        default_filter = "Группа = " + nid;
                        SetFilter(default_filter);
                    }
                    else
                        OpenInGridAndSelect(2, группыBindingSource, "Код", current_cell.Value);
                    break;

                case "Специальность":
                    OpenInGridAndSelect(6, специальностиBindingSource, "Код", current_cell.Value);
                    break;

                case "Факультет":
                    OpenInGridAndSelect(0, факультетыBindingSource, "Код", current_cell.Value);
                    break;

                case "Кафедра":
                    OpenInGridAndSelect(1, кафедрыBindingSource, "Код", current_cell.Value);
                    break;

                case "Название":
                case "Сокращенное название":
                    nid = (int)current_cell.OwningRow.Cells["Код"].Value;
                    switch (data_title.Text.Trim())
                    {
                        case "Факультеты":
                            BtnClick(1);
                            default_filter = "Факультет = " + nid;
                            SetFilter(default_filter);
                            break;
                        case "Кафедры":
                            BtnClick(8);
                            default_filter = "Кафедра = " + nid;
                            SetFilter(default_filter);
                            break;
                        case "Дисциплины":
                            if (user.type == "stud")
                            {
                                BtnClick(5);
                                default_filter = "Дисциплина = " + nid + " AND Специальность = '" + dm.SelectOne("SELECT Специальности.Код FROM Специальности LEFT JOIN Группы ON Специальности.Код = Группы.Специальность WHERE Группы.Код = " + user.groupId, "Код") + "'";
                                SetFilter(default_filter);
                            }
                            else if (user.type == "prep")
                            {
                                BtnClick(5);
                                default_filter = "Дисциплина = " + nid;
                                SetFilter(default_filter);
                            }
                            break;
                    }
                        
                    break;

                case "classId":
                    var tp = current_cell.OwningRow.Cells["class"].Value.ToString().Trim();
                    if (tp == "prep")
                        OpenInGridAndSelect(8, преподавателиBindingSource, "Код", current_cell.Value);
                    else if (tp == "stud")
                        OpenInGridAndSelect(3, студентыBindingSource, "Зачётка", current_cell.Value);
                    break;
            }
        }

        private void OpenInGridAndSelect(int iBtn, BindingSource source, string key, object value)
        {
            BtnClick(iBtn);
            int nid = source.Find(key, value);
            dataGridView1.ClearSelection();
            dataGridView1.Rows[nid].Selected = true;
            dataGridView1.FirstDisplayedScrollingRowIndex = nid;
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Report r = new Report();
            r.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Help r = new Help();
            r.ShowDialog();
        }
    }
}
