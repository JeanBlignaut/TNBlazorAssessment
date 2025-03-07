﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tng.TechnicalEvaluation.Infrastructure.Models
{
    public class Part
    {
        [Key]
        public long Id { get; set; }
        public long? ParentId { get; set; }
        public string Number { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
        public decimal Cost { get; set; }

        [ForeignKey("ParentId")]
        public Part Parent { get; set; }

        [InverseProperty("Parent")]
        public ICollection<Part> Children { get; set; }
    }
}