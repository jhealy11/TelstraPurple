
using TelstraPurple.Console.Client.Commands;
using TelstraPurple.Robot;

namespace TelstraPurple.Console.Client.Tests
{
    public class CommandValidatorTests
    {
        [Fact]
        public void ConvertStringToInt_WithValidString_ReturnsInt()
        {
            const string input = "5";
            const int output = 5;
            CommandValidator validator = new CommandValidator();
            var result = validator.ConvertStringToInt(input);

            Assert.Equal(output, result);
        }

        [Fact]
        public void ConvertStringToInt_WithInvalidString_ThrowsException()
        {
            const string input = "gg";
            CommandValidator validator = new CommandValidator();
            Assert.Throws<FormatException>(() => validator.ConvertStringToInt(input));

        }

        [Fact]
        public void ConvertOrientation_WithValidString_ReturnsOrientation()
        {
            const string input = "NORTH";
            const Orientation output = Orientation.NORTH;
            CommandValidator validator = new CommandValidator();
            var result = validator.ConvertOrientation(input);

            Assert.Equal(output, result);
        }

        [Fact]
        public void ConvertOrientation_WithInvalidString_ThrowsException()
        {
            const string input = "gg";
            CommandValidator validator = new CommandValidator();
            Assert.Throws<FormatException>(() => validator.ConvertOrientation(input));

        }

        [Fact]
        public void ConvertPrimaryCommand_WithValidString_ReturnsOrientation()
        {
            const string input = "LEFT";
            const PrimaryCommand output = PrimaryCommand.LEFT;
            CommandValidator validator = new CommandValidator();
            var result = validator.ConvertPrimaryCommand(input);

            Assert.Equal(output, result);
        }

        [Fact]
        public void ConvertPrimaryCommand_WithInvalidString_ThrowsException()
        {
            const string input = "gg";
            CommandValidator validator = new CommandValidator();
            Assert.Throws<FormatException>(() => validator.ConvertPrimaryCommand(input));

        }
    }
}
