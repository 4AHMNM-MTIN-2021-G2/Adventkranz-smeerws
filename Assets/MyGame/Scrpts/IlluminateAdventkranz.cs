using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IlluminateAdventkranz : MonoBehaviour
{
    public GameObject flame1, flame2, flame3, flame4;

    private DateTime currentDay, christmasDay;
    private DateTime firstAdvent, secondAdvent, thirdAdvent, fourthAdvent;
    
    
    
    // Start is called before the first frame update
    void Start()
    {
        currentDay = DateTime.Today;

        firstAdvent = new DateTime(2020, 11, 30);
        secondAdvent = new DateTime(2020, 12, 6);
        thirdAdvent = new DateTime(2020, 12, 13);
        fourthAdvent = new DateTime(2020, 12, 20);
        christmasDay = new DateTime(2020, 12, 24);

        currentDay = firstAdvent;

        flame1.SetActive(false);
        flame2.SetActive(false);
        flame3.SetActive(false);
        flame4.SetActive(false);

        if (currentDay.CompareTo(firstAdvent) >= 0)
        {
            Debug.Log("K1 brennt");
            flame1.SetActive(true);
        }
        if (currentDay.CompareTo(secondAdvent) >= 0)
        {
            Debug.Log("K2 brennt");
            flame2.SetActive(true);
        }
        if (currentDay.CompareTo(thirdAdvent) >= 0)
        {
            Debug.Log("K3 brennt");
            flame3.SetActive(true);
        }
        if (currentDay.CompareTo(fourthAdvent) >= 0)
        {
            Debug.Log("K4 brennt");
            flame4.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
