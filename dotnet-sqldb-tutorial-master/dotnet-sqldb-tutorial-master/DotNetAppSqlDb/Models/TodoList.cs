using System;
using System.ComponentModel.DataAnnotations;

namespace DotNetAppSqlDb.Models
{
    public class TodoList
    {
        public int ID { get; set; }
        public string CourseName { get; set; }
        public string CourseDetails { get; set; }
        public string CourseProf { get; set; }
        public bool privateCourse { get; set; }



    }
}