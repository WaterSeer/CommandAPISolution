using System.Collections.Generic;
using CommandAPI.Models;

namespace CommandAPI.Data
{
    public interface ICommandAPIRepo
    {
        bool SaveChanges();

        IEnumerable<Command> GetAllCommands();
        Command GetCommandById(int id);       
        void CreateCommand(Command cmd);
        void UpdateCommand(Command command);
        void DeleteCommand(Command command);
    }
}