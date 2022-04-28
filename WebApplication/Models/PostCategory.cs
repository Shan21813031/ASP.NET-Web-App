﻿namespace WebApplication.Models
{
    public class PostCategory
    {
        public int Id { get; set; }

        public Post Post { get; set; } 

        public Category Category { get; set; }

        public int PostId { get; set; } 

        public int CategoryId { get; set; }

    }
}
