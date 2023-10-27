﻿using System.ComponentModel.DataAnnotations.Schema;

namespace Service.Models
{
    public class ForumThread
    {
        public int Id { get; set; }
        [Column("my_document_key")]
        public required string DocumentKey { get; set; }
        public required string Title { get; set; }
        public required string Author { get; set; }
        public DateTimeOffset Created { get; set; }
    }
}
