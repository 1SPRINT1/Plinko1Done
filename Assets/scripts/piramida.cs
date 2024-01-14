using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class piramida : MonoBehaviour
{
    public GameObject partical;
    public GameObject parents;
    public float t = 0;


    private void OnCollisionEnter2D(Collision2D collision)
    {
        Instantiate(partical, parents.transform.position , Quaternion.identity);
        

    }
    private void Update()
    {
        t = t + Time.deltaTime;
        if (t >= 3)
        {
            FindDel();
            t = 0;
        }

      
    }

    void FindDel()
    {
        GameObject[] game_oblect = GameObject.FindGameObjectsWithTag("partical");
        foreach (GameObject element in game_oblect)
        {
            Destroy(element);
        }
    }
}
