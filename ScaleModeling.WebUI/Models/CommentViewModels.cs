using System;
using System.ComponentModel.DataAnnotations;

namespace ScaleModeling.WebUI.Models
{
    public class CommenterInfoViewModel
    {
        public string UserName { get; set; }

        public int Rating { get; set; }

        public int WorksCount { get; set; }

        public int ArticleCount { get; set; }

        public int CommentedEntityId { get; set; }
    }

    public class CommentViewModel
    {
        [Required( ErrorMessage = "Необходимо ввести текст комментария" )]
        public string CommentText { get; set; }
    }
}