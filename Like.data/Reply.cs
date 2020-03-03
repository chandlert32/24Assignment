using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Like.data
{
    public class Reply : Comment
    {
        [ForeignKey(nameof(ReplyComment))]
        public int CommentRepliedTo { get; set; }
        public virtual Comment ReplyComment { get; set; }
    }
}
