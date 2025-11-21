/// Emilii-Viktorian Bahirov-Kasianenko F110580
using StudentsStudyPlanner.Models;
using System;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Runtime.CompilerServices.RuntimeHelpers;

namespace StudentsStudyPlanner.Forms
{
    // Тази форма се ползва за добавяне и редактиране на курсове.
    public partial class CourseForm : Form
    {
        // Тези public свойства са, за да може MainForm да си дръпне данните от текстовите полета.
        public string CourseName { get { return txtName.Text.Trim(); } }
        public string CourseCode { get { return txtCode.Text.Trim(); } }
        public string CourseTeacher { get { return txtTeacher.Text.Trim(); } }
        public string CourseSemester { get { return txtSemester.Text.Trim(); } }

        // Конструктор за чисто нова форма (когато добавяме нов курс).
        public CourseForm()
        {
            InitializeComponent();
            // Заглавието на прозореца, да се знае какво правим.
            this.Text = "Нов курс";
        }

        // Конструктор, който приема съществуващ курс за редактиране.
        public CourseForm(Course course) : this() // this() вика горния конструктор, за да не повтаряме InitializeComponent().
        {
            this.Text = "Редактиране на курс";

            // Ако са ни подали курс, пълним полетата с неговите данни.
            if (course != null)
            {
                txtName.Text = course.Name;
                txtCode.Text = course.Code;
                txtTeacher.Text = course.Teacher;
                txtSemester.Text = course.Semester; 
            }
        }

        // Като цъкнем "ОК", първо проверяваме дали поне името на курса е въведено.
        private void btnOk_Click(object sender, EventArgs e)
        {
            // Без име не може, показваме съобщение и чакаме потребителя да го въведе.
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Моля, въведете име на курса.");
                txtName.Focus(); // Слагаме курсора директно в полето за име.
                return;
            }

            // останалите полета спокойно може да са празни – не сме в корпорация
            // Всичко е точно, казваме на MainForm, че сме готови (DialogResult.OK) и затваряме.
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        // Потребителят се отказа, просто затваряме формата.
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            // оставям празно – дизайнерът го е вързал, но не ни треба
        }
    }
}
