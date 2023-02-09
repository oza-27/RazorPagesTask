﻿using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace RazorTaskTwo.Model
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        [Required]
        public bool IsActive { get; set; }
        public int Price { get; set; }
        [Display(Name = "Category Name")]
        public int CategoryId { get; set; }
        [ForeignKey("CategoryId")]
        [ValidateNever]
        public Category Category { get; set; }
        public DateTime isCreated { get; set; } = DateTime.Now;
        public DateTime isModified { get; set; } = DateTime.Now;
        public int Quantity { get; set; }
        public string Image { get; set; }
    }
}
