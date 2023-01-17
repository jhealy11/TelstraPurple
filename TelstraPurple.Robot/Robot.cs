using System;
using System.Drawing;
using TelstraPurple.Robot.Exceptions;
namespace TelstraPurple.Robot
{
    /// <summary>
    /// A robot that moves.
    /// </summary>
    public sealed class Robot
    {
        private Point _position;
        private Orientation _orientation;
        public Robot(Point position, Orientation orientation)
        {
            if (position == null)
                throw new ArgumentNullException("position");

            _position = position;
            _orientation = orientation;
        }

        /// <summary>
        /// The current position of the <see cref="Robot"/>
        /// </summary>
        /// <returns>The current position</returns>
        public Point GetPosition()
        {
            return _position;
        }
        /// <summary>
        /// The current <see cref="Orientation"/> of the <see cref="Robot"/>
        /// </summary>
        /// <returns></returns>
        public Orientation GetOrientation()
        {
            return _orientation;
        }

        /// <summary>
        /// Sets a new <see cref="Orientation"/> of the <see cref="Robot"/>
        /// </summary>
        /// <param name="newDirection"></param>
        private void SetOrientation(Orientation newDirection)
        {
            _orientation = newDirection;
        }

        public void SetPosition(Point position)
        {
            _position = position;
        }

        /// <summary>
        /// Changes the <see cref="Orientation"/> of the <see cref="Robot"/>
        /// </summary>
        /// <param name="movement">The <see cref="Movement"/> the <see cref="Robot"/> is to change to</param>
        public void ChangeOrientation(Movement movement)
        {
            if (movement == Movement.LEFT)
            {
                ChangeOrientationForTurningLeft();
            }
            else
            {
                ChangeOrientationForTurningRight();
            }
        }

        /// <summary>
        /// Turn <see cref="Movement.LEFT"/>, i.e. always anti-clockwise
        /// </summary>
        /// <exception cref="UnknownOrientationException"></exception>
        private void ChangeOrientationForTurningLeft()
        {
            var currentDirection = GetOrientation();
            switch (currentDirection)
            {
                case Orientation.NORTH:
                    {
                        SetOrientation(Orientation.WEST);
                        break;
                    }
                case Orientation.SOUTH:
                    {
                        SetOrientation(Orientation.EAST);
                        break;
                    }
                case Orientation.EAST:
                    {
                        SetOrientation(Orientation.NORTH);
                        break;
                    }
                case Orientation.WEST:
                    {
                        SetOrientation(Orientation.SOUTH);
                        break;
                    }
                default:
                    {
                        throw new UnknownOrientationException("Unknown Orientation");
                    }
            }
        }

        /// <summary>
        /// Turn <see cref="Movement.RIGHT"/>, i.e. always clockwise
        /// </summary>
        /// <exception cref="UnknownOrientationException"></exception>
        private void ChangeOrientationForTurningRight()
        {
            var currentDirection = GetOrientation();

            switch (currentDirection)
            {
                case Orientation.NORTH:
                    {
                        SetOrientation(Orientation.EAST);
                        break;
                    }
                case Orientation.SOUTH:
                    {
                        SetOrientation(Orientation.WEST);
                        break;
                    }
                case Orientation.EAST:
                    {
                        SetOrientation(Orientation.SOUTH);
                        break;
                    }
                case Orientation.WEST:
                    {
                        SetOrientation(Orientation.NORTH);
                        break;
                    }
                default:
                    {
                        throw new UnknownOrientationException("Unknown Orientation");
                    }
            }
        }

        /// <summary>
        /// The current position and <see cref="Orientation"/> of the <see cref="Robot"/>
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return string.Format("Output: {0},{1}, {2}", GetPosition().X, GetPosition().Y, GetOrientation());
        }
    }
}
