/// Emilii-Viktorian Bahirov-Kasianenko F110580
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace StudentsStudyPlanner.Models
{
    // Този клас е супер проста "база данни".
    // Просто един статичен клас, който държи списък с курсове в паметта.
    public static class DataStorage
    {
        // Докато програмата работи, всички курсове се пазят тук.
        // Като я спрем, всичко изчезва.
        public static List<Course> Courses = new List<Course>();
    }
}

        