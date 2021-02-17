using System;
using _6_Command.Commands;
using _6_Command.Externals.Doors;
using _6_Command.Externals.Light;
using _6_Command.Externals.MusicPlayers;

namespace _6_Command
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            #region MiniController

            //var control = new MiniController();
            //var light = new KitchenLight();
            //var garageDoor = new GarageDoors();
            //var turnOnCommmand = new TurnOnLight(light);
            //var openGarageDoors = new OpenGarageDoors(garageDoor);

            //control.SetCommand(turnOnCommmand);
            //control.InvokeExecution();
            //control.SetCommand(openGarageDoors);
            //control.InvokeExecution();

            #endregion MiniController

            #region SuperController

            //var controller = new SuperController();

            //var diningRoomLight = new DiningRoomLight();
            //var kitechLight = new KitchenLight();
            //var garageDoor = new GarageDoors();
            //var hiFiSet = new HiFi();

            //var diningRoomTurnOnLight = new TurnOnLight(diningRoomLight);
            //var diningRoomTurnOffLight = new TurnOnLight(diningRoomLight);
            //var kitechTurnOnLight = new TurnOnLight(kitechLight);
            //var kitechTurnOffLight = new TurnOnLight(kitechLight);

            //var openGarageDoors = new OpenGarageDoors(garageDoor);
            //var closeGarageDoors = new CloseGarageDoors(garageDoor);

            //var turnOnHiFiCDPlayer = new TurnOnHiFiCDPlayer(hiFiSet);
            //var turnOffHiFiCDPlayer = new TurnOffHiFiCDPlayer(hiFiSet);

            //controller.SetCommand(0, diningRoomTurnOnLight, diningRoomTurnOffLight);
            //controller.SetCommand(1, kitechTurnOnLight, kitechTurnOffLight);
            //controller.SetCommand(2, openGarageDoors, closeGarageDoors);
            //controller.SetCommand(3, turnOnHiFiCDPlayer, turnOffHiFiCDPlayer);

            //Console.WriteLine(controller.ToString());

            //controller.TurnOnButtonPushed(0);
            //controller.TurnOffButtonPushed(0);
            //controller.TurnOnButtonPushed(1);
            //controller.TurnOffButtonPushed(1);
            //controller.TurnOnButtonPushed(2);
            //controller.TurnOffButtonPushed(2);
            //controller.TurnOnButtonPushed(3);
            //controller.TurnOffButtonPushed(3);

            #endregion SuperController

            #region SuperControllerWithUndo

            var controller = new SuperControllerWithUndo();

            var diningRoomLight = new DiningRoomLight();
            var kitechLight = new KitchenLight();
            var garageDoor = new GarageDoors();
            var hiFiSet = new HiFi();

            var diningRoomTurnOnLight = new TurnOnLight(diningRoomLight);
            var diningRoomTurnOffLight = new TurnOffLight(diningRoomLight);
            var kitechTurnOnLight = new TurnOnLight(kitechLight);
            var kitechTurnOffLight = new TurnOffLight(kitechLight);

            var openGarageDoors = new OpenGarageDoors(garageDoor);
            var closeGarageDoors = new CloseGarageDoors(garageDoor);

            var turnOnHiFiCDPlayer = new TurnOnHiFiCDPlayer(hiFiSet);
            var turnOffHiFiCDPlayer = new TurnOffHiFiCDPlayer(hiFiSet);

            controller.SetCommand(0, diningRoomTurnOnLight, diningRoomTurnOffLight);
            controller.SetCommand(1, kitechTurnOnLight, kitechTurnOffLight);
            controller.SetCommand(2, openGarageDoors, closeGarageDoors);
            controller.SetCommand(3, turnOnHiFiCDPlayer, turnOffHiFiCDPlayer);

            Console.WriteLine(controller.ToString());

            controller.TurnOnButtonPushed(0);
            controller.TurnOffButtonPushed(0);
            controller.UndoButtonPushed();
            controller.TurnOnButtonPushed(1);
            controller.TurnOffButtonPushed(1);
            controller.UndoButtonPushed();
            controller.TurnOnButtonPushed(2);
            controller.TurnOffButtonPushed(2);
            controller.UndoButtonPushed();
            controller.TurnOnButtonPushed(3);
            controller.TurnOffButtonPushed(3);

            #endregion SuperControllerWithUndo
        }
    }
}
