using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _6_Command.Commands;
using _6_Command.Interfaces;

namespace _6_Command
{
    class SuperController
    {
        private const int slotSize = 7; 
        private readonly ICommand[] turnOnCommands = new ICommand[slotSize];
        private readonly ICommand[] turnOffCommands = new ICommand[slotSize];

        public SuperController()
        {
            foreach (var index in Enumerable.Range(0, turnOnCommands.Length))
            {
                this.turnOnCommands[index] = new EmptyCommand();
            }

            foreach (var index in Enumerable.Range(0, turnOffCommands.Length))
            {
                this.turnOffCommands[index] = new EmptyCommand();
            }
        }

        public void SetCommand(int slot, ICommand commandTurnOn, ICommand commandTurnOff)
        {
            this.turnOnCommands[slot] = commandTurnOn;
            this.turnOffCommands[slot] = commandTurnOff;
        }

        public void TurnOnButtonPushed(int slot)
        {
            this.turnOnCommands[slot].Execute();
        }

        public void TurnOffButtonPushed(int slot)
        {
            this.turnOffCommands[slot].Execute();
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb = sb.Append("\n------SuperController------\n");
            foreach (var index in Enumerable.Range(0, turnOnCommands.Length))
            {
                sb = sb.Append("[slot " + index + "] " + this.turnOnCommands[index].GetType().Name + "  " + this.turnOffCommands[index].GetType().Name + "\n");
            }
            return sb.ToString();
        }
    }
}
