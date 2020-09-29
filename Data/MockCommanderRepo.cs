using System.Collections.Generic;
using Project.Models;

namespace Project.Data
{
    public class MockCommanderRepo : ICommanderRepo
    {
        public IEnumerable<Command> GerAppCommands()
        {
            var commands = new List<Command>
            {
                new Command{Id=0, HowTo="Boill and egg", Line="Boil Watter", Platform="Kettle & Pan"},
                new Command{Id=1, HowTo="Cut bread", Line="Get a knife", Platform="Ke  "},
                new Command{Id=2, HowTo="Make cup of tea", Line="Place teabag in cup", Platform="K"}

            };
            return commands;
        }

        public Command GetCommandById(int id)
        {
            return new Command{Id=0, HowTo="Boill and egg", Line="Boil Watter", Platform="Kettle & Pan"};

        }
    }
}