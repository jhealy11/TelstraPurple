

namespace TelstraPurple.Robot.Tests
{
    public class TableTests
    {
        [Fact]
        public void Constructor_InvalidX_ThrowsException()
        {
            Assert.Throws<ArgumentException>(() => new Table(-1, 4));
        }
        [Fact]
        public void Constructor_InvalidY_ThrowsException()
        {
            Assert.Throws<ArgumentException>(() => new Table(1, -4));
        }

        [Fact]
        public void Constructor_ValidXAndY_CreatesTable()
        {
            var table = new Table(4, 5);
            Assert.NotNull(table);
        }


        [Fact]
        public void MoveRobot_WithNullRobot_ThrowsException()
        {
            Table table = new Table(3, 3);
            Assert.Throws<ArgumentNullException>(() => table.MoveRobot(null));
        }

        [Fact]
        public void ValidatePlacePosition_WithGivenTableAndCorrrectDimensions_ReturnsTrue()
        {
            Table table = new Table(3, 3);
            var result = table.ValidatePlacePosition(new System.Drawing.Point(3, 3));

            Assert.True(result);
        }

        [Fact]
        public void ValidatePlacePosition_WithGivenTableAndInvalidXPositionSmaller_ReturnsFalse()
        {
            Table table = new Table(3, 3);
            var result = table.ValidatePlacePosition(new System.Drawing.Point(-5, 3));

            Assert.False(result);
        }

        [Fact]
        public void ValidatePlacePosition_WithGivenTableAndInvalidXPositionBigger_ReturnsFalse()
        {
            Table table = new Table(3, 3);
            var result = table.ValidatePlacePosition(new System.Drawing.Point(10, 3));

            Assert.False(result);
        }

        [Fact]
        public void ValidatePlacePosition_WithGivenTableAndInvalidYPositionSmaller_ReturnsFalse()
        {
            Table table = new Table(3, 3);
            var result = table.ValidatePlacePosition(new System.Drawing.Point(3, -5));

            Assert.False(result);
        }

        [Fact]
        public void ValidatePlacePosition_WithGivenTableAndInvalidYPositionBigger_ReturnsFalse()
        {
            Table table = new Table(3, 3);
            var result = table.ValidatePlacePosition(new System.Drawing.Point(3, 10));

            Assert.False(result);
        }
    }
}
