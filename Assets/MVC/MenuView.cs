using System;
using UnityEngine;

public class MenuView : MonoBehaviour
{
    public event Action PlayButtonClicked;
    public event Action QuitButtonClicked;

    public void PlayButton()
    {
        PlayButtonClicked?.Invoke();
    }

    public void QuitButton()
    {
        QuitButtonClicked?.Invoke();
    }

    public void ShowUI()
    {
        gameObject.SetActive(true);
    }

    public void HideUI()
    {
        gameObject.SetActive(false);
    }
}
