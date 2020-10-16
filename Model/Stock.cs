using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AssessmentTest.Model
{
    public class Stock
    {
        [Key]
        public Guid Id {get; set;}

        
        [Required]
        public string MarchantId {get; set;}

        public IEnumerable<StockProcessor> StockProcessors { get; set; }

    }
}