
using System.Drawing;
using TelstraPurple.Console.Client.Commands;
using TelstraPurple.Console.Client.Commands.Exceptions;
using TelstraPurple.Robot;

namespace TelstraPurple.Console.Client.Tests
{
    public class RobotExecutorTests
    {
        [Fact]
        public void ExecuteCommand_WithGivenPlaceCommandExecutes_Executes()
        {
            var executor = new RobotExecutor(new Table(5, 5));
            executor.ExecuteCommand(new Command(PrimaryCommand.PLACE, new Point(4, 4), Orientation.NORTH));
        }

        [Fact]
        public void ExecuteCommand_WithPlaceNotSet_ThrowsException()
        {
            var executor = new RobotExecutor(new Table(5, 5));
            Assert.Throws<PlacedNotSetException>(() => executor.ExecuteCommand(new Command(PrimaryCommand.MOVE)));
        }

        [Fact]
        public void ExecuteCommand_WithPlaceSet_Executes()
        {
            var executor = new RobotExecutor(new Table(5, 5));
            executor.ExecuteCommand(new Command(PrimaryCommand.PLACE, new Point(4, 4)));
        }

        [Fact]
        public void ExecuteCommand_WithPlaceSetAndInvalidPosition_ThrowsException()
        {
            var executor = new RobotExecutor(new Table(5, 5));
            Assert.Throws<InvalidPlacementException>(() => executor.ExecuteCommand(new Command(PrimaryCommand.PLACE, new Point(50, 50))));
        }
    }
}
