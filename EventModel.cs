using UnityEngine;
using System;

public class EventModel
{
    public DateTime _deadline;
    public  string _eventName;
    public EventModel(DateTime deadline, string eventName)
    {
        _deadline = deadline;
        _eventName = eventName;
    }
}
