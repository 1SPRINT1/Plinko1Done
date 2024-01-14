using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopMiniManager : MonoBehaviour
{
   public Animator anim;
   public GameObject MenuPanel;

   public void ExitButton()
   {
      anim.Play("ExitAnimation");
   }

   public void ExitPanelAnimation()
   {
      gameObject.SetActive(false);
      MenuPanel.SetActive(true);
   }
}
