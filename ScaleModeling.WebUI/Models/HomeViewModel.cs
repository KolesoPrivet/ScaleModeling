using System.Collections.Generic;

using ScaleModeling.Domain.Entities;

namespace ScaleModeling.WebUI.Models
{
    public class HomeViewModel
    {
        public IEnumerable<Article> Articles { get; set; }

        public IEnumerable<Event> Events { get; set; }

        public IEnumerable<ForumTopic> Topics { get; set; }

        public IEnumerable<Product> Products { get; set; }
    }
}