using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PausePanel : MonoBehaviour
{
    public void OnClickedSettingButton()
    {
        if (UIManager.HasInstance)
        {
            UIManager.Instance.ActiveOptionPanel(true);
            UIManager.Instance.ActivePausePanel(false);
            UIManager.Instance.ActivePlayerPanel(false);
        }
    }
    public void OnClickedResumeButton()
    {
        if (GameManager.HasInstance && UIManager.HasInstance)
        {
            GameManager.Instance.ResumeGame();
            UIManager.Instance.ActivePausePanel(false);
            UIManager.Instance.ActivePlayerPanel(true);
        }
    }
    public void OnClickedQuitButton()
    {
        if (GameManager.HasInstance && UIManager.HasInstance)
        {
            GameManager.Instance.ReStartGame();
            UIManager.Instance.ActivePlayerPanel(false);
            UIManager.Instance.ActivePausePanel(false);
        }
    }
}
