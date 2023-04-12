﻿using System;

namespace TaskManagerAPI.DTOs
{
    public class TasksDTO
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public bool Completed { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int UserId { get; set; }
    }
}
