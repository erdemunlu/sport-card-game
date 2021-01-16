using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class ChangeTextPlayer : MonoBehaviour
{
    // Start is called before the first frame update
    Test test1;
    [SerializeField] TextMeshProUGUI playerText;
    void Start()
    {
        test1 = FindObjectOfType<Test>();
    }

    // Update is called once per frame
    void Update()
    {
        playerText.text = test1.KullaniciPuan.ToString();
    }
}
