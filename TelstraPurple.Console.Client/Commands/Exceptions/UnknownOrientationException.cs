

namespace TelstraPurple.Console.Client.Commands.Exceptions
{
    public sealed class UnknownOrientationException : Exception
    {
        public UnknownOrientationException()
        {
        }

        public UnknownOrientationException(string message)
            : base(message)
        {
        }

        public UnknownOrientationException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
