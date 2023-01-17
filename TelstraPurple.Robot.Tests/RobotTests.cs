using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelstraPurple.Robot.Tests
{
    public class RobotTests
    {
        [Fact]
        public void GetPosition_WithValidPosition_ReturnsPosition()
        {
            int x = 4;
            int y = 3;
            var position = new Point(x, y);
            Robot robot = new Robot(position, Orientation.NORTH);

            var result = robot.GetPosition();

            Assert.Equal(x, result.X);
            Assert.Equal(y, result.Y);
        }

        [Fact]
        public void GetOrientation_WithValidPosition_ReturnsOrientation()
        {
            int x = 4;
            int y = 3;
            var position = new Point(x, y);
            var orientation = Orientation.NORTH;
            Robot robot = new Robot(position, orientation);

            var result = robot.GetOrientation();

            Assert.Equal(orientation, result);
        }

        [Fact]
        public void SetPosition_WithValidPosition_SetsPosition()
        {
            int x = 4;
            int y = 3;
            var position = new Point(x, y);

            x = 3;
            y = 1;
            var newPosition = new Point(x, y);


            var orientation = Orientation.NORTH;
            Robot robot = new Robot(position, orientation);

            robot.SetPosition(newPosition);

            var result = robot.GetPosition();

            Assert.Equal(x, result.X);
            Assert.Equal(y, result.Y);
        }

        [Fact]
        public void ChangeOrientation_WithOrientationNORTHAndMovementLeft_SetsNewOrientation()
        {
            int x = 4;
            int y = 3;
            var position = new Point(x, y);
            var newOrientation = Orientation.WEST;

            var orientation = Orientation.NORTH;
            Robot robot = new Robot(position, orientation);

            robot.ChangeOrientation(Movement.LEFT);

            var result = robot.GetOrientation();

            Assert.Equal(newOrientation, result);

        }

        [Fact]
        public void ChangeOrientation_WithOrientationWESTAndMovementLeft_SetsNewOrientation()
        {
            int x = 4;
            int y = 3;
            var position = new Point(x, y);
            var newOrientation = Orientation.SOUTH;

            var orientation = Orientation.WEST;
            Robot robot = new Robot(position, orientation);

            robot.ChangeOrientation(Movement.LEFT);

            var result = robot.GetOrientation();

            Assert.Equal(newOrientation, result);

        }

        [Fact]
        public void ChangeOrientation_WithOrientationSOUTHAndMovementLeft_SetsNewOrientation()
        {
            int x = 4;
            int y = 3;
            var position = new Point(x, y);
            var newOrientation = Orientation.EAST;

            var orientation = Orientation.SOUTH;
            Robot robot = new Robot(position, orientation);

            robot.ChangeOrientation(Movement.LEFT);

            var result = robot.GetOrientation();

            Assert.Equal(newOrientation, result);

        }

        [Fact]
        public void ChangeOrientation_WithOrientationEASTAndMovementLeft_SetsNewOrientation()
        {
            int x = 4;
            int y = 3;
            var position = new Point(x, y);
            var newOrientation = Orientation.NORTH;

            var orientation = Orientation.EAST;
            Robot robot = new Robot(position, orientation);

            robot.ChangeOrientation(Movement.LEFT);

            var result = robot.GetOrientation();

            Assert.Equal(newOrientation, result);

        }

        [Fact]
        public void ChangeOrientation_WithOrientationNORTHAndMovementRight_SetsNewOrientation()
        {
            int x = 4;
            int y = 3;
            var position = new Point(x, y);
            var newOrientation = Orientation.EAST;

            var orientation = Orientation.NORTH;
            Robot robot = new Robot(position, orientation);

            robot.ChangeOrientation(Movement.RIGHT);

            var result = robot.GetOrientation();

            Assert.Equal(newOrientation, result);

        }

        [Fact]
        public void ChangeOrientation_WithOrientationWESTAndMovementRight_SetsNewOrientation()
        {
            int x = 4;
            int y = 3;
            var position = new Point(x, y);
            var newOrientation = Orientation.NORTH;

            var orientation = Orientation.WEST;
            Robot robot = new Robot(position, orientation);

            robot.ChangeOrientation(Movement.RIGHT);

            var result = robot.GetOrientation();

            Assert.Equal(newOrientation, result);

        }

        [Fact]
        public void ChangeOrientation_WithOrientationSOUTHAndMovementRight_SetsNewOrientation()
        {
            int x = 4;
            int y = 3;
            var position = new Point(x, y);
            var newOrientation = Orientation.WEST;

            var orientation = Orientation.SOUTH;
            Robot robot = new Robot(position, orientation);

            robot.ChangeOrientation(Movement.RIGHT);

            var result = robot.GetOrientation();

            Assert.Equal(newOrientation, result);

        }

        [Fact]
        public void ChangeOrientation_WithOrientationEASTAndMovementRight_SetsNewOrientation()
        {
            int x = 4;
            int y = 3;
            var position = new Point(x, y);
            var newOrientation = Orientation.SOUTH;

            var orientation = Orientation.EAST;
            Robot robot = new Robot(position, orientation);

            robot.ChangeOrientation(Movement.RIGHT);

            var result = robot.GetOrientation();

            Assert.Equal(newOrientation, result);

        }

        [Fact]
        public void ToString_WithGivenRobot_ReturnsPositionAndOrientation()
        {
            int x = 4;
            int y = 3;
            var position = new Point(x, y);
            const string report = "Output: 4,3, EAST";

            var orientation = Orientation.EAST;
            Robot robot = new Robot(position, orientation);

            var result = robot.ToString();

            Assert.Equal(report, result);
        }
    }
}
