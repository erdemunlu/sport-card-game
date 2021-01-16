using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Test : MonoBehaviour
{

    Oyuncu oyuncu;
    public Futbolcu f1;
    public Futbolcu f2;
    public Futbolcu f3;
    public Futbolcu f4;
    public Futbolcu f5;
    public Futbolcu f6;
    public Futbolcu f7;
    public Futbolcu f8;
    public Basketbolcu b1;
    public Basketbolcu b2;
    public Basketbolcu b3;
    public Basketbolcu b4;
    public Basketbolcu b5;
    public Basketbolcu b6;
    public Basketbolcu b7;
    public Basketbolcu b8;
    public Basketbolcu b9;


    public GameObject messi;
    public GameObject ronaldo;
    public GameObject ibrahimovic;
    public GameObject rooney;
    public GameObject talisca;
    public GameObject cenk;
    public GameObject sergen;
    public GameObject quaresma;
    public GameObject kobe;
    public GameObject lebron;
    public GameObject stephen;
    public GameObject michael;
    public GameObject semih;
    public GameObject cedi;
    public GameObject omer;
    public GameObject ersan;
    public GameObject backOfCard;

    public GameObject playerArea;
    public GameObject ComputerArea;
    public GameObject VSareaComputer;

    public Sprite Messi;
    public Sprite Ronaldo;
    public Sprite Ibrahimovic;
    public Sprite Rooney;
    public Sprite Talisca;
    public Sprite Cenk;
    public Sprite Sergen;
    public Sprite Quaresma;
    public Sprite Kobe;
    public Sprite Lebron;
    public Sprite Stephen;
    public Sprite Michael;
    public Sprite Semih;
    public Sprite Cedi;
    public Sprite Omer;
    public Sprite Ersan;


    public List<GameObject> cards = new List<GameObject>();
    //public List<Futbolcu> cardsF = new List<Futbolcu>();
    public List<Sprite> sprites = new List<Sprite>();

    public Kullanici kullanici;
    public Bilgisayar bilgisayar;
    public CardFlipper cardFlip;
    public DragDrop dragDrop;

    public int KullaniciPuan = 0;
    public int BilgisayarPuan = 0;

    public int sira = 1;
    public bool deal = false;
    public bool finished = false;
    public int totalCardNumber;
    public void Awake()
    {
        oyuncu = FindObjectOfType<Oyuncu>();
        kullanici = FindObjectOfType<Kullanici>();
        bilgisayar = FindObjectOfType<Bilgisayar>();
        cardFlip = FindObjectOfType<CardFlipper>();
        dragDrop = FindObjectOfType<DragDrop>();
        sprites.Add(Messi);
        sprites.Add(Ronaldo);
        sprites.Add(Ibrahimovic);
        sprites.Add(Rooney);
        sprites.Add(Talisca);
        sprites.Add(Cenk);
        sprites.Add(Sergen);
        sprites.Add(Quaresma);
        sprites.Add(Kobe);
        sprites.Add(Lebron);
        sprites.Add(Stephen);
        sprites.Add(Michael);
        sprites.Add(Semih);
        sprites.Add(Cedi);
        sprites.Add(Omer);
        sprites.Add(Ersan);





        f1 = new Futbolcu();

        f1.futbolcuAdi = "Messi";
        f1.futbolcuTakim = "Barcelona";
        f1.penaltı = 100;
        f1.serbestVurus = 85;
        f1.kaleciKarsiKarsiya = 95;
        oyuncu.kartListesiF.Add(f1);


        f2 = new Futbolcu();

        f2.futbolcuAdi = "Ronaldo";
        f2.futbolcuTakim = "Juventus";
        f2.penaltı = 100;
        f2.serbestVurus = 80;
        f2.kaleciKarsiKarsiya = 95;
        oyuncu.kartListesiF.Add(f2);


        f3 = new Futbolcu();

        f3.futbolcuAdi = "Ibrahimovic";
        f3.futbolcuTakim = "Milan";
        f3.penaltı = 100;
        f3.serbestVurus = 75;
        f3.kaleciKarsiKarsiya = 85;
        oyuncu.kartListesiF.Add(f3);




        f4 = new Futbolcu();

        f4.futbolcuAdi = "Rooney";
        f4.futbolcuTakim = "Derby County";
        f4.penaltı = 100;
        f4.serbestVurus = 70;
        f4.kaleciKarsiKarsiya = 75;
        oyuncu.kartListesiF.Add(f4);

        f5 = new Futbolcu();

        f5.futbolcuAdi = "Talisca";
        f5.futbolcuTakim = "Guanco Hengda Taobao ZÇ";
        f5.penaltı = 100;
        f5.serbestVurus = 70;
        f5.kaleciKarsiKarsiya = 70;
        oyuncu.kartListesiF.Add(f5);

        f6 = new Futbolcu();

        f6.futbolcuAdi = "CenkTosun";
        f6.futbolcuTakim = "Everton";
        f6.penaltı = 100;
        f6.serbestVurus = 75;
        f6.kaleciKarsiKarsiya = 75;
        oyuncu.kartListesiF.Add(f6);

        f7 = new Futbolcu();

        f7.futbolcuAdi = "SergenYalcin";
        f7.futbolcuTakim = "Beşiktaş";
        f7.penaltı = 100;
        f7.serbestVurus = 100;
        f7.kaleciKarsiKarsiya = 100;
        oyuncu.kartListesiF.Add(f7);

        f8 = new Futbolcu();

        f8.futbolcuAdi = "Quaresma";
        f8.futbolcuTakim = "Vitoria";
        f8.penaltı = 100;
        f8.serbestVurus = 75;
        f8.kaleciKarsiKarsiya = 80;
        oyuncu.kartListesiF.Add(f8);



        b1 = new Basketbolcu();
        b2 = new Basketbolcu();
        b3 = new Basketbolcu();
        b4 = new Basketbolcu();
        b5 = new Basketbolcu();
        b6 = new Basketbolcu();
        b7 = new Basketbolcu();
        b8 = new Basketbolcu();
        b9 = new Basketbolcu();




        b1.basketbolcuAdi = "KobeBryant";
        b1.basketbolcuTakim = "Los Angeles Lakers";
        b1.ucluk = 90;
        b1.ikilik = 95;
        b1.serbestAtis = 85;
        oyuncu.kartListesiB.Add(b1);


        b2.basketbolcuAdi = "LebronJames";
        b2.basketbolcuTakim = "Los Angeles Lakers";
        b2.ucluk = 85;
        b2.ikilik = 90;
        b2.serbestAtis = 85;
        oyuncu.kartListesiB.Add(b2);


        b3.basketbolcuAdi = "StephenCurry";
        b3.basketbolcuTakim = "Golden State Warriors";
        b3.ucluk = 80;
        b3.ikilik = 95;
        b3.serbestAtis = 90;
        oyuncu.kartListesiB.Add(b3);


        b4.basketbolcuAdi = "MichaelJordan";
        b4.basketbolcuTakim = "Chicago Bulls";
        b4.ucluk = 100;
        b4.ikilik = 100;
        b4.serbestAtis = 100;
        oyuncu.kartListesiB.Add(b4);


        b5.basketbolcuAdi = "SemihErden";
        b5.basketbolcuTakim = "Pınar Karşıyaka";
        b5.ucluk = 70;
        b5.ikilik = 75;
        b5.serbestAtis = 70;
        oyuncu.kartListesiB.Add(b5);


        b6.basketbolcuAdi = "CediOsman";
        b6.basketbolcuTakim = "Cleveland Cavaliers";
        b6.ucluk = 75;
        b6.ikilik = 80;
        b6.serbestAtis = 75;
        oyuncu.kartListesiB.Add(b6);


        b7.basketbolcuAdi = "ÖmerAşık";
        b7.basketbolcuTakim = "Chicago Bulls";
        b7.ucluk = 75;
        b7.ikilik = 80;
        b7.serbestAtis = 70;
        oyuncu.kartListesiB.Add(b7);


        b8.basketbolcuAdi = "ErsanIlyasova";
        b8.basketbolcuTakim = "Milwaukee Bucks";
        b8.ucluk = 70;
        b8.ikilik = 75;
        b8.serbestAtis = 80;
        oyuncu.kartListesiB.Add(b8);

        b9.basketbolcuAdi = "KobeBryant";
        b9.basketbolcuTakim = "Los Angeles Lakers";
        b9.ucluk = 90;
        b9.ikilik = 95;
        b9.serbestAtis = 85;
        oyuncu.kartListesiB.Add(b9);





        cards.Add(messi);
        cards.Add(ronaldo);
        cards.Add(ibrahimovic);
        cards.Add(rooney);
        cards.Add(talisca);
        cards.Add(cenk);
        cards.Add(sergen);
        cards.Add(quaresma);
        cards.Add(omer);
        cards.Add(cedi);
        cards.Add(ersan);
        cards.Add(semih);
        cards.Add(kobe);
        cards.Add(lebron);
        cards.Add(stephen);
        cards.Add(michael);
        totalCardNumber = cards.Count;
        messi.tag = "Futbolcu";
        ronaldo.tag = "Futbolcu";
        ibrahimovic.tag = "Futbolcu";
        rooney.tag = "Futbolcu";
        talisca.tag = "Futbolcu";
        cenk.tag = "Futbolcu";
        sergen.tag = "Futbolcu";
        quaresma.tag = "Futbolcu";
        omer.tag = "Basketbolcu";
        cedi.tag = "Basketbolcu";
        ersan.tag = "Basketbolcu";
        semih.tag = "Basketbolcu";
        kobe.tag = "Basketbolcu";
        lebron.tag = "Basketbolcu";
        stephen.tag = "Basketbolcu";
        michael.tag = "Basketbolcu";



        foreach (Button button in Object.FindObjectsOfType(typeof(Button)))
        {
            if (button.name == "IkilikButton")
            {
                button.interactable = false;
            }
            if (button.name == "UclukButton")
            {
                button.interactable = false;
            }
            if (button.name == "SerbestAtısButton")
            {
                button.interactable = false;
            }
        }

    }
    void Start()
    {
        for (var i = 0; i < 16; i++)
        {
            UnityEngine.Debug.Log("Sprite adı: " + sprites[i].name);

        }







    }
    public void flipIt(GameObject gameobject)
    {
        string player = gameobject.name;
        player = player.Remove(player.Length - 7, 7);
        if (player == "Messi")
        {
            gameobject.GetComponent<Image>().sprite = sprites[0];
        }
        else if (player == "Ronaldo")
        {
            gameobject.GetComponent<Image>().sprite = sprites[1];
        }
        else if (player == "Ibrahimovic")
        {
            gameobject.GetComponent<Image>().sprite = sprites[2];
        }
        else if (player == "Rooney")
        {
            gameobject.GetComponent<Image>().sprite = sprites[3];
        }
        else if (player == "Talisca")
        {
            gameobject.GetComponent<Image>().sprite = sprites[4];
        }
        else if (player == "CenkTosun")
        {
            gameobject.GetComponent<Image>().sprite = sprites[5];
        }
        else if (player == "SergenYalcin")
        {
            gameobject.GetComponent<Image>().sprite = sprites[6];
        }
        else if (player == "Quaresma")
        {
            gameobject.GetComponent<Image>().sprite = sprites[7];
        }
        else if (player == "KobeBryant")
        {
            gameobject.GetComponent<Image>().sprite = sprites[8];
        }
        else if (player == "LebronJames")
        {
            gameobject.GetComponent<Image>().sprite = sprites[9];
        }
        else if (player == "StephenCurry")
        {
            gameobject.GetComponent<Image>().sprite = sprites[10];
        }
        else if (player == "MichaelJordan")
        {
            gameobject.GetComponent<Image>().sprite = sprites[11];
        }
        else if (player == "SemihErden")
        {
            gameobject.GetComponent<Image>().sprite = sprites[12];
        }
        else if (player == "CediOsman")
        {
            gameobject.GetComponent<Image>().sprite = sprites[13];
        }
        else if (player == "ÖmerAşık")
        {
            gameobject.GetComponent<Image>().sprite = sprites[14];
        }
        else if (player == "ErsanIlyasova")
        {
            gameobject.GetComponent<Image>().sprite = sprites[15];
        }

    }


    public void onClick()
    {


        UnityEngine.Debug.Log("HEYBURADAYIM YARDIM");

        int temp1 = 0;
        while (temp1 < 4)
        {
            int x = UnityEngine.Random.Range(0, cards.Count);
            if (cards[x].tag == "Futbolcu")
            {
                cards[x].tag = "KullaniciF";
                kullanici.KullanicikartListesi.Add(cards[x]);
                cards.Remove(cards[x]);
                temp1++;
            }
        }
        temp1 = 0;
        while (temp1 < 4)
        {
            int x = UnityEngine.Random.Range(0, cards.Count);
            if (cards[x].tag == "Basketbolcu")
            {
                cards[x].tag = "KullaniciB";
                kullanici.KullanicikartListesi.Add(cards[x]);
                cards.Remove(cards[x]);
                temp1++;
            }
        }

        for (var i = 0; i < 8; i++)
        {
            if (cards[i].tag == "Futbolcu")
            {
                cards[i].tag = "ComputerF";
            }
            else if (cards[i].tag == "Basketbolcu")
            {
                cards[i].tag = "ComputerB";
            }
            bilgisayar.BilgisayarkartListesi.Add(cards[i]);
        }


        for (var i = 0; i < 8; i++)
        {

            GameObject playerCard = Instantiate(kullanici.KullanicikartListesi[i], new Vector3(0, 0, 0), Quaternion.identity);
            playerCard.transform.SetParent(playerArea.transform, false);


        }

        for (var i = 0; i < 8; i++)
        {
            GameObject playerCard = Instantiate(bilgisayar.BilgisayarkartListesi[i], new Vector3(0, 0, 0), Quaternion.identity);

            playerCard.transform.SetParent(ComputerArea.transform, false);
        }

        foreach (Button button in Object.FindObjectsOfType(typeof(Button)))
        {
            if (button.name == "DealButton")
            {
                button.interactable = false;
            }
        }




        deal = true;
    }


    public void PenaltiOnClick()
    {


        GameObject ParentGameObjectPlayer = GameObject.FindGameObjectWithTag("VSPlayer");
        int mevcut = ParentGameObjectPlayer.transform.childCount;

        GameObject ParentGameObjectPlayerAreaBase = GameObject.FindGameObjectWithTag("PlayerCardArea");
        int mevcutPlayerAreaBase = ParentGameObjectPlayerAreaBase.transform.childCount;

        if (mevcut != 0 || mevcutPlayerAreaBase != 0)
        {
            IEnumerator text2()
            {


                GameObject ChildGameObject0Player = ParentGameObjectPlayer.transform.GetChild(0).gameObject;
                string player = ChildGameObject0Player.name;
                player = player.Remove(player.Length - 7, 7);
                UnityEngine.Debug.Log("player Cocugun adi burada:" + player);

                if (ChildGameObject0Player.tag == "KullaniciF")
                {
                    for (var i = 0; i < 8; i++)
                    {
                        GameObject ParentGameObjectComputer1 = GameObject.FindGameObjectWithTag("ComputerArea");
                        if (ParentGameObjectComputer1.transform.GetChild(i).gameObject.tag == "ComputerF")
                        {

                            GameObject ChildGameObject0Computer1 = ParentGameObjectComputer1.transform.GetChild(i).gameObject;
                            ChildGameObject0Computer1.transform.SetParent(VSareaComputer.transform, false);

                            flipIt(ChildGameObject0Computer1);
                            yield return new WaitForSeconds(4);
                            break;
                        }
                    }
                }

                GameObject ParentGameObjectComputer = GameObject.FindGameObjectWithTag("VSComputer");
                GameObject ChildGameObject0Computer = ParentGameObjectComputer.transform.GetChild(0).gameObject;
                string computer = ChildGameObject0Computer.name;
                computer = computer.Remove(computer.Length - 7, 7);
                UnityEngine.Debug.Log("computer Cocugun adi burada:" + computer);
                if (ChildGameObject0Player.tag == "KullaniciF" && ChildGameObject0Computer.tag == "ComputerF")
                {
                    int GucPlayer = 0;
                    int GucComputer = 0;
                    for (int i = 0; i < 8; i++)
                    {
                        if (oyuncu.kartListesiF[i].futbolcuAdi == player)
                        {
                            UnityEngine.Debug.Log("EŞLEŞME OLDU: " + oyuncu.kartListesiF[i].futbolcuAdi);
                            GucPlayer = oyuncu.kartListesiF[i].penaltı;
                        }
                        if (oyuncu.kartListesiF[i].futbolcuAdi == computer)
                        {
                            UnityEngine.Debug.Log("EŞLEŞME OLDU: " + oyuncu.kartListesiF[i].futbolcuAdi);
                            GucComputer = oyuncu.kartListesiF[i].penaltı;
                        }
                    }
                    if (GucPlayer > GucComputer)
                    {
                        KullaniciPuan += 10;
                        UnityEngine.Debug.Log("Kullanici yeni puan:" + KullaniciPuan);
                        Destroy(ChildGameObject0Computer);
                        Destroy(ChildGameObject0Player);
                        totalCardNumber -= 2;

                    }
                    else if (GucComputer > GucPlayer)
                    {
                        BilgisayarPuan += 10;
                        UnityEngine.Debug.Log("Bilgisayar yeni puan:" + BilgisayarPuan);
                        Destroy(ChildGameObject0Player);
                        Destroy(ChildGameObject0Computer);
                        totalCardNumber -= 2;

                    }
                    else
                    {
                        ChildGameObject0Computer.transform.SetParent(ComputerArea.transform, false);
                        ChildGameObject0Player.transform.SetParent(playerArea.transform, false);
                    }
                }


            }
            StartCoroutine(text2());







            int mevcutPlayerVSarea1 = ParentGameObjectPlayer.transform.childCount;
            GameObject ParentGameObjectPlayerArea = GameObject.FindGameObjectWithTag("PlayerCardArea");
            int mevcutPlayerArea = ParentGameObjectPlayerArea.transform.childCount;
            int flag = 1;

            if (mevcutPlayerArea > 0)
            {
                GameObject ChildGameObject0Player1 = ParentGameObjectPlayerArea.transform.GetChild(0).gameObject;
                for (int i = 0; i < mevcutPlayerArea; i++)
                {
                    GameObject ChildGameObject0Player2 = ParentGameObjectPlayerArea.transform.GetChild(i).gameObject;
                    if (ChildGameObject0Player1.tag != ChildGameObject0Player2.tag)
                    {
                        flag = 0;
                    }

                }
                if (flag == 1)
                {
                    if (ChildGameObject0Player1.tag == "KullaniciF")
                    {
                        foreach (Button button in Object.FindObjectsOfType(typeof(Button)))
                        {
                            if (button.name == "IkilikButton")
                            {
                                button.interactable = false;
                            }
                            if (button.name == "UclukButton")
                            {
                                button.interactable = false;
                            }
                            if (button.name == "SerbestAtısButton")
                            {
                                button.interactable = false;
                            }
                            if (button.name == "PenaltiButton")
                            {
                                button.interactable = true;
                            }
                            if (button.name == "SerbestVurusButton")
                            {
                                button.interactable = true;
                            }
                            if (button.name == "KaleciyleKKButton")
                            {
                                button.interactable = true;
                            }
                        }
                        sira = 1;

                    }
                    else if (ChildGameObject0Player1.tag == "KullaniciB")
                    {
                        foreach (Button button in Object.FindObjectsOfType(typeof(Button)))
                        {
                            if (button.name == "IkilikButton")
                            {
                                button.interactable = true;
                            }
                            if (button.name == "UclukButton")
                            {
                                button.interactable = true;
                            }
                            if (button.name == "SerbestAtısButton")
                            {
                                button.interactable = true;
                            }
                            if (button.name == "PenaltiButton")
                            {
                                button.interactable = false;
                            }
                            if (button.name == "SerbestVurusButton")
                            {
                                button.interactable = false;
                            }
                            if (button.name == "KaleciyleKKButton")
                            {
                                button.interactable = false;
                            }
                        }
                        sira = 2;

                    }

                }
                else
                {
                    foreach (Button button in Object.FindObjectsOfType(typeof(Button)))
                    {
                        if (button.name == "IkilikButton")
                        {
                            button.interactable = true;
                        }
                        if (button.name == "UclukButton")
                        {
                            button.interactable = true;
                        }
                        if (button.name == "SerbestAtısButton")
                        {
                            button.interactable = true;
                        }
                        if (button.name == "PenaltiButton")
                        {
                            button.interactable = false;
                        }
                        if (button.name == "SerbestVurusButton")
                        {
                            button.interactable = false;
                        }
                        if (button.name == "KaleciyleKKButton")
                        {
                            button.interactable = false;
                        }
                    }
                    sira = 2;
                }

            }
            else if (mevcutPlayerArea == 0 && mevcutPlayerVSarea1 == 0)
            {

                UnityEngine.Debug.Log("Oyun biter!!!!!");
            }
        }





    }

    public void SerbestVurusOnClick()
    {


        GameObject ParentGameObjectPlayer = GameObject.FindGameObjectWithTag("VSPlayer");
        int mevcut = ParentGameObjectPlayer.transform.childCount;

        GameObject ParentGameObjectPlayerAreaBase = GameObject.FindGameObjectWithTag("PlayerCardArea");
        int mevcutPlayerAreaBase = ParentGameObjectPlayerAreaBase.transform.childCount;

        if (mevcut != 0 || mevcutPlayerAreaBase != 0)
        {
            IEnumerator text2()
            {

                GameObject ChildGameObject0Player = ParentGameObjectPlayer.transform.GetChild(0).gameObject;
                string player = ChildGameObject0Player.name;
                player = player.Remove(player.Length - 7, 7);
                UnityEngine.Debug.Log("player Cocugun adi burada:" + player);

                if (ChildGameObject0Player.tag == "KullaniciF")
                {
                    for (var i = 0; i < 8; i++)
                    {
                        GameObject ParentGameObjectComputer1 = GameObject.FindGameObjectWithTag("ComputerArea");
                        if (ParentGameObjectComputer1.transform.GetChild(i).gameObject.tag == "ComputerF")
                        {

                            GameObject ChildGameObject0Computer1 = ParentGameObjectComputer1.transform.GetChild(i).gameObject;
                            ChildGameObject0Computer1.transform.SetParent(VSareaComputer.transform, false);

                            flipIt(ChildGameObject0Computer1);
                            yield return new WaitForSeconds(4);
                            break;
                        }
                    }
                }

                GameObject ParentGameObjectComputer = GameObject.FindGameObjectWithTag("VSComputer");
                GameObject ChildGameObject0Computer = ParentGameObjectComputer.transform.GetChild(0).gameObject;
                string computer = ChildGameObject0Computer.name;
                computer = computer.Remove(computer.Length - 7, 7);
                UnityEngine.Debug.Log("computer Cocugun adi burada:" + computer);
                if (ChildGameObject0Player.tag == "KullaniciF" && ChildGameObject0Computer.tag == "ComputerF")
                {
                    int GucPlayer = 0;
                    int GucComputer = 0;
                    for (int i = 0; i < 8; i++)
                    {
                        if (oyuncu.kartListesiF[i].futbolcuAdi == player)
                        {
                            UnityEngine.Debug.Log("EŞLEŞME OLDU: " + oyuncu.kartListesiF[i].futbolcuAdi);
                            GucPlayer = oyuncu.kartListesiF[i].serbestVurus;
                        }
                        if (oyuncu.kartListesiF[i].futbolcuAdi == computer)
                        {
                            UnityEngine.Debug.Log("EŞLEŞME OLDU: " + oyuncu.kartListesiF[i].futbolcuAdi);
                            GucComputer = oyuncu.kartListesiF[i].serbestVurus;
                        }
                    }
                    if (GucPlayer > GucComputer)
                    {
                        KullaniciPuan += 10;
                        UnityEngine.Debug.Log("Kullanici yeni puan:" + KullaniciPuan);
                        Destroy(ChildGameObject0Computer);
                        Destroy(ChildGameObject0Player);
                        totalCardNumber -= 2;

                    }
                    else if (GucComputer > GucPlayer)
                    {
                        BilgisayarPuan += 10;
                        UnityEngine.Debug.Log("Bilgisayar yeni puan:" + BilgisayarPuan);
                        Destroy(ChildGameObject0Player);
                        Destroy(ChildGameObject0Computer);
                        totalCardNumber -= 2;

                    }
                    else
                    {
                        ChildGameObject0Computer.transform.SetParent(ComputerArea.transform, false);
                        ChildGameObject0Player.transform.SetParent(playerArea.transform, false);
                    }
                }


            }
            StartCoroutine(text2());



            int mevcutPlayerVSarea1 = ParentGameObjectPlayer.transform.childCount;
            GameObject ParentGameObjectPlayerArea = GameObject.FindGameObjectWithTag("PlayerCardArea");
            int mevcutPlayerArea = ParentGameObjectPlayerArea.transform.childCount;
            int flag = 1;

            if (mevcutPlayerArea > 0)
            {
                GameObject ChildGameObject0Player1 = ParentGameObjectPlayerArea.transform.GetChild(0).gameObject;
                for (int i = 0; i < mevcutPlayerArea; i++)
                {
                    GameObject ChildGameObject0Player2 = ParentGameObjectPlayerArea.transform.GetChild(i).gameObject;
                    if (ChildGameObject0Player1.tag != ChildGameObject0Player2.tag)
                    {
                        flag = 0;
                    }

                }
                if (flag == 1)
                {
                    if (ChildGameObject0Player1.tag == "KullaniciF")
                    {
                        foreach (Button button in Object.FindObjectsOfType(typeof(Button)))
                        {
                            if (button.name == "IkilikButton")
                            {
                                button.interactable = false;
                            }
                            if (button.name == "UclukButton")
                            {
                                button.interactable = false;
                            }
                            if (button.name == "SerbestAtısButton")
                            {
                                button.interactable = false;
                            }
                            if (button.name == "PenaltiButton")
                            {
                                button.interactable = true;
                            }
                            if (button.name == "SerbestVurusButton")
                            {
                                button.interactable = true;
                            }
                            if (button.name == "KaleciyleKKButton")
                            {
                                button.interactable = true;
                            }
                        }
                        sira = 1;

                    }
                    else if (ChildGameObject0Player1.tag == "KullaniciB")
                    {
                        foreach (Button button in Object.FindObjectsOfType(typeof(Button)))
                        {
                            if (button.name == "IkilikButton")
                            {
                                button.interactable = true;
                            }
                            if (button.name == "UclukButton")
                            {
                                button.interactable = true;
                            }
                            if (button.name == "SerbestAtısButton")
                            {
                                button.interactable = true;
                            }
                            if (button.name == "PenaltiButton")
                            {
                                button.interactable = false;
                            }
                            if (button.name == "SerbestVurusButton")
                            {
                                button.interactable = false;
                            }
                            if (button.name == "KaleciyleKKButton")
                            {
                                button.interactable = false;
                            }
                        }
                        sira = 2;

                    }

                }
                else
                {
                    foreach (Button button in Object.FindObjectsOfType(typeof(Button)))
                    {
                        if (button.name == "IkilikButton")
                        {
                            button.interactable = true;
                        }
                        if (button.name == "UclukButton")
                        {
                            button.interactable = true;
                        }
                        if (button.name == "SerbestAtısButton")
                        {
                            button.interactable = true;
                        }
                        if (button.name == "PenaltiButton")
                        {
                            button.interactable = false;
                        }
                        if (button.name == "SerbestVurusButton")
                        {
                            button.interactable = false;
                        }
                        if (button.name == "KaleciyleKKButton")
                        {
                            button.interactable = false;
                        }
                    }
                    sira = 2;
                }

            }
            else if (mevcutPlayerArea == 0 && mevcutPlayerVSarea1 == 0)
            {

                UnityEngine.Debug.Log("Oyun biter!!!!!");
            }
        }





    }

    public void KaleciyleKKOnClick()
    {


        GameObject ParentGameObjectPlayer = GameObject.FindGameObjectWithTag("VSPlayer");
        int mevcut = ParentGameObjectPlayer.transform.childCount;

        GameObject ParentGameObjectPlayerAreaBase = GameObject.FindGameObjectWithTag("PlayerCardArea");
        int mevcutPlayerAreaBase = ParentGameObjectPlayerAreaBase.transform.childCount;

        if (mevcut != 0 || mevcutPlayerAreaBase != 0)
        {
            IEnumerator text2()
            {

                GameObject ChildGameObject0Player = ParentGameObjectPlayer.transform.GetChild(0).gameObject;
                string player = ChildGameObject0Player.name;
                player = player.Remove(player.Length - 7, 7);
                UnityEngine.Debug.Log("player Cocugun adi burada:" + player);

                if (ChildGameObject0Player.tag == "KullaniciF")
                {
                    for (var i = 0; i < 8; i++)
                    {
                        GameObject ParentGameObjectComputer1 = GameObject.FindGameObjectWithTag("ComputerArea");
                        if (ParentGameObjectComputer1.transform.GetChild(i).gameObject.tag == "ComputerF")
                        {

                            GameObject ChildGameObject0Computer1 = ParentGameObjectComputer1.transform.GetChild(i).gameObject;
                            ChildGameObject0Computer1.transform.SetParent(VSareaComputer.transform, false);

                            flipIt(ChildGameObject0Computer1);
                            yield return new WaitForSeconds(4);
                            break;
                        }
                    }
                }

                GameObject ParentGameObjectComputer = GameObject.FindGameObjectWithTag("VSComputer");
                GameObject ChildGameObject0Computer = ParentGameObjectComputer.transform.GetChild(0).gameObject;
                string computer = ChildGameObject0Computer.name;
                computer = computer.Remove(computer.Length - 7, 7);
                UnityEngine.Debug.Log("computer Cocugun adi burada:" + computer);
                if (ChildGameObject0Player.tag == "KullaniciF" && ChildGameObject0Computer.tag == "ComputerF")
                {
                    int GucPlayer = 0;
                    int GucComputer = 0;
                    for (int i = 0; i < 8; i++)
                    {
                        if (oyuncu.kartListesiF[i].futbolcuAdi == player)
                        {
                            UnityEngine.Debug.Log("EŞLEŞME OLDU: " + oyuncu.kartListesiF[i].futbolcuAdi);
                            GucPlayer = oyuncu.kartListesiF[i].kaleciKarsiKarsiya;
                        }
                        if (oyuncu.kartListesiF[i].futbolcuAdi == computer)
                        {
                            UnityEngine.Debug.Log("EŞLEŞME OLDU: " + oyuncu.kartListesiF[i].futbolcuAdi);
                            GucComputer = oyuncu.kartListesiF[i].kaleciKarsiKarsiya;
                        }
                    }
                    if (GucPlayer > GucComputer)
                    {
                        KullaniciPuan += 10;
                        UnityEngine.Debug.Log("Kullanici yeni puan:" + KullaniciPuan);
                        Destroy(ChildGameObject0Computer);
                        Destroy(ChildGameObject0Player);
                        totalCardNumber -= 2;

                    }
                    else if (GucComputer > GucPlayer)
                    {
                        BilgisayarPuan += 10;
                        UnityEngine.Debug.Log("Bilgisayar yeni puan:" + BilgisayarPuan);
                        Destroy(ChildGameObject0Player);
                        Destroy(ChildGameObject0Computer);
                        totalCardNumber -= 2;

                    }
                    else
                    {
                        ChildGameObject0Computer.transform.SetParent(ComputerArea.transform, false);
                        ChildGameObject0Player.transform.SetParent(playerArea.transform, false);
                    }
                }


            }
            StartCoroutine(text2());



            int mevcutPlayerVSarea1 = ParentGameObjectPlayer.transform.childCount;
            GameObject ParentGameObjectPlayerArea = GameObject.FindGameObjectWithTag("PlayerCardArea");
            int mevcutPlayerArea = ParentGameObjectPlayerArea.transform.childCount;
            int flag = 1;

            if (mevcutPlayerArea > 0)
            {
                GameObject ChildGameObject0Player1 = ParentGameObjectPlayerArea.transform.GetChild(0).gameObject;
                for (int i = 0; i < mevcutPlayerArea; i++)
                {
                    GameObject ChildGameObject0Player2 = ParentGameObjectPlayerArea.transform.GetChild(i).gameObject;
                    if (ChildGameObject0Player1.tag != ChildGameObject0Player2.tag)
                    {
                        flag = 0;
                    }

                }
                if (flag == 1)
                {
                    if (ChildGameObject0Player1.tag == "KullaniciF")
                    {
                        foreach (Button button in Object.FindObjectsOfType(typeof(Button)))
                        {
                            if (button.name == "IkilikButton")
                            {
                                button.interactable = false;
                            }
                            if (button.name == "UclukButton")
                            {
                                button.interactable = false;
                            }
                            if (button.name == "SerbestAtısButton")
                            {
                                button.interactable = false;
                            }
                            if (button.name == "PenaltiButton")
                            {
                                button.interactable = true;
                            }
                            if (button.name == "SerbestVurusButton")
                            {
                                button.interactable = true;
                            }
                            if (button.name == "KaleciyleKKButton")
                            {
                                button.interactable = true;
                            }
                        }
                        sira = 1;

                    }
                    else if (ChildGameObject0Player1.tag == "KullaniciB")
                    {
                        foreach (Button button in Object.FindObjectsOfType(typeof(Button)))
                        {
                            if (button.name == "IkilikButton")
                            {
                                button.interactable = true;
                            }
                            if (button.name == "UclukButton")
                            {
                                button.interactable = true;
                            }
                            if (button.name == "SerbestAtısButton")
                            {
                                button.interactable = true;
                            }
                            if (button.name == "PenaltiButton")
                            {
                                button.interactable = false;
                            }
                            if (button.name == "SerbestVurusButton")
                            {
                                button.interactable = false;
                            }
                            if (button.name == "KaleciyleKKButton")
                            {
                                button.interactable = false;
                            }
                        }
                        sira = 2;

                    }

                }
                else
                {
                    foreach (Button button in Object.FindObjectsOfType(typeof(Button)))
                    {
                        if (button.name == "IkilikButton")
                        {
                            button.interactable = true;
                        }
                        if (button.name == "UclukButton")
                        {
                            button.interactable = true;
                        }
                        if (button.name == "SerbestAtısButton")
                        {
                            button.interactable = true;
                        }
                        if (button.name == "PenaltiButton")
                        {
                            button.interactable = false;
                        }
                        if (button.name == "SerbestVurusButton")
                        {
                            button.interactable = false;
                        }
                        if (button.name == "KaleciyleKKButton")
                        {
                            button.interactable = false;
                        }
                    }
                    sira = 2;
                }

            }
            else if (mevcutPlayerArea == 0 && mevcutPlayerVSarea1 == 0)
            {

                UnityEngine.Debug.Log("Oyun biter!!!!!");
            }
        }




    }
    public void ikilikOnClick()
    {

        GameObject ParentGameObjectPlayer = GameObject.FindGameObjectWithTag("VSPlayer");
        int mevcut = ParentGameObjectPlayer.transform.childCount;

        GameObject ParentGameObjectPlayerAreaBase = GameObject.FindGameObjectWithTag("PlayerCardArea");
        int mevcutPlayerAreaBase = ParentGameObjectPlayerAreaBase.transform.childCount;
        if (mevcut != 0 || mevcutPlayerAreaBase != 0)
        {
            IEnumerator text2()
            {

                GameObject ChildGameObject0Player = ParentGameObjectPlayer.transform.GetChild(0).gameObject;

                string player = ChildGameObject0Player.name;
                player = player.Remove(player.Length - 7, 7);
                UnityEngine.Debug.Log("player Cocugun adi burada:" + player);

                if (ChildGameObject0Player.tag == "KullaniciB")
                {
                    for (var i = 0; i < 8; i++)
                    {
                        GameObject ParentGameObjectComputer1 = GameObject.FindGameObjectWithTag("ComputerArea");
                        if (ParentGameObjectComputer1.transform.GetChild(i).gameObject.tag == "ComputerB")
                        {

                            GameObject ChildGameObject0Computer1 = ParentGameObjectComputer1.transform.GetChild(i).gameObject;
                            ChildGameObject0Computer1.transform.SetParent(VSareaComputer.transform, false);

                            flipIt(ChildGameObject0Computer1);
                            yield return new WaitForSeconds(4);
                            break;
                        }
                    }
                }

                GameObject ParentGameObjectComputer = GameObject.FindGameObjectWithTag("VSComputer");
                GameObject ChildGameObject0Computer = ParentGameObjectComputer.transform.GetChild(0).gameObject;
                string computer = ChildGameObject0Computer.name;
                computer = computer.Remove(computer.Length - 7, 7);
                UnityEngine.Debug.Log("computer Cocugun adi burada:" + computer);
                if (ChildGameObject0Player.tag == "KullaniciB" && ChildGameObject0Computer.tag == "ComputerB")
                {
                    int GucPlayer = 0;
                    int GucComputer = 0;
                    for (int i = 0; i < 8; i++)
                    {
                        if (oyuncu.kartListesiB[i].basketbolcuAdi == player)
                        {
                            UnityEngine.Debug.Log("EŞLEŞME OLDU: " + oyuncu.kartListesiB[i].basketbolcuAdi);
                            GucPlayer = oyuncu.kartListesiB[i].ikilik;
                        }
                        if (oyuncu.kartListesiB[i].basketbolcuAdi == computer)
                        {
                            UnityEngine.Debug.Log("EŞLEŞME OLDU: " + oyuncu.kartListesiB[i].basketbolcuAdi);
                            GucComputer = oyuncu.kartListesiB[i].ikilik;
                        }
                    }
                    if (GucPlayer > GucComputer)
                    {
                        KullaniciPuan += 10;
                        UnityEngine.Debug.Log("Kullanici yeni puan:" + KullaniciPuan);
                        Destroy(ChildGameObject0Computer);
                        Destroy(ChildGameObject0Player);
                        totalCardNumber -= 2;

                    }
                    else if (GucComputer > GucPlayer)
                    {
                        BilgisayarPuan += 10;
                        UnityEngine.Debug.Log("Bilgisayar yeni puan:" + BilgisayarPuan);
                        Destroy(ChildGameObject0Player);
                        Destroy(ChildGameObject0Computer);
                        totalCardNumber -= 2;

                    }
                    else
                    {
                        ChildGameObject0Computer.transform.SetParent(ComputerArea.transform, false);
                        ChildGameObject0Player.transform.SetParent(playerArea.transform, false);
                    }
                }


            }
            StartCoroutine(text2());



            int mevcutPlayerVSarea1 = ParentGameObjectPlayer.transform.childCount;
            GameObject ParentGameObjectPlayerArea = GameObject.FindGameObjectWithTag("PlayerCardArea");
            int mevcutPlayerArea = ParentGameObjectPlayerArea.transform.childCount;
            int flag = 1;

            if (mevcutPlayerArea > 0)
            {
                GameObject ChildGameObject0Player1 = ParentGameObjectPlayerArea.transform.GetChild(0).gameObject;
                for (int i = 0; i < mevcutPlayerArea; i++)
                {
                    GameObject ChildGameObject0Player2 = ParentGameObjectPlayerArea.transform.GetChild(i).gameObject;
                    if (ChildGameObject0Player1.tag != ChildGameObject0Player2.tag)
                    {
                        flag = 0;
                    }

                }
                if (flag == 1)
                {
                    if (ChildGameObject0Player1.tag == "KullaniciF")
                    {
                        foreach (Button button in Object.FindObjectsOfType(typeof(Button)))
                        {
                            if (button.name == "IkilikButton")
                            {
                                button.interactable = false;
                            }
                            if (button.name == "UclukButton")
                            {
                                button.interactable = false;
                            }
                            if (button.name == "SerbestAtısButton")
                            {
                                button.interactable = false;
                            }
                            if (button.name == "PenaltiButton")
                            {
                                button.interactable = true;
                            }
                            if (button.name == "SerbestVurusButton")
                            {
                                button.interactable = true;
                            }
                            if (button.name == "KaleciyleKKButton")
                            {
                                button.interactable = true;
                            }
                        }
                        sira = 1;

                    }
                    else if (ChildGameObject0Player1.tag == "KullaniciB")
                    {
                        foreach (Button button in Object.FindObjectsOfType(typeof(Button)))
                        {
                            if (button.name == "IkilikButton")
                            {
                                button.interactable = true;
                            }
                            if (button.name == "UclukButton")
                            {
                                button.interactable = true;
                            }
                            if (button.name == "SerbestAtısButton")
                            {
                                button.interactable = true;
                            }
                            if (button.name == "PenaltiButton")
                            {
                                button.interactable = false;
                            }
                            if (button.name == "SerbestVurusButton")
                            {
                                button.interactable = false;
                            }
                            if (button.name == "KaleciyleKKButton")
                            {
                                button.interactable = false;
                            }
                        }
                        sira = 2;

                    }

                }
                else
                {
                    foreach (Button button in Object.FindObjectsOfType(typeof(Button)))
                    {
                        if (button.name == "IkilikButton")
                        {
                            button.interactable = false;
                        }
                        if (button.name == "UclukButton")
                        {
                            button.interactable = false;
                        }
                        if (button.name == "SerbestAtısButton")
                        {
                            button.interactable = false;
                        }
                        if (button.name == "PenaltiButton")
                        {
                            button.interactable = true;
                        }
                        if (button.name == "SerbestVurusButton")
                        {
                            button.interactable = true;
                        }
                        if (button.name == "KaleciyleKKButton")
                        {
                            button.interactable = true;
                        }
                    }
                    sira = 1;
                }

            }
            else if (mevcutPlayerArea == 0 && mevcutPlayerVSarea1 == 0)
            {

                UnityEngine.Debug.Log("Oyun biter!!!!!");
            }
        }





    }

    public void uclukOnClick()
    {

        GameObject ParentGameObjectPlayer = GameObject.FindGameObjectWithTag("VSPlayer");
        int mevcut = ParentGameObjectPlayer.transform.childCount;

        GameObject ParentGameObjectPlayerAreaBase = GameObject.FindGameObjectWithTag("PlayerCardArea");
        int mevcutPlayerAreaBase = ParentGameObjectPlayerAreaBase.transform.childCount;
        if (mevcut != 0 || mevcutPlayerAreaBase != 0)
        {
            IEnumerator text2()
            {

                GameObject ChildGameObject0Player = ParentGameObjectPlayer.transform.GetChild(0).gameObject;

                string player = ChildGameObject0Player.name;
                player = player.Remove(player.Length - 7, 7);
                UnityEngine.Debug.Log("player Cocugun adi burada:" + player);

                if (ChildGameObject0Player.tag == "KullaniciB")
                {
                    for (var i = 0; i < 8; i++)
                    {
                        GameObject ParentGameObjectComputer1 = GameObject.FindGameObjectWithTag("ComputerArea");
                        if (ParentGameObjectComputer1.transform.GetChild(i).gameObject.tag == "ComputerB")
                        {

                            GameObject ChildGameObject0Computer1 = ParentGameObjectComputer1.transform.GetChild(i).gameObject;
                            ChildGameObject0Computer1.transform.SetParent(VSareaComputer.transform, false);

                            flipIt(ChildGameObject0Computer1);
                            yield return new WaitForSeconds(4);
                            break;
                        }
                    }
                }

                GameObject ParentGameObjectComputer = GameObject.FindGameObjectWithTag("VSComputer");
                GameObject ChildGameObject0Computer = ParentGameObjectComputer.transform.GetChild(0).gameObject;
                string computer = ChildGameObject0Computer.name;
                computer = computer.Remove(computer.Length - 7, 7);
                UnityEngine.Debug.Log("computer Cocugun adi burada:" + computer);
                if (ChildGameObject0Player.tag == "KullaniciB" && ChildGameObject0Computer.tag == "ComputerB")
                {
                    int GucPlayer = 0;
                    int GucComputer = 0;
                    for (int i = 0; i < 8; i++)
                    {
                        if (oyuncu.kartListesiB[i].basketbolcuAdi == player)
                        {
                            UnityEngine.Debug.Log("EŞLEŞME OLDU: " + oyuncu.kartListesiB[i].basketbolcuAdi);
                            GucPlayer = oyuncu.kartListesiB[i].ucluk;
                        }
                        if (oyuncu.kartListesiB[i].basketbolcuAdi == computer)
                        {
                            UnityEngine.Debug.Log("EŞLEŞME OLDU: " + oyuncu.kartListesiB[i].basketbolcuAdi);
                            GucComputer = oyuncu.kartListesiB[i].ucluk;
                        }
                    }
                    if (GucPlayer > GucComputer)
                    {
                        KullaniciPuan += 10;
                        UnityEngine.Debug.Log("Kullanici yeni puan:" + KullaniciPuan);
                        Destroy(ChildGameObject0Computer);
                        Destroy(ChildGameObject0Player);
                        totalCardNumber -= 2;

                    }
                    else if (GucComputer > GucPlayer)
                    {
                        BilgisayarPuan += 10;
                        UnityEngine.Debug.Log("Bilgisayar yeni puan:" + BilgisayarPuan);
                        Destroy(ChildGameObject0Player);
                        Destroy(ChildGameObject0Computer);
                        totalCardNumber -= 2;

                    }
                    else
                    {
                        ChildGameObject0Computer.transform.SetParent(ComputerArea.transform, false);
                        ChildGameObject0Player.transform.SetParent(playerArea.transform, false);
                    }
                }


            }
            StartCoroutine(text2());



            int mevcutPlayerVSarea1 = ParentGameObjectPlayer.transform.childCount;
            GameObject ParentGameObjectPlayerArea = GameObject.FindGameObjectWithTag("PlayerCardArea");
            int mevcutPlayerArea = ParentGameObjectPlayerArea.transform.childCount;
            int flag = 1;

            if (mevcutPlayerArea > 0)
            {
                GameObject ChildGameObject0Player1 = ParentGameObjectPlayerArea.transform.GetChild(0).gameObject;
                for (int i = 0; i < mevcutPlayerArea; i++)
                {
                    GameObject ChildGameObject0Player2 = ParentGameObjectPlayerArea.transform.GetChild(i).gameObject;
                    if (ChildGameObject0Player1.tag != ChildGameObject0Player2.tag)
                    {
                        flag = 0;
                    }

                }
                if (flag == 1)
                {
                    if (ChildGameObject0Player1.tag == "KullaniciF")
                    {
                        foreach (Button button in Object.FindObjectsOfType(typeof(Button)))
                        {
                            if (button.name == "IkilikButton")
                            {
                                button.interactable = false;
                            }
                            if (button.name == "UclukButton")
                            {
                                button.interactable = false;
                            }
                            if (button.name == "SerbestAtısButton")
                            {
                                button.interactable = false;
                            }
                            if (button.name == "PenaltiButton")
                            {
                                button.interactable = true;
                            }
                            if (button.name == "SerbestVurusButton")
                            {
                                button.interactable = true;
                            }
                            if (button.name == "KaleciyleKKButton")
                            {
                                button.interactable = true;
                            }
                        }
                        sira = 1;

                    }
                    else if (ChildGameObject0Player1.tag == "KullaniciB")
                    {
                        foreach (Button button in Object.FindObjectsOfType(typeof(Button)))
                        {
                            if (button.name == "IkilikButton")
                            {
                                button.interactable = true;
                            }
                            if (button.name == "UclukButton")
                            {
                                button.interactable = true;
                            }
                            if (button.name == "SerbestAtısButton")
                            {
                                button.interactable = true;
                            }
                            if (button.name == "PenaltiButton")
                            {
                                button.interactable = false;
                            }
                            if (button.name == "SerbestVurusButton")
                            {
                                button.interactable = false;
                            }
                            if (button.name == "KaleciyleKKButton")
                            {
                                button.interactable = false;
                            }
                        }
                        sira = 2;

                    }

                }
                else
                {
                    foreach (Button button in Object.FindObjectsOfType(typeof(Button)))
                    {
                        if (button.name == "IkilikButton")
                        {
                            button.interactable = false;
                        }
                        if (button.name == "UclukButton")
                        {
                            button.interactable = false;
                        }
                        if (button.name == "SerbestAtısButton")
                        {
                            button.interactable = false;
                        }
                        if (button.name == "PenaltiButton")
                        {
                            button.interactable = true;
                        }
                        if (button.name == "SerbestVurusButton")
                        {
                            button.interactable = true;
                        }
                        if (button.name == "KaleciyleKKButton")
                        {
                            button.interactable = true;
                        }
                    }
                    sira = 1;
                }

            }
            else if (mevcutPlayerArea == 0 && mevcutPlayerVSarea1 == 0)
            {

                UnityEngine.Debug.Log("Oyun biter!!!!!");
            }
        }





    }
    public void SerbestAtisOnClick()
    {

        GameObject ParentGameObjectPlayer = GameObject.FindGameObjectWithTag("VSPlayer");
        int mevcut = ParentGameObjectPlayer.transform.childCount;

        GameObject ParentGameObjectPlayerAreaBase = GameObject.FindGameObjectWithTag("PlayerCardArea");
        int mevcutPlayerAreaBase = ParentGameObjectPlayerAreaBase.transform.childCount;
        if (mevcut != 0 || mevcutPlayerAreaBase != 0)
        {
            IEnumerator text2()
            {

                GameObject ChildGameObject0Player = ParentGameObjectPlayer.transform.GetChild(0).gameObject;

                string player = ChildGameObject0Player.name;
                player = player.Remove(player.Length - 7, 7);
                UnityEngine.Debug.Log("player Cocugun adi burada:" + player);

                if (ChildGameObject0Player.tag == "KullaniciB")
                {
                    for (var i = 0; i < 8; i++)
                    {
                        GameObject ParentGameObjectComputer1 = GameObject.FindGameObjectWithTag("ComputerArea");
                        if (ParentGameObjectComputer1.transform.GetChild(i).gameObject.tag == "ComputerB")
                        {

                            GameObject ChildGameObject0Computer1 = ParentGameObjectComputer1.transform.GetChild(i).gameObject;
                            ChildGameObject0Computer1.transform.SetParent(VSareaComputer.transform, false);

                            flipIt(ChildGameObject0Computer1);
                            yield return new WaitForSeconds(4);
                            break;
                        }
                    }
                }

                GameObject ParentGameObjectComputer = GameObject.FindGameObjectWithTag("VSComputer");
                GameObject ChildGameObject0Computer = ParentGameObjectComputer.transform.GetChild(0).gameObject;
                string computer = ChildGameObject0Computer.name;
                computer = computer.Remove(computer.Length - 7, 7);
                UnityEngine.Debug.Log("computer Cocugun adi burada:" + computer);
                if (ChildGameObject0Player.tag == "KullaniciB" && ChildGameObject0Computer.tag == "ComputerB")
                {
                    int GucPlayer = 0;
                    int GucComputer = 0;
                    for (int i = 0; i < 8; i++)
                    {
                        if (oyuncu.kartListesiB[i].basketbolcuAdi == player)
                        {
                            UnityEngine.Debug.Log("EŞLEŞME OLDU: " + oyuncu.kartListesiB[i].basketbolcuAdi);
                            GucPlayer = oyuncu.kartListesiB[i].serbestAtis;
                        }
                        if (oyuncu.kartListesiB[i].basketbolcuAdi == computer)
                        {
                            UnityEngine.Debug.Log("EŞLEŞME OLDU: " + oyuncu.kartListesiB[i].basketbolcuAdi);
                            GucComputer = oyuncu.kartListesiB[i].serbestAtis;
                        }
                    }
                    if (GucPlayer > GucComputer)
                    {
                        KullaniciPuan += 10;
                        UnityEngine.Debug.Log("Kullanici yeni puan:" + KullaniciPuan);
                        Destroy(ChildGameObject0Computer);
                        Destroy(ChildGameObject0Player);
                        totalCardNumber -= 2;

                    }
                    else if (GucComputer > GucPlayer)
                    {
                        BilgisayarPuan += 10;
                        UnityEngine.Debug.Log("Bilgisayar yeni puan:" + BilgisayarPuan);
                        Destroy(ChildGameObject0Player);
                        Destroy(ChildGameObject0Computer);
                        totalCardNumber -= 2;

                    }
                    else
                    {
                        ChildGameObject0Computer.transform.SetParent(ComputerArea.transform, false);
                        ChildGameObject0Player.transform.SetParent(playerArea.transform, false);
                    }
                }


            }
            StartCoroutine(text2());



            int mevcutPlayerVSarea1 = ParentGameObjectPlayer.transform.childCount;
            GameObject ParentGameObjectPlayerArea = GameObject.FindGameObjectWithTag("PlayerCardArea");
            int mevcutPlayerArea = ParentGameObjectPlayerArea.transform.childCount;
            int flag = 1;

            if (mevcutPlayerArea > 0)
            {
                GameObject ChildGameObject0Player1 = ParentGameObjectPlayerArea.transform.GetChild(0).gameObject;
                for (int i = 0; i < mevcutPlayerArea; i++)
                {
                    GameObject ChildGameObject0Player2 = ParentGameObjectPlayerArea.transform.GetChild(i).gameObject;
                    if (ChildGameObject0Player1.tag != ChildGameObject0Player2.tag)
                    {
                        flag = 0;
                    }

                }
                if (flag == 1)
                {
                    if (ChildGameObject0Player1.tag == "KullaniciF")
                    {
                        foreach (Button button in Object.FindObjectsOfType(typeof(Button)))
                        {
                            if (button.name == "IkilikButton")
                            {
                                button.interactable = false;
                            }
                            if (button.name == "UclukButton")
                            {
                                button.interactable = false;
                            }
                            if (button.name == "SerbestAtısButton")
                            {
                                button.interactable = false;
                            }
                            if (button.name == "PenaltiButton")
                            {
                                button.interactable = true;
                            }
                            if (button.name == "SerbestVurusButton")
                            {
                                button.interactable = true;
                            }
                            if (button.name == "KaleciyleKKButton")
                            {
                                button.interactable = true;
                            }
                        }
                        sira = 1;

                    }
                    else if (ChildGameObject0Player1.tag == "KullaniciB")
                    {
                        foreach (Button button in Object.FindObjectsOfType(typeof(Button)))
                        {
                            if (button.name == "IkilikButton")
                            {
                                button.interactable = true;
                            }
                            if (button.name == "UclukButton")
                            {
                                button.interactable = true;
                            }
                            if (button.name == "SerbestAtısButton")
                            {
                                button.interactable = true;
                            }
                            if (button.name == "PenaltiButton")
                            {
                                button.interactable = false;
                            }
                            if (button.name == "SerbestVurusButton")
                            {
                                button.interactable = false;
                            }
                            if (button.name == "KaleciyleKKButton")
                            {
                                button.interactable = false;
                            }
                        }
                        sira = 2;

                    }

                }
                else
                {
                    foreach (Button button in Object.FindObjectsOfType(typeof(Button)))
                    {
                        if (button.name == "IkilikButton")
                        {
                            button.interactable = false;
                        }
                        if (button.name == "UclukButton")
                        {
                            button.interactable = false;
                        }
                        if (button.name == "SerbestAtısButton")
                        {
                            button.interactable = false;
                        }
                        if (button.name == "PenaltiButton")
                        {
                            button.interactable = true;
                        }
                        if (button.name == "SerbestVurusButton")
                        {
                            button.interactable = true;
                        }
                        if (button.name == "KaleciyleKKButton")
                        {
                            button.interactable = true;
                        }
                    }
                    sira = 1;
                }

            }






            else if (mevcutPlayerArea == 0 && mevcutPlayerVSarea1 == 0)
            {

                UnityEngine.Debug.Log("Oyun biter!!!!!");
            }
        }




    }
    IEnumerator text()
    {
        yield return new WaitForSeconds(4);


    }

    IEnumerator wait()
    {
        yield return new WaitForSeconds(4);
        SceneManager.LoadScene(3);



    }

    // Update is called once per frame
    void Update()
    {
        if (totalCardNumber == 0)
        {
            StartCoroutine(wait());
        }

        UnityEngine.PlayerPrefs.SetInt("KullaniciPoint", KullaniciPuan);
        UnityEngine.PlayerPrefs.SetInt("BilgisayarPoint", BilgisayarPuan);


    }
}