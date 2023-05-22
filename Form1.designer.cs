namespace SqlConnectionLior
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.Server = new System.Windows.Forms.TextBox();
            this.Database = new System.Windows.Forms.TextBox();
            this.Username = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Connectbtn = new System.Windows.Forms.Button();
            this.Disconnectbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.fetchBT = new System.Windows.Forms.Button();
            this.numericCourses = new System.Windows.Forms.NumericUpDown();
            this.numericStudents = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Clear = new System.Windows.Forms.Button();
            this.Populate = new System.Windows.Forms.Button();
            this.StudentCount = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.TheChosenCourse = new System.Windows.Forms.ComboBox();
            this.textBoxOfSummery = new System.Windows.Forms.TextBox();
            this.numericstudentsgrades = new System.Windows.Forms.NumericUpDown();
            this.WorstButton = new System.Windows.Forms.RadioButton();
            this.BestButton = new System.Windows.Forms.RadioButton();
            this.dataGridOfStudents = new System.Windows.Forms.DataGridView();
            this.RefeshBT = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericCourses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericStudents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericstudentsgrades)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOfStudents)).BeginInit();
            this.SuspendLayout();
            // 
            // Server
            // 
            this.Server.Location = new System.Drawing.Point(128, 80);
            this.Server.Margin = new System.Windows.Forms.Padding(4);
            this.Server.Name = "Server";
            this.Server.Size = new System.Drawing.Size(84, 22);
            this.Server.TabIndex = 0;
            this.Server.TextChanged += new System.EventHandler(this.Server_TextChanged);
            // 
            // Database
            // 
            this.Database.Location = new System.Drawing.Point(321, 79);
            this.Database.Margin = new System.Windows.Forms.Padding(4);
            this.Database.Name = "Database";
            this.Database.Size = new System.Drawing.Size(84, 22);
            this.Database.TabIndex = 1;
            // 
            // Username
            // 
            this.Username.Location = new System.Drawing.Point(529, 80);
            this.Username.Margin = new System.Windows.Forms.Padding(4);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(109, 22);
            this.Username.TabIndex = 2;
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(731, 80);
            this.Password.Margin = new System.Windows.Forms.Padding(4);
            this.Password.Name = "Password";
            this.Password.PasswordChar = '*';
            this.Password.Size = new System.Drawing.Size(123, 22);
            this.Password.TabIndex = 3;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Connectbtn
            // 
            this.Connectbtn.Location = new System.Drawing.Point(875, 79);
            this.Connectbtn.Margin = new System.Windows.Forms.Padding(4);
            this.Connectbtn.Name = "Connectbtn";
            this.Connectbtn.Size = new System.Drawing.Size(100, 28);
            this.Connectbtn.TabIndex = 7;
            this.Connectbtn.Text = "Connect";
            this.Connectbtn.UseVisualStyleBackColor = true;
            this.Connectbtn.Click += new System.EventHandler(this.Connectbtn_Click);
            // 
            // Disconnectbtn
            // 
            this.Disconnectbtn.Location = new System.Drawing.Point(983, 78);
            this.Disconnectbtn.Margin = new System.Windows.Forms.Padding(4);
            this.Disconnectbtn.Name = "Disconnectbtn";
            this.Disconnectbtn.Size = new System.Drawing.Size(100, 28);
            this.Disconnectbtn.TabIndex = 8;
            this.Disconnectbtn.Text = "Disconnect";
            this.Disconnectbtn.UseVisualStyleBackColor = true;
            this.Disconnectbtn.Click += new System.EventHandler(this.Disconnectbtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 82);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Server: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(239, 84);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Database:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(444, 84);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Username:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(648, 82);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Password:";
            // 
            // fetchBT
            // 
            this.fetchBT.Location = new System.Drawing.Point(505, 302);
            this.fetchBT.Margin = new System.Windows.Forms.Padding(4);
            this.fetchBT.Name = "fetchBT";
            this.fetchBT.Size = new System.Drawing.Size(93, 28);
            this.fetchBT.TabIndex = 13;
            this.fetchBT.Text = "Fetch";
            this.fetchBT.UseVisualStyleBackColor = true;
            this.fetchBT.Click += new System.EventHandler(this.fetchBT_Click);
            // 
            // numericCourses
            // 
            this.numericCourses.Location = new System.Drawing.Point(128, 158);
            this.numericCourses.Name = "numericCourses";
            this.numericCourses.Size = new System.Drawing.Size(105, 22);
            this.numericCourses.TabIndex = 14;
            this.numericCourses.ValueChanged += new System.EventHandler(this.numericCourses_ValueChanged);
            // 
            // numericStudents
            // 
            this.numericStudents.Location = new System.Drawing.Point(307, 158);
            this.numericStudents.Name = "numericStudents";
            this.numericStudents.Size = new System.Drawing.Size(98, 22);
            this.numericStudents.TabIndex = 15;
            this.numericStudents.ValueChanged += new System.EventHandler(this.numericStudents_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(61, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 16);
            this.label5.TabIndex = 16;
            this.label5.Text = "Courses: ";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(239, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 16);
            this.label6.TabIndex = 17;
            this.label6.Text = "Students:";
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(434, 157);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(88, 23);
            this.Clear.TabIndex = 18;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Populate
            // 
            this.Populate.Location = new System.Drawing.Point(545, 157);
            this.Populate.Name = "Populate";
            this.Populate.Size = new System.Drawing.Size(93, 23);
            this.Populate.TabIndex = 19;
            this.Populate.Text = "Populate";
            this.Populate.UseVisualStyleBackColor = true;
            this.Populate.Click += new System.EventHandler(this.Populate_Click);
            // 
            // StudentCount
            // 
            this.StudentCount.AutoSize = true;
            this.StudentCount.Location = new System.Drawing.Point(61, 296);
            this.StudentCount.Name = "StudentCount";
            this.StudentCount.Size = new System.Drawing.Size(95, 16);
            this.StudentCount.TabIndex = 20;
            this.StudentCount.Text = "Student Count: ";
            this.StudentCount.Click += new System.EventHandler(this.label7_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(61, 210);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 16);
            this.label7.TabIndex = 21;
            this.label7.Text = "Choose course:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(61, 251);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 16);
            this.label8.TabIndex = 22;
            this.label8.Text = "Summary:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // TheChosenCourse
            // 
            this.TheChosenCourse.FormattingEnabled = true;
            this.TheChosenCourse.Location = new System.Drawing.Point(180, 207);
            this.TheChosenCourse.Name = "TheChosenCourse";
            this.TheChosenCourse.Size = new System.Drawing.Size(121, 24);
            this.TheChosenCourse.TabIndex = 23;
            this.TheChosenCourse.SelectedIndexChanged += new System.EventHandler(this.TheChosenCourse_SelectedIndexChanged);
            // 
            // textBoxOfSummery
            // 
            this.textBoxOfSummery.Location = new System.Drawing.Point(128, 251);
            this.textBoxOfSummery.Name = "textBoxOfSummery";
            this.textBoxOfSummery.Size = new System.Drawing.Size(955, 22);
            this.textBoxOfSummery.TabIndex = 24;
            this.textBoxOfSummery.TextChanged += new System.EventHandler(this.textBoxOfSummery_TextChanged);
            // 
            // numericstudentsgrades
            // 
            this.numericstudentsgrades.Location = new System.Drawing.Point(180, 296);
            this.numericstudentsgrades.Name = "numericstudentsgrades";
            this.numericstudentsgrades.Size = new System.Drawing.Size(105, 22);
            this.numericstudentsgrades.TabIndex = 25;
            this.numericstudentsgrades.ValueChanged += new System.EventHandler(this.numericstudentsgrades_ValueChanged);
            // 
            // WorstButton
            // 
            this.WorstButton.AutoSize = true;
            this.WorstButton.Location = new System.Drawing.Point(414, 306);
            this.WorstButton.Name = "WorstButton";
            this.WorstButton.Size = new System.Drawing.Size(63, 20);
            this.WorstButton.TabIndex = 26;
            this.WorstButton.TabStop = true;
            this.WorstButton.Text = "Worst";
            this.WorstButton.UseVisualStyleBackColor = true;
            this.WorstButton.CheckedChanged += new System.EventHandler(this.WorstButton_CheckedChanged);
            // 
            // BestButton
            // 
            this.BestButton.AutoSize = true;
            this.BestButton.Location = new System.Drawing.Point(334, 306);
            this.BestButton.Name = "BestButton";
            this.BestButton.Size = new System.Drawing.Size(55, 20);
            this.BestButton.TabIndex = 27;
            this.BestButton.TabStop = true;
            this.BestButton.Text = "Best";
            this.BestButton.UseVisualStyleBackColor = true;
            this.BestButton.CheckedChanged += new System.EventHandler(this.BestButton_CheckedChanged);
            // 
            // dataGridOfStudents
            // 
            this.dataGridOfStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridOfStudents.Location = new System.Drawing.Point(651, 279);
            this.dataGridOfStudents.Name = "dataGridOfStudents";
            this.dataGridOfStudents.RowHeadersWidth = 51;
            this.dataGridOfStudents.RowTemplate.Height = 24;
            this.dataGridOfStudents.Size = new System.Drawing.Size(203, 150);
            this.dataGridOfStudents.TabIndex = 28;
            this.dataGridOfStudents.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridOfStudents_CellContentClick);
            // 
            // RefeshBT
            // 
            this.RefeshBT.Location = new System.Drawing.Point(321, 208);
            this.RefeshBT.Name = "RefeshBT";
            this.RefeshBT.Size = new System.Drawing.Size(88, 23);
            this.RefeshBT.TabIndex = 29;
            this.RefeshBT.Text = "Refesh";
            this.RefeshBT.UseVisualStyleBackColor = true;
            this.RefeshBT.Click += new System.EventHandler(this.RefeshBT_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1127, 450);
            this.Controls.Add(this.RefeshBT);
            this.Controls.Add(this.dataGridOfStudents);
            this.Controls.Add(this.BestButton);
            this.Controls.Add(this.WorstButton);
            this.Controls.Add(this.numericstudentsgrades);
            this.Controls.Add(this.textBoxOfSummery);
            this.Controls.Add(this.TheChosenCourse);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.StudentCount);
            this.Controls.Add(this.Populate);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numericStudents);
            this.Controls.Add(this.numericCourses);
            this.Controls.Add(this.fetchBT);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Disconnectbtn);
            this.Controls.Add(this.Connectbtn);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.Database);
            this.Controls.Add(this.Server);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericCourses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericStudents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericstudentsgrades)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOfStudents)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Server;
        private System.Windows.Forms.TextBox Database;
        private System.Windows.Forms.TextBox Username;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button Connectbtn;
        private System.Windows.Forms.Button Disconnectbtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button fetchBT;
        private System.Windows.Forms.NumericUpDown numericCourses;
        private System.Windows.Forms.NumericUpDown numericStudents;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button Populate;
        private System.Windows.Forms.Label StudentCount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox TheChosenCourse;
        private System.Windows.Forms.TextBox textBoxOfSummery;
        private System.Windows.Forms.NumericUpDown numericstudentsgrades;
        private System.Windows.Forms.RadioButton WorstButton;
        private System.Windows.Forms.RadioButton BestButton;
        private System.Windows.Forms.DataGridView dataGridOfStudents;
        private System.Windows.Forms.Button RefeshBT;
    }
}

