using System;
using System.Windows.Forms;

namespace StudentProfileApp
{
    public partial class StudentPage : Form
    {
        private Student student;

        public StudentPage()
        {
            InitializeComponent();
            student = new Student
            {
                Name = "Charles Dave A. Bugarin",
                Age = 21,
                Address = "M.H.D.P Bayambang, Pangasinan",
                ContactNumber = "+639564366036",
                EmailAddress = "bogartpenta123@gmail.com",
                CourseYear = "BSIT Third Year",
                Guardian = "Dave Bugarin",
                GuardianContactNumber = "+639129451235",
                Hobbies = "Gaming",
                Nickname = "CD"
            };
            DisplayStudentInfo();
        }

        private void DisplayStudentInfo()
        {
            NameTextBox.Text = student.Name;
            AgeTextBox.Text = student.Age.ToString();
            AddressTextBox.Text = student.Address;
            ContactNumberTextBox.Text = student.ContactNumber;
            EmailAddressTextBox.Text = student.EmailAddress;
            CourseYearTextBox.Text = student.CourseYear;
            GuardianTextBox.Text = student.Guardian;
            GuardianContactTextBox.Text = student.GuardianContactNumber;
            HobbiesTextBox.Text = student.Hobbies;
            NicknameTextBox.Text = student.Nickname;
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            EditPage editPage = new EditPage(student);
            if (editPage.ShowDialog() == DialogResult.OK)
            {
                DisplayStudentInfo();
            }
        }
    }
}