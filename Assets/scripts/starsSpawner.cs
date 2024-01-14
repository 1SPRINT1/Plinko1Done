using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class starsSpawner : MonoBehaviour
{
    public GameObject[] obj;

    private float _time = 3f;
    private float hard;
    private int balls = 1;

    private Vector3 spawnPosition;

    public GameObject TutorialPanel;
    private void Update()
    {
        if (TutorialPanel.activeSelf == false)
        {
            _time -= 1f * Time.deltaTime;
            if (_time <= 0)
            {
                Spawner();
                _time = 1f;
            }

            hard = hard + Time.deltaTime;
            if (hard >= 60)
            {
                balls++;
                hard = 0;
            }
        }
    }

    public void Spawner()
    {
        for (int i = 0; i < balls; i++)
        {
            spawnPosition = new Vector3(Random.Range(-0.5f, 0.5f), 2f, 0);
            Instantiate(obj[Random.Range(0, obj.Length)], spawnPosition, Quaternion.identity);
        }
    }
    
}
