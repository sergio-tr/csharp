using System;
using System.Linq;

class BirdCount
{

    private static readonly int[] lastWeek = new int[] { 0, 2, 5, 3, 7, 8, 4 };

    private static readonly int busyDayBirdCount = 5;

    private int[] birdsPerDay;

    public BirdCount(int[] birdsPerDay)
    {
        this.birdsPerDay = birdsPerDay;
    }

    public static int[] LastWeek()
    {
        return (int[])lastWeek.Clone();
    }

    public int Today()
    {
        if (birdsPerDay == null || birdsPerDay.Length == 0)
        {
            return 0;
        }

        return birdsPerDay[birdsPerDay.Length - 1];
    }

    public void IncrementTodaysCount()
    {
        if (birdsPerDay != null && birdsPerDay.Length > 0)
        {
            birdsPerDay[birdsPerDay.Length - 1] += 1;
        }
    }

    public bool HasDayWithoutBirds()
    {
        return birdsPerDay != null && birdsPerDay.Any(birdsCount => birdsCount == 0);
    }

    public int CountForFirstDays(int numberOfDays)
    {
        if (numberOfDays > this.birdsPerDay.Length)
        {
            throw new ArgumentOutOfRangeException("The number of days provided must be lower than the number of days used for recording the birds count");
        }

        return birdsPerDay.Take(numberOfDays).Sum();
    }

    public int BusyDays()
    {
        return birdsPerDay.Where(birdsCount => birdsCount >= busyDayBirdCount).Count();
    }
}
