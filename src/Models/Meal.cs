using System;
using System.Collections;

namespace Models
{
    public class Meal
    {
        public long Id { get; set; }
        public MealTime MealTime { get; set; }
        public int DayOfWeek { get; set; }
        public Recipe Recipe { get; set; }
        public string Note { get; set; }
    }

    public enum MealTime
    {
        Breakfast,Lunch,Dinner
    }
}