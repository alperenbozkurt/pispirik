using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class elDagit : MonoBehaviour {
    public int[] deste;
    public int[] oyuncu1 = new int[4];
    public int[] oyuncu2 = new int[4];
    public int[] oyuncu3 = new int[4];
    public int[] oyuncu4 = new int[4];

    public int[] yerdekiler = new int[52];
    void Start () {
        for (int i = 0; i < 52; i++)
        {
            deste[i] = (i / 4) + 1;
        }


        for (int i = 0; i < 1000; i++)
        {
            int a = Random.Range(0, 52);
            for (int k = 0; k < 100; k++)
            {

            }
            int b = Random.Range(0, 52);
            int temp = deste[b];
            deste[b] = deste[a];
            deste[a] = temp;
        }
        
    }
    void Update () {
        if (oyuncu4[0] == 0 && oyuncu4[1] == 0 && oyuncu4[2] == 0 && oyuncu4[3] == 0)
        {
            kagitDagit();
        }
    }
    int destedeNerede = 48;

    void kagitDagit()
    {
        for (int i = destedeNerede; i > 16; i--)
        {

        }

        return;
    }
}
