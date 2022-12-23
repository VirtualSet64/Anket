﻿namespace Anket.Models
{
    public class Anketa
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public List<Question>? ListQuestion { get; set; }
        public bool IsDeleted { get; set; }
    }
}
