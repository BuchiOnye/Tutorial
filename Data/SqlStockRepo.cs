using System;
using System.Collections.Generic;
using System.Linq;
using AssessmentTest.Model;

namespace AssessmentTest.Data
{
    public class SqlStockRepo : IStockRepo
    {
        private readonly StockContext _context;
        public SqlStockRepo(StockContext stockContext)
        {
            _context = stockContext;
        }

        public void CreateStock(Stock stock)
        {
            if(stock == null){
                throw new ArgumentNullException(nameof(stock));
            }

             _context.Stocks.Add(stock);
        }

        public IEnumerable<Stock> GetCommandByUserIdAndMarchantId(Guid id, String marchantId )
        {
            return _context.Stocks.Where(x => x.Id == id && x.MarchantId == marchantId)
                .OrderByDescending(x => x.StockProcessors.OrderByDescending(y => y.CreateDate)).Select(z => new Stock(){
                   StockProcessors = z.StockProcessors.Select(y => new StockProcessor() {
                       Name = y.Name,
                       Procedure = y.Procedure,
                       CreateDate = y.CreateDate,

                    })
                });
        }

       // public Stock GetCommandByIdAndUserName(int id)
        //{
          //  return _context.Commands.FirstOrDefault(p => p.Id == id);
        //}

        public bool saveChanges()
        {
            return (_context.SaveChanges() > 0);
        }
    }
}