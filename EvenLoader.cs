using UnityEngine;

public class EvenLoader : MonoBehaviour
{
    [SerializeField] GameObject prefabEventItem;
    [SerializeField] EventsData eventsData;
    [SerializeField] Transform eventsItemParent;
    private void Awake()
    {
        
    }

    private void LoadEvents()
    {
        for (int i = 0; i < eventsData.eventModels.Count; i++)
        {
        }
    }

    public void AddEventItem(EventModel eventModel)
    {
        GameObject item = Instantiate(prefabEventItem, eventsItemParent);
        EventItem eventItem = item.GetComponent<EventItem>();
        eventItem.Init(eventModel);
        eventsItemParent.localPosition = new Vector3(0, 0, 0);
    }
}
