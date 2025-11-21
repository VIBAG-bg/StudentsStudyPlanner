/// Emilii-Viktorian Bahirov-Kasianenko F110580
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace StudentsStudyPlanner.Models
{
    // Това е базовият, абстрактен клас за задача.
    // "Абстрактен" означава, че не можем да създадем обект директно от него,
    // а трябва да го наследим (както правят HomeworkTask, ExamTask, ProjectTask).
    public abstract class StudyTask
    {
        public int Id { get; set; }  // Уникален номер на задачата в рамките на един курс.

        public string Title { get; set; } // Заглавие на задачата.

        public DateTime Deadline { get; set; } // Краен срок.

        public TaskType Type { get; protected set; } // Тип на задачата (домашно, изпит...). `protected set` означава, че само наследниците могат да го променят.

        public string Description { get; set; } // По-дълго описание.

        public Priority Priority { get; set; } // Приоритет.

        public TaskStatus Status { get; set; } // Статус.

        // Конструктор на базовия клас.
        protected StudyTask()
        {
            // Задаваме някакви стойности по подразбиране.
            Title = string.Empty;
            Description = string.Empty;
            Deadline = DateTime.Now;
            Priority = Priority.Normal;
            Status = TaskStatus.NotStarted;
        }

        // За съвместимост, понеже на места в кода се ползваше "Name" вместо "Title".
        // Това е просто свойство, което чете и записва в "Title".
        public string Name
        {
            get { return Title; }
            set { Title = value; }
        }

        // Виртуален метод, който връща основна информация за задачата.
        // "Виртуален" означава, че наследниците могат да го пренапишат (override),
        // за да добавят своя специфична информация.
        public virtual string GetInfo()
        {
            return $"{Title} - {Deadline:dd.MM.yyyy} ({Status})";
        }

        // Пак за съвместимост, просто вика GetInfo().
        public string GetDetails()
        {
            return GetInfo();
        }

        // Както при курсовете, това определя как ще изглежда задачата в ListBox.
        public override string ToString()
        {
            return GetInfo();
        }
    }
}
