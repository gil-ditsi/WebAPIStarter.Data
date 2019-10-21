using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebAPIStarter.Data.Models
{
    public class Post
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        
        [Required]
        public string Data { get; set; }
        public IList<Comment> Comments { get; set; }
    }
}
