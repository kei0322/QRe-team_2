using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class mouseover : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    // Start is called before the first frame update
    public GameObject comment;
    //マウスが乗っている時
    public void OnPointerEnter(PointerEventData eventData)
    {
        comment.gameObject.SetActive(true);
    }

    //マウスが外れた時
    public void OnPointerExit(PointerEventData eventData)
    {
        comment.gameObject.SetActive(false);
    }
}
