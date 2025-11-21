/// Emilii-Viktorian Bahirov-Kasianenko F110580                                             
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsStudyPlanner.Models
{
    // Този клас управлява всички данни в приложението.
    // Използва Singleton pattern, за да имаме само една инстанция навсякъде.
    public class DataManager
    {
        // Тук се пази единствената инстанция на класа.
        private static DataManager instance;
        // Чрез това свойство всички останали части на програмата достъпват инстанцията.
        public static DataManager Instance => instance ?? (instance = new DataManager());

        // Конструкторът е private, за да не може никой друг да създава инстанции.
        private DataManager() { }

        // Връща всички курсове, които се пазят в DataStorage.
        public List<Course> GetAllCourses()
        {
            return DataStorage.Courses;
        }

        // Добавя нов курс.
        public void AddCourse(Course course)
        {
            if (course == null) return;
            // Проверяваме дали вече не съществува, за всеки случай.
            if (!DataStorage.Courses.Contains(course))
            {
                // Даваме му ID по същата схема като при задачите.
                course.Id = DataStorage.Courses.Count == 0 ? 1 : DataStorage.Courses.Max(c => c.Id) + 1;
                DataStorage.Courses.Add(course);
            }
        }

        // Премахва курс.
        public void RemoveCourse(Course course)
        {
            if (course == null) return;
            DataStorage.Courses.Remove(course);
        }

        // Обновява курс. Намира го по ID и го заменя с новия обект.
        public void UpdateCourse(Course course)
        {
            if (course == null) return;
            var idx = DataStorage.Courses.FindIndex(c => c.Id == course.Id);
            if (idx >= 0)
                DataStorage.Courses[idx] = course;
        }
    }
}