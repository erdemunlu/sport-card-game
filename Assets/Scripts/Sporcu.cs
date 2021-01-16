using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sporcu : MonoBehaviour
{

    public string sporcuIsim { get; set; }
    public string sporcuTakim { get; set; }
    public Sporcu()
    {
        this.sporcuIsim = "NoName";
        this.sporcuTakim = "NoTeam";
    }
    public Sporcu(string sporcuIsim, string sporcuTakim)
    {
        this.sporcuIsim = sporcuIsim;
        this.sporcuTakim = sporcuTakim;
    }
    public virtual void sporcuPuaniGoster()
    {
        UnityEngine.Debug.Log("No Point");
    }

    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
