/// Emilii-Viktorian Bahirov-Kasianenko F110580     
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace StudentsStudyPlanner.Models
{
    // Интерфейсът е като договор. Всеки клас, който го имплементира,
    // обещава, че ще има методите, описани тук.
    // В нашия случай, Course е ITaskOwner, защото може да "притежава" задачи.
    public interface ITaskOwner
    {
        void AddTask(StudyTask task); // Трябва да може да добавя задачи.

        List<StudyTask> GetTasks(); // Трябва да може да връща списък със задачите си.

        // Тези са добавени за съвместимост и пълнота.
        void RemoveTask(StudyTask task); // Да може да трие.
        void UpdateTask(StudyTask task); // Да може да обновява.
        List<StudyTask> GetAllTasks(); // Пак да връща всички задачи.
    }
}

