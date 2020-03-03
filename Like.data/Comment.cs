using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Like.data
{
    public class Comment
    {
        [Key]
        public int CommentId { get; set; }
        [Required]
        public string Text { get; set; }

        [ForeignKey(nameof(Post))]
        public int PostFK { get; set; }
        public virtual Post Post { get; set; }

        [ForeignKey(nameof(User))]
        public Guid UserFK { get; set; }
        public virtual User User { get; set; }
    }
}
