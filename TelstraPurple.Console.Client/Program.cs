// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using TelstraPurple.Console.Client;
using TelstraPurple.Robot;
using TelstraPurple.Console.Client.Commands.Exceptions;
using TelstraPurple.Console.Client.Commands;

    var _table = new Table(5, 5);
    RobotExecutor _executor = null;

    Console.WriteLine("/**********************************************/");
    Console.WriteLine("/*                                            */");
    Console.WriteLine("/*                                            */");
    Console.WriteLine("/* Welcome to TestraPurple - Robot Simulation */");
    Console.WriteLine("/*                                            */");
    Console.WriteLine("/* At any time press Q to quit                */");
    Console.WriteLine("/*                                            */");
    Console.WriteLine("/**********************************************/");


    Console.WriteLine("Please enter a valid command:");
    string command;
    _executor = new RobotExecutor(_table);

    while ((command = Console.ReadLine()) != "Q")
    {
        try
        {
            var commands = ParseCommand(command);
            ExecuteCommand(commands);
        }
        catch (FormatException e)
        {
            System.Console.WriteLine(e.Message);
        }
        catch (PlacedNotSetException e)
        {
            System.Console.WriteLine(e.Message);
        }

        catch (InvalidPlacementException e)
        {
            System.Console.WriteLine(e.Message);
        }
        catch (Exception)
        {
            System.Console.WriteLine("Enter a valid command");
        }
    }

    Command ParseCommand(string command)
    {
        var parser = new CommandParser(command);

        return parser.GetCommands();
    }

    void ExecuteCommand(Command command)
    {
        _executor.ExecuteCommand(command);
    }
