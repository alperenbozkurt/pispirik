using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deneme : MonoBehaviour {

	int[] dizi = new int[52];
	int degisken;
	int sayi;
	string kagit;
	int kisi_z , kisi_x;

	void Start () {

		for (int i = 0; i <52; i++)
		{
			dizi[i] = (i + 1);
		}


		for (int n = 0; n < 3; n++)   // toplamda 3 el oynanacagından dolayı.(dağıtma işlemini 3 kere yapıyor)
		{



			for (int i = 0; i < 4; i++) // 4 kişiye kagıt vermesi için
			{
				if (i == 0)
				{
					kisi_x = 0;
					kisi_z = -5;
				}

				if (i == 1)
				{
					kisi_z = 0;
					kisi_x = 10;
				}
				if (i == 2)
				{
					kisi_x = 0;
					kisi_z = 10;
				}

				if (i == 3)
				{
					kisi_x = -5;
					kisi_z = 0;
				}


				for (int k = 0; k <4; k++)   // bir kişiye 4 kagıt vermesi için
				{
					random_sayi_uret();

					Debug.Log("degişkenin degeri =  " + degisken);
					kagit = degisken.ToString();

					if (kisi_x == 0)
					{
						GameObject.Find(kagit).GetComponent<Transform>().Translate((2 * k) , 0 , kisi_z);
					}

					if (kisi_z == 0)
					{
						GameObject.Find(kagit).GetComponent<Transform>().Translate(kisi_x , 0 , (2 * k));
					}

					dizi[sayi] = 0;

				}

			}








		}


	}

	// Update is called once per frame
	void Update () {

	}



	void random_sayi_uret()
	{
		sayi = Random.Range(0, 52);
		degisken = dizi[sayi];
		if (degisken==0)
		{
			Debug.Log("bu kagıt daha önce kullanılmış");
			random_sayi_uret();
		}
		else
		{
			Debug.Log("bu kagıt kullanılmamış");

		}

	}


}

