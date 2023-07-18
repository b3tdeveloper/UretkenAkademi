using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Odev2 : MonoBehaviour
{
    public int sayi1 = 0, sayi2 = 100;
    void bolenleriBul(int ilkSayi, int ikinciSayi)
    {
        for (int i = 1; i < 6; i++)
        {
            string s = "";
            for (int j = sayi1; j <= sayi2; j++)
            {
                
                if (i == 1)
                {
                    if (j == sayi1)
                    {
                        s += "Tum liste : " + j;
                    }
                    else
                    {
                        s += " - " + j;
                    }
                    
                }
                else if (j % i == 0)
                {
                    if (j == sayi1)
                    {
                        s += i + "'e bolunenler : " + j;
                    }
                    else
                    {
                        s += " - " + j;
                    }
                }
                
            }
            print(s);
        }
    }

    void Start()
    {
        
        bolenleriBul(sayi1, sayi2);
    }
}
