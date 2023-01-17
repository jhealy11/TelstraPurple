
namespace TelstraPurple.Console.Client.Commands.Exceptions
{
    public sealed class PlacedNotSetException : Exception
    {
        public PlacedNotSetException()
        {
        }

        public PlacedNotSetException(string message)
            : base(message)
        {
        }

        public PlacedNotSetException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
