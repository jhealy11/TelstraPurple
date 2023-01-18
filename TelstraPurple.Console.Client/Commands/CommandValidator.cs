using System;
using TelstraPurple.Robot;

namespace TelstraPurple.Console.Client.Commands
{
    /// <summary>
    /// Validates any input commands from the UI
    /// </summary>
    public sealed class CommandValidator
    {
        /// <summary>
        /// Converts a string to an <see cref="Int32"/>
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException">throws exception if <paramref name="number"/> is null or empty</exception>
        /// <exception cref="Exception">throws exception if the string cannot be parsed</exception>
        public int ConvertStringToInt(string number)
        {
            if (string.IsNullOrEmpty(number))
            {
                throw new ArgumentNullException(number);
            }

            if (int.TryParse(number, out int result))
            {
                return result;
            }
            else
            {
                throw new FormatException("value is not a number");
            }
        }

        /// <summary>
        /// Converts a string input to a <see cref="Orientation"/>
        /// </summary>
        /// <param name="orientation"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException">throws exception if <paramref name="orientation"/> is null or empty</exception>
        /// <exception cref="Exception">throws exception if cannot parse to <see cref="Orientation"/></exception>
        public Orientation ConvertOrientation(string orientation)
        {
            if (string.IsNullOrEmpty(orientation))
                throw new ArgumentNullException(orientation);

            if (Enum.TryParse<Orientation>(orientation, true, out Orientation result))
            {
                return result;
            }
            else
            {
                throw new FormatException("Cannot parse orientation");
            }
        }

        /// <summary>
        /// Converts a string input to a <see cref="PrimaryCommand"/>
        /// </summary>
        /// <param name="command"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException">throws exception if command is null or empty</exception>
        /// <exception cref="FormatException">throws exception if cannot convert to <see cref="PrimaryCommand"/></exception>
        public PrimaryCommand ConvertPrimaryCommand(string command)
        {
            if (string.IsNullOrEmpty(command))
            {
                throw new ArgumentNullException(command);
            }

            if (Enum.TryParse<PrimaryCommand>(command, true, out PrimaryCommand result))
            {
                return result;
            }
            else
            {
                throw new FormatException("Cannot parse primary command");
            }

        }
    }
}
