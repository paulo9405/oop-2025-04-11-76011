// See https://aka.ms/new-console-template for more information
using oop_2025_04_11_76011.models;
using Challenge;

Console.WriteLine("Hello, World!");

// Run the DriverTimeAndDate class
DriverTimeAndDate.Run();

// Print the local and UTC time
LocalToUTC.PrintLocalTime();

// Create an EventCountdown for Christmas (25th December)
var christmas = new EventCountdown(new DateTime(DateTime.Now.Year, 12, 25));
Console.WriteLine($"Days until Christmas: {christmas.GetDaysRemaining()}");
var (days, hours, minutes, seconds) = christmas.GetTimeRemaining();
Console.WriteLine($"Time until Christmas: {days} days, {hours} hours, {minutes} minutes, {seconds} seconds");
