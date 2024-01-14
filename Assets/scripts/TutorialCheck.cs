using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialCheck : MonoBehaviour
{
   public int TutorINT;
   public GameObject TutorialObj;
   private void Update()
   {
       TutorINT = PlayerPrefs.GetInt("Tutorial", TutorINT);
       if (TutorINT == 1)
       {
           TutorialObj.SetActive(false);
       }
       else
       {
           TutorialObj.SetActive(true);
       }
   }
}
