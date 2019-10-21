using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPIStarter.Data.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public int PostId { get; set; }
        
        [ForeignKey("PostId")]
        public Post Post { get; set; }
    }
}