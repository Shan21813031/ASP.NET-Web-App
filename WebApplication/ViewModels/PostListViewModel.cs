using System;
using WebApplication.Models;

namespace WebApplication.ViewModels
{
    public class PostListViewModel
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public DateTime PublishedDate { get; set; }

        public ApplicationUser ApplicationUser { get; set; }

    }
}
