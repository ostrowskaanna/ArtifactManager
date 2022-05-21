using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArtifactManager.DataModels;

namespace ArtifactManager.DataModels
{
    using System.ComponentModel.DataAnnotations;
    public class Tower
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public virtual Category Category { get; set; }

        [Required]
        public virtual User User { get; set; }

        [Required]
        public string Name { get; set; }
        public int Height { get; set; }

        public int Age { get; set; }
    }
}
