using System;
using System.Collections.Generic;
using System.Text;

namespace Funny_Events_HW_NET
{
    class Event
    {
        private string name;
        private uint population;
        private string place;
        private DateTime playTime;
        public readonly uint ID;
        private static uint counter = 0;
        private Client client;

        public Event(string name = "Noname", uint population = 0, string place = "No place", DateTime playTime = )
        {
            this.name = name;
            this.population = population;
            this.place = place;
            this.playTime = playTime;
        }

        public void moveDateByDay(uint days = 0)
        {
            playTime.AddDays(days);
        }

        public void moveDateByWeek(uint weeks = 0)
        {
            playTime.AddDays(weeks * 7);
        }

        public override string ToString()
        {
            return ($"");
        }
    }
}
