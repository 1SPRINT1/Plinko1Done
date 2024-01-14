using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class slowing : MonoBehaviour
{
    public GameObject _slowing;
    public static int slower;

    private bool _timerbool = false;

    private float t = 0;
    private void Start()
    {
        
    }
    void Update()
    {
        if (_timerbool == true)
        {
            t = t + Time.deltaTime;
            if (t >= 3)
            {
                Time.timeScale = 1f;
                slower = 0;
                
            }
        }

        if (slower==1)
        {
            _slowing.SetActive(true);
        }
        else
        {
            _slowing.SetActive(false);
        }
    }

    public void Slowing()
    {
        _timerbool = true;
        Time.timeScale = 0.5f;
        Time.fixedDeltaTime = Time.fixedDeltaTime * Time.timeScale;


    }
}
