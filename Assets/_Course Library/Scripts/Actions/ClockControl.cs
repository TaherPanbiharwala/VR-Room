using UnityEngine;
using System;

public class ClockControl : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
        private Transform Clock_Analog_A_Hour;
        private Transform Clock_Analog_A_Minute;
        private Transform Clock_Analog_A_Second;
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
{
    DateTime currentTime = DateTime.Now;
    
    float hourRotation = (currentTime.Hour % 12) * 30f + currentTime.Minute * 0.5f;
    float minuteRotation = currentTime.Minute * 6f;
    float secondRotation = currentTime.Second * 6f;

    Clock_Analog_A_Hour.localRotation = Quaternion.Euler(0, 0, -hourRotation);
    Clock_Analog_A_Minute.localRotation = Quaternion.Euler(0, 0, -secondRotation);
    Clock_Analog_A_Second.localRotation = Quaternion.Euler(0, 0, -secondRotation);
}
}
