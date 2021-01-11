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
        //TotalDaysToChristmasV1();
        //TotalDaysToChristmasV2();
        //TotalDaysToChristmasV3();
        //TotalDaysToChristmasV4();
        daysGui.text = TotalDaysToChristmasV4().ToString();
    }

    private void TotalDaysToChristmasV1()
    {
        while (currentDay.CompareTo(christmasDay) < 0)
        {
            currentDay = currentDay.AddDays(1);
            days++;
        }

        daysGui.text = days.ToString();
    }

    private void TotalDaysToChristmasV2()
    {
        int myDays = 0;

        while (currentDay.CompareTo(christmasDay) < 0)
        {
            currentDay = currentDay.AddDays(1);
            myDays++;
        }

        daysGui.text = myDays.ToString();
    }

    private void TotalDaysToChristmasV3()
    {
        double myDays = christmasDay.Subtract(currentDay).TotalDays;
        daysGui.text = myDays.ToString();
    }

    private double TotalDaysToChristmasV4()
    {
        return christmasDay.Subtract(currentDay).TotalDays;
    }

    void TestLocalVars()
    {
        Debug.Log("Test instanz; " + days);
        //Debug.Log("Test local; " + myDays);
    }
}
