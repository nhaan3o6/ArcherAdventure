using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : BaseManager<UIManager>
{
    [SerializeField]
    private MenuPanel menuPanel;
    public MenuPanel MenuPanel => menuPanel;

    [SerializeField]
    private OptionPanel optionPanel;
    public OptionPanel Option => optionPanel;

    [SerializeField]
    private LosePanel losePanel;
    public LosePanel LosePanel => losePanel;

    [SerializeField]
    private VictoryPanel victoryPanel;
    public VictoryPanel VictoryPanel => victoryPanel;

    [SerializeField]
    private PausePanel pausePanel;
    public PausePanel PausePanel => pausePanel;

    [SerializeField]
    private LoadingPanel loadingPanel;
    public LoadingPanel Loading => loadingPanel;

    [SerializeField]
    private PlayerPanel playerPanel;
    public PlayerPanel Player => playerPanel;




    private void Start()
    {
        ActiveMenuPanel(true);
        ActivePlayerPanel(false);
        ActiveOptionPanel(false);
        ActiveLosePanel(false);
        ActiveVictoryPanel(false);
        ActivePausePanel(false);
        ActiveLoadingPanel(false);
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameManager.HasInstance && GameManager.Instance.IsPlaying)
            {
                GameManager.Instance.PauseGame();
                ActivePausePanel(true);
            }
        }
    }
    public void ActiveMenuPanel(bool active)
    {
        menuPanel.gameObject.SetActive(active);
    }

    public void ActiveOptionPanel(bool active)
    {
        optionPanel.gameObject.SetActive(active);
    }
    public void ActiveLosePanel(bool active)
    {
        losePanel.gameObject.SetActive(active);
    }
    public void ActiveVictoryPanel(bool active)
    {
        victoryPanel.gameObject.SetActive(active);
    }
    public void ActivePausePanel(bool active)
    {
        pausePanel.gameObject.SetActive(active);
    }
    public void ActiveLoadingPanel(bool active)
    {
        loadingPanel.gameObject.SetActive(active);
    }
    public void ActivePlayerPanel(bool active)
    {
        playerPanel.gameObject.SetActive(active);
    }
}
