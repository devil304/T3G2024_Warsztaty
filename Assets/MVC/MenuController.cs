using System;
using UnityEngine;

public class MenuController : MonoBehaviour
{
    RootController _rootControler;
    [SerializeField] MenuView _menuView;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _menuView.PlayButtonClicked += Play;
        _menuView.QuitButtonClicked += Quit;
    }

    public void SetRootController(RootController rootController)
    {
        _rootControler = rootController;
    }

    private void Quit()
    {
        Application.Quit();
    }

    private void Play()
    {
        _rootControler.ActivateController(RootController.UIstate.Game);
    }

    private void OnEnable()
    {
        _menuView.ShowUI();
    }

    private void OnDisable()
    {
        _menuView.HideUI();
    }
}
