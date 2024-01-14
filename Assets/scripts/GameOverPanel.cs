using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using Color = System.Drawing.Color;

public class GameOverPanel : MonoBehaviour
{
   public color colorSys;
  [SerializeField] public int allScore;
  [SerializeField] public Text scoreTXT;

   private void Update()
   {
       allScore = PlayerPrefs.GetInt("score", allScore);
       scoreTXT.text = "Score: " + colorSys.score.ToString();
       // scoreTXT.text = Сюда допиши ту переменную с полученными очками за игру
   }

   public void GameOverforPanel()
   {
       // Сюда добавь allScore += переменная которая считает полученные очки за всю игру
       // Обязательно потом впиши это в сохранения
       Debug.Log(allScore);
       Time.timeScale = 0f;
   }

   public void HomeButton()
   {
       allScore += colorSys.score;
       PlayerPrefs.SetInt("score",allScore);
       SceneManager.LoadScene("Menu");
   }
}
