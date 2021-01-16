using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Basketbolcu : Sporcu
{
    

    public Basketbolcu()
    {
        this.basketbolcuAdi = "NoName";
        this.basketbolcuTakim = "NoTeam";
        this.ikilik = 0;
        this.ucluk = 0;
        this.serbestAtis = 0;
    }
    public Basketbolcu(string basketbolcuAdi, string basketbolcuTakim,int ikilik,int ucluk, int serbestAtis)
        :base(basketbolcuAdi, basketbolcuTakim)
    {
        this.ikilik = ikilik;
        this.ucluk = ucluk;
        this.serbestAtis = serbestAtis;
    }
    
    public override void sporcuPuaniGoster()
    {
        UnityEngine.Debug.Log("Ikilik: " + this.ikilik);
        UnityEngine.Debug.Log("Ucluk: " + this.ucluk);
        UnityEngine.Debug.Log("Serbest Atış: " + this.serbestAtis);
    }
    public string basketbolcuAdi { get; set; }
    public string basketbolcuTakim { get; set; }
    public int ikilik { get; set; }
    public int ucluk { get; set; }
    public int serbestAtis { get; set; }
    public bool kartKullanildiMi { get; set; }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
