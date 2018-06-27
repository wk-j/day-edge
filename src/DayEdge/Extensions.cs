using System;

namespace DayEdge {
    public static class Extensions {
        public static DateTime StartOfDay(this DateTime source)
            => source.Date;
        public static DateTime EndOfDay(this DateTime source)
            => source.Date.AddDays(1).AddTicks(-1);
    }
}
