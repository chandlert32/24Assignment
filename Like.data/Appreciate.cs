using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Like.data
{
    public class Appreciate
    {
        [ForeignKey(nameof(Liker))]
        public Guid LikerId { get; set; }
        public virtual User Liker { get; set; }


        [ForeignKey(nameof(LikedPost))]
        public int LikedId { get; set; }
        public virtual Post LikedPost { get; set; }
    }
}
