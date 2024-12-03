using System;
using UnityEngine;

public class GameOverController : MonoBehaviour
{
    RootController _rootController;
    [SerializeField] GameOverView _gameoverView;

    public void SetRootController(RootController rootController)
    {
        _rootController = rootController;
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _gameoverView.MenuButtonClicked += MenuClicked;
    }

    private void MenuClicked()
    {
        _rootController.ActivateController(RootController.UIstate.Menu);
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnEnable()
    {
        _gameoverView.ShowUI();
    }

    private void OnDisable()
    {
        _gameoverView.HideUI();
    }
}
