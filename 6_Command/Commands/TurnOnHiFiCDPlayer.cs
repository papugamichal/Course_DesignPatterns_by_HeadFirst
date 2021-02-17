using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _6_Command.Externals.MusicPlayers;
using _6_Command.Interfaces;

namespace _6_Command.Commands
{
    class TurnOnHiFiCDPlayer : ICommand
    {
        private readonly IHiFi hiFi;

        public TurnOnHiFiCDPlayer(IHiFi hiFi)
        {
            this.hiFi = hiFi ?? throw new ArgumentNullException(nameof(hiFi));
        }

        public void Execute()
        {
            this.hiFi.TurnOn();
            this.hiFi.LaodCD();
            this.hiFi.SetVolume(11);
            Console.WriteLine($"Command {nameof(TurnOnHiFiCDPlayer)} executed!");
        }

        public void Undo()
        {
            this.hiFi.TurnOff();
            Console.WriteLine($"Undo command {nameof(TurnOnHiFiCDPlayer)} executed!");
        }
    }

    class TurnOffHiFiCDPlayer : ICommand
    {
        private readonly IHiFi hiFi;

        public TurnOffHiFiCDPlayer(IHiFi hiFi)
        {
            this.hiFi = hiFi ?? throw new ArgumentNullException(nameof(hiFi));
        }

        public void Execute()
        {
            this.hiFi.TurnOff();
            Console.WriteLine($"Command {nameof(TurnOffHiFiCDPlayer)} executed!");
        }

        public void Undo()
        {
            this.hiFi.TurnOn();
            Console.WriteLine($"Undo command {nameof(TurnOffHiFiCDPlayer)} executed!");
        }
    }
}
