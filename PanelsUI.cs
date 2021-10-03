using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class PanelsUI : MonoBehaviour
{
    [SerializeField] GameObject AddImagePanel;
    private void Awake()
    {
        AddImagePanel.GetComponent<RectTransform>().anchoredPosition = new Vector3(-1500, 0, 0);
    }
    public void OpenAddImagePanel()
    {
        AddImagePanel.transform.DOLocalMoveX(0, 0.7f);
    }
    public void CloseAddImagePanel()
    {
        AddImagePanel.transform.DOLocalMoveX(-1500, 0.7f);
    }
}
