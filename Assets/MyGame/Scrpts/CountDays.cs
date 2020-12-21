using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountDays : MonoBehaviour
{
    public Text daysGui;

    private System.DateTime christmasDay, currentDay;
    private System.DateTime firstAdvent, secondAdvent, thirdAdvent, fourthAdvent;

    private System.DateTime currTestDay;

    private int days = 0;

   

    // Start is called before the first frame update
    void Start()
    {
        christmasDay = new System.DateTime(2020, 12, 24);
        firstAdvent = new System.DateTime(2020, 11, 30);
        secondAdvent = new System.DateTime(2020, 12, 6);
        thirdAdvent = new System.DateTime(2020, 12, 13);
        fourthAdvent = new System.DateTime(2020, 12, 20);

        currTestDay = new System.DateTime(2020, 12, 23);


        currentDay = System.DateTime.Today;


        Debug.Log("curr Test Day " + currTestDay);
        currTestDay = currTestDay.AddDays(1);
        Debug.Log("curr Test Day + 1 " + currTestDay);
        currTestDay = currTestDay.AddDays(1);
        Debug.Log("curr Test Day + 2 " + currTestDay);
        currTestDay = currTestDay.AddDays(1);
        Debug.Log("curr Test Day + 3 " + currTestDay);

       while (currentDay.CompareTo(christmasDay) <= 0)
        {  
            currentDay = currentDay.AddDays(1);
            Debug.Log("currentDay " + currentDay);
            days++;

        }

        daysGui.text = days.ToString();
        Debug.Log("Days to christmas " + days);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
