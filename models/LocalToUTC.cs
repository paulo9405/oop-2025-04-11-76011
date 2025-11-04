namespace oop_2025_04_11_76011.models;

public static class LocalToUTC
{
    public static void PrintLocalTime()
    {
        DateTime localTime = DateTime.Now;
        DateTime utcTime = localTime.ToUniversalTime();
        Console.WriteLine($"Local Time: {localTime}");
        Console.WriteLine($"UTC Time: {utcTime}");
    }
}

public static class BirthdayCalculator {
    public static int DaysUntilBirthday()
    {
        DateTime today = new DateTime(2025, 11, 4);
        DateTime birthday = new DateTime(today.Year, 5, 5);
        if (today > birthday)
        {
            birthday = birthday.AddYears(1);
        }
        return (birthday - today).Days;
    }
}