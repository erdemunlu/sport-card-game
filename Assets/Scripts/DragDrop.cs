using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragDrop : MonoBehaviour
{
    public GameObject Canvas;
    private bool isDragging = false;
    private Vector3 startPosition;
    private bool isOverDropZonePlayer = false;
    private bool isOverDropZoneComputer = false;
    private GameObject stratParent;
    private GameObject dropZone;
    public GameObject kart;
    private GameObject VSareaPlayer;
    private GameObject VSareaComputer;
    public bool dragging = false;
    Test test1;
    
    public void Awake()
    {
        
        Canvas = GameObject.Find("Canvas");
        VSareaPlayer = GameObject.Find("VSareaPlayer");
        VSareaComputer = GameObject.Find("VSareaComputer");
}
    public void Start()
    {
        test1 = FindObjectOfType<Test>();
    }
    public void startDrag()
    {
        dragging = true;
        if (gameObject.tag == "KullaniciF" || gameObject.tag == "KullaniciB")
        {
            stratParent = transform.parent.gameObject;
            startPosition = transform.position;
            isDragging = true;
        }
            
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject ParentGameObjectPlayer = GameObject.FindGameObjectWithTag("VSPlayer");
        int mevcut = ParentGameObjectPlayer.transform.childCount;
        if (gameObject.tag == "KullaniciF"   && mevcut == 0 && test1.sira == 1)
        {
            isOverDropZonePlayer = true;
            //VSareaPlayer = collision.gameObject;
        }
        else if (gameObject.tag == "KullaniciB" && mevcut == 0 && test1.sira == 2)
        {
            isOverDropZonePlayer = true;
            // VSareaComputer = collision.gameObject;
        }
        else if (gameObject.tag == "ComputerF" )
        {
            isOverDropZoneComputer = true;
           // VSareaComputer = collision.gameObject;
        }
        else if (gameObject.tag == "ComputerB")
        {
            isOverDropZoneComputer = true;
            // VSareaComputer = collision.gameObject;
        }

        //dropZone = collision.gameObject;
    }
    public void endDrag()
    {
        dragging = false;
        isDragging = false;
        if (isOverDropZonePlayer && (gameObject.tag == "KullaniciF" || gameObject.tag == "KullaniciB"))
        {
            transform.SetParent(VSareaPlayer.transform,false);
            UnityEngine.Debug.Log("Player kartının adı:" + gameObject.name);
        }

        else if (isOverDropZoneComputer && (gameObject.tag == "ComputerF" || gameObject.tag == "ComputerB"))
        {
            transform.SetParent(VSareaComputer.transform, false);
            UnityEngine.Debug.Log("Computer kartının adı:" + gameObject.name);
        }
        else
        {
            if (gameObject.tag == "KullaniciF" || gameObject.tag == "KullaniciB")
            {
                transform.position = startPosition;
                transform.SetParent(stratParent.transform, false);
            }

        }
    }
    
    void Update()
    {
        if (isDragging)
        {
            if (gameObject.tag == "KullaniciF" || gameObject.tag == "KullaniciB")
            {
                transform.position = new Vector3(Input.mousePosition.x, Input.mousePosition.y);
                transform.SetParent(Canvas.transform, true);
            }
                
        }
        
    }
}
