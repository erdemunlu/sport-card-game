using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kullanici : Oyuncu
{
    public List<GameObject> KullanicikartListesi = new List<GameObject>();
    public Kullanici() : base()
    {

    }
    public Kullanici(int oyuncuID, string oyuncuAdi, int Skor) : base(oyuncuID, oyuncuAdi, Skor)
    {
       
    }

    public override int kartSec()
    {
        return base.kartSec();
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
