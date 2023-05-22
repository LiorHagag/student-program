using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace SqlConnectionLior
{
 
    public partial class Form1 : Form
    {
        Boolean flag = false;
        Random rnd = new Random();
        Courses c = new Courses();
        Student s = new Student();
        SqlConnection getMySqlConnection()
        {

            string connctionString = string.Format("Data Source = {0};Initial Catalog = {1};" +
              " User ID = {2};Password = {3};"
               , Server.Text.ToString(), Database.Text.ToString(),
               Username.Text.ToString(), Password.Text.ToString());

            SqlConnection sqlconect = new SqlConnection(connctionString);
            return sqlconect;
        }



        public void isitAnabled(bool flag)
        {
            try
            {
               
                SqlConnection con = getMySqlConnection();
                if (flag)
                {
                    TheChosenCourse.Items.Clear();
                    con.Open();
                 
                    MessageBox.Show("connection succeeded", "connection Message",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "SELECT  [Name]  FROM [MyConnection].[dbo].[courses] ";
                    cmd.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    foreach (DataRow dr in dt.Rows)
                    {
                        TheChosenCourse.Items.Add(dr["Name"].ToString());
                    }
                }
                else
                {
                    MessageBox.Show("Disconnected", "Message",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                if (TheChosenCourse.Text != "")
                {
                    SqlCommand cmd = new SqlCommand("SELECT count( StudentId) as axxsfd" +
                        "\r\nFROM [MyConnection].[dbo].[grades] \r\n" +
                        "INNER JOIN [MyConnection].[dbo].[students] " +
                        "\r\n    on studentid = Id\r\n" +
                        "INNER JOIN [MyConnection].[dbo].[courses]as c" +
                        "\r\n    on CourseNumber=Number\r\n" +
                        "where c.Name='" + TheChosenCourse.Text + "'", con);
                    cmd.ExecuteNonQuery();

                    SqlCommand cmd1 = new SqlCommand("   SELECT AVG(Grade) as gradesAdeG" +
                        " FROM [MyConnection].[dbo].[grades]  " +
                        "INNER JOIN [MyConnection].[dbo].[students] " +
                        " on studentid = Id " +
                        "INNER JOIN [MyConnection].[dbo].[courses]as c" +
                        "    on CourseNumber=Number" +
                        " where c.Name='" + TheChosenCourse.Text + "'", con);
                    cmd1.ExecuteNonQuery();

                    SqlCommand cmd2 = new SqlCommand("SELECT count(Grade) as goodness FROM grades INNER JOIN courses" +
                        " ON[Number] = [courseNumber] and courses.Name = '" + TheChosenCourse.Text + "' and grade < 50;"
                   , con);
                    cmd1.ExecuteNonQuery();
                   setBoxSummery(cmd, cmd1, cmd2);

                }
                else
                {
                    textBoxOfSummery.Text = null;
                }
            }


            
            catch (Exception)
            {

            }
        }

        public void setBoxSummery(SqlCommand s, SqlCommand a, SqlCommand f)
        {
            Int32 qs = ((Int32?)s.ExecuteScalar()) ?? 0;
            Int32 qa = ((Int32?)a.ExecuteScalar()) ?? 0;
            Int32 qf = ((Int32?)f.ExecuteScalar()) ?? 0;
            textBoxOfSummery.Text = "Students in Course: " +
                qs + ", Grade Avarage: " + qa + ", Failed Students: " + qf;
        }
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Server.Text = "MyPC";
            Database.Text = "MyCONNECTION";
            Username.Text = "lior";
            Password.Text = "869911";
        }

        private void Connectbtn_Click(object sender, EventArgs e)
        {
            flag = true;
            isitAnabled(flag);
        }

        private void Disconnectbtn_Click(object sender, EventArgs e)
        {
            SqlConnection con = getMySqlConnection();
            con.Close();
            try
            {
                flag = false;
                isitAnabled(flag);
                
            }
            catch
            {
                
                MessageBox.Show("Disconnection not worked", "Error Message",
                    MessageBoxButtons.OK);
            }

        }
        private Boolean checkConnection()
        {
            SqlConnection con = getMySqlConnection();
            if (con != null && con.State != ConnectionState.Closed)
                return true;
            return false;

        }

        private void Server_TextChanged(object sender, EventArgs e)
        {

        }
        private void fetchBT_Click(object sender, EventArgs e)
        {
            try
            {
                if (BestButton.Checked)
                {
                    SqlConnection con = getMySqlConnection();

                    if (flag)
                    {
                        Grades[] allRecords = null;
                        string sql = @"SELECT TOP (" + numericstudentsgrades.Value + ") [MyConnection].[dbo].[students].Name,grade " +
                            "FROM [MyConnection].[dbo].[grades] " +
                            "INNER JOIN [MyConnection].[dbo].[students] " +
                            "  on studentid = Id" +
                            " INNER JOIN [MyConnection].[dbo].[courses]as c" +
                            " on CourseNumber=Number " +
                            "where c.Name='" + TheChosenCourse.Text + "'" +
                            " order by grade desc ";

                        using (var command = new SqlCommand(sql, con))
                        {
                            con.Open();
                            using (var reader = command.ExecuteReader())
                            {
                                var list = new List<Grades>();
                                while (reader.Read())
                                    list.Add(new Grades { Name = reader.GetString(0), GradeOfStudent = reader.GetInt32(1) });



                                allRecords = list.ToArray();
                                var groupedList = allRecords.GroupBy(GradeOfStudent => GradeOfStudent.Name).ToList();

                                dataGridOfStudents.DataSource = groupedList;
                            }
                        }
                    }
                }
                else if (WorstButton.Checked)
                {
                    SqlConnection con = getMySqlConnection();

                    if (flag)
                    {
                        Grades[] allRecords = null;
                        string sql = @"SELECT TOP (" + numericstudentsgrades.Value + ") [MyConnection].[dbo].[students].Name,grade " +
                            "FROM [MyConnection].[dbo].[grades] " +
                            "INNER JOIN [MyConnection].[dbo].[students] " +
                            "  on studentid = Id" +
                            " INNER JOIN [MyConnection].[dbo].[courses]as c" +
                            " on CourseNumber=Number " +
                            "where c.Name='" + TheChosenCourse.Text + "'" +
                            " order by grade  ASC";




                        using (var command = new SqlCommand(sql, con))
                        {
                            con.Open();
                            using (var reader = command.ExecuteReader())
                            {
                                var list = new List<Grades>();
                                while (reader.Read())
                                    list.Add(new Grades { Name = reader.GetString(0), GradeOfStudent = reader.GetInt32(1) });



                                allRecords = list.ToArray();
                                var groupedList = allRecords.GroupBy(GradeOfStudent => GradeOfStudent.Name).ToList();

                                dataGridOfStudents.DataSource = groupedList;
                            }
                        }
                    }
                }



            }
            catch
            {
                MessageBox.Show("connection crashed ", "Error Message",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            
            }

        }


 

        private void label5_Click(object sender, EventArgs e)
        {

        }



        private void numericCourses_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericStudents_ValueChanged(object sender, EventArgs e)
        {

        }
        private void Clear_Click(object sender, EventArgs e)
        {
            try
            {
                flag = true;
                if (flag)
                {

                    SqlConnection con = getMySqlConnection();
                   
                    con.Open();
                    SqlCommand cmd = new SqlCommand("delete  from grades", con);

                    cmd.ExecuteNonQuery();

                    SqlCommand cmd1 = new SqlCommand("delete  from courses", con);

                    cmd1.ExecuteNonQuery();
                    SqlCommand cmd2 = new SqlCommand("delete  from students", con);

                    cmd2.ExecuteNonQuery();
                    MessageBox.Show("all cleared", "success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                }
                else
                {

                    MessageBox.Show("cant clear" +
                    " connect and try again", "Error Message",
               MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
            catch (Exception)
            {
                MessageBox.Show("connection Failed", "Error Message",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    

    private void Populate_Click(object sender, EventArgs e)
    {
  
            try
            {
                for (int j = 0; j < numericStudents.Value; j++)
                {
                    if (flag)
                    {
                        c.Number = rnd.Next(0, 99);
                        int grades = rnd.Next(0, 98);
                        int IDS = rnd.Next(0, 9090);
                        int ink = rnd.Next(0, 94);
                        SqlConnection con = getMySqlConnection();
                        //string str = @"server=localhost;userid=root;password=869911;database=myfirstconnection;";
                        //con = new MySqlConnection(str);
                        con.Open();

                        SqlCommand cmd2 = new SqlCommand("select  count(name) from students", con);
                        cmd2.ExecuteNonQuery();
                        Int32 qs = ((Int32?)cmd2.ExecuteScalar()) ?? 0;

                        s.Name = "student " + (IDS);
                        s.Id = ink + j;
                        SqlCommand cmd = new SqlCommand("insert into students (Name,Id)values('"
                            + s.Name + "','" + s.Id + "')", con);
                        cmd.ExecuteNonQuery();

                        SqlCommand cmd4 = new SqlCommand("UPDATE  [MyConnection].[dbo].[grades]\r\nSET Grade = ROUND( 100 *RAND(convert(varbinary, newid())), 0)\r\nWHERE  Grade<1000", con);
                        cmd4.ExecuteNonQuery();


                        SqlCommand cmd3 = new SqlCommand("insert into grades (StudentId,CourseNumber, Grade)" +
                             "\r\nselect  students.Id, courses.Number,'" + grades + "'" +
                             "\r\nfrom students,courses\r\n" +
                             "select * from grades\r\n" +
                             "select * from students", con);
                        cmd3.ExecuteNonQuery();





                        if (j == numericStudents.Value - 1)
                        {
                            MessageBox.Show("Students Data Recorded", "Sucsess Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        if (j == numericStudents.Value - 1)
                        {
                            MessageBox.Show("you are not connected" +
                            " please connect and try again", "Error Message",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
                          
                        }
                    }
                }





                for (int i = 0; i < numericCourses.Value; i++)
                {
                    if (flag)
                    {
                        SqlConnection con = getMySqlConnection();
                        con.Open();
                        int grades = rnd.Next(0, 100);
                        int ink = rnd.Next(0, 100);
                        int CR = rnd.Next(0, 10000);
                        c.Number = CR + i;
                        c.Name = "Course " + c.Number;



                        SqlCommand cmd = new SqlCommand("insert into courses (Name,Number)values('"
                            + c.Name + "','" + c.Number + "')", con);
                        cmd.ExecuteNonQuery();
                        SqlCommand cmd3 = new SqlCommand("insert into grades (StudentId,CourseNumber, Grade)" +
                              "\r\nselect  students.Id, '" + c.Number + "','" + ink + "'" +
                              "\r\nfrom students,courses\r\n" +
                              "select * from grades\r\n" +
                              "select * from students", con);
                        cmd3.ExecuteNonQuery();

                        SqlCommand cmd4 = new SqlCommand("UPDATE  [MyConnection].[dbo].[grades]\r\nSET Grade = ROUND( 100 *RAND(convert(varbinary, newid())), 0)\r\nWHERE  Grade<1000", con);
                        cmd4.ExecuteNonQuery();

                        if (i == numericCourses.Value - 1)
                        {
                            MessageBox.Show("Courses Data Recorded", "Sucsess Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        if (i == numericCourses.Value - 1)
                        {
                            MessageBox.Show("you are not connected" +
                            "  connect now and try again", "Error Message",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }



                }
            }
            catch (Exception)
             {
                 MessageBox.Show("connection stopped ", "Error Message",
                     MessageBoxButtons.OK, MessageBoxIcon.Error);
             }
            dataGridOfStudents.DataSource = null;

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBoxOfSummery_TextChanged(object sender, EventArgs e)
        {

        }

        private void TheChosenCourse_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BestButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void WorstButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dataGridOfStudents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void numericstudentsgrades_ValueChanged(object sender, EventArgs e)
        {

        }

        private void RefeshBT_Click(object sender, EventArgs e)
        {
            try
            {
                if (flag)
                {
                    isitAnabled(flag);
                    dataGridOfStudents.DataSource = null;
                }
                else
                {
                    MessageBox.Show("cant Clear, connect first", "Error Message",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                  
                }

            }
            catch
            {
                MessageBox.Show("connection crashed by Clear Button", "Error Message",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
              
            }
        }
    }
}
