/// Emilii-Viktorian Bahirov-Kasianenko F110580
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsStudyPlanner.Models
{
    // Enum-ите са просто изброени типове, които ни помагат да не пишем низове (string) навсякъде.
    // По-чисто и по-малко вероятно за грешки.

    // Възможните типове задачи.
    public enum TaskType
    {
        Homework,
        Exam,
        Project
    }   

    // Възможните статуси на една задача.
    public enum TaskStatus
    {
        NotStarted, // Още не е почната
        InProgress, // Работи се по нея
        Done,       // Готова е
        // Completed е псевдоним (alias) на Done, за съвместимост, ако някъде е написано така.
        Completed = Done
    }

    // Възможните приоритети.
    public enum Priority
    {
        Low,    // Нисък
        Normal, // Нормален
        High,   // Висок
        // Medium е псевдоним на Normal.
        Medium = Normal
    }
}
