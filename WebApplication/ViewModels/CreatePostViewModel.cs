using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;

namespace WebApplication.ViewModels
{
    public class CreatePostViewModel
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public List<SelectListItem> Categories { get; set; }

        public List<SelectListItem> PostTags { get; set; }



        public DateTime PublishedDate { get; set; }

    }
}
