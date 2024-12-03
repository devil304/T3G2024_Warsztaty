using System;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameplayController : MonoBehaviour
{
    RootController _rootController;
    [SerializeField] GameplayView _gameplayView;
    [SerializeField] DataModel _data;

    public void SetRootController(RootController rootController)
    {
        _rootController = rootController;
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _gameplayView.MenuButtonClicked += MenuClicked;
    }

    private void MenuClicked()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        _rootController.ActivateController(RootController.UIstate.Menu);
    }

    // Update is called once per frame
    void Update()
    {
        _gameplayView.UpdateTime(_data.Time);
        _gameplayView.UpdatePoints(_data.Points);
    }

    private void OnEnable()
    {
        _gameplayView.ShowUI();
    }

    private void OnDisable()
    {
        _gameplayView.HideUI();
    }
}
