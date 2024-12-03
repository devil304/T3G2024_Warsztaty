using System;
using TMPro;
using UnityEngine;

public class GameplayView : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI _pointsText;
    [SerializeField] TextMeshProUGUI _timeText;
    string _timeDefaultText;

    public event Action MenuButtonClicked;

    private void Start()
    {
        _timeDefaultText = _timeText.text;
    }

    public void UpdatePoints(int points)
    {
        _pointsText.text = points.ToString();
    }

    public void UpdateTime(float time)
    {
        _timeText.text = _timeDefaultText + time.ToString();
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
