using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuPanel : MonoBehaviour
{
   public GameObject ShopPanel;

   public void ExitMenuPanel()
   {
      ShopPanel.SetActive(true);
      gameObject.SetActive(false);
   }
}
