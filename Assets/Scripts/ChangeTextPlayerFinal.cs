using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class ChangeTextPlayerFinal : MonoBehaviour
{
    Test test1;
    [SerializeField] TextMeshProUGUI playerText;
    // Start is called before the first frame update
    void Start()
    {
        test1 = FindObjectOfType<Test>();
        int scorePlayer = UnityEngine.PlayerPrefs.GetInt("KullaniciPoint");
        playerText.text = scorePlayer.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
