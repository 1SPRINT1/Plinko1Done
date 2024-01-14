using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class balls : MonoBehaviour
{


    public GameObject effectDeathka;
    public color ColorManager;

    private void Start()
    {
        ColorManager = FindObjectOfType<color>();
    }

    public void Red()
    {
        if (color.activeColor == 1)
        {
           ColorManager.score++;
            efects.red = true;
        }
        else
        {
            color.hp--;
        }
        Destroy(gameObject);
       
    }
    public void Blue()
    {
        if (color.activeColor == 2)
        {
            ColorManager.score++;
            efects.blue = true;
        }
        else
        {
            color.hp--;
        }
        
        Destroy(gameObject, 0.1f);
        
    }
    public void Green()
    {
        if (color.activeColor == 3)
        {
            ColorManager.score++;
            efects.green = true;
        }
        else
        {
            color.hp--;
        }
        Destroy(gameObject);
        
    }
    public void Purple()
    {
        if (color.activeColor == 4)
        {
            ColorManager.score++;
            efects.purple = true;
        }
        else
        {
            color.hp--;
        }
        Destroy(gameObject);
        
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("DeadZone"))
        {
            Instantiate(effectDeathka, transform.position, Quaternion.identity);
        } 
    }
}
   


