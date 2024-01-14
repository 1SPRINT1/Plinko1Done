using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialSaves : MonoBehaviour
{
   public int Tutorial;
   public int SoundStats;
   private void Start()
   {
      Tutorial = PlayerPrefs.GetInt("Tutorial", Tutorial);
      SoundStats = PlayerPrefs.GetInt("Sound", SoundStats);
   }

   private void Update()
   {
       Tutorial = PlayerPrefs.GetInt("Tutorial", Tutorial);
       SoundStats = PlayerPrefs.GetInt("Sound", SoundStats);
   }
}
