using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Futbolcu : Sporcu
{


    
    public Futbolcu()
    {
        this.futbolcuAdi = "NoName";
        this.futbolcuTakim = "NoTeam";
        this.penaltı = 0;
        this.serbestVurus = 0;
        this.kaleciKarsiKarsiya = 0;
    }
    public Futbolcu(string futbolcuAdi, string futbolcuTakim, int penaltı,int serbestVurus, int kaleciKarsiKarsiya)
        :base(futbolcuAdi, futbolcuTakim)
    {
        this.penaltı = penaltı;
        this.serbestVurus = serbestVurus;
        this.kaleciKarsiKarsiya = kaleciKarsiKarsiya;
    }
    public override void sporcuPuaniGoster()
    {
        UnityEngine.Debug.Log("Penaltı:" + this.penaltı);
        UnityEngine.Debug.Log("Serbest Vuruş:" + this.serbestVurus);
        UnityEngine.Debug.Log("Kaleciyle karşıkarşıya:" + this.kaleciKarsiKarsiya);
    }
    public string futbolcuAdi { get; set; }
    public string futbolcuTakim { get; set; }
    public int penaltı { get; set; }
    public int serbestVurus { get; set; }
    public int kaleciKarsiKarsiya { get; set; }
    public bool kartKullanildiMi { get; set; }
    // Start is called before the first frame update

    public void Awake()
    {
        
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
