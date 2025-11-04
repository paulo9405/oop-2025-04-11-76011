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
            DateTime today = DateTime.Today;
            int days = (eventDate - today).Days;
            return days > 0 ? days : 0;
        }
    }
}
