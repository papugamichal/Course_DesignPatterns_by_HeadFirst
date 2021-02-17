using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _6_Command.Externals.Doors;
using _6_Command.Interfaces;

namespace _6_Command.Commands
{
    class EmptyCommand : ICommand
    {
        public EmptyCommand()
        {
        }

        public void Execute()
        {
        }

        public void Undo()
        {
        }
    }
}
