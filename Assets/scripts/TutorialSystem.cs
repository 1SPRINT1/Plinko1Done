using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialSystem : MonoBehaviour
{
   public Animator anim;
   public int Tut;
   public GameObject Tut1;
   public GameObject Tut2;
   public void DoneTutorial()
   {
      Tut = 1;
      PlayerPrefs.SetInt("Tutorial", Tut);
      gameObject.SetActive(false);
   }

   public void StartTut2()
   {
      anim.Play("Tut1Exit");
   }

   public void Exit1Tutorial()
   {
      Tut1.SetActive(false);
      Tut2.SetActive(true);
   }

   public void ExitTut2()
   {
      anim.Play("TutExit2");
   }
}
