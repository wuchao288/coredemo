﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Model
{
    public class Movie:IValidatableObject
    {
        public int Id { get; set; }

        public string Title { get; set; }

        [Display(Name = "ReleaseDate")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }
        public string Rating { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            return null;
        }
    }
}
