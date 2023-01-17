
namespace TelstraPurple.Console.Client.Commands.Exceptions
{
    public sealed class InvalidPlacementException : Exception
    {
        public InvalidPlacementException()
        {
        }

        public InvalidPlacementException(string message)
            : base(message)
        {
        }

        public InvalidPlacementException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
