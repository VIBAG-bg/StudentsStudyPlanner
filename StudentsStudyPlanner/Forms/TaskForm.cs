/// Emilii-Viktorian Bahirov-Kasianenko F110580             
using StudentsStudyPlanner.Models;
using System;
using System.Windows.Forms;
using System.Xml.Linq;

namespace StudentsStudyPlanner.Forms
{
    // Тази форма се ползва за добавяне и редактиране на задачи (домашни, изпити, проекти).
    public partial class TaskForm : Form
    {
        private StudyTask existingTask; // Ако редактираме, тук пазим оригиналната задача.

        // Конструктор за нова задача.
        public TaskForm()
        {
            InitializeComponent();
            InitCombos(); // Зареждаме опциите в падащите менюта.
            this.Text = "Нова задача";
        }

        // Конструктор за редактиране на съществуваща задача.
        public TaskForm(StudyTask task) : this()
        {
            existingTask = task;
            this.Text = "Редактиране на задача";

            // Ако има подадена задача, попълваме формата с нейните данни.
            if (task != null)
            {
                txtName.Text = task.Name;
                txtDescription.Text = task.Description;
                dateTimeDeadline.Value = task.Deadline;

                comboPriority.SelectedItem = task.Priority;
                comboStatus.SelectedItem = task.Status;
                comboTaskType.SelectedItem = task.Type;
            }
        }

        // Този метод пълни падащите менюта (комбо боксовете) с възможните стойности.
        private void InitCombos()
        {
            // Типове задачи
            comboTaskType.Items.Clear();
            comboTaskType.Items.Add(TaskType.Homework);
            comboTaskType.Items.Add(TaskType.Exam);
            comboTaskType.Items.Add(TaskType.Project);
            if (comboTaskType.Items.Count > 0)
                comboTaskType.SelectedIndex = 0; // Избираме първия по подразбиране.

            // Приоритети
            comboPriority.Items.Clear();
            comboPriority.Items.Add(Priority.Low);
            comboPriority.Items.Add(Priority.Medium);
            comboPriority.Items.Add(Priority.High);
            if (comboPriority.Items.Count > 1)
                comboPriority.SelectedIndex = 1; // Medium да е по подразбиране.

            // Статуси
            comboStatus.Items.Clear();
            comboStatus.Items.Add(TaskStatus.NotStarted);
            comboStatus.Items.Add(TaskStatus.InProgress);
            comboStatus.Items.Add(TaskStatus.Completed);
            comboStatus.SelectedIndex = 0; // NotStarted по подразбиране.

            // Краен срок по подразбиране - след 1 седмица.
            dateTimeDeadline.Value = DateTime.Now.AddDays(7);
        }

        /// <summary>
        /// Този метод сглобява обект от тип задача (HomeworkTask, ExamTask, ProjectTask)
        /// на база на това, което е въведено във формата.
        /// MainForm после си го взима, ако сме натиснали ОК.
        /// </summary>
        public StudyTask BuildTask()
        {
            TaskType selectedType = TaskType.Homework;
            if (comboTaskType.SelectedItem != null)
            {
                selectedType = (TaskType)comboTaskType.SelectedItem;
            }

            StudyTask task;

            // В зависимост от избрания тип, създаваме правилния обект.
            // Това е полиморфизъм в действие.
            if (selectedType == TaskType.Exam)
                task = new ExamTask();
            else if (selectedType == TaskType.Project)
                task = new ProjectTask();
            else
                task = new HomeworkTask();

            // Попълваме общите свойства, които ги има във всяка задача.
            task.Name = txtName.Text.Trim();
            task.Description = txtDescription.Text.Trim();
            task.Deadline = dateTimeDeadline.Value;
            task.Priority = (Priority)comboPriority.SelectedItem;
            task.Status = (TaskStatus)comboStatus.SelectedItem;

            // За курсовия проект не се занимаваме със специфичните полета (стая, предмет и т.н.)
            // от тази форма, за да е по-просто. Те си остават празни, но обектите са си от правилния тип.

            return task;
        }

        // Бутон "ОК" - валидация и затваряне.
        private void btnOk_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Моля, въведете име на задачата.");
                txtName.Focus();
                return;
            }

            if (comboTaskType.SelectedItem == null)
            {
                MessageBox.Show("Изберете тип задача.");
                return;
            }

            // Всичко е наред, затваряме с резултат ОК.
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        // Бутон "Отказ" - просто затваряме.
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void labelPriority_Click(object sender, EventArgs e)
        {
            // Нищо специално, просто оставяме метода да съществува, защото дизайнерът го е създал.
        }

        private void TaskForm_Load(object sender, EventArgs e)
        {
            // Всичко важно вече е в конструкторите, тук няма нужда от код.
        }
    }
}
