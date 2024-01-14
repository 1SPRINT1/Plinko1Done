using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestDeleteSaving : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            PlayerPrefs.DeleteAll();
            PlayerPrefs.Save();
        } 
    }
}
