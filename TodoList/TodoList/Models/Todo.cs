﻿using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace TodoList.Models
{
    public class Todo
    {
        // (Id: long, Title: string, IsUrgent: boolean(default false), IsDone: boolean(default false))
        public long Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public bool IsUrgent { get; set; } = false;
        public bool IsDone { get; set; } = false;


        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [DisplayName("Created")]

        public DateTime Inserted { get; set; }
        [DisplayName("Due at")]

        public DateTime DueAt { get; set; }
        [DisplayName("Assignee")]

        public User User { get; set; }
        public int IdUser { get; set; }
    }
}
