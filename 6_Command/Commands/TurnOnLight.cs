using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _6_Command.Commands.Externals.Light;
using _6_Command.Interfaces;

namespace _6_Command.Commands
{
    public class TurnOnLight : ICommand
    {
        private readonly ILight light;

        public TurnOnLight(ILight light)
        {
            this.light = light ?? throw new ArgumentNullException(nameof(light));
        }

        public void Execute()
        {
            this.light.TurnOn();
            Console.WriteLine($"Command {nameof(TurnOnLight)} executed!");
        }

        public void Undo()
        {
            this.light.TurnOff();
            Console.WriteLine($"Undo command {nameof(TurnOnLight)} executed!");
        }
    }

    public class TurnOffLight : ICommand
    {
        private readonly ILight light;

        public TurnOffLight(ILight light)
        {
            this.light = light ?? throw new ArgumentNullException(nameof(light));
        }

        public void Execute()
        {
            this.light.TurnOff();
            Console.WriteLine($"Command {nameof(TurnOffLight)} executed!");
        }

        public void Undo()
        {
            this.light.TurnOn();
            Console.WriteLine($"Undo command {nameof(TurnOffLight)} executed!");
        }
    }
}
