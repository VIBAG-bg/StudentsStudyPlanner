/// Emilii-Viktorian Bahirov-Kasianenko F110580 
namespace StudentsStudyPlanner.Models
{
    // Клас, който описва задача от тип "Изпит". Наследява базовия StudyTask.
    public class ExamTask : StudyTask
    {
        public string Subject { get; set; } // По кой предмет е изпитът.

        public string Room { get; set; } // В коя зала ще се проведе.

        public string Time { get; set; } // В колко часа.

        public ExamTask()
        {
            // Казваме, че този тип задача е Exam.
            Type = TaskType.Exam;
            // Инициализираме си полетата.
            Subject = string.Empty;
            Room = string.Empty;
            Time = string.Empty;
        }

        // Пренаписваме базовия метод, за да показва специфичната информация за изпит.
        public override string GetInfo()
        {
            return $"Изпит: {Title} по {Subject} в {Room} в {Time} на {Deadline:dd.MM.yyyy}";
        }
    }
}
