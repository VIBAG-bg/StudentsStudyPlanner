/// Emilii-Viktorian Bahirov-Kasianenko F110580
using StudentsStudyPlanner.Forms;   // Тук са другите ни форми - CourseForm, TaskForm
using StudentsStudyPlanner.Models;   // А тук са моделите, които описват данните
using System;
using System.Windows.Forms;


namespace StudentsStudyPlanner
{
    // Това е главната форма на приложението, от тук почва всичко.
    public partial class MainForm : Form
    {
        private DataManager dataManager; // Мениджър, който се грижи за данните (курсове, задачи).
        private Course selectedCourse; // Кой курс е избран в момента от списъка.

        public MainForm()
        {                                                                                                                   
            InitializeComponent();
            // Взимаме единствената инстанция на DataManager-а (Singleton pattern).
            dataManager = DataManager.Instance;
        }

        // Този метод се вика, когато формата зареди за първи път.
        private void MainForm_Load(object sender, EventArgs e)
        {
            // Ако няма никакви курсове, да не е празно, създаваме малко демо данни.
            if (dataManager.GetAllCourses().Count == 0)
            {
                SeedDemoData();
            }

            // Зареждаме курсовете в левия списък.
            LoadCourses();
        }

        // Метод за създаване на примерни данни, за да не е празно приложението при първо пускане.
        private void SeedDemoData()
        {
            // Примерен курс по ООП
            var csharpCourse = new Course();
            csharpCourse.Name = "Обектно-ориентирано програмиране";
            csharpCourse.Code = "CSCB579";
            csharpCourse.Teacher = "преп. Иван Петров";
            csharpCourse.Semester = "Зимен семестър";

            // Добавяме му едно домашно.
            csharpCourse.AddTask(new HomeworkTask
            {
                Name = "Домашно 1 – класове",
                Description = "Прости класове с полета и свойства",
                Deadline = DateTime.Now.AddDays(7),
                Priority = Priority.High,
                Status = TaskStatus.InProgress,
                Subject = "C#",
                ExerciseNumber = "1"
            });

            // И един изпит.
            csharpCourse.AddTask(new ExamTask
            {
                Name = "Междинен изпит",
                Description = "Наследяване и полиморфизъм",
                Deadline = DateTime.Now.AddDays(14),
                Priority = Priority.High,
                Status = TaskStatus.NotStarted,
                Subject = "C#",
                Time = "10:00",
                Room = "Зала 300"
            });

            dataManager.AddCourse(csharpCourse);

            // Примерен курс по бази данни
            var dbCourse = new Course();
            dbCourse.Name = "Бази данни";
            dbCourse.Code = "CSCB515";
            dbCourse.Teacher = "проф. Мария Георгиева";
            dbCourse.Semester = "Зимен семестър";

            // И един проект към него.
            dbCourse.AddTask(new ProjectTask
            {
                Name = "Мини библиотека",
                Description = "CRUD за книги и читатели",
                Deadline = DateTime.Now.AddDays(30),
                Priority = Priority.Medium,
                Status = TaskStatus.NotStarted,
                Topic = "БД",
                TeamMembers = "Аз + още двама"
            });

            dataManager.AddCourse(dbCourse);
        }

        // Презарежда списъка с курсове от DataManager-а.
        private void LoadCourses()
        {
            listBoxCourses.Items.Clear(); // Чистим старите, за да няма дубликати.

            foreach (var c in dataManager.GetAllCourses())
            {
                listBoxCourses.Items.Add(c);
            }

            // Ако няма курсове, нулираме всичко.
            if (listBoxCourses.Items.Count == 0)
            {
                selectedCourse = null;
                lblSelectedCourse.Text = "Няма избран курс";
                listBoxTasks.Items.Clear();
            }
        }

        // Презарежда списъка със задачи за избрания в момента курс.
        private void LoadTasks()
        {
            listBoxTasks.Items.Clear();

            // Ако не е избран курс, няма какво да показваме.
            if (selectedCourse == null)
            {
                lblSelectedCourse.Text = "Няма избран курс";
                return;
            }

            // Показваме името на избрания курс отгоре.
            lblSelectedCourse.Text = selectedCourse.Name + " (" + selectedCourse.Code + ")";

            // Дърпаме задачите от курса и ги набиваме в десния списък.
            foreach (var t in selectedCourse.GetAllTasks())
            {
                listBoxTasks.Items.Add(t);
            }
        }

        // Когато потребителят цъкне на друг курс в списъка.
        private void listBoxCourses_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedCourse = listBoxCourses.SelectedItem as Course;
            LoadTasks(); // Презареждаме задачите за новоизбрания курс.
        }

