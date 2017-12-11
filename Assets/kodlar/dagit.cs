using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dagit : MonoBehaviour {

    public GameObject deste;
    public GameObject[] karilan_Deste= new GameObject[52];
    public GameObject[] asil_Oyuncu = new GameObject[4];
    public GameObject[] oyuncu1 = new GameObject[4];
    public GameObject[] oyuncu2 = new GameObject[4];
    public GameObject[] oyuncu3 = new GameObject[4];
    public Transform kagit1;
    public Transform kagit2;
    public Transform kagit3;
    public Transform kagit4;
    // Use this for initialization
    void Start () {
        for (int i = 0; i < 52; i++)
        {
            karilan_Deste[i] = deste.transform.GetChild(i).gameObject;
        }
        for (int i = 0; i < 1000; i++)
        {
            int a = Random.Range(0, 52);
            GameObject birinciKagit = karilan_Deste[a];
            for (int k = 0; k < 100; k++)
            {

            }
            int b = Random.Range(0, 52);
            GameObject ikinciKagit = karilan_Deste[b];
            
            karilan_Deste[b] = birinciKagit;
            karilan_Deste[a] = ikinciKagit;
        }
        /*-------------------------------------Karildi -----------------------------*/
        int enUsttekiKagit = 51;
        for ( ; enUsttekiKagit > 47; enUsttekiKagit--)
        {
            Instantiate(karilan_Deste[enUsttekiKagit], deste.transform.position, deste.transform.rotation);
        }
        /*--------------------------Yere 4 kağıt Açıldı -----------------------------*/
        Transform[] kagitlar = new Transform[4];
        kagitlar[0] = kagit1;
        kagitlar[1] = kagit2;
        kagitlar[2] = kagit3;
        kagitlar[3] = kagit4;
        GameObject[][] oyuncular = new GameObject[4][];
        oyuncular[0] = asil_Oyuncu;
        oyuncular[1] = oyuncu1;
        oyuncular[2] = oyuncu2;
        oyuncular[3] = oyuncu3;

        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                oyuncular[i][j] = karilan_Deste[enUsttekiKagit];
                enUsttekiKagit--;
                if (i == 0)
                {
                    Instantiate(asil_Oyuncu[j], kagitlar[j].transform.position, kagitlar[j].transform.rotation);
                }
                Debug.Log("kalan kagit " + (enUsttekiKagit + 1));
            }
            
        }
        

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
