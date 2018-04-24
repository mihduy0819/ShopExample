using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Model
{
    [Table("Footer")]
    public class Footer
    {
        public string ID { get; set; }

        [Required]
        public string Content { get; set; }
    }
}