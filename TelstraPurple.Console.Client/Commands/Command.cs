using System.Drawing;
using TelstraPurple.Robot;


namespace TelstraPurple.Console.Client.Commands
{
    public sealed class Command
    {
        private readonly PrimaryCommand _command;
        private readonly Point _point;
        private readonly Orientation _orientation;
        public Command(PrimaryCommand command, Point point, Orientation orientation)
        {
            _command = command;
            _point = point;
            _orientation = orientation;
        }

        public Command(PrimaryCommand command, Point point)
        {
            _command = command;
            _point = point;
        }

        public Command(PrimaryCommand command)
        {
            _command = command;
        }

        public PrimaryCommand GetPrimaryCommand()
        {
            return _command;
        }
        public Point GetPoint()
        {
            return _point;
        }

        public Orientation GetOrientation()
        {
            return _orientation;
        }
    }
}
