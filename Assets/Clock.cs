using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clock : MonoBehaviour
{
    public int hoursInt;
    public string hours;

    public string nonTwentyFour;

    public string minutes;
    public int minutesInt;
    public char minZero;
    public char minOne;
    public char hourZero;
    public char hourOne;

    void Update()
    {
        var date = System.DateTime.Now;

        hours = date.ToString("HH");
        hoursInt = int.Parse(hours);

        if (hoursInt > 12)
        {
            hoursInt = hoursInt - 12;
        }

        nonTwentyFour = hoursInt.ToString();
        hourZero = nonTwentyFour[0];
        if (hoursInt > 10)
        {
            hourOne = nonTwentyFour[1];
        }
        minutes = date.ToString("mm");
        minutesInt = int.Parse(minutes);
        minZero = minutes[0];
        minOne = minutes[1]; 
    }
}
