using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _6_Command.Interfaces;

namespace _6_Command
{
    public class MiniController
    {
        private ICommand command;

        public MiniController()
        {
        }

        public void SetCommand(ICommand command)
        {
            this.command = command;
        }

        public void InvokeExecution()
        {
            this.command.Execute();
        }
    }
}
