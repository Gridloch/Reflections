using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class AnalogueClock : MonoBehaviour
{
    public RectTransform hourHand;
    public RectTransform minuteHand;
    

    // Update is called once per frame
    void Update()
    {
        System.TimeSpan time = (System.DateTime.UtcNow - SaveLoadManager.Instance.playerData.timeDayStart);

        if (time.Duration().TotalHours > 1)
        {
            minuteHand.localRotation = Quaternion.Euler(0, 0f, 0f);
            hourHand.localRotation = Quaternion.Euler(0, 0f, 0f);
        }
        else
        {
            float minutes = (float)time.TotalSeconds;
            float hours = (float)time.TotalMinutes;

            minuteHand.localRotation = Quaternion.Euler(0, 0f, -minutes * 6f);
            hourHand.localRotation = Quaternion.Euler(0, 0f, -hours * 6f);
        }

        
    }
}
