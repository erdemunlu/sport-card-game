using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bilgisayar : Oyuncu
{
    public List<GameObject> BilgisayarkartListesi = new List<GameObject>();
    public Bilgisayar():base()
    {
        
    }
    public Bilgisayar(int oyuncuID,string oyuncuAdi, int Skor) : base(oyuncuID, oyuncuAdi, Skor)
    {

    }
    public override int kartSec()
    {
        return base.kartSec();
    }

    // Start is called before the first frame update
    void Start()
    {
        Bilgisayar f1 = FindObjectOfType<Bilgisayar>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
