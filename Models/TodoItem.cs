﻿using System.ComponentModel.DataAnnotations;

namespace ToDoApp.Models
{
    public class TodoItem
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public bool IsCompleted { get; set; }

        public DateTime? DueTime { get; set; }
    }
}
