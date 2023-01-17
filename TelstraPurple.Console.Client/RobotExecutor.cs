
using TelstraPurple.Robot;
using TelstraPurple.Console.Client.Commands;
using TelstraPurple.Console.Client.Commands.Exceptions;

namespace TelstraPurple.Console.Client
{
    public sealed class RobotExecutor
    {
        private bool _placed = false;
        private Robot.Robot _robot;
        private readonly Table _table;

        public RobotExecutor(Table table)
        {
            _table = table;
        }

        public void ExecuteCommand(Command command)
        {
            var primaryCommand = command.GetPrimaryCommand();

            if (primaryCommand != PrimaryCommand.PLACE && !_placed)
            {
                throw new PlacedNotSetException("Set place command first");
            }
            switch (primaryCommand)
            {
                case PrimaryCommand.PLACE:
                    {
                        if (!_table.ValidatePlacePosition(command.GetPoint()))
                            throw new InvalidPlacementException("Place location is outside of bounds");

                        if (!_placed)
                        {
                            _robot = new Robot.Robot(command.GetPoint(), command.GetOrientation());
                            _placed = true;
                        }
                        else
                        {
                            _robot = new Robot.Robot(command.GetPoint(), _robot.GetOrientation());
                        }
                        break;
                    }
                case PrimaryCommand.MOVE:
                    {
                        _table.MoveRobot(_robot);
                        break;
                    }
                case PrimaryCommand.LEFT:
                    {
                        _robot.ChangeOrientation(Movement.LEFT);
                        break;
                    }
                case PrimaryCommand.RIGHT:
                    {
                        _robot.ChangeOrientation(Movement.RIGHT);
                        break;
                    }
                case PrimaryCommand.REPORT:
                    {
                        System.Console.WriteLine(_robot.ToString());
                        break;
                    }

            }
        }
    }
}