        // При двоен клик на задача - показваме детайли.
        private void listBoxTasks_DoubleClick(object sender, EventArgs e)
        {
            var task = listBoxTasks.SelectedItem as StudyTask;
            if (task == null) return;

            // Просто едно MessageBox-че с информацията от задачата.
            MessageBox.Show(task.GetDetails(), "Детайли за задачата",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Бутон "Добави курс" - отваря CourseForm.
        private void btnAddCourse_Click(object sender, EventArgs e)
        {
            using (var form = new CourseForm())
            {
                // Ако потребителят натисне "ОК" във формата...
                if (form.ShowDialog() == DialogResult.OK)
                {
                    // ...създаваме нов курс с данните от нея.
                    var course = new Course();
                    course.Name = form.CourseName;
                    course.Code = form.CourseCode;
                    course.Teacher = form.CourseTeacher;
                    course.Semester = form.CourseSemester;

                    dataManager.AddCourse(course);
                    LoadCourses(); // Опресняваме списъка с курсове.
                }
            }
        }

        // Бутон "Редактирай курс".
        private void btnEditCourse_Click(object sender, EventArgs e)
        {
            if (selectedCourse == null)
            {
                MessageBox.Show("Първо изберете курс от списъка.");
                return;
            }

            // Отваряме същата форма, но й подаваме избрания курс, за да го редактира.
            using (var form = new CourseForm(selectedCourse))
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    // Обновяваме данните на избрания курс с новите от формата.
                    selectedCourse.Name = form.CourseName;
                    selectedCourse.Code = form.CourseCode;
                    selectedCourse.Teacher = form.CourseTeacher;
                    selectedCourse.Semester = form.CourseSemester;

                    dataManager.UpdateCourse(selectedCourse);
                    LoadCourses(); // Опресняваме, за да се види промяната.
                    LoadTasks(); // И задачите, ако името на курса се е сменило.
                }
            }
        }

        // Бутон "Изтрий курс".
        private void btnDeleteCourse_Click(object sender, EventArgs e)
        {
            if (selectedCourse == null)
            {
                MessageBox.Show("Първо изберете курс за изтриване.");
                return;
            }

            // Питаме за потвърждение, че да не стане грешка.
            var result = MessageBox.Show(
                "Наистина ли да изтрия курса \"" + selectedCourse.Name + "\"?",
                "Потвърждение",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                dataManager.RemoveCourse(selectedCourse);
                selectedCourse = null; // Вече няма избран курс.
                LoadCourses(); // Опресняваме.
                LoadTasks();
            }
        }

        // Бутон "Добави задача".
        private void btnAddTask_Click(object sender, EventArgs e)
        {
            if (selectedCourse == null)
            {
                MessageBox.Show("Първо изберете курс.");
                return;
            }

            // Отваряме формата за задачи.
            using (var form = new TaskForm())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    // Взимаме готовата задача от формата.
                    var task = form.BuildTask();
                    if (task != null)
                    {
                        selectedCourse.AddTask(task);
                        LoadTasks(); // Опресняваме списъка със задачи.
                    }
                }
            }
        }

        // Бутон "Редактирай задача".
        private void btnEditTask_Click(object sender, EventArgs e)
        {
            if (selectedCourse == null || listBoxTasks.SelectedItem == null)
            {
                MessageBox.Show("Изберете задача за редактиране.");
                return;
            }

            var existingTask = listBoxTasks.SelectedItem as StudyTask;
            if (existingTask == null) return;

            // Пак същата форма, но й подаваме избраната задача.
            using (var form = new TaskForm(existingTask))
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    var updatedTask = form.BuildTask();
                    if (updatedTask != null)
                    {
                        // Трябва да запазим старото ID, защото BuildTask прави нов обект.
                        updatedTask.Id = existingTask.Id;
                        selectedCourse.UpdateTask(updatedTask);
                        LoadTasks(); // Опресняваме.
                    }
                }
            }
        }

        // Бутон "Изтрий задача".
        private void btnDeleteTask_Click(object sender, EventArgs e)
        {
            if (selectedCourse == null || listBoxTasks.SelectedItem == null)
            {
                MessageBox.Show("Изберете задача за изтриване.");
                return;
            }

            var task = listBoxTasks.SelectedItem as StudyTask;
            if (task == null) return;

            // Пак питаме за всеки случай.
            var result = MessageBox.Show(
                "Да се изтрие ли задачата \"" + task.Name + "\"?",
                "Потвърждение",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                selectedCourse.RemoveTask(task);
                LoadTasks(); // Опресняваме.
            }
        }

        // Този метод е закачен за клик на лейбъла, ама реално не прави нищо.
        private void label1_Click(object sender, EventArgs e)
        {
            // няма нужда да прави нищо
        }
    }
}
