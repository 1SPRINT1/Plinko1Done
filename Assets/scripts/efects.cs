using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class efects : MonoBehaviour
{
    public GameObject partical;
    public GameObject parent;

    public Vector3[] _poz = {new Vector3(-1.8f,1.4f,0), new Vector3(1.8f, 1.4f, 0), new Vector3(0.12f, 2f, 0) } ;

   
    public static bool blue = false;
    public static bool green = false;
    public static bool red = false;
    public static bool purple = false;

    void Update()
    {
        
        
        if (blue == true)
        {
            Instantiate(partical, _poz[Random.Range(0, _poz.Length)], Quaternion.identity);
            blue = false;
        }

        if (red == true)
        {
            Instantiate(partical, _poz[Random.Range(0, _poz.Length)], Quaternion.identity);
            red = false;
        }

        if (green == true)
        {
            Instantiate(partical, _poz[Random.Range(0, _poz.Length)], Quaternion.identity);
            green = false;
        }

        if (purple == true)
        {
            Instantiate(partical, _poz[Random.Range(0, _poz.Length)], Quaternion.identity);
            purple = false;
        }
    }
}
