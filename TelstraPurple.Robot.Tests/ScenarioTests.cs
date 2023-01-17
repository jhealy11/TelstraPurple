
using System.Drawing;

namespace TelstraPurple.Robot.Tests
{
    public class ScenarioTests
    {

        //Bottom Left, can't move left
        [Fact]
        public void Robot00West_Move_RobotPositionStaysTheSame()
        {
            var table = new Table(5, 5);
            var robot = new Robot(new Point(0, 0), Orientation.WEST);
            const string output = "Output: 0,0, WEST";
            table.MoveRobot(robot);

            var result = robot.ToString();

            Assert.Equal(output, result);
        }
        //Bottom Left, can't move down
        [Fact]
        public void Robot00South_Move_RobotPositionStaysTheSame()
        {
            var table = new Table(5, 5);
            var robot = new Robot(new Point(0, 0), Orientation.SOUTH);
            const string output = "Output: 0,0, SOUTH";
            table.MoveRobot(robot);

            var result = robot.ToString();

            Assert.Equal(output, result);
        }

        //top left, can't move left
        [Fact]
        public void Robot00North_Move_RobotPositionStaysTheSame()
        {
            var table = new Table(5, 5);
            var robot = new Robot(new Point(0, 5), Orientation.WEST);
            const string output = "Output: 0,5, WEST";
            table.MoveRobot(robot);

            var result = robot.ToString();

            Assert.Equal(output, result);
        }
        //top left, can't move up
        [Fact]
        public void Robot05West_Move_RobotPositionStaysTheSame()
        {
            var table = new Table(5, 5);
            var robot = new Robot(new Point(0, 5), Orientation.NORTH);
            const string output = "Output: 0,5, NORTH";
            table.MoveRobot(robot);

            var result = robot.ToString();

            Assert.Equal(output, result);
        }

        //Top Right, can't move right
        [Fact]
        public void Robot55East_Move_RobotPositionStaysTheSame()
        {
            var table = new Table(5, 5);
            var robot = new Robot(new Point(5, 5), Orientation.EAST);
            const string output = "Output: 5,5, EAST";
            table.MoveRobot(robot);

            var result = robot.ToString();

            Assert.Equal(output, result);
        }
        //Top Right, can't move up
        [Fact]
        public void Robot55North_Move_RobotPositionStaysTheSame()
        {
            var table = new Table(5, 5);
            var robot = new Robot(new Point(5, 5), Orientation.NORTH);
            const string output = "Output: 5,5, NORTH";
            table.MoveRobot(robot);

            var result = robot.ToString();

            Assert.Equal(output, result);
        }

        //bottom right, can't move right
        [Fact]
        public void Robot50East_Move_RobotPositionStaysTheSame()
        {
            var table = new Table(5, 5);
            var robot = new Robot(new Point(5, 0), Orientation.EAST);
            const string output = "Output: 5,0, EAST";
            table.MoveRobot(robot);

            var result = robot.ToString();

            Assert.Equal(output, result);
        }
        //bottom right, can't move down
        [Fact]
        public void Robot50South_Move_RobotPositionStaysTheSame()
        {
            var table = new Table(5, 5);
            var robot = new Robot(new Point(5, 0), Orientation.SOUTH);
            const string output = "Output: 5,0, SOUTH";
            table.MoveRobot(robot);

            var result = robot.ToString();

            Assert.Equal(output, result);
        }

        [Fact]
        public void ScenarioA_Start00North_Move_RobotMoves()
        {
            var table = new Table(5, 5);
            var robot = new Robot(new Point(0, 0), Orientation.NORTH);
            const string output = "Output: 0,1, NORTH";

            table.MoveRobot(robot);

            var result = robot.ToString();

            Assert.Equal(output, result);

        }

        [Fact]
        public void ScenarioB_Start00North_NewOrientation_RobotChangesOrientation()
        {
            var robot = new Robot(new Point(0, 0), Orientation.NORTH);
            const string output = "Output: 0,0, WEST";

            robot.ChangeOrientation(Movement.LEFT);

            var result = robot.ToString();

            Assert.Equal(output, result);
        }

        [Fact]
        public void ScenarioC_Start12East_Move_Move_Left_Move_GetsCorrectPositionAndOrientation()
        {
            var table = new Table(5, 5);
            var robot = new Robot(new Point(1, 2), Orientation.EAST);
            const string output = "Output: 3,3, NORTH";
            table.MoveRobot(robot);
            table.MoveRobot(robot);
            robot.ChangeOrientation(Movement.LEFT);
            table.MoveRobot(robot);

            var result = robot.ToString();

            Assert.Equal(output, result);
        }

        [Fact]
        public void ScenarioD_Start12East_Move_Left_Move_Place_Move_GetsCorrectPositionAndOrientation()
        {
            var table = new Table(5, 5);
            var robot = new Robot(new Point(1, 2), Orientation.EAST);
            const string output = "Output: 3,2, NORTH";

            table.MoveRobot(robot);
            robot.ChangeOrientation(Movement.LEFT);
            table.MoveRobot(robot);
            robot = new Robot(new Point(3, 1), robot.GetOrientation());
            table.MoveRobot(robot);

            var result = robot.ToString();

            Assert.Equal(output, result);
        }
    }
}
