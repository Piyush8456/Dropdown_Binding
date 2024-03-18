using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DropdownListBinding.Models
{
    public class Servants
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // This line
        public int Id { get; set; }

        public string ServantName { get; set; }

        // Change the type to int to represent the foreign key
        public int SkillId { get; set; }

        // Navigation property
        public virtual Skills Skills { get; set; }
    }

    public class Skills
    {
        [Key]
        public int SkillId { get; set; }

        public string SkillName { get; set; }
    }
}
