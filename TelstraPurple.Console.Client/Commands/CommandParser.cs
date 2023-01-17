using System.Drawing;

namespace TelstraPurple.Console.Client.Commands
{
    public sealed class CommandParser
    {
        private readonly string _command;
        public CommandParser(string command)
        {
            _command = command;
        }

        public Command GetCommands()
        {
            //Splits commands into PLACE [space] 0,0,NORTH. Need to sub split the second command based on ,;
            var commands = SplitCommand(_command, " ");
            var command = commands[0];

            var commandValidator = new CommandValidator();
            var primaryCommand = commandValidator.ConvertPrimaryCommand(command);


            if (commands.Length > 1)
            {
                var subCommands = SplitCommand(commands[1], ",");
                var x = commandValidator.ConvertStringToInt(subCommands[0]);
                var y = commandValidator.ConvertStringToInt(subCommands[1]);
                if (subCommands.Length > 2)
                {
                    var orinetation = commandValidator.ConvertOrientation(subCommands[2]);
                    return new Command(primaryCommand, new Point(x, y), orinetation);
                }
                return new Command(primaryCommand, new Point(x, y));


            }

            return new Command(primaryCommand);
        }

        private string[] SplitCommand(string command, string parser)
        {
            return command.Split(parser);
        }
    }
}
