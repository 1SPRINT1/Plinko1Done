using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class scens : MonoBehaviour
{
    public Animator animMenu;
    public Animator animSetting;
    public GameObject Menu;
    public GameObject SettingPanel;
    private void Start()
    {
        Time.timeScale = 1f;
    }

    public void ScenesGame()
    {
        SceneManager.LoadScene("game");
    }

        public void Exit()
        {
            Application.Quit();
        }

        public void Shop()
        {
            animMenu.Play("ShopActivate");
        }

        public void Setting()
        {
            SettingPanel.SetActive(true);
            animSetting.Play("OpenAnim");
            Menu.SetActive(false);
        }
}
