using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberData : MonoBehaviour
{
    //The number gameobjects(What contains the gameobjects that will be changed
    public List<GameObject> numbers = new List<GameObject>();
    
    //The clock class attached to this gameobject
    public Clock clock;

    //the temporary variable for the current hour (used to check if the hour is changed)
    public int tempHour;
    //Determines whether the hour has changed to tell the clock to show a different hour
    public bool hourChanged = true;

    //The temporary variable for the current miunute (used to check if the minute has changed)
    public int tempMinutes;
    //Determines whether the minute has changed to tell the clock to show a different minute
    public bool minuteChanged = true;

    private void Start()
    {
        //Declares the clock variable
        clock = gameObject.GetComponent<Clock>();
    }
    private void Update()
    {
        //if the hour is different from the tempHour variable
        if (tempHour != clock.hoursInt)
        {
            //set them equal
            tempHour = clock.hoursInt;
            //Tell the program that the hour has been changed
            hourChanged = true;
        }

        //if hour has been changed
        if (hourChanged)
        {
            //if time is before 1:00 PM (13:00) (It always should be unless program is set to 24 hour time) and the clock.hours variable has been declared
            if (clock.hoursInt <= 12 && (clock.hours != ""))
            {
                //if time is before 10:00 AM (10:00)
                if (clock.hoursInt < 10)
                {
                    //Change the first number gameobject to display "0"
                    ChangeValue("0", 0);
                    //Chane the second number gameobject to display the time (1-9)
                    ChangeValue(clock.hourZero.ToString(), 1);
                }
                //if time is after 9:59
                else if (clock.hoursInt > 10)
                {
                    //Change the first number gameobject to display the first number of the time. (ex; if the time is 12, it will display "1"
                    ChangeValue(clock.hourZero.ToString(), 0);
                    //Change the second number gameobject to display the second number of the time. (ex; if the time is 12, it will display "2"
                    ChangeValue(clock.hourOne.ToString(), 1);

                }
                //Set hourChanged to false because we've already matched the hour displayed with the hour it is
                hourChanged = false;

            }
        }
        //if the minute value is different from the tempMin variable
        if (tempMinutes != clock.minutesInt)
        {
            //Set the temp value to the minute value
            tempMinutes = clock.minutesInt;
            //Tell the program that the minute value has changed
            minuteChanged = true;
        }
        //if the minute has changed and the clock.minutes variable has been declared
        if (minuteChanged && clock.minutes != "")
        {
            //change the first minute gameobject to the first minute value. (ex; if the minute is 34, this will display "3"
            ChangeValue(clock.minZero.ToString(), 2);
            //change the second minute gameobject to the second minute value. (ex; if the minute is 34, this will display "4"
            ChangeValue(clock.minOne.ToString(), 3);
            //Set minuteChanged to false because we've already matched the minute value displayed with the minute value it is
            minuteChanged = false;
        }
    }

    void ChangeValue(string time, int number)
    {
        List<Transform> temp = new List<Transform>();
        for (int i = 0; i < numbers[number].transform.childCount; i++)
        {
            temp.Add(numbers[number].transform.GetChild(i));
        }
        foreach(Transform side in temp)
        {
            side.gameObject.SetActive(false);
        }

        switch (time)
        {
            case "1":
                //Debug.Log("One");
                
                temp[4].gameObject.SetActive(true);
                temp[6].gameObject.SetActive(true);
                break;

            case "2":
                temp[0].gameObject.SetActive(true);
                temp[1].gameObject.SetActive(true);
                temp[2].gameObject.SetActive(true);
                temp[4].gameObject.SetActive(true);
                temp[5].gameObject.SetActive(true);
                //Debug.Log("Two");
                break;

            case "3":
                temp[0].gameObject.SetActive(true);
                temp[1].gameObject.SetActive(true);
                temp[2].gameObject.SetActive(true);
                temp[4].gameObject.SetActive(true);
                temp[6].gameObject.SetActive(true);
                //Debug.Log("Three");
                break;

            case "4":
                temp[1].gameObject.SetActive(true);
                temp[3].gameObject.SetActive(true);
                temp[4].gameObject.SetActive(true);
                temp[6].gameObject.SetActive(true);
                //Debug.Log("Four");
                break;

            case "5":
                temp[0].gameObject.SetActive(true);
                temp[1].gameObject.SetActive(true);
                temp[2].gameObject.SetActive(true);
                temp[3].gameObject.SetActive(true);
                temp[6].gameObject.SetActive(true);
                //Debug.Log("Five");
                break;

            case "6":
                temp[0].gameObject.SetActive(true);
                temp[1].gameObject.SetActive(true);
                temp[2].gameObject.SetActive(true);
                temp[3].gameObject.SetActive(true);
                temp[5].gameObject.SetActive(true);
                temp[6].gameObject.SetActive(true);
                //Debug.Log("Six");
                break;

            case "7":
                temp[0].gameObject.SetActive(true);
                temp[4].gameObject.SetActive(true);
                temp[6].gameObject.SetActive(true);
                //Debug.Log("Seven");
                break;

            case "8":
                temp[0].gameObject.SetActive(true);
                temp[1].gameObject.SetActive(true);
                temp[2].gameObject.SetActive(true);
                temp[3].gameObject.SetActive(true);
                temp[4].gameObject.SetActive(true);
                temp[5].gameObject.SetActive(true);
                temp[6].gameObject.SetActive(true);
                //Debug.Log("Eight");
                break;

            case "9":
                temp[0].gameObject.SetActive(true);
                temp[1].gameObject.SetActive(true);
                temp[3].gameObject.SetActive(true);
                temp[4].gameObject.SetActive(true);
                temp[6].gameObject.SetActive(true);
                //Debug.Log("Nine");
                break;

            case "0":
                temp[0].gameObject.SetActive(true);
                temp[2].gameObject.SetActive(true);
                temp[3].gameObject.SetActive(true);
                temp[4].gameObject.SetActive(true);
                temp[5].gameObject.SetActive(true);
                temp[6].gameObject.SetActive(true);
                //Debug.Log("Zero");
                break;
        }
    }

}
