using System;
using System.ComponentModel.DataAnnotations;

namespace AssessmentTest.Model
{
    public class StockProcessor
    {
        
        [Required]
        [MaxLength(255)]
        public string Name {get; set;}
        
        [Required]
        public string Procedure {get; set;}

        public DateTime CreateDate {get; set;}

    }
}