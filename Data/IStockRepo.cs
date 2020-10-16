using System;
using System.Collections.Generic;
using AssessmentTest.Model;

namespace AssessmentTest.Data
{
    public interface IStockRepo
    {
        IEnumerable<Stock> GetCommandByUserIdAndMarchantId(Guid id, String marchantId);

        void CreateStock(Stock stock);

        bool saveChanges();

    }
}