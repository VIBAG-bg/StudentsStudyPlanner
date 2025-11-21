/// Emilii-Viktorian Bahirov-Kasianenko F110580 
namespace StudentsStudyPlanner.Models
{
    // Клас за задача от тип "Домашно". Наследява базовия StudyTask.
    public class HomeworkTask : StudyTask
    {
        public string Subject { get; set; } // По кой предмет е домашното.

        public string ExerciseNumber { get; set; } // Кое упражнение/номер е.

        public HomeworkTask()
        {
            // Казваме, че типът е Homework.
            Type = TaskType.Homework;
            Subject = string.Empty;
            ExerciseNumber = string.Empty;
        }

        // Специфична информация за домашно.
        public override string GetInfo()
        {
            return $"Домашно: {Title} ({Subject}), упражнение {ExerciseNumber}, краен срок: {Deadline:dd.MM.yyyy}";
        }
    }
}
