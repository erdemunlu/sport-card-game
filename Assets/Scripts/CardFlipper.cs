using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CardFlipper : MonoBehaviour
{
    public Sprite cardFront;
    public Sprite cardBack;

    public void flip()
    {
        if (gameObject.tag == "KullaniciF" || gameObject.tag == "KullaniciB")
        {
            Sprite currentSprite = gameObject.GetComponent<Image>().sprite;
            if (currentSprite == cardFront)
            {
                gameObject.GetComponent<Image>().sprite = cardBack;
            }
            else
            {
                gameObject.GetComponent<Image>().sprite = cardFront;
            }
        }
        
    }
   
    public void flipEnd()
    {

        if (gameObject.tag == "KullaniciF" || gameObject.tag == "KullaniciB")
        {
            Sprite currentSprite = gameObject.GetComponent<Image>().sprite;
            if (currentSprite == cardFront)
            {
                gameObject.GetComponent<Image>().sprite = cardBack;
            }
            else
            {
                gameObject.GetComponent<Image>().sprite = cardFront;
            }
        }
            
        

    }
    public void flipEndComputer(GameObject f)
    {

        {
            Sprite currentSprite = f.GetComponent<Image>().sprite;
            if (currentSprite == cardFront)
            {
                f.GetComponent<Image>().sprite = cardBack;
            }
            else
            {
                f.GetComponent<Image>().sprite = cardFront;
            }
        }

    }
}

