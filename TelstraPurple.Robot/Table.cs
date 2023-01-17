using System;
using System.Drawing;
using TelstraPurple.Robot.Exceptions;

namespace TelstraPurple.Robot
{
    /// <summary>
    /// The table class that the <see cref="Robot"/> moves on.
    /// </summary>
    public sealed class Table
    {
        private readonly int _xSize;
        private readonly int _ySize;

        public Table(int x, int y)
        {
            if (x < 0)
                throw new ArgumentException("x co-ord must be a positive number");
            if (y < 0)
                throw new ArgumentException("x co-ord must be a positive number");

            _xSize = x;
            _ySize = y;
        }

        /// <summary>
        /// Moves the Robot along the table by one square.
        /// </summary>
        /// <param name="robot"></param>
        /// <exception cref="ArgumentNullException"></exception>
        public void MoveRobot(Robot robot)
        {
            if (robot == null)
            {
                throw new ArgumentNullException("robot");
            }
            var currentOrintation = robot.GetOrientation();
            var currentPosition = robot.GetPosition();

            var newPosition = MoveToNewPosition(currentOrintation, currentPosition);

            robot.SetPosition(newPosition);
        }

        /// <summary>
        /// Based on the current <see cref="Orientation"/> and position of the <see cref="Robot"/>, moves one square.
        /// </summary>
        /// <param name="orientation">The current <see cref="Orientation"/></param>
        /// <param name="currentPosition">The current position</param>
        /// <returns>A new <see cref="Point"/> for the <see cref="Robot"/>. If the <see cref="Robot"/> can't move to the location requested, the <see cref="Robot"/> stays in its current position</returns>
        /// <exception cref="UnknownOrientationException"></exception>
        private Point MoveToNewPosition(Orientation orientation, Point currentPosition)
        {
            Point newPosition = currentPosition;
            switch (orientation)
            {
                //Move Along Y access
                case Orientation.NORTH:
                    {
                        if ((currentPosition.Y + 1) > _ySize)   //Can't move beyond the top of the table
                        {

                        }
                        else
                        {
                            newPosition = new Point(currentPosition.X, currentPosition.Y + 1);
                        }
                        break;
                    }
                //Move Along Y access
                case Orientation.SOUTH:
                    {
                        if (currentPosition.Y - 1 < 0) //Can't move beyond the bottom of the table
                        {

                        }
                        else
                            newPosition = new Point(currentPosition.X, currentPosition.Y - 1);
                        break;
                    }
                //Move Along X access
                case Orientation.EAST:
                    {
                        if (currentPosition.X + 1 > _xSize)  //Can't move beyond the side of the table
                        {

                        }
                        else
                        {
                            newPosition = new Point(currentPosition.X + 1, currentPosition.Y);
                        }
                        break;
                    }
                //Move Along X access
                case Orientation.WEST:
                    {
                        if (currentPosition.X - 1 < 0)   //Can't move beyond the side of the table
                        {

                        }
                        else
                        {
                            newPosition = new Point(currentPosition.X - 1, currentPosition.Y);
                        }
                        break;

                    }
                default:
                    {
                        throw new UnknownOrientationException("Unknown Orientation");
                    }
            }
            return newPosition;
        }

        /// <summary>
        /// Validates that a position is within the boundaries of the <see cref="Table"/>
        /// </summary>
        /// <param name="point"></param>
        /// <returns>true - if the co-ordinates are within the boandaries, false otherwise</returns>
        public bool ValidatePlacePosition(Point point)
        {
            if ((point.X < 0 || point.Y < 0) || (point.X > _xSize || point.Y > _ySize))
            {
                return false;
            }

            return true;
        }
    }
}
