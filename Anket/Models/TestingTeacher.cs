﻿namespace Anket.Models
{
    public class TestingTeacher
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public int DisciplineId { get; set; }
        public int TeacherId { get; set; }
        public bool IsDeleted { get; set; }
    }
}