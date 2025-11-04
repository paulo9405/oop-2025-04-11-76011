namespace oop_2025_04_11_76011.models;

public static class DriverTimeAndDate
{
    public static void Run()
    {
        Console.WriteLine("I am the DriverTimeAndDate class!");
        ShowAppDetails();
    }

    public static void ShowAppDetails()
    {
        Console.WriteLine($"Title: {AppConstants.Title}");
        Console.WriteLine($"Version: {AppConstants.Version}");
    }
}

public static class ChristmasCountdown
{
    public static void CheckDaysUntilChristmas()
    {
        var today = DateTime.Now;
        var christmas = new DateTime(today.Year, 12, 25);
        if (today > christmas)
        {
            christmas = christmas.AddYears(1);
        }
        var daysUntilChristmas = (christmas - today).Days;
        Console.WriteLine($"Days until Christmas: {daysUntilChristmas}");
    }
}

public static class Deadline {
    public static void CheckDeadline() {
        var today = DateTime.Now;
        var deadline = today.AddDays(2);
        Console.WriteLine($"Deadline is in 2 days: {deadline.ToShortDateString()}");
    }
}
