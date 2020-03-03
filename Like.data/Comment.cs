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
<<<<<<< HEAD
        
=======
>>>>>>> master
        [Required]
        public string Text { get; set; }

        [ForeignKey(nameof(Post))]
<<<<<<< HEAD
        public int PostFk { get; set; }
=======
        public int PostFK { get; set; }
>>>>>>> master
        public virtual Post Post { get; set; }

        [ForeignKey(nameof(User))]
        public Guid UserFK { get; set; }
        public virtual User User { get; set; }
    }
}
