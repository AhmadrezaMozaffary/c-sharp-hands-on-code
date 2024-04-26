using System.Collections.Generic;

namespace Rooydaad.Web.Data
{
    public static class Database
    {

        public static List<Event> GetAvailableEvents(int howMany = 15)
        {
            List<Event> events = new();

            for (int i = 1; i <= howMany; i++)
            {
                events.Add(
                    new Event()
                    {
                        Id = i,
                        Name = $"Amazing event for Compny({i})",
                        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Tempor nec feugiat nisl pretium fusce id. Viverra accumsan in nisl nisi scelerisque eu. In nulla posuere sollicitudin aliquam ultrices.",
                        Image = @"https://www.yugioh-card.com/eu/wp-content/uploads/2022/07/events-01.webp"
                    });
            }

            return events;
        }
    }
}
