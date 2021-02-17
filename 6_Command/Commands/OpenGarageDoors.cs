using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _6_Command.Externals.Doors;
using _6_Command.Interfaces;

namespace _6_Command.Commands
{
    class OpenGarageDoors : ICommand
    {
        private readonly IDoor door;

        public OpenGarageDoors(IDoor door)
        {
            this.door = door ?? throw new ArgumentNullException(nameof(door));
        }

        public void Execute()
        {
            this.door.Open();
            Console.WriteLine($"Command {nameof(OpenGarageDoors)} executed!");
        }

        public void Undo()
        {
            this.door.Close();
            Console.WriteLine($"Undo command {nameof(OpenGarageDoors)} executed!");
        }
    }

    class CloseGarageDoors : ICommand
    {
        private readonly IDoor door;

        public CloseGarageDoors(IDoor door)
        {
            this.door = door ?? throw new ArgumentNullException(nameof(door));
        }

        public void Execute()
        {
            this.door.Close();
            Console.WriteLine($"Command {nameof(CloseGarageDoors)} executed!");
        }

        public void Undo()
        {
            this.door.Open();
            Console.WriteLine($"Undo command {nameof(CloseGarageDoors)} executed!");
        }
    }
}
