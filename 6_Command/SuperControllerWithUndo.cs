using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _6_Command.Commands;
using _6_Command.Interfaces;

namespace _6_Command
{
    class SuperControllerWithUndo
    {
        private const int slotSize = 7; 
        private readonly ICommand[] turnOnCommands = new ICommand[slotSize];
        private readonly ICommand[] turnOffCommands = new ICommand[slotSize];
        private ICommand undoCommand;

        public SuperControllerWithUndo()
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
            var command = this.turnOnCommands[slot];
            this.undoCommand = command;
            command.Execute();
        }

        public void TurnOffButtonPushed(int slot)
        {
            var command = this.turnOffCommands[slot];
            this.undoCommand = command;
            command.Execute();
        }

        public void UndoButtonPushed()
        {
            this.undoCommand.Undo();
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
