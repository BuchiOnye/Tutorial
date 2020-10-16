using System.Collections.Generic;
using AssessmentTest.Model;

namespace AssessmentTest.Dto
{
    public class StockReadDto 
    {
        string responseMessage {get; set;}

        IEnumerable<Stock> stock {get; set;}
        public StockReadDto(string message, IEnumerable<Stock> stockProcessor)
        {
            responseMessage = message;
            stock = stockProcessor;
        
        }

        
    }
}