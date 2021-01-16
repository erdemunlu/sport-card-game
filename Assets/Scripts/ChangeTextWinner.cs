using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class ChangeTextWinner : MonoBehaviour
{
    Test test1;
    [SerializeField] TextMeshProUGUI winnerText;
    // Start is called before the first frame update
    void Start()
    {
        test1 = FindObjectOfType<Test>();
        int scorePlayer = UnityEngine.PlayerPrefs.GetInt("KullaniciPoint");
        int scoreComputer = UnityEngine.PlayerPrefs.GetInt("BilgisayarPoint");
        if(scorePlayer > scoreComputer)
        {
            winnerText.text = "PLAYER";
        }
        else if (scorePlayer < scoreComputer)
        {
            winnerText.text = "COMPUTER";
        }
        else if(scorePlayer == scoreComputer)
        {
            winnerText.text = "SCORELESS";
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
