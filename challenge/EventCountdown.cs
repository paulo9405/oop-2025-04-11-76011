using System;

namespace Challenge
{
    public class EventCountdown
    {
        public DateTime eventDate;

        public EventCountdown(DateTime date)
        {
            eventDate = date;
        }

        public int GetDaysRemaining()
        {
            DateTime now = DateTime.Now;
            int days = (eventDate.Date - now.Date).Days;
            return days > 0 ? days : 0;
        }

        public (int days, int hours, int minutes, int seconds) GetTimeRemaining()
        {
            DateTime now = DateTime.Now;
            TimeSpan diff = eventDate - now;
            if (diff.TotalSeconds < 0)
                return (0, 0, 0, 0);
            return (diff.Days, diff.Hours, diff.Minutes, diff.Seconds);
        }
    }
}
