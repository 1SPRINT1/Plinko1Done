using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    public Text _scoreText;
    public int Score;
    
    private void Update()
    {
        _scoreText.text = "Score: " + PlayerPrefs.GetInt("score", Score);
    }



}
