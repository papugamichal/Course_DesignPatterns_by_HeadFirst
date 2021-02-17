using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_Command.Externals.MusicPlayers
{
    class HiFi : IHiFi
    {
        public void TurnOn() { }
        public void TurnOff() { }
        public void LaodCD() { }
        public void SetVolume(int level) { }
    }
}
