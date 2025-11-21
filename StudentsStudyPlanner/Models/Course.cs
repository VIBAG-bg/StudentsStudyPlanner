/// Emilii-Viktorian Bahirov-Kasianenko F110580         
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsStudyPlanner.Models
{
    // Този клас описва един учебен курс.
    public class Course : ITaskOwner
    {
        public int Id { get; set; } // Уникален номер на курса.

        public string Name { get; set; } // Име, например "Обектно-ориентирано програмиране".

        public string Code { get; set; } // Код на курса, например "CSCB579".

        public string Teacher { get; set; } // Име на преподавателя.

        public string Semester { get; set; } // Семестър, например "Зимен семестър".

        // Всеки курс си има списък със задачи (домашни, изпити...).
        public List<StudyTask> Tasks;

        // Конструкторът, който се вика, когато правим нов обект от тип Course.
        public Course()
        {
            // Инициализираме полетата с празни стойности, за да не гърми, ако някой се опита да ги ползва.
            Name = "";
            Code = "";
            Teacher = "";
            Semester = "";
            Tasks = new List<StudyTask>();
        }

        // Метод за добавяне на нова задача към курса.
        public void AddTask(StudyTask task)
        {
            if (task == null) return;

            // Генерираме просто ID за задачата. За курсов проект е достатъчно.
            if (Tasks.Count == 0)
            {
                task.Id = 1;
            }
            else
            {
                // Намираме най-голямото ID досега и добавяме 1.
                task.Id = Tasks.Max(t => t.Id) + 1;
            }

            Tasks.Add(task);
        }

        // Метод за премахване на задача от курса.
        public void RemoveTask(StudyTask task)
        {
            if (task == null) return;
            Tasks.Remove(task);
        }

        // Метод за обновяване на задача. Намира старата по ID и я заменя с новата.
        public void UpdateTask(StudyTask task)
        {
            if (task == null) return;
            var idx = Tasks.FindIndex(t => t.Id == task.Id);
            if (idx >= 0)
            {
                Tasks[idx] = task;
            }
        }

        // Връща списъка със задачи.
        public List<StudyTask> GetTasks()
        {
            return Tasks;
        }

        // Същото като GetTasks(), просто за съвместимост.
        public List<StudyTask> GetAllTasks()
        {
            return Tasks;
        }

        // Този метод определя как ще изглежда обектът, когато го сложим в ListBox.
        public override string ToString()
        {
            return $"{Code} - {Name}";
        }
    }
}

