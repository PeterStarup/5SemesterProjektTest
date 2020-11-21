using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public abstract class BaseEntityModel
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public bool IsDeleted { get; set; }
    }
}
