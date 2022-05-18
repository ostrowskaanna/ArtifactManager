﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtifactManager
{
    using System.ComponentModel.DataAnnotations;

    public class User
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        [MinLength(1)]
        public string Name { get; set; }
        
        [Required]
        [MinLength(5)]
        public string email { get; set; }

        [Required]
        public string password { get; set; }

    }
}
