using System;
using System.Data;
using System.Data.SqlClient;

namespace University
{
    public class DataManager
    {
        private readonly Main form;
        public DataManager(Main form)
        {
            this.form = form;
        }

        public User GetUser()
        {
            User user = new User();

            user.type = Properties.Settings.Default.type;
            user.login = Properties.Settings.Default.login;
            user.pass = Properties.Settings.Default.pass;

            DataView view;
            switch (user.type)
            {
                case "stud":
                    view = form.ta_студент_ПИ.GetData().DefaultView;
                    view.RowFilter = $"login = '{user.login}' and pass = '{user.pass}'";

                    Student student = new Student(user);
                    student.kurs = int.Parse(view[0][10].ToString().Trim());
                    student.specId = view[0][15].ToString().Trim();
                    student.spec = view[0][14].ToString().Trim();
                    student.learnType = view[0][11].ToString().Trim();

                    student.id = int.Parse(view[0][0].ToString().Trim());
                    student.name = view[0][4].ToString().Trim();
                    student.phone = view[0][5].ToString().Trim();
                    student.birthday = view[0][6].ToString().Trim().Split(' ')[0];
                    student.address = view[0][7].ToString().Trim();
                    student.groupId = int.Parse(view[0][8].ToString().Trim());
                    student.group = view[0][9].ToString().Trim();
                    student.faculty = view[0][12].ToString().Trim();
                    student.facult = view[0][13].ToString().Trim();

                    user = (User)student;
                    break;
                case "prep":
                    Teacher teacher = new Teacher(user);
                    view = form.ta_преподаватель_ПИ.GetData().DefaultView;
                    view.RowFilter = $"login = '{user.login}' and pass = '{user.pass}'";

                    teacher.id = int.Parse(view[0][0].ToString().Trim());
                    teacher.name = view[0][4].ToString().Trim();
                    teacher.phone = view[0][7].ToString().Trim();
                    teacher.birthday = view[0][6].ToString().Trim().Split(' ')[0];
                    teacher.address = view[0][5].ToString().Trim();
                    teacher.groupId = int.Parse(view[0][10].ToString().Trim());
                    teacher.group = view[0][11].ToString().Trim();
                    teacher.faculty = view[0][8].ToString().Trim();
                    teacher.facult = view[0][9].ToString().Trim();

                    user = (User)teacher;
                    break;
            }

            return user;
        }

        public object SelectOne(string query, string value)
        {
            SqlConnection connection = new SqlConnection(Properties.Settings.Default.university_db);
            connection.Open();
            SqlCommand command = new SqlCommand(query, connection);
            object res = null;
            using (SqlDataReader reader = command.ExecuteReader())
            {
                if (reader.Read())
                {
                    res = reader[value];
                }
            }
            connection.Close();
            return res;
        }

        public int Query(string query)
        {
            SqlConnection connection = new SqlConnection(Properties.Settings.Default.university_db);
            connection.Open();
            SqlCommand command = new SqlCommand(query, connection);
            var r = command.ExecuteNonQuery();
            connection.Close();
            return r;
        }

        public class User
        {
            public int id;
            public string login;
            public string pass;
            public string type;

            public string name;
            public string phone;
            public string address;
            public string birthday;
            public int groupId;
            public string group;
            public string faculty;
            public string facult;
            public User() { }
            public User(User user)
            {
                this.id = user.id;
                this.login = user.login;
                this.pass = user.pass;
                this.type = user.type;
                this.name = user.name;
                this.phone = user.phone;
                this.address = user.address;
                this.birthday = user.birthday;
                this.groupId = user.groupId;
                this.group = user.group;
                this.facult = user.facult;
                this.faculty = user.faculty;
            }
        }

        public class Teacher : User
        {
            public Teacher(User user) : base(user) { }
        }

        public class Student : User
        {
            public Student(User user) : base(user) { }
            public int kurs;
            public string learnType;
            public string specId;
            public string spec;
        }
    }
}
