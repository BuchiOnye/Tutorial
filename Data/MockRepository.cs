using System;
using System.Collections.Generic;
using AssessmentTest.Model;

namespace AssessmentTest.Data
{
    public class MockRepository : IStockRepo
    {
        // public void CreateCommand(Command command)
        //{
        //  throw new System.NotImplementedException();
        //}

        //public IEnumerable<Command> GetAppCommands()
        //{
        //  var commands = new List<Command>{
        //new Command{Id=0, HowTo="Fry an egg", Line="Dunno shit", Platform="Windows"},
        //new Command{Id=1, HowTo="Fry an egg", Line="Dunno shit", Platform="Windows"},
        //new Command{Id=2, HowTo="Fry an egg", Line="Dunno shit", Platform="Windows"}
        //};
        //return commands;

        //}

        // public Command GetCommandById(int id)
        //{
        //  return new Command{Id=0, HowTo="Fry an egg", Line="Dunno shit", Platform="Windows"};
        //}

        // public bool saveChanges()
        //{
        //  throw new System.NotImplementedException();
        //}
        public void CreateStock(Stock stock)
        {
            throw new NotImplementedException();
        }

        public bool saveChanges()
        {
            throw new NotImplementedException();
        }

        IEnumerable<Stock> IStockRepo.GetCommandByUserIdAndMarchantId(Guid id, string marchantId)
        {
            throw new NotImplementedException();
        }
    }
}