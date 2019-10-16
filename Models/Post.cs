using System.ComponentModel.DataAnnotations;

namespace WebAPIStarter.Data.Models
{
    public class Post
    {
        public int Id { get; set; }
        [Required]
        public object Data { get; set; }
    }
}