using DG.Tweening;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIPanelRestart : MonoBehaviour, IMenu
{
    [SerializeField] Image blurImg;

    private UIMainManager m_mngr;

    public void Setup(UIMainManager mngr)
    {
        m_mngr = mngr;
    }

    public void Show()
    {
        Debug.Log("Showing");
        gameObject.SetActive(true);

        blurImg.DOKill();
        blurImg.DOFade(0.6f, 0.25f).OnComplete(() =>
        {
            m_mngr.RestartLevel();
            blurImg.DOFade(0, 0.25f).OnComplete(() =>
            {
                Hide();
                m_mngr.ShowGameMenu();
            });
        });
    }

    public void Hide()
    {
            gameObject.SetActive(false);

    }
}
