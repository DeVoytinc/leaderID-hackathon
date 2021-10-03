
using System;
using UnityEngine;
using TMPro;
using System.Globalization;


public class AddPanelUI : MonoBehaviour
{
    [SerializeField] private TMP_Text nameEvent;
    [SerializeField] private TMP_Text _date;
    [SerializeField] private TMP_Text hours;
    [SerializeField] private TMP_Text minute;
    [SerializeField] private TMP_Dropdown dropdown;
    [SerializeField] private EvenLoader evenLoader;

    public void AddEvent()
    {
        string[] date = _date.text.Split('.');
        date[2] = date[2].Substring(0, 2);
        DateTime time = new DateTime((Convert.ToInt32(date[2])) + 2000, Convert.ToInt32(date[1]), Convert.ToInt32(date[0]), Convert.ToInt32(hours.text), Convert.ToInt32(minute.text), 0);
        EventModel eventmod = new EventModel(time, nameEvent.text);
        evenLoader.AddEventItem(eventmod);
    }

    

    public void AddHour()
    {
        
        if (Convert.ToInt32(hours.text) + 1 < 24)
            hours.text = (Convert.ToInt32(hours.text) + 1).ToString();
        else
            hours.text = "0";
    }
    public void AddMinute()
    {
        if (Convert.ToInt32(minute.text) + 1 < 60)
            minute.text = (Convert.ToInt32(minute.text) + 1).ToString();
        else
            minute.text = "0";
    }
    public void MinusHour()
    {
        if (Convert.ToInt32(hours.text) - 1 > 0)
            hours.text = (Convert.ToInt32(hours.text) - 1).ToString();
        else
            hours.text = "23";
    }
    public void MinusMinute()
    {
        if (Convert.ToInt32(minute.text) - 1 > 0)
            minute.text = (Convert.ToInt32(minute.text) - 1).ToString();
        else
            minute.text = "59";
    }
}
