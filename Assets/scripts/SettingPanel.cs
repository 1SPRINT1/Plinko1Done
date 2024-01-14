using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingPanel : MonoBehaviour
{
   public GameObject Menu;
   public Animator Setting;
   public Text SettText;
   public bool SetStatus;
   public SoundSystem SS;
   public void ExitSettingPanel()
   {
      gameObject.SetActive(false);
   }

   public void ExitButtonPanel()
   {
      Setting.Play("ExitAnim");
   }

   public void ExitSettingOpenMenu()
   {
      gameObject.SetActive(false);
      Menu.SetActive(true);
   }

   private void Update()
   {
      SetStatus = SS.isStatus;
      if (SetStatus == false)
      {
         SettText.text = "Sound Status: OFF";
      }

      if (SetStatus == true)
      {
         SettText.text = "Sound Status: ON";
      }
   }
}
