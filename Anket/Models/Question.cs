﻿namespace Anket.Models
{
    public class Question
    {
        public int Id { get; set; }
        public string? Text { get; set; }
        public QuestionType Type { get; set; }
        public int? Number { get; set; }
        public string? Image { get; set; }
        public bool IsDeleted { get; set; }

        public int? AnketId { get; set; }
        public Anketa? Anket { get; set; }
    }
}
