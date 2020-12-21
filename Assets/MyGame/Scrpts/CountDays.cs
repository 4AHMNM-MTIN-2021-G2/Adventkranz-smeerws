using UnityEngine;
using UnityEngine.UI;

public class CountDays : MonoBehaviour
{
    public Text daysGui;

    private System.DateTime christmasDay, currentDay;
    private System.DateTime firstAdvent, secondAdvent, thirdAdvent, fourthAdvent;

    private int days = 0;

    void Start()
    {
       christmasDay = new System.DateTime(2020, 12, 24);
       firstAdvent = new System.DateTime(2020, 11, 30);
       secondAdvent = new System.DateTime(2020, 12, 6);
       thirdAdvent = new System.DateTime(2020, 12, 13);
       fourthAdvent = new System.DateTime(2020, 12, 20);

       currentDay = System.DateTime.Today;

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
