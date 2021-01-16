using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ChangeTextComputer : MonoBehaviour
{
    Test test1;
    [SerializeField] TextMeshProUGUI computerText;
    // Start is called before the first frame update
    void Start()
    {
        test1 = FindObjectOfType<Test>();
    }

    // Update is called once per frame
    void Update()
    {
        computerText.text = test1.BilgisayarPuan.ToString();
    }
}
