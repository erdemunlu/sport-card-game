using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardZoom : MonoBehaviour
{
    public GameObject Canvas;
    private GameObject zoomCard;
    public void Awake()
    {
        Canvas = GameObject.Find("Canvas");
    }
    
    public void OnHoverEnter()
    {
        if (Input.mousePosition.y< 600){
            zoomCard = Instantiate(gameObject, new Vector2(Input.mousePosition.x, Input.mousePosition.y + 250), Quaternion.identity);
            zoomCard.transform.SetParent(Canvas.transform, false);
            zoomCard.layer = LayerMask.NameToLayer("Zoom");


            RectTransform rect = zoomCard.GetComponent<RectTransform>();
            rect.sizeDelta = new Vector2(300, 500);
        }
         
       

    }
    public void OnHoverExit()
    {
        Destroy(zoomCard);
    }
}
