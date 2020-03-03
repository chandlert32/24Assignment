using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Like.Model
{
    public class ReplyCreate 
        //: CommentCreate
    {
        [Required]
        public int CommentReplied { get; set; }
    }
}
