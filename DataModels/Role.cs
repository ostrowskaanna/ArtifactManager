using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtifactManager.DataModels
{
    using System.ComponentModel.DataAnnotations;
    public class Role
    {
        [Key]
        public int Id { get; set; }
       
        [Required]
        public string Name { get; set; }

        public bool AddCategory { get; set; }
        public bool EditCategory { get; set; }
        public bool DeleteCategory { get; set; }
        public bool AddObject { get; set; }
        public bool EditObject { get; set; }
        public bool DeleteObject { get; set; }
        public bool AddUser { get; set; }
        public bool EditUser { get; set; }
        public bool DeleteUser { get; set; }
        public bool AddRole { get; set; }
        public bool EditRole { get; set; }
        public bool DeleteRole { get; set; }

    }
}
