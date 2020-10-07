using System.Collections.Generic;
using Project.Models;

namespace Project.Data
{
    public interface ICommanderRepo
    {
        IEnumerable<Command> GetAllCommands();
        Command GetCommandById(int id);
    }
}