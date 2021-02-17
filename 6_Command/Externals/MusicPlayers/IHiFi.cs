namespace _6_Command.Externals.MusicPlayers
{
    internal interface IHiFi
    {
        void LaodCD();
        void SetVolume(int level);
        void TurnOn();
        void TurnOff();
    }
}