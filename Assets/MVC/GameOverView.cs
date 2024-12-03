using System;
using TMPro;
using UnityEngine;

public class GameOverView : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI _winState;
    public event Action MenuButtonClicked;

    public void WinStateSet(string winState)
    {
        _winState.text = winState;
    }

    public void MenuButton()
    {
        MenuButtonClicked?.Invoke();
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
