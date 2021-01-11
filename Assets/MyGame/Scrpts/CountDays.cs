using UnityEngine;
using UnityEngine.UI;
using System;

public class CountDays : MonoBehaviour
{
    public Text daysGui;

    private DateTime christmasDay, currentDay;
    private DateTime firstAdvent, secondAdvent, thirdAdvent, fourthAdvent;

    private int days = 0;

    void Start()
    {
       christmasDay = new DateTime(2020, 12, 24);
       firstAdvent = new DateTime(2020, 11, 30);
       secondAdvent = new DateTime(2020, 12, 6);
       thirdAdvent = new DateTime(2020, 12, 13);
       fourthAdvent = new DateTime(2020, 12, 20);

        //currentDay = DateTime.Today;
        currentDay = firstAdvent;

        //exclusive christmasday
        TotalDaysToChristmas();
    }

    private void TotalDaysToChristmas()
    {
        while (currentDay.CompareTo(christmasDay) < 0)
        {
            currentDay = currentDay.AddDays(1);
            days++;
        }

        daysGui.text = days.ToString();
    }
}
