using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class LosePanel : MonoBehaviour
{
    public void OnClickedRestartButton()
    {
        if (GameManager.HasInstance && UIManager.HasInstance)
        {
            GameManager.Instance.ReStartGame();
            UIManager.Instance.ActivePlayerPanel(false);
        }
    }
    public void OnClickedExitButton()
    {
        if (GameManager.HasInstance)
        {
            GameManager.Instance.ReStartLevel();
        }
    }
}
