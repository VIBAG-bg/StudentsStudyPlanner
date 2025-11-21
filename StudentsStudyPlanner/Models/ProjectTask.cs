/// Emilii-Viktorian Bahirov-Kasianenko F110580
namespace StudentsStudyPlanner.Models
{
    // Клас за задача от тип "Проект". Наследява базовия StudyTask.
    public class ProjectTask : StudyTask
    {
        public string Topic { get; set; } // Каква е темата на проекта.

        public string TeamMembers { get; set; } // Кои са членовете на екипа.

        public ProjectTask()
        {
            // Казваме, че типът е Project.
            Type = TaskType.Project;
            Topic = string.Empty;
            TeamMembers = string.Empty;
        }

        // Специфична информация за проект.
        public override string GetInfo()
        {
            return $"Проект: {Title} - тема: {Topic}, екип: {TeamMembers}, краен срок: {Deadline:dd.MM.yyyy}";
        }
    }
}
