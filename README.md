# TelstraPurple

#Assumptions about this project
# 1 - When a command that will put the Robot over the edge of the table is entered, the robot will just stay still on it's spot.
#		This is not reported to the user. But two "REPORT" commands, one before the "MOVE" and one after will yield the same result.

#2 - It is hard to know if all potential incorrect input commands have been captured. But I have done my best

# Build the solution
dontnet build

# Run Tests
dotnet test

# Build solution for release
dotnet publish -c Release -r win10-x64

# Start the project
.\TelstraPurple.Console.Client\bin\Release\net6.0\TelstraPurple.Console.Client.exe
