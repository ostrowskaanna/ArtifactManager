using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArtifactManager.DataModels;

namespace ArtifactManager.DataModels
{
    using System.ComponentModel.DataAnnotations;
    public class Witch
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public virtual Tower Tower { get; set; }

        [Required]
        public string Name { get; set; }
        public int Power { get; set; }
        public int Smart { get; set; }

    }
}
