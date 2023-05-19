using System;
namespace LW_210702.Models
{
    public class Course
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string ImgName { get; set; }

        public string Category { get; set; }

        public decimal Price { get; set; }

        public string TeacherName { get; set; }

        public string TeacherImgName { get; set; }
    }
}
