using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Like.Model
{
    public class PostCreate
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        [MaxLength(8000)]
        public string Text { get; set; }

        //[ForeignKey(nameof(User))]
        public int UserGuiD { get; set; }
        //public virtual User User { get; set; }
    }
}
