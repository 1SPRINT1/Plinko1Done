using System.Collections;
using System.Collections.Generic;
using System.Net;
using UnityEngine;
using UnityEngine.UI;

public class buy : MonoBehaviour
{
    
    

    private int sprice = 25;
    
    
    public static int saccess = 0;

    public Text _sprice;
    

    public GameObject ssold;
    

    public GameObject sbutton;

    public int score;
    private void Start()
    {
        
        PlayerPrefs.GetInt("saccess", saccess);
    }

    private void Update()
    {
        score = PlayerPrefs.GetInt("score",score);
        _sprice.text = "Price: " + sprice;
        
        PlayerPrefs.SetInt("saccess", saccess);

        Debug.Log(slowing.slower);        


        if (PlayerPrefs.GetInt("saccess", saccess) == 1)
        {
            sbutton.SetActive(false);
            ssold.SetActive(true);
            
        }
        else
        {
           ssold.SetActive(false);
            sbutton.SetActive(true);

        }

       
    }
    public void BuySlower()
    {
        if (score >= sprice)
        {
            PlayerPrefs.SetInt("score", score - sprice);
            slowing.slower+=1;
            saccess = 1;
        }
    }

   
}
