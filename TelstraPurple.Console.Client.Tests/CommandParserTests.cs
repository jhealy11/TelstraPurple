
using System.Drawing;
using TelstraPurple.Console.Client.Commands;
using TelstraPurple.Robot;

namespace TelstraPurple.Console.Client.Tests
{
    public class CommandParserTests
    {
        [Fact]
        public void GetCommands_WithSingleCommand_ReturnsSingleCommand()
        {
            const PrimaryCommand primaryCommand = PrimaryCommand.MOVE;
            const string command = "MOVE";
            CommandParser commandParser = new CommandParser(command);
            var commands = commandParser.GetCommands();

            Assert.Equal(commands.GetPrimaryCommand(), primaryCommand);
        }

        [Fact]
        public void GetCommands_WithFullCommand_ReturnsCommand()
        {
            const PrimaryCommand primaryCommand = PrimaryCommand.PLACE;
            const string command = "PLACE 1,2,NORTH";
            const Orientation orientation = Orientation.NORTH;
            var point = new Point(1, 2);

            CommandParser commandParser = new CommandParser(command);
            var commands = commandParser.GetCommands();

            Assert.Equal(commands.GetPrimaryCommand(), primaryCommand);
            Assert.Equal(commands.GetPoint().X, point.X);
            Assert.Equal(commands.GetPoint().Y, point.Y);
            Assert.Equal(commands.GetOrientation(), orientation);
        }

        [Fact]
        public void GetCommands_WithPlaceCommand_ReturnsCorrrectCommand()
        {
            const PrimaryCommand primaryCommand = PrimaryCommand.PLACE;
            const string command = "PLACE 3,3";
            var point = new Point(3, 3);

            CommandParser commandParser = new CommandParser(command);
            var commands = commandParser.GetCommands();

            Assert.Equal(commands.GetPrimaryCommand(), primaryCommand);
            Assert.Equal(commands.GetPoint().X, point.X);
            Assert.Equal(commands.GetPoint().Y, point.Y);
        }
    }
}
