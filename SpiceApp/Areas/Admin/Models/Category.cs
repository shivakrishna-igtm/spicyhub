﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SpiceApp.Areas.Admin.Models
{
    [Table("Category_UKSARMA")]
    public class Category
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CategoryId { get; set; }

        [Display(Name = "Category Name")]
        [Required]
        public string CategoryName { get; set; }
    }
}
