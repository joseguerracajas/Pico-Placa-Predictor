using Pico_Placa_Predictor.Models;

namespace Pico_Placa_Predictor.Data
{
    public class DataPicoPlaca
    {
        public static List<Schedule> Schedules = new List<Schedule>
        {
            new Schedule(new TimeOnly(7,00), new TimeOnly(9,30)),
            new Schedule(new TimeOnly(16,00), new TimeOnly(19,30)),
        };

        public static List<Restriction> Restrictions = new List<Restriction>
        {
            new Restriction(DayOfWeek.Monday, Schedules , new List<int>{1,2}),
            new Restriction(DayOfWeek.Tuesday, Schedules , new List<int>{3,4}),
            new Restriction(DayOfWeek.Wednesday, Schedules , new List<int>{5,6}),
            new Restriction(DayOfWeek.Thursday, Schedules , new List<int>{7,8}),
            new Restriction(DayOfWeek.Friday, Schedules , new List<int>{9,0}),
        };

        public static List<Holiday> Holidays = new List<Holiday>
        {
            new Holiday("New year", new DateOnly(2021,1,1)),
            new Holiday("Carnival", new DateOnly(2021,2,28)),
            new Holiday("Carnival", new DateOnly(2021,3,1)),
            new Holiday("Good Friday", new DateOnly(2021,4,15)),
        };


    }
}
