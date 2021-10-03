using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class EventItem : MonoBehaviour
{
    [SerializeField] TMP_Text _nameText;
    [SerializeField] TMP_Text _dateText;
    public void Init(EventModel eventModel)
    {
        _nameText.text = eventModel._eventName;
        _dateText.text = eventModel._deadline.ToString().Substring(0,16);
    }
}
