using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPanel : MonoBehaviour
{
    public void OnClickedStartGameButton()
    {

        if (UIManager.HasInstance)
        {
            UIManager.Instance.ActiveLoadingPanel(true);
            UIManager.Instance.ActiveMenuPanel(false);
            UIManager.Instance.ActivePlayerPanel(false);
        }
    }
    public void OnSettingButtonClick()
    {
        UIManager.Instance.ActiveOptionPanel(true);
    }
    public void OnQuitButtonClick()
    {
        Application.Quit();
    }
}
