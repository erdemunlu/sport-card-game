using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oyuncu : MonoBehaviour
{
    
    public Oyuncu()
    {
        this.oyuncuID = 0;
        this.oyuncuAdi = "NoName";
        this.Skor = 0;

       
    }
    public Oyuncu(int oyuncuID, string oyuncuAdi, int Skor)
    {
        this.oyuncuID = oyuncuID;
        this.oyuncuAdi = oyuncuAdi;
        this.Skor = Skor;
        
    }

    

    public void SkorGoster()
    {
        UnityEngine.Debug.Log("Skor:" + this.Skor);
    }

   

    public virtual int kartSec()
    {
        return 10;
    }

    public int oyuncuID { get; set; }
    public string oyuncuAdi { get; set; }
    public int Skor { get; set; }
    public List<Basketbolcu> kartListesiB = new List<Basketbolcu>();
    public List<Futbolcu> kartListesiF = new List<Futbolcu>();
    


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
