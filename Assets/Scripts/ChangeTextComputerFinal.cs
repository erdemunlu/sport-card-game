using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class ChangeTextComputerFinal : MonoBehaviour
{
    Test test1;
    [SerializeField] TextMeshProUGUI computerText;
    // Start is called before the first frame update
    void Start()
    {
        test1 = FindObjectOfType<Test>();
        int scoreComputer = UnityEngine.PlayerPrefs.GetInt("BilgisayarPoint");
        computerText.text = scoreComputer.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
