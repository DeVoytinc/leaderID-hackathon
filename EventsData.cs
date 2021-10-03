using System.Net;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System;
using System.Text;
using System.Xml.Linq;
public class EventsData : MonoBehaviour
{

    public List<EventModel> eventModels;
    public void AddEvent(EventModel eventModel)
    {
        eventModels.Add(eventModel);
    }

}
