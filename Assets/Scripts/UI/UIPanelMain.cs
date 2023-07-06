using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIPanelMain : MonoBehaviour, IMenu
{
    [SerializeField] private Button btnTimer;

    [SerializeField] private Button btnMoves;

    [SerializeField] private Button btnRestartGame;

    private UIMainManager m_mngr;

    private void Awake()
    {
        btnMoves.onClick.AddListener(OnClickMoves);
        btnTimer.onClick.AddListener(OnClickTimer);
        btnRestartGame.onClick.AddListener(OnRestartGame);
    }


    private void OnDestroy()
    {
        if (btnMoves) btnMoves.onClick.RemoveAllListeners();
        if (btnTimer) btnTimer.onClick.RemoveAllListeners();
        if (btnRestartGame) btnRestartGame.onClick.RemoveAllListeners();
    }

    public void Setup(UIMainManager mngr)
    {
        m_mngr = mngr;
    }

    private void OnClickTimer()
    {
        m_mngr.LoadLevelTimer();
    }

    private void OnClickMoves()
    {
        m_mngr.LoadLevelMoves();
    }

    private void OnRestartGame()
    {
        m_mngr.GameManager.ClearLevel();
        if (m_mngr.GameManager.ELevelMode == GameManager.eLevelMode.MOVES)
        {
            m_mngr.LoadLevelMoves();
        }
        else
        {
            m_mngr.LoadLevelTimer();
        }
    }

    public void Show()
    {
        this.gameObject.SetActive(true);
        btnRestartGame.gameObject.SetActive(false);
    }

    public void Hide()
    {
        this.gameObject.SetActive(false);
        btnRestartGame.gameObject.SetActive(true);
    }
}
